#region Namespaces / Assemblies
using System;
#if DEBUG
using System.Diagnostics;
#endif
#endregion

namespace RVJ.IO {

    /*

        OVERVIEW
        
        The	 RVJ.IO.FileMode.New specifies that the operating system should create a new file. This requires Write permission. If the file already exists, an IOException exception is thrown.

        	
        The RVJ.IO.FileMode.Create specifies that the operating system should create a new file. If the file already exists, it will be overwritten. This requires Write permission. System.IO.FileMode.Create is equivalent to requesting that if the file does not exist, use CreateNew; otherwise, use Truncate. If the file already exists but is a hidden file, an UnauthorizedAccessException exception is thrown.

        The RVJ.IO.FileMode.OpenOrCreate specifies that the operating system should open a file if it exists; otherwise, a new file should be created. If the file is opened with System.IO.FileAccess.Read, Read permission is required. If the file access is System.IO.FileAccess.Write, Write permission is required. If the file is opened with System.IO.FileAccess.ReadWrite, both Read and Write permissions are required.


        The RVJ.IO.FileMode.Open Specifies that the operating system should open an existing file. The ability to open the file is dependent on the value specified by the System.IO.FileAccess enumeration. A FileNotFoundException exception is thrown if the file does not exist.


        	
        The RVJ.IO.FileMode.Append opens the file if it exists and seeks to the end of the file, or creates a new file. This requires Append permission. System.IO.FileMode.Append can be used only in conjunction with System.IO.FileAccess.Write. Trying to seek to a position before the end of the file throws an IOException exception, and any attempt to read fails and throws a NotSupportedException exception.

        The RVJ.IO.FileMode.Truncate specifies that the operating system should open an existing file. When the file is opened, it should be truncated so that its size is zero bytes. This requires Write permission. Attempts to read from a file opened with System.IO.FileMode.Truncate cause an ArgumentException exception.


    */
    public enum FileMode {
        New = System.IO.FileMode.CreateNew,
        Create = System.IO.FileMode.Create,
        OpenOrCreate = System.IO.FileMode.OpenOrCreate,
        Open = System.IO.FileMode.Open,
        Append = System.IO.FileMode.Append,
        Truncate = System.IO.FileMode.Truncate
    };
};
