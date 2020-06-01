#region Namespaces
using System;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
#endregion

namespace RVJ {
    public unsafe class UnmanagedMemory : System.Object {

        #region Private members
        private String _localBuffer;
        private System.IO.UnmanagedMemoryStream _unmanagedStream;
        private Int32 _bufferSizeInBytes;
        private IntPtr _memoryBlock;
        #endregion

        #region Constructors
        public UnmanagedMemory() : base() {

            this._localBuffer = null;
            this._unmanagedStream = null;
            this._bufferSizeInBytes = new Int32();
            this._memoryBlock = IntPtr.Zero;

            return;
        }

        public UnmanagedMemory( String value ) : this() {

            this._localBuffer = value;

            return;
        }
        #endregion



        #region Closes the unmanaged memory stream.
        public void Close() {

            Marshal.FreeHGlobal( this._memoryBlock );
            
            this._unmanagedStream.Close();
            this._unmanagedStream = null;
            this._memoryBlock = IntPtr.Zero;

            return;
        }
        #endregion

        #region Read a sequence of instances of System.Byte from a memory block using an unmanaged stream .
        public void ReadAll( out Byte[] _buffer ) {

            _buffer = new Byte[ this._bufferSizeInBytes ];

            this._unmanagedStream.Position = new Int64();
            this._unmanagedStream.Read( _buffer, new Int32(), this._bufferSizeInBytes );

            return;
        }
        #endregion

        #region Write a sequence of instances of System.Byte in a memory block using an unmanaged stream .
        public void WriteAll() {

            if ( ( this._localBuffer != null ) && ( this._localBuffer.Length > 0 ) ) {

                this._bufferSizeInBytes = UnicodeEncoding.Unicode.GetByteCount( this._localBuffer );

                this._memoryBlock = Marshal.AllocHGlobal( this._bufferSizeInBytes );

                this._unmanagedStream = new System.IO.UnmanagedMemoryStream( ( ( Byte* ) this._memoryBlock.ToPointer() ), this._bufferSizeInBytes, this._bufferSizeInBytes, FileAccess.ReadWrite );

                this._unmanagedStream.Write( UnicodeEncoding.Unicode.GetBytes( this._localBuffer ) );


            };

            return;
        }
        #endregion
    };
};

