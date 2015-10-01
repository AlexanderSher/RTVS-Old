﻿using Microsoft.VisualStudio.Editor.Mocks;

namespace Microsoft.R.Support.Test.Utility
{
    public sealed class RSupportTestCompositionCatalog : TestCompositionCatalog
    {
        private static RSupportTestCompositionCatalog _instance;

        public static ITestCompositionCatalog Current
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RSupportTestCompositionCatalog();
                }

                return _instance;
            }
        }

        private static string[] _rEditorAssemblies = new string[]
        {
            "Microsoft.R.Support.dll",
        };

        private RSupportTestCompositionCatalog() :
            base(_rEditorAssemblies)
        {
        }
    }
}