using System;
using System.Collections.Generic;
using Castle.DynamicProxy;

namespace Microsoft.UnitTests.Core.Stubs {
    public interface IStubFactory {
        object CreateStub(Type interfaceToProxy, Type[] additionalInterfaces = null, IEnumerable<object> mixins = null, IInterceptor[] interceptors = null);
    }
}