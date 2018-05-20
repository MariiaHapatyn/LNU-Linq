using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqStart {
    class Program {
        public static void Task1 () {
            StreamReader reader = new StreamReader( "fileInt.txt" );
            var str = reader.ReadLine().Split( ',' );
            int[ ] numbers = new int[str.Length];
            for( int i = 0; i < str.Length; i++ ) {
                numbers[i] = int.Parse( str[i] );
            }
            var positiveNumb = numbers.Where( i => i > 0 );
            StreamWriter strim = new StreamWriter( "result1.txt" );
            foreach( var i in positiveNumb ) {
                strim.WriteLine( i );
            }
            reader.Close();
            strim.Close();
        }

        public static void Task2 () {
            StreamReader reader = new StreamReader( "fileInt.txt" );
            var str = reader.ReadLine().Split( ',' );
            int[ ] numbers = new int[str.Length];
            for( int i = 0; i < str.Length; i++ ) {
                numbers[i] = int.Parse( str[i] );
            }
            var oddNumb = numbers.Where( i => ( i % 2 ) != 0 ).Distinct();
            StreamWriter strim = new StreamWriter( "result2.txt" );
            foreach( var i in oddNumb ) {
                strim.WriteLine( i );
            }
            reader.Close();
            strim.Close();
        }

        public static void Task3 () {
            StreamReader reader = new StreamReader( "fileInt.txt" );
            var str = reader.ReadLine().Split( ',' );
            int[ ] numbers = new int[str.Length];
            for( int i = 0; i < str.Length; i++ ) {
                numbers[i] = int.Parse( str[i] );
            }
            var twoDigitsNumber = numbers.Where( i => ( ( i > 0 ) && ( ( i / 10 ) < 10 && ( i / 10 ) > 0 ) ) ).OrderBy( i => i );
            StreamWriter strim = new StreamWriter( "result3.txt" );
            foreach( var i in twoDigitsNumber ) {
                strim.WriteLine( i );
            }
            reader.Close();
            strim.Close();
        }

        public static void Task4 () {
            StreamReader reader = new StreamReader( "file.txt" );
            string line;
            if( ( line = reader.ReadLine() ) != null ) {
                string[ ] parts = line.Split( ',' );
                var orderedWords = parts.OrderBy( i => i.Length ).ThenByDescending( i => i );
                StreamWriter strim = new StreamWriter( "result4.txt" );
                foreach( var i in orderedWords ) {
                    strim.WriteLine( i );
                }
                reader.Close();
                strim.Close();
            }
        }
        public static void Task5 () {
            StreamReader reader = new StreamReader( "fileInt.txt" );
            var str = reader.ReadLine().Split( ',' );
            int[ ] numbers = new int[str.Length];
            for( int i = 0; i < str.Length; i++ ) {
                numbers[i] = int.Parse( str[i] );
            }
            int D = 20;
            var A = numbers.SkipWhile( i => i < D ).Where( i => i % 2 != 0 && i > 0 ).Reverse();
            StreamWriter strim = new StreamWriter( "result5.txt" );
            foreach( var i in A ) {
                strim.WriteLine( i );
            }
            reader.Close();
            strim.Close();
        }

        public static void Task44 () {
            StreamReader reader1 = new StreamReader( "fileInt.txt" );
            StreamReader reader2 = new StreamReader( "fileInt2.txt" );
            var str1 = reader1.ReadLine().Split( ',' );
            var str2 = reader2.ReadLine().Split( ',' );
            int[ ] numbersA = new int[str1.Length];
            int[ ] numbersB = new int[str2.Length];
            for( int i = 0; i < str1.Length; i++ ) {
                numbersA[i] = int.Parse( str1[i] );
            }
            for( int i = 0; i < str2.Length; i++ ) {
                numbersB[i] = int.Parse( str2[i] );
            }
            int k1 = 40;
            int k2 = 70;
            var result = numbersA.Where( i => i > k1 ).Union( numbersB.Where( i => i < k2 ) ).OrderBy( i => i );
            StreamWriter strim = new StreamWriter( "result44.txt" );
            foreach( var i in result ) {
                strim.WriteLine( i );
            }
            reader1.Close();
            reader2.Close();
            strim.Close();
        }
        public static void Task45 () {
            StreamReader reader1 = new StreamReader( "file.txt" );
            StreamReader reader2 = new StreamReader( "file2.txt" );
            string line1 = reader1.ReadLine();
            string[ ] arrayA = line1.Split( ',' );
            string line2 = reader2.ReadLine();
            string[ ] arrayB = line2.Split( ',' );
            int l1 = 3;
            int l2 = 4;
            var orderedWords = arrayA.Where( i => i.Length == l1 ).Union( arrayB.Where( i => i.Length == l2 ) ).OrderByDescending( i => i );
            StreamWriter strim = new StreamWriter( "result45.txt" );
            foreach( var i in orderedWords ) {
                strim.WriteLine( i );
            }
            reader1.Close();
            reader2.Close();
            strim.Close();
        }

        static void Main ( string[ ] args ) {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task44();
            Task45();
        }

    }
}

