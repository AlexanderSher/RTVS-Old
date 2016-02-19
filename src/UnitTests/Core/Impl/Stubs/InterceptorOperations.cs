using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;

namespace Microsoft.UnitTests.Core.Stubs {
    internal class InterceptorOperations : IInterceptorOperations {
        private static readonly ThreadLocal<InterceptorOperations> ThreadLocal = new ThreadLocal<InterceptorOperations>(() => new InterceptorOperations());
        private ICustomizableInterceptor _lastInvokedInterceptor;
        private MethodInfo _lastInvokedMethod;

        public static IInterceptorOperations ForCurrentThread => ThreadLocal.Value;

        private InterceptorOperations() { }

        public bool IsOverriding { get; private set; }

        public void SetOverride(Action method, Func<IReadOnlyList<object>, bool> filter, Action<InvocationData> handler) {
            if (IsOverriding) {
                throw new InvalidOperationException("Can't override one method while overriding another in the same thread");
            }

            try {
                IsOverriding = true;
                // Invoke method to make interceptor register itself for customization
                // In case of chained call, only last interceptor will be affected
                method.Invoke();
                _lastInvokedInterceptor?.AddOverride(_lastInvokedMethod, filter, handler);
            } finally {
                _lastInvokedInterceptor = null;
                _lastInvokedMethod = null;
                IsOverriding = false;
            }
        }

        public void SetLastInvokedInterceptor(ICustomizableInterceptor interceptor, MethodInfo method) {
            _lastInvokedInterceptor = interceptor;
            _lastInvokedMethod = method;
        }
    }
}