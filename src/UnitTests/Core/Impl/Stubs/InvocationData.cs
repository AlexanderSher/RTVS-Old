using System.Reflection;

namespace Microsoft.UnitTests.Core.Stubs {
    public class InvocationData {
        public InvocationData(MethodInfo methodInfo, object[] arguments) {
            MethodInfo = methodInfo;
            Arguments = arguments;
        }

        public MethodInfo MethodInfo { get; }
        public object[] Arguments { get; }
        public object ReturnValue { get; set; }
    }
}