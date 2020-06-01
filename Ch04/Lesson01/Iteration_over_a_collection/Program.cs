#region Namespaces / Assemblies
using System;
using System.Collections;
using System.Collections.Generic;
#endregion

namespace Lesson01 { 
    public static class Program {

        public static void Main() {

            String[] values = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            UInt32[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            #region List of numbers using a nongenerics-based collection.
            ArrayList nonGenericsList = new ArrayList();
            nonGenericsList.AddRange( values );
            #endregion


            #region List of numbers using a generics-based collection.
            List<UInt32> genericsList = new List<UInt32>();
            genericsList.AddRange( numbers );
            #endregion


            foreach ( String number in nonGenericsList ) { Console.WriteLine( "{0}\n", number ); }

            IEnumerator enumerator = nonGenericsList.GetEnumerator();
            while ( enumerator.MoveNext() ) { Console.WriteLine( "{0}\n", enumerator.Current.ToString() ); }

            foreach ( UInt32 number in genericsList ) { Console.WriteLine( "{0}\n", number.ToString() ); }

            IEnumerator<UInt32> enumeratorGenerics = genericsList.GetEnumerator();
            while ( enumeratorGenerics.MoveNext() ) { Console.WriteLine( "{0}\n", enumeratorGenerics.Current.ToString() ); }
            
            UInt32 index = new UInt32();
            UInt32 length = ( ( UInt32 ) nonGenericsList.Count );

            for ( String[] items = ( String[] ) nonGenericsList.ToArray(); index < length; index++ ) { Console.WriteLine( "{0}\n", items[ index ].ToString() ); }

            length = ( ( UInt32 ) genericsList.Count );
            index = new UInt32();

            for ( UInt32[] items = genericsList.ToArray(); index < length; index++ ) { Console.WriteLine( "{0}\n", items[ index ].ToString() ); }
            
        }
    };
};
