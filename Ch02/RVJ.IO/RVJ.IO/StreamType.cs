#region Namespaces / Assemblies
using System;
#if DEBUG
using System.Diagnostics;
#endif
#endregion

namespace RVJ.IO {

    public  enum StreamType {

        Directory,
        File,
        Memory,
        Unknown // The data stream is managed as a pure sequence of bytes.


    };
};
