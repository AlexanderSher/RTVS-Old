using System;

namespace Microsoft.UnitTests.Core.Stubs {
    public interface IDefaultValueProvider {
        bool CanProvide(Type type);
        object Provide(Type type);
    }
}