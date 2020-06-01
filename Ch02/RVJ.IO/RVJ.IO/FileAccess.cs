#region Namespaces / Assemblies
using System;
#if DEBUG
using System.Diagnostics;
#endif
#endregion

namespace RVJ.IO {
    public enum FileAccess {
        Read = System.IO.FileAccess.Read,
        Write = System.IO.FileAccess.Write,
        ReadAndWrite = System.IO.FileAccess.ReadWrite
    };
};
