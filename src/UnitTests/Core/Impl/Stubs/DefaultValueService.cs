using System;
using System.Collections.Concurrent;
using System.Linq;
using Microsoft.UnitTests.Core.Stubs.DefaultValueProviders;

namespace Microsoft.UnitTests.Core.Stubs {
    internal sealed class DefaultValueService : IDefaultValueService {
        private readonly ConcurrentStack<IDefaultValueProvider> _providers;

        public DefaultValueService() {
            _providers = new ConcurrentStack<IDefaultValueProvider>(new IDefaultValueProvider[] {
                new SystemDefaultValueProvider(),
                new ByRefDefaultValueProvider(this)
            });
        }

        public void Add(IDefaultValueProvider provider) {
            _providers.Push(provider);
        }

        public object GetValue(Type type) {
            return _providers.First(provider => provider.CanProvide(type)).Provide(type);
        }
    }
}