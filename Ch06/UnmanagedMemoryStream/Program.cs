#region Namespaces
using System;
using System.Text;
#endregion

namespace RVJ {
    public class Program : System.Object {
        public static void Main() {

            String _sampleMessage = "Unmanaged .NET data types";

            RVJ.UnmanagedMemory _unmanagedMemory = new RVJ.UnmanagedMemory( _sampleMessage );

            _unmanagedMemory.WriteAll();

            _unmanagedMemory.ReadAll( out Byte[] _localBuffer );
            _unmanagedMemory.Close();

            String result = UnicodeEncoding.Unicode.GetString( _localBuffer );

            Console.WriteLine("result: {0}", result );

            return;
        }
    };
};
