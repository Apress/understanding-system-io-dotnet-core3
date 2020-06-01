#region Namespaces / Assemblies 
using System;
#if DEBUG
using System.Diagnostics;
#endif
#endregion

namespace RVJ.IO {

    /*

        OVERVIEW
        
        The	 RVJ.IO.SearchOptionsForDirectories.All 	includes the current directory and all its subdirectories in a search operation. This option includes reparse points such as mounted drives and symbolic links in the search.

        The RVJ.IO.SearchOptionsForDirectories.Top includes only the current directory in a search operation.
        	
     


    */
    public enum SearchOptionsForDirectories {
        All = System.IO.SearchOption.AllDirectories,
        Top = System.IO.SearchOption.TopDirectoryOnly
    };
};
