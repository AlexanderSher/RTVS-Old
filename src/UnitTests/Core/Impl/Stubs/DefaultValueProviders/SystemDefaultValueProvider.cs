using System;

namespace Microsoft.UnitTests.Core.Stubs.DefaultValueProviders {
    internal sealed class SystemDefaultValueProvider : IDefaultValueProvider {
        public bool CanProvide(Type type) => true;
        public object Provide(Type type) => type.IsValueType ? Activator.CreateInstance(type) : null;
    }
}