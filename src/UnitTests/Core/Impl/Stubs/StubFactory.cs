using System;
using System.Collections.Generic;
using System.Linq;
using Castle.DynamicProxy;
using Microsoft.Common.Core;
using Microsoft.UnitTests.Core.Stubs.DefaultValueProviders;

namespace Microsoft.UnitTests.Core.Stubs {
    public class StubFactory : IStubFactory {
        private static readonly Lazy<IStubFactory> DefaultLazy = new Lazy<IStubFactory>(() => {
            var factory = new StubFactory();

            var defaultValues = factory.DefaultValues;
            defaultValues.Add(new ArrayDefaultValueProvider());
            defaultValues.Add(new StringDefaultValueProvider());
            defaultValues.Add(new TaskDefaultValueProvider(defaultValues));
            defaultValues.Add(new StubDefaultValueProvider(factory));

            return factory;
        });

        public static IStubFactory Default => DefaultLazy.Value;

        private readonly ProxyGenerator _proxyGenerator;
        public IDefaultValueService DefaultValues { get; }

        public StubFactory() {
            _proxyGenerator = new ProxyGenerator();
            DefaultValues = new DefaultValueService();
        }

        public object CreateStub(Type interfaceToProxy, Type[] additionalInterfaces = null, IEnumerable<object> mixins = null, IInterceptor[] interceptors = null) {
            additionalInterfaces = additionalInterfaces ?? new Type[0];
            mixins = mixins ?? Enumerable.Empty<object>();
            interceptors = interceptors ?? new IInterceptor[0];

            var defaultIInterceptor = new Interceptor(DefaultValues);
            var proxyGenerationOptions = CreateOptions(mixins.ToList());
            interceptors = interceptors.Append(defaultIInterceptor).ToArray();
            return _proxyGenerator.CreateInterfaceProxyWithoutTarget(interfaceToProxy, additionalInterfaces, proxyGenerationOptions, interceptors);
        }

        private ProxyGenerationOptions CreateOptions(ICollection<object> mixins) {
            if (mixins.Count == 0) {
                return new ProxyGenerationOptions(new AllMethodsHook());
            }

            var options = new ProxyGenerationOptions(new AllMethodsExceptMixinsProxyGeneratorHook(mixins));
            foreach (var mixin in mixins) {
                options.AddMixinInstance(mixin);
            }

            return options;
        }
    }
}