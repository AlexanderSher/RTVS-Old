using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Microsoft.R.Host.Client {
    public sealed partial class RHost {
        private class RExpressionEvaluator : IRExpressionEvaluator {
            private readonly WebSocket _ws;
            private readonly byte[] _buffer;
            private readonly CancellationToken _ct;

            public RExpressionEvaluator(WebSocket ws, byte[] buffer, CancellationToken ct) {
                _ws = ws;
                _buffer = buffer;
                _ct = ct;
            }

            public async Task<REvaluationResult> EvaluateAsync(string expression) {
                string request = JsonConvert.SerializeObject(new {
                    command = "eval",
                    expr = expression
                });

                int count = Encoding.UTF8.GetBytes(request, 0, request.Length, _buffer, 0);
                await _ws.SendAsync(new ArraySegment<byte>(_buffer, 0, count), WebSocketMessageType.Text, true, _ct);

                var wsrr = await _ws.ReceiveAsync(new ArraySegment<byte>(_buffer), _ct);
                if (wsrr.CloseStatus != null) {
                    throw new TaskCanceledException();
                }

                string response = Encoding.UTF8.GetString(_buffer, 0, wsrr.Count);
                var obj = JObject.Parse(response);

                JToken result, error, parseStatus;
                obj.TryGetValue("result", out result);
                obj.TryGetValue("error", out error);
                obj.TryGetValue("ParseStatus", out parseStatus);

                return new REvaluationResult(
                    result != null ? (string)result : null,
                    error != null ? (string)error : null,
                    parseStatus != null ? (RParseStatus)(double)parseStatus : RParseStatus.Null);
            }
        }

    }
}
