using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Common.Core;
using Microsoft.VisualStudio.Shell.Interop;
using NSubstitute;

namespace Microsoft.VisualStudio.Shell.Mocks {
    [ExcludeFromCodeCoverage]
    public static class VsUiObjectMock {
        public static IVsUIObject Create() {
            IVsUIObject obj = Substitute.For<IVsUIObject>();
            Set(obj.get_Data, (object)Resources.SampleImage, VSConstants.S_OK);
            return obj;
        }

        public static void Set<TOut1, TResult>(this FuncOut1<TOut1, TResult> method, FuncOut1<TOut1, TResult> implementation) {
            TOut1 p1;
            method(out p1).ReturnsForAnyArgs(x => {
                TOut1 ip1;
                var result = implementation(out ip1);
                x[0] = ip1;
                return result;
            });
        }

        public static void Set<TOut1, TResult>(this FuncOut1<TOut1, TResult> method, TOut1 outArg1, TResult result) {
            method.Set((out TOut1 arg1) => { arg1 = outArg1; return result; });
        }
    }
}
