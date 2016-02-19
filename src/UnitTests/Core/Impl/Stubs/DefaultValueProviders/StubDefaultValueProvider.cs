using System;

namespace Microsoft.UnitTests.Core.Stubs.DefaultValueProviders {
    internal class StubDefaultValueProvider : IDefaultValueProvider {
        private readonly IStubFactory _stubFactory;

        public StubDefaultValueProvider(IStubFactory stubFactory) {
            _stubFactory = stubFactory;
        }

        public bool CanProvide(Type type) => type.IsInterface;

        public object Provide(Type type) => _stubFactory.CreateStub(type);
    }
}