using System;

namespace Microsoft.UnitTests.Core.Stubs.DefaultValueProviders {
    internal sealed class ByRefDefaultValueProvider : IDefaultValueProvider {
        private readonly IDefaultValueService _defaultValues;

        public ByRefDefaultValueProvider(IDefaultValueService defaultValues) {
            _defaultValues = defaultValues;
        }

        public bool CanProvide(Type type) => type.IsByRef;

        public object Provide(Type type) => _defaultValues.GetValue(type.GetElementType());
    }
}