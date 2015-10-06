using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.R.Host.Client {
    public sealed partial class RHost : IDisposable {
        public const int DefaultPort = 5118;
        public const string RHostExe = "Microsoft.R.Host.exe";
        public const string RBinPathX64 = @"bin\x64";

        public static IRContext TopLevelContext { get; } = new RContext(RContextType.TopLevel);

        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private readonly IRCallbacks _callbacks;

        public RHost(IRCallbacks callbacks) {
            _callbacks = callbacks;
        }

        public void Dispose() {
            _cts.Cancel();
        }

        public async Task CreateAndRun(string rHome, ProcessStartInfo psi = null, CancellationToken ct = default(CancellationToken)) {
            if (ct.IsCancellationRequested) {
                return;
            }

            string rhostExe = Path.Combine(Path.GetDirectoryName(typeof(RHost).Assembly.ManifestModule.FullyQualifiedName), RHostExe);
            string rBinPath = Path.Combine(rHome, RBinPathX64);

            if (!File.Exists(rhostExe)) {
                throw new MicrosoftRHostMissingException();
            }

            psi = psi ?? new ProcessStartInfo();
            psi.FileName = rhostExe;
            psi.UseShellExecute = false;
            psi.EnvironmentVariables["R_HOME"] = rHome;
            psi.EnvironmentVariables["PATH"] = Environment.GetEnvironmentVariable("PATH") + ";" + rBinPath;

            using (var process = new Process()) {
                process.EnableRaisingEvents = true;
                process.StartInfo = psi;
                process.Exited += ProcessExited;

                try {
                    process.Start();
                    ct = CancellationTokenSource.CreateLinkedTokenSource(ct, _cts.Token).Token;
                    using (var ws = new ClientWebSocket()) {
                        var uri = new Uri("ws://localhost:" + DefaultPort);
                        for (int i = 0; ; ++i) {
                            try {
                                await ws.ConnectAsync(uri, ct);
                                break;
                            } catch (WebSocketException) {
                                if (i > 10) {
                                    throw;
                                }
                                await Task.Delay(100, ct);
                            }
                        }

                        await Run(ws, ct);
                    }
                } finally {
                    if (!process.HasExited) {
                        try {
                            process.WaitForExit(500);
                            process.Kill();
                        } catch (InvalidOperationException) {
                        }
                    }

                    process.Exited -= ProcessExited;
                }
            }
        }

        private void ProcessExited(object sender, EventArgs e) {
            _cts.Cancel();
        }

        public async Task AttachAndRun(Uri uri, CancellationToken ct = default(CancellationToken)) {
            ct = CancellationTokenSource.CreateLinkedTokenSource(ct, _cts.Token).Token;
            using (var ws = new ClientWebSocket()) {
                await ws.ConnectAsync(uri, ct);
                await Run(ws, ct);
            }
        }

        private async Task Run(WebSocket webSocket, CancellationToken ct) {
            var buffer = new byte[0x10000];

            try {
                var webSocketReceiveResult = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), ct);
                string s = Encoding.UTF8.GetString(buffer, 0, webSocketReceiveResult.Count);
                var obj = JObject.Parse(s);
                int protocolVersion = (int)(double)obj["protocol_version"];
                Debug.Assert(protocolVersion == 1);
                string rVersion = (string)obj["R_version"];
                await _callbacks.Connected(rVersion, ct);

                await RunLoop(webSocket, ct, buffer);
            } finally {
                await _callbacks.Disconnected();
            }
        }

        private async Task RunLoop(WebSocket webSocket, CancellationToken ct, byte[] buffer) {
            while (!ct.IsCancellationRequested) {
                WebSocketReceiveResult webSocketReceiveResult;
                var s = string.Empty;
                do {
                    webSocketReceiveResult = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), ct);
                    if (webSocketReceiveResult.CloseStatus != null) {
                        return;
                    }

                    s += Encoding.UTF8.GetString(buffer, 0, webSocketReceiveResult.Count);
                } while (!webSocketReceiveResult.EndOfMessage);

                JObject obj = JObject.Parse(s);

                var contexts = GetContexts(obj);
                var evaluator = new RExpressionEvaluator(webSocket, buffer, ct);

                var evt = (string)obj["event"];

                await _callbacks.Evaluate(contexts, evaluator, ct);

                if (ct.IsCancellationRequested) {
                    return;
                }

                switch (evt) {
                    case "YesNoCancel":
                        {
                            YesNoCancel input = await _callbacks.YesNoCancel(contexts, (string)obj["s"], ct);
                            await SendAsync(webSocket, ct, buffer, (double)input);
                            break;
                        }

                    case "ReadConsole":
                        {
                            string input = await _callbacks.ReadConsole(
                                contexts,
                                (string)obj["prompt"],
                                (string)obj["buf"],
                                (int)(double)obj["len"],
                                (bool)obj["addToHistory"],
                                ct);
                            input = input.Replace("\r\n", "\n");
                            await SendAsync(webSocket, ct, buffer, input);
                            break;
                        }

                    case "WriteConsoleEx":
                        await _callbacks.WriteConsoleEx(contexts, (string)obj["buf"], (OutputType)(double)obj["otype"], ct);
                        break;

                    case "ShowMessage":
                        await _callbacks.ShowMessage(contexts, (string)obj["s"], ct);
                        break;

                    case "Busy":
                        await _callbacks.Busy(contexts, (bool)obj["which"], ct);
                        break;

                    case "CallBack":
                        break;

                    case "exit":
                        return;

                    default:
                        throw new InvalidDataException("Unknown event type " + evt);
                }
            }
        }

        private static async Task SendAsync<T>(WebSocket webSocket, CancellationToken ct, byte[] buffer, T input) {
            if (ct.IsCancellationRequested) {
                return;
            }

            var response = JsonConvert.SerializeObject(input);
            int count = Encoding.UTF8.GetBytes(response, 0, response.Length, buffer, 0);
            await webSocket.SendAsync(new ArraySegment<byte>(buffer, 0, count), WebSocketMessageType.Text, true, ct);
        }

        private static RContext[] GetContexts(JObject obj) {
            JToken contextsArray;
            if (!obj.TryGetValue("contexts", out contextsArray)) {
                return new RContext[0];
            }

            return ((JArray)contextsArray)
                .Cast<JObject>()
                .Select(ctx => new RContext((RContextType)(double)ctx["callflag"]))
                .ToArray();
        }
    }
}
