using System;
using System.Collections.Generic;
using System.Reflection;

namespace Microsoft.UnitTests.Core.Stubs {
    public interface IInterceptorOperations {
        void SetOverride(Action method, Func<IReadOnlyList<object>, bool> filter, Action<InvocationData> handler);
        void SetLastInvokedInterceptor(ICustomizableInterceptor interceptor, MethodInfo method);
        bool IsOverriding { get; }
    }
}