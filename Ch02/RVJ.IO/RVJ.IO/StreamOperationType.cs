#region Namespaces / Assemblies
using System;
#if DEBUG
using System.Diagnostics;
#endif
#endregion

namespace RVJ.IO {

    public enum StreamOperationType {

        Read, // Can read from data stream.
        Write, // Can write to the data stream.
        Seek, // Can move randomically between positional bytes in the data stream.
        All, // The data stream is managed as a pure sequence of bytes, can read, can write, and can seek.
        None //  No operation can be applied in the data stream.
    };
};
