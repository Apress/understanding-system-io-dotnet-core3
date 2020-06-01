#region Namespaces / Assemblies
using System;
#if DEBUG
using System.Diagnostics;
#endif
#endregion

namespace RVJ.IO {

    /*

        OVERVIEW
        
        The	 RVJ.IO.PositionInStream.Begin specifies the beginning of a stream.
        The	 RVJ.IO.PositionInStream.Current specifies the current position within a stream. 
        The	 RVJ.IO.PositionInStream.End specifies the end of a stream. 

        	
     


    */
    public enum PositionInStream {
        Begin = System.IO.SeekOrigin.Begin,
        Current = System.IO.SeekOrigin.Current,
        End = System.IO.SeekOrigin.End
    };
};
