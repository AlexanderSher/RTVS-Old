using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Castle.DynamicProxy;

namespace Microsoft.UnitTests.Core.Stubs {
    public class AllMethodsExceptMixinsProxyGeneratorHook : AllMethodsHook {
        private readonly HashSet<Type> _mixinTypes;

        public AllMethodsExceptMixinsProxyGeneratorHook(IEnumerable<object> mixins) {
            _mixinTypes = new HashSet<Type>(mixins.Select(m => m.GetType()).SelectMany(GetAllTypes));
        }

        public override bool ShouldInterceptMethod(Type type, MethodInfo methodInfo) {
            return IsNotMixinMethod(methodInfo) && base.ShouldInterceptMethod(type, methodInfo);
        }

        private bool IsNotMixinMethod(MethodInfo methodInfo) {
            return !_mixinTypes.Contains(methodInfo.DeclaringType);
        }

        private static IEnumerable<Type> GetAllTypes(Type type) {
            foreach (var i in type.GetInterfaces()) {
                yield return i;
            }

            while (type != typeof(object) && type != null) {
                yield return type;
                type = type.BaseType;
            }
        }
    }
}