using System;

namespace Microsoft.UnitTests.Core.Stubs.DefaultValueProviders {
    internal class ArrayDefaultValueProvider : IDefaultValueProvider {
        public bool CanProvide(Type type) => type.IsArray;

        public object Provide(Type type) => Array.CreateInstance(type.GetElementType(), 0);
    }
}