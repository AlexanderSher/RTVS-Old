using System;

namespace Microsoft.UnitTests.Core.Stubs.DefaultValueProviders {
    internal class StringDefaultValueProvider : IDefaultValueProvider {
        public bool CanProvide(Type type) => type == typeof(string);

        public object Provide(Type type) => string.Empty;
    }
}