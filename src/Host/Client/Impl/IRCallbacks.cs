using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.R.Host.Client {
    public interface IRCallbacks {
        Task Connected(string rVersion, CancellationToken cancellationToken);
        Task Disconnected();
        Task<string> ReadConsole(IReadOnlyCollection<IRContext> contexts, string prompt, string buf, int len, bool addToHistory, CancellationToken cancellationToken);
        Task WriteConsoleEx(IReadOnlyCollection<IRContext> contexts, string buf, OutputType otype, CancellationToken cancellationToken);
        Task ShowMessage(IReadOnlyCollection<IRContext> contexts, string s, CancellationToken cancellationToken);
        Task<YesNoCancel> YesNoCancel(IReadOnlyCollection<IRContext> contexts, string s, CancellationToken cancellationToken);
        Task Busy(IReadOnlyCollection<IRContext> contexts, bool which, CancellationToken cancellationToken);
        Task Evaluate(IReadOnlyCollection<IRContext> contexts, IRExpressionEvaluator evaluator, CancellationToken cancellationToken);
    }
}
