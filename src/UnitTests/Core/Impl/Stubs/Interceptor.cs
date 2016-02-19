using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Castle.DynamicProxy;

namespace Microsoft.UnitTests.Core.Stubs {
    internal class Interceptor : ICustomizableInterceptor {
        private static readonly Func<IReadOnlyList<object>, bool> DefaultFilter = _ => true;

        private readonly IDefaultValueService _defaultValueService;
        private readonly ConcurrentDictionary<MethodInfo, IOverride> _overrides;

        public Interceptor(IDefaultValueService defaultValueService) {
            _defaultValueService = defaultValueService;
            _overrides = new ConcurrentDictionary<MethodInfo, IOverride>();
        }

        public void Intercept(IInvocation invocation) {
            if (InterceptorOperations.ForCurrentThread.IsOverriding) {
                InterceptorOperations.ForCurrentThread.SetLastInvokedInterceptor(this, invocation.Method);
            }

            ExecuteOverride(invocation);
        }

        public void AddOverride(MethodInfo method, Func<IReadOnlyList<object>, bool> filter, Action<InvocationData> handler) {
            var ov = new Override(filter ?? DefaultFilter, handler);
            _overrides.AddOrUpdate(method, ov, (mi, ovCurrent) => {
                ov.Next = ovCurrent;
                return ov;
            });
        }

        private void ExecuteOverride(IInvocation invocation) {
            var method = invocation.Method;
            var parameters = method.GetParameters();

            IOverride ov = _overrides.GetOrAdd(method, CreateDefaultOverride(method));

            var arguments = new ReadOnlyCollection<object>(invocation.Arguments);
            while (ov != null) {
                if (ov.Filter(arguments)) {
                    break;
                }
                ov = ov.Next;
            }   

            if (ov == null) {
                ov = InjectDefault(method);
            }

            var invocationData = new InvocationData(method, (object[])invocation.Arguments.Clone());
            ov.Handler(invocationData);

            var outRefIndexes = parameters
                .Where(p => p.IsOut || p.ParameterType.IsByRef)
                .Select(p => p.Position);

            foreach (var index in outRefIndexes) {
                invocation.SetArgumentValue(index, invocationData.Arguments[index]);
            }

            if (method.ReturnType != typeof (void)) {
                invocation.ReturnValue = invocationData.ReturnValue;
            }
        }

        private IOverride InjectDefault(MethodInfo method) {
            var ov = CreateDefaultOverride(method);
            _overrides.AddOrUpdate(method, ov, (mi, ovCurrent) => {
                var top = ovCurrent;
                while (ovCurrent.Next != null) {
                    ovCurrent = ovCurrent.Next;
                }
                ovCurrent.Next = ov;
                return top;
            });
            return ov;
        }

        private IOverride CreateDefaultOverride(MethodInfo method) {
            return new DefaultOverride(new Lazy<Action<InvocationData>>(() => CreateDefaultHandler(method)));
        }

        private Action<InvocationData> CreateDefaultHandler(MethodInfo method) {
            var parameters = method.GetParameters();
            var outIndexes = parameters
                .Where(p => p.IsOut)
                .Select(p => p.Position)
                .ToList();

            var outValues = new KeyValuePair<int, object>[outIndexes.Count];
            for (var i  = 0; i < outIndexes.Count; i++) {
                var index = outIndexes[i];
                var value = _defaultValueService.GetValue(parameters[index].ParameterType);
                outValues[i] = new KeyValuePair<int, object>(index, value);
            }

            if (method.ReturnType == typeof (void)) {
                return CreateDefaultHandler(outValues);
            }

            var returnValue = _defaultValueService.GetValue(method.ReturnType);
            return CreateDefaultHandler(outValues, returnValue);
        }

        private static Action<InvocationData> CreateDefaultHandler(KeyValuePair<int, object>[] outValues, object returnValue) {
            return data => {
                foreach (var outValue in outValues) {
                    data.Arguments[outValue.Key] = outValue.Value;
                }
                data.ReturnValue = returnValue;
            };
        }

        private static Action<InvocationData> CreateDefaultHandler(KeyValuePair<int, object>[] outValues) {
            return data => {
                foreach (var outValue in outValues) {
                    data.Arguments[outValue.Key] = outValue.Value;
                }
            };
        }

        private interface IOverride {
            IOverride Next { get; set; }
            Func<IReadOnlyList<object>, bool> Filter { get; }
            Action<InvocationData> Handler { get; }
        }

        private class Override : IOverride {
            public Override(Func<IReadOnlyList<object>, bool> filter, Action<InvocationData> handler) {
                Filter = filter;
                Handler = handler;
            }

            public IOverride Next { get; set; }
            public Func<IReadOnlyList<object>, bool> Filter { get; }
            public Action<InvocationData> Handler { get; }
        }

        private class DefaultOverride : IOverride {
            private readonly Lazy<Action<InvocationData>> _handlerProvider;

            public DefaultOverride(Lazy<Action<InvocationData>> handlerProvider) {
                _handlerProvider = handlerProvider;
            }

            public IOverride Next {
                get { return null; }
                set { throw new NotSupportedException("Default Override should be at the bottom of the stack"); }
            }

            public Func<IReadOnlyList<object>, bool> Filter => DefaultFilter;
            public Action<InvocationData> Handler => _handlerProvider.Value;
        }
    }
}
