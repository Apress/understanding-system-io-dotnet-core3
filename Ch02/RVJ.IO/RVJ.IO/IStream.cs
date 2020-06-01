#region Namespaces / Assemblies
using System;
#if DEBUG
using System.Diagnostics;
#endif
#endregion

namespace RVJ.IO {

    public interface IStream {

        #region Behaviors
        /// <summary>
        ///  Tries to open the data stream.
        /// </summary>
        Boolean Open();
        /// <summary>
        /// Verifies if the data stream was created.
        /// </summary>
        Boolean Exists();

        /// <summary>
        /// Tries to read some portion of the data stream.
        /// Returns the readed portion of data stream in  System.Byte[] array.
        /// </summary>
        Byte[] Read( OperationDirection operationDirection, UInt32 numberOfBytes, Boolean asyncOperation );

        /// <summary>
        /// Tries to write to the data stream.
        /// </summary>
        Boolean Write();

        /// <summary>
        /// Tries to close the data stream.
        /// </summary>
        Boolean Close();
        #endregion

        #region Properties
        /// <summary>
        /// Base data stream object instance that was opened for manipulation.
        /// </summary>
        System.IO.Stream DataStream { get; set; }
        #endregion


    };


};
