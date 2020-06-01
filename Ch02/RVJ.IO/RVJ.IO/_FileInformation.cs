using System;
#if DEBUG
using System.Diagnostics;
#endif

namespace RVJ.IO {

    /*

        OVERVIEW
     


    */
    internal sealed class _FileInformation : System.Object, RVJ.IO.IStream {

        #region Fields
        private String _fileName;
        private System.IO.FileStream _dataStream;
        #endregion

        #region Constructors
        /// <summary>
        /// The constructor will open for read/write byte default.
        /// </summary>
        /// <param name="fileStream"></param>
        public _FileInformation( String fileName ) : base() {

            this._fileName = fileName;

            return;
        }

        #endregion

        #region  IStream Methods
        /// <summary>
        /// Verifies if the data stream was created.
        /// </summary>
        public Boolean Exists() {
            return ( System.IO.File.Exists( this._fileName ) );
        }
        /// <summary>
        /// The method will open for read/write by default. 
        /// </summary>
        /// <returns></returns>
        public Boolean Open() {

            Boolean _opened = new Boolean();

            if ( this.Exists() ) this._dataStream = System.IO.File.Open( this._fileName, System.IO.FileMode.Open, System.IO.FileAccess.ReadWrite );


            return _opened;

        }
        public Byte[] Read( OperationDirection operationDirection, UInt32 numberOfBytes, Boolean asyncOperation ) {
            return ( this._internalStream = base.Read( operationDirection, numberOfBytes, asyncOperation ) );
        }

        /// <summary>
        /// Tries to write to the data stream.
        /// </summary>
        public Boolean Write() {
            return new Boolean();
        }

        /// <summary>
        /// Tries to close the data stream.
        /// </summary>
        public Boolean Close() {

            Boolean _closed = ( this._dataStream == null );

            if ( !_closed ) {
                this._dataStream.Dispose();
                this._dataStream = null;
            }

            return _closed;
        }
        #endregion

        #region Public Properties
        #endregion
    };
};
