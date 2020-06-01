#region Namespaces / Assemblies
using System;
#if DEBUG
using System.Diagnostics;
#endif
#endregion

namespace RVJ.IO {
    /*

        OVERVIEW

        The RVJ.IO.FileAttributes.Normal attribute indicates that the file is a standard file that has no special attributes. This System.IO.FileAttributes.Normal attribute is valid only if it is used alone. System.IO.FileAttributes.Normal is supported on Windows, Linux, and macOS.

        The RVJ.IO.FileAttributes.Directory indicates that the file is a directory. System.IO.FileAttributes.Directory is supported on Windows, Linux, and macOS.
        	
        The RVJ.IO.FileAttributes.ReadOnly indicates that the file is read-only. The System.IO.FileAttributes.ReadOnly is supported on Windows, Linux, and macOS. On Linux and macOS, changing the ReadOnly flag is a permissions operation.

        The RVJ.IO.FileAttributes.Hidden indicates that the file is hidden, and thus is not included in an ordinary directory listing, by default. System.IO.FileAccess.Hidden attribute is supported on Windows, Linux, and macOS.


        	
         The RVJ.IO.FileAttributes.OperatingSystem indicates that the file is a operating system file. That is, the file is part of the operating system or is used exclusively by the operating system.

        	
        The RVJ.IO.FileAttributes.Temporary indicates that the file is temporary. A temporary file contains data that is needed while an application is executing but is not needed after the application is finished. File systems try to keep all the data in memory for quicker access rather than flushing the data back to mass storage. A temporary file should be deleted by the application as soon as it is no longer needed.


        	
        The RVJ.IO.FileAttributes.Compressed indicates that the file is compressed.

    */
    public enum FileAttibutes {
        Normal = System.IO.FileAttributes.Normal,
        Directory = System.IO.FileAttributes.Directory,
        ReadOnly = System.IO.FileAttributes.ReadOnly,
        Hidden = System.IO.FileAttributes.Hidden,
        OperatingSystem = System.IO.FileAttributes.System,
        Temporary = System.IO.FileAttributes.Temporary,
        Compressed = System.IO.FileAttributes.Compressed
    };
};
