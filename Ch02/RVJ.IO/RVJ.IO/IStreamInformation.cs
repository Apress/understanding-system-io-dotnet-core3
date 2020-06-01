#region Namespaces / Assemblies
using System;
#if DEBUG
using System.Diagnostics;
#endif
#endregion

namespace RVJ.IO {
    public interface IStreamInformation : RVJ.IO.IStream {

        #region Properties
        /// <summary>
        /// Type of data stream.
        /// </summary>
        RVJ.IO.StreamType Type { get; set; }

        /// <summary>
        /// Name of data stream (real or virtual).
        /// </summary>
        String Name { get; set; }

        /// <summary>
        /// Size of data stream (32-bit). Can be zero or a negative value.
        /// </summary>
        Int32 SizeInBytes { get; set; }

        /// <summary>
        /// Larger size (64-bit) of a data stream, if available. Can be zero or a negative value.
        /// </summary>
        Int64 LargerSizeInBytes { get; set; }

        /// <summary>
        /// Date of creation of data stream. 
        /// </summary>
        DateTime Creation { get; set; }

        /// <summary>
        /// Date of last update of data stream. 
        /// </summary>
        DateTime LastUpdate { get; set; }

        /// <summary>
        /// Indicates the type of operation supported by the data stream at this moment.
        /// </summary>
        RVJ.IO.StreamOperationType OperatingType { get; set; }

        /// <summary>
        /// Indicates if an operation of read can be realized.
        /// </summary>
        Boolean CanRead { get; }

        /// <summary>
        /// Indicates if an operation of write can be realized.
        /// </summary>
        Boolean CanWrite { get; }

        #endregion

    };
};
