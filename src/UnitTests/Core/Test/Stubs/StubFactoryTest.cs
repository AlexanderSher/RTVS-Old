using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.UnitTests.Core.Stubs;
using Microsoft.UnitTests.Core.XUnit;

namespace Microsoft.UnitTests.Core.Test.Stubs {
    public class StubFactoryTest {

        public class Default {
            private readonly IForProxy _proxy;

            public Default() {
                _proxy = (IForProxy)StubFactory.Default.CreateStub(typeof(IForProxy));
            }

            [Test]
            public void DefaultArrayValue() {
                _proxy.GetArray().Should().NotBeNull().And.BeEmpty();
            }

            [Test]
            public void DefaultDoubleValue() {
                _proxy.GetDouble().Should().Be(0d);
            }

            [Test]
            public void DefaultStringValue() {
                _proxy.GetString().Should().NotBeNull().And.BeEmpty();
            }

            [Test]
            public void DefaultTaskValue() {
                _proxy.ExecuteAsync().Should().NotBeNull();
            }

            [Test]
            public void DefaultTaskWithResultValue() {
                _proxy.GetStringAsync().Should().NotBeNull()
                    .And.BeOfType<Task<string>>()
                    .Which.Result.Should().NotBeNull()
                        .And.BeEmpty();
            }

            [Test]
            public void DefaultInterfaceValue() {
                _proxy.GetNextTest().Should().NotBeNull();
            }

            [Test]
            public void DefaultOutParameterValue() {
                string pIn = "a", pRef = "b", pOut;

                var result = _proxy.InOutRef(pIn, ref pRef, out pOut);

                pRef.Should().Be("b");
                pOut.Should().NotBeNull().And.BeEmpty();
                result.Should().NotBeNull().And.BeEmpty();
            }
        }

        public class Operations {
            private readonly IForProxy _proxy;

            public Operations() {
                _proxy = (IForProxy)StubFactory.Default.CreateStub(typeof(IForProxy));
            }

            [Test]
            public void OverrideInRefOut() {
                Action action = () => {
                    string dRef = null, dOut;
                    _proxy.InOutRef(null, ref dRef, out dOut);
                };

                Action<InvocationData> handler = data => {
                    data.Arguments[2] = data.Arguments[1] + "b";
                    data.Arguments[1] = data.Arguments[0] + "a";
                };

                InterceptorOperations.ForCurrentThread.SetOverride(action, null, handler);

                string pRef = "2", pOut;
                _proxy.InOutRef("1", ref pRef, out pOut);

                pRef.Should().Be("1a");
                pOut.Should().Be("2b");
            }

            [Test]
            public void OverrideChained() {
                Action<InvocationData> handler = data => {
                    data.ReturnValue = _proxy;
                };

                InterceptorOperations.ForCurrentThread.SetOverride(() => _proxy.GetNextTest().GetNextTest(), null, handler);
                _proxy.GetNextTest().Should().NotBeNull();
                _proxy.GetNextTest().GetNextTest().Should().Be(_proxy);
            }

            [Test]
            public void ApplyFilters() {
                Action action = () => {
                    int dOut;
                    _proxy.Method(0, out dOut);
                };

                Func<IReadOnlyList<object>, bool> filter = args => (int)args[0] > 0;
                Action<InvocationData> handler = data => {
                    data.Arguments[1] = -1;
                };

                InterceptorOperations.ForCurrentThread.SetOverride(action, filter, handler);

                int pOut;
                _proxy.Method(-1, out pOut);
                pOut.Should().Be(0);

                _proxy.Method(1, out pOut);
                pOut.Should().Be(-1);
            }

            [Test]
            public void ApplyMultipleFilters() {
                InterceptorOperations.ForCurrentThread.SetOverride(() => _proxy.GetDouble(0), args => (double)args[0] > 0, data => { data.ReturnValue = data.Arguments[0]; });
                InterceptorOperations.ForCurrentThread.SetOverride(() => _proxy.GetDouble(0), args => (double)args[0] < 0, data => { data.ReturnValue = -1d; });

                _proxy.GetDouble(5).Should().Be(5);
                _proxy.GetDouble(0).Should().Be(0);
                _proxy.GetDouble(-5).Should().Be(-1);
            }
        }
    }

    public interface IForProxy {
        void Method(int i, out int j);
        double GetDouble();
        double GetDouble(double i);
        int[] GetArray();
        string GetString();
        IForProxy GetNextTest();
        string InOutRef(string pIn, ref string pRef, out string pOut);

        Task ExecuteAsync();
        Task<string> GetStringAsync();
    }
}
