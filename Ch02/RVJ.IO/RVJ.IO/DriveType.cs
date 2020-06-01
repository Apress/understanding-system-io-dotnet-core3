#region Namespaces / Assemblies
using System;
#if DEBUG
using System.Diagnostics;
#endif
#endregion

namespace RVJ.IO {
    public enum DriveType {
        Fixed =  System.IO.DriveType.Fixed,
        Ram = System.IO.DriveType.Ram,
        Network = System.IO.DriveType.Network,
        CDRom = System.IO.DriveType.CDRom,
        Removable = System.IO.DriveType.Removable
    };
};
