using System;

namespace Microsoft.UnitTests.Core.Stubs {
    public interface IDefaultValueService {
        void Add(IDefaultValueProvider provider);
        object GetValue(Type type);
    }
}