using Microsoft.Common.Core;
using NSubstitute;
using NSubstitute.Core;

namespace Microsoft.UnitTests.Core {
    public static partial class StubUtil {
/*        public static void Set<T1, TResult>(FuncOut1<T1, TResult> method, T1 outArg1, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, TResult>(FuncOut1<T1, TResult> method, FuncOut1<T1, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, TResult>(FuncOut2<T1, T2, TResult> method, T1 inArg1, T2 outArg2, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, TResult>(FuncOut2<T1, T2, TResult> method, FuncOut2<T1, T2, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, TResult>(FuncOut12<T1, T2, TResult> method, T1 outArg1, T2 outArg2, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, TResult>(FuncOut12<T1, T2, TResult> method, FuncOut12<T1, T2, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, TResult>(FuncOut3<T1, T2, T3, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, TResult>(FuncOut3<T1, T2, T3, TResult> method, FuncOut3<T1, T2, T3, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, TResult>(FuncOut13<T1, T2, T3, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, TResult>(FuncOut13<T1, T2, T3, TResult> method, FuncOut13<T1, T2, T3, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, TResult>(FuncOut23<T1, T2, T3, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, TResult>(FuncOut23<T1, T2, T3, TResult> method, FuncOut23<T1, T2, T3, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, TResult>(FuncOut123<T1, T2, T3, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, TResult>(FuncOut123<T1, T2, T3, TResult> method, FuncOut123<T1, T2, T3, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, TResult>(FuncOut4<T1, T2, T3, T4, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, TResult>(FuncOut4<T1, T2, T3, T4, TResult> method, FuncOut4<T1, T2, T3, T4, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, TResult>(FuncOut14<T1, T2, T3, T4, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, TResult>(FuncOut14<T1, T2, T3, T4, TResult> method, FuncOut14<T1, T2, T3, T4, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, TResult>(FuncOut24<T1, T2, T3, T4, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, TResult>(FuncOut24<T1, T2, T3, T4, TResult> method, FuncOut24<T1, T2, T3, T4, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, TResult>(FuncOut124<T1, T2, T3, T4, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, TResult>(FuncOut124<T1, T2, T3, T4, TResult> method, FuncOut124<T1, T2, T3, T4, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, TResult>(FuncOut34<T1, T2, T3, T4, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, TResult>(FuncOut34<T1, T2, T3, T4, TResult> method, FuncOut34<T1, T2, T3, T4, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, TResult>(FuncOut134<T1, T2, T3, T4, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, TResult>(FuncOut134<T1, T2, T3, T4, TResult> method, FuncOut134<T1, T2, T3, T4, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, TResult>(FuncOut234<T1, T2, T3, T4, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, TResult>(FuncOut234<T1, T2, T3, T4, TResult> method, FuncOut234<T1, T2, T3, T4, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, TResult>(FuncOut1234<T1, T2, T3, T4, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, TResult>(FuncOut1234<T1, T2, T3, T4, TResult> method, FuncOut1234<T1, T2, T3, T4, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut5<T1, T2, T3, T4, T5, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut5<T1, T2, T3, T4, T5, TResult> method, FuncOut5<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut15<T1, T2, T3, T4, T5, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut15<T1, T2, T3, T4, T5, TResult> method, FuncOut15<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut25<T1, T2, T3, T4, T5, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut25<T1, T2, T3, T4, T5, TResult> method, FuncOut25<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut125<T1, T2, T3, T4, T5, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut125<T1, T2, T3, T4, T5, TResult> method, FuncOut125<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut35<T1, T2, T3, T4, T5, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut35<T1, T2, T3, T4, T5, TResult> method, FuncOut35<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut135<T1, T2, T3, T4, T5, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut135<T1, T2, T3, T4, T5, TResult> method, FuncOut135<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut235<T1, T2, T3, T4, T5, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut235<T1, T2, T3, T4, T5, TResult> method, FuncOut235<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut1235<T1, T2, T3, T4, T5, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut1235<T1, T2, T3, T4, T5, TResult> method, FuncOut1235<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut45<T1, T2, T3, T4, T5, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut45<T1, T2, T3, T4, T5, TResult> method, FuncOut45<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut145<T1, T2, T3, T4, T5, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut145<T1, T2, T3, T4, T5, TResult> method, FuncOut145<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut245<T1, T2, T3, T4, T5, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut245<T1, T2, T3, T4, T5, TResult> method, FuncOut245<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut1245<T1, T2, T3, T4, T5, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut1245<T1, T2, T3, T4, T5, TResult> method, FuncOut1245<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut345<T1, T2, T3, T4, T5, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut345<T1, T2, T3, T4, T5, TResult> method, FuncOut345<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut1345<T1, T2, T3, T4, T5, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut1345<T1, T2, T3, T4, T5, TResult> method, FuncOut1345<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut2345<T1, T2, T3, T4, T5, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut2345<T1, T2, T3, T4, T5, TResult> method, FuncOut2345<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut12345<T1, T2, T3, T4, T5, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, TResult>(FuncOut12345<T1, T2, T3, T4, T5, TResult> method, FuncOut12345<T1, T2, T3, T4, T5, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut6<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut6<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut6<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut16<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut16<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut16<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut26<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut26<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut26<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut126<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut126<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut126<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut36<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut36<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut36<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut136<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut136<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut136<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut236<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut236<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut236<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut1236<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut1236<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut1236<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut46<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut46<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut46<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut146<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut146<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut146<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut246<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut246<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut246<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut1246<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut1246<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut1246<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut346<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut346<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut346<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut1346<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut1346<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut1346<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut2346<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut2346<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut2346<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut12346<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut12346<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut12346<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut56<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut56<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut56<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut156<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut156<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut156<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut256<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut256<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut256<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut1256<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut1256<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut1256<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut356<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut356<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut356<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut1356<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut1356<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut1356<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut2356<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut2356<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut2356<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut12356<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut12356<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut12356<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut456<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut456<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut456<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut1456<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut1456<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut1456<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut2456<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut2456<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut2456<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut12456<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut12456<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut12456<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut3456<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut3456<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut3456<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut13456<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut13456<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut13456<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut23456<T1, T2, T3, T4, T5, T6, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut23456<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut23456<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut123456<T1, T2, T3, T4, T5, T6, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, TResult>(FuncOut123456<T1, T2, T3, T4, T5, T6, TResult> method, FuncOut123456<T1, T2, T3, T4, T5, T6, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut7<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut7<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut7<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut17<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut17<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut17<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut27<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut27<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut27<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut127<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut127<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut127<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut37<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut37<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut37<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut137<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut137<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut137<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut237<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut237<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut237<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1237<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1237<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut1237<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut47<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut47<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut47<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut147<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut147<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut147<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut247<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut247<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut247<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1247<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1247<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut1247<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut347<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut347<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut347<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1347<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1347<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut1347<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut2347<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut2347<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut2347<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut12347<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut12347<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut12347<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut57<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut57<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut57<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut157<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut157<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut157<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut257<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut257<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut257<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1257<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1257<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut1257<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut357<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut357<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut357<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1357<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1357<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut1357<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut2357<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut2357<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut2357<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut12357<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut12357<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut12357<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut457<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut457<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut457<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1457<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1457<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut1457<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut2457<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut2457<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut2457<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut12457<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut12457<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut12457<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut3457<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut3457<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut3457<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut13457<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut13457<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut13457<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut23457<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut23457<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut23457<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut123457<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut123457<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut123457<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut67<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut67<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut67<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut167<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut167<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut167<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut267<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut267<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut267<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1267<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1267<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut1267<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut367<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut367<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut367<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1367<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1367<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut1367<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut2367<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut2367<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut2367<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut12367<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut12367<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut12367<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut467<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut467<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut467<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1467<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1467<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut1467<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut2467<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut2467<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut2467<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut12467<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut12467<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut12467<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut3467<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut3467<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut3467<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut13467<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut13467<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut13467<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut23467<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut23467<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut23467<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut123467<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut123467<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut123467<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut1567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut2567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut2567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut2567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut12567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut12567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut12567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut3567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut3567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut3567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut13567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut13567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut13567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut23567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut23567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut23567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut123567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut123567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut123567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut4567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut4567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut4567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut14567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut14567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut14567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut24567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut24567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut24567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut124567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut124567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut124567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut34567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut34567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut34567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut134567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut134567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut134567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut234567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut234567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut234567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1234567<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, TResult>(FuncOut1234567<T1, T2, T3, T4, T5, T6, T7, TResult> method, FuncOut1234567<T1, T2, T3, T4, T5, T6, T7, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut8<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut8<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut8<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut18<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut18<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut18<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut28<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut28<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut28<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut128<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut128<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut128<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut38<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut38<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut38<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut138<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut138<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut138<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut238<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut238<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut238<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1238<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1238<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1238<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut48<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut48<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut48<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut148<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut148<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut148<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut248<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut248<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut248<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1248<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1248<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1248<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut348<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut348<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut348<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1348<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1348<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1348<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2348<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2348<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut2348<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12348<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12348<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut12348<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut58<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut58<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut58<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut158<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut158<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut158<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut258<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut258<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut258<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1258<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1258<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1258<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut358<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut358<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut358<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1358<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1358<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1358<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2358<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2358<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut2358<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12358<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12358<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut12358<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut2458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut12458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut3458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut3458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut3458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut13458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut13458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut13458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut23458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut23458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut23458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut123458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut123458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut123458<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut68<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut68<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut68<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut168<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut168<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut168<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut268<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut268<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut268<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1268<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1268<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1268<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut368<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut368<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut368<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1368<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1368<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1368<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2368<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2368<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut2368<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12368<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12368<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut12368<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut2468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut12468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut3468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut3468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut3468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut13468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut13468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut13468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut23468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut23468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut23468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut123468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut123468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut123468<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut2568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut12568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut3568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut3568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut3568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut13568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut13568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut13568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut23568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut23568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut23568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut123568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut123568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut123568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut4568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut4568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut4568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut14568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut14568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut14568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut24568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut24568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut24568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut124568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut124568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut124568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut34568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut34568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut34568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut134568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut134568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut134568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut234568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut234568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut234568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1234568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 inArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1234568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1234568<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut78<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut78<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut78<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut178<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut178<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut178<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut278<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut278<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut278<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1278<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1278<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1278<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut378<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut378<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut378<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1378<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1378<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1378<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2378<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2378<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut2378<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12378<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12378<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut12378<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut2478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut12478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut3478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut3478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut3478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut13478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut13478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut13478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut23478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut23478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut23478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut123478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut123478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut123478<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut2578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut12578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut3578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut3578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut3578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut13578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut13578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut13578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut23578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut23578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut23578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut123578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut123578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut123578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut4578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut4578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut4578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut14578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut14578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut14578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut24578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut24578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut24578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut124578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut124578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut124578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut34578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut34578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut34578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut134578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut134578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut134578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut234578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut234578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut234578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1234578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 inArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1234578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1234578<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut2678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut12678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut3678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut3678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut3678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut13678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut13678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut13678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut23678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut23678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut23678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut123678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut123678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut123678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut4678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut4678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut4678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut14678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut14678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut14678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut24678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut24678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut24678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut124678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut124678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut124678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut34678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut34678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut34678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut134678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut134678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut134678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut234678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut234678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut234678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1234678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 inArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1234678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1234678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut5678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut5678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut5678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut15678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut15678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut15678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut25678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut25678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut25678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut125678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut125678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut125678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut35678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut35678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut35678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut135678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut135678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut135678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut235678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut235678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut235678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1235678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 inArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1235678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1235678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut45678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut45678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut45678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut145678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut145678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut145678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut245678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut245678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut245678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1245678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 inArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1245678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1245678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut345678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut345678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut345678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1345678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 inArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut1345678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut1345678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2345678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 inArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut2345678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut2345678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
/*        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12345678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 outArg1, T2 outArg2, T3 outArg3, T4 outArg4, T5 outArg5, T6 outArg6, T7 outArg7, T8 outArg8, TResult result) {
            Set(method, (out TOut1 arg1) => { arg1 = outArg1; return result; });
        }

        public static void Set<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(FuncOut12345678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, FuncOut12345678<T1, T2, T3, T4, T5, T6, T7, T8, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }
		*/
	}
}
