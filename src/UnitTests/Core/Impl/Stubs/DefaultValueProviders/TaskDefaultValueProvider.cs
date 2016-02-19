using System;
using System.Reflection;
using System.Threading.Tasks;

namespace Microsoft.UnitTests.Core.Stubs.DefaultValueProviders {
    internal sealed class TaskDefaultValueProvider : IDefaultValueProvider {
        private static readonly MethodInfo FromResult = typeof (Task).GetMethod(nameof(Task.FromResult));
        private readonly IDefaultValueService _defaultValues;

        public TaskDefaultValueProvider(IDefaultValueService defaultValues) {
            _defaultValues = defaultValues;
        }

        public bool CanProvide(Type type) => type == typeof(Task) || (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Task<>));

        public object Provide(Type type) {
            if (type == typeof (Task)) {
                return Task.CompletedTask;
            }

            var taskResultType = type.GenericTypeArguments[0];
            var value = _defaultValues.GetValue(taskResultType);
            return FromResult.MakeGenericMethod(taskResultType).Invoke(null, new []{value});
        }
    }
}