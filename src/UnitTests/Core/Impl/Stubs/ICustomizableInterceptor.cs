using System;
using System.Collections.Generic;
using System.Reflection;
using Castle.DynamicProxy;

namespace Microsoft.UnitTests.Core.Stubs {
    public interface ICustomizableInterceptor : IInterceptor {
        void AddOverride(MethodInfo method, Func<IReadOnlyList<object>, bool> filter, Action<InvocationData> handler);
    }
}