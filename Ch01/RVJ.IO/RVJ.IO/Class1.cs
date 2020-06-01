using System;
#if DEBUG
using System.Diagnostics;
#endif

namespace RVJ.IO {
    public class Class1 {
        public Class1() {
#if NETCOREAPP3_1 || netstandard2_1

#if DEBUG
            Debug.WriteLine( "Using DEBUG symbol!" );
#endif

#endif

        }

    };
};
