#region Namespaces / Assemblies
using System;
#if DEBUG
using System.Diagnostics;
#endif
#endregion

namespace RVJ.IO {

	public sealed class StreamInformation : System.Object, RVJ.IO.IStreamInformation {

		#region Common Fields
		// Type of data stream.
		private StreamType _type;
		// Name of data stream (real of not).
		private String _name;
		// Size (32-bit) of data stream, if available. Can be zero or a negative value.
		private Int32 _sizeInBytes;
		// Larger size (64-bit) of a data stream, if available. Can be zero or a negative value.
		private Int64 _largerSizeInBytes;
		// Date of creation of data stream.
		private DateTime _creationDateTime;
		// Date of last update of data stream.
		private DateTime _lastUpdateDateTime;
		#endregion

		#region Stream management typical fields
		// The opened data stream of some specialized type.
		private System.IO.Stream _dataStream;

		// Type of operation, read/write/seek/all, that can be used with the data stream.
		private StreamOperationType _operationType;


		// Fields for working with the position when moving between bytes within the sequence.
		private UInt32 _currentPosition32;
		private UInt32 _nextPosition32;
		private UInt32 _previousPosition32;
		private UInt64 _lastPosition32; // Not the last byte in the data stream, but the last usefull position for the application.
		private UInt64 _currentPosition64;
		private UInt64 _nextPosition64;
		private UInt64 _previousPosition64;
		private UInt64 _lastPosition64; // Not the last byte in the data stream, but the last usefull position for the application.

		// The sequence of bytes stored in an internal data stream.
		private Byte[] _internalStream;

		#endregion

		#region Constructors
		public StreamInformation() : base() {

			this._type = StreamType.File;
			this._name = String.Empty;
			this._sizeInBytes = new Int32();
			this._largerSizeInBytes = new Int64();
			this._creationDateTime = DateTime.Now;
			this._lastUpdateDateTime = DateTime.Now;

			this._dataStream = null;
			this._operationType = StreamOperationType.None;

			this._currentPosition32 = new UInt32();
			this._nextPosition32 = new UInt32();
			this._previousPosition32 = new UInt32();
			this._lastPosition32 = new UInt32();
			this._currentPosition64 = new UInt64();
			this._nextPosition64 = new UInt64();
			this._previousPosition64 = new UInt64();
			this._lastPosition64 = new UInt64();

			this._internalStream = null;

			return;
		}

		public StreamInformation( StreamType type ) : this() {

			switch ( type ) {
				case StreamType.Directory:
				case StreamType.File:
				case StreamType.Memory: {

					};
					break;
				default: break;
			}

			return;
		}
		#endregion

		#region Methods

		/// <summary>
		/// Verifies if the data stream was created.
		/// </summary>
		public Boolean Exists() {
			Boolean _exists = new Boolean();

			return _exists;
		}

		/// <summary>
		///  Tries to open the data stream.
		/// </summary>
		public Boolean Open() {

			return new Boolean();
		}

		/// <summary>
		/// Tries to read some portion of the data stream.
		/// Returns the readed portion of data stream in  a System.Byte[] array.
		/// </summary>
		public Byte[] Read( OperationDirection operationDirection, UInt32 numberOfBytes, Boolean asyncOperation ) {

			Boolean _argumentValuesValid = new Boolean();
			UInt32 _localValue = new UInt32();

			switch ( operationDirection ) {
				case OperationDirection.Forward: {
						// The number of bytes must be greater than zero.
						_argumentValuesValid = ( numberOfBytes > _localValue );
					};
					break;
				case OperationDirection.Back: {
						// The number of bytes must be negative.
						_argumentValuesValid = ( numberOfBytes < _localValue );
					};
					break;
				default: // For the zero value, does nothing.
					break;
			}

			if ( asyncOperation ) {
				// Should use the async available methods for management of data stream.
			} else {
				// Should use the non-async available methods for management of data stream.
			};



			return this._internalStream;
		}


		/// <summary>
		/// Tries to write to the data stream.
		/// </summary>
		public Boolean Write() {

			Boolean _written = new Boolean();

			return _written;
		}

		/// <summary>
		/// Tries to close the data stream.
		/// </summary>
		public Boolean Close() {

			Boolean _closed = new Boolean();




			return _closed;
		}
		#endregion


		#region Public Properties
		/// <summary>
		/// Type of data stream.
		/// </summary>
		public StreamType Type {
			get {
				return this._type;
			}

			set {
				this._type = value;
				return;
			}
		}

		/// <summary>
		/// Name of data stream (real or virtual).
		/// </summary>
		public String Name {
			get {
				return this._name;
			}

			set {
				if ( !String.IsNullOrEmpty( value ) ) { this._name = value; }
				return;
			}
		}

		/// <summary>
		/// Size of data stream (32-bit). Can be zero or a negative value.
		/// </summary>
		public Int32 SizeInBytes {

			get {
				return this._sizeInBytes;
			}

			set { this._sizeInBytes = value; return; }

		}

		/// <summary>
		/// Larger size (64-bit) of a data stream, if available. Can be zero or a negative value.
		/// </summary>
		public Int64 LargerSizeInBytes {
			get { return this._largerSizeInBytes; }
			set { this._largerSizeInBytes = value; return; }
		}

		/// <summary>
		/// Date of creation of data stream. 
		/// </summary>
		public DateTime Creation {
			get { return this._creationDateTime; }
			set { this._creationDateTime = value; return; }
		}

		/// <summary>
		/// Date of last update of data stream. 
		/// </summary>
		public DateTime LastUpdate {
			get { return this._lastUpdateDateTime; }
			set { this._lastUpdateDateTime = value; return; }
		}

		/// <summary>
		/// Indicates the type of operation supported by the data stream at this moment.
		/// </summary>
		public StreamOperationType OperatingType {
			get { return this._operationType; }
			set { this._operationType = value; return; }
		}

		/// <summary>
		/// Indicates if an operation of read can be realized.
		/// </summary>
		public Boolean CanRead {
			get { return this._operationType == ( StreamOperationType.All | StreamOperationType.Read | StreamOperationType.Seek ); }
		}

		/// <summary>
		/// Indicates if an operation of write can be realized.
		/// </summary>
		public Boolean CanWrite {
			get { return this._operationType == ( RVJ.IO.StreamOperationType.All | RVJ.IO.StreamOperationType.Write ); }
		}

		public System.IO.Stream DataStream {
			get { return this._dataStream; }
			set { if ( value != null ) { this._dataStream = value; return; } }
		}
		#endregion
	};
};
