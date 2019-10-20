using System;

namespace Repeated_squaring_cript {

    class Program {

        static void Main( string[] args ) {

            Console.Write( "Enter a: " );
            int a = Convert.ToInt32( Console.ReadLine() );
            Console.Write( "Enter n: " );
            int n = Convert.ToInt32( Console.ReadLine() );

            string binary_n = "";

            while (n > 0) {
                binary_n += n % 2;        //Інвертований бінарний запис.
                n /= 2;
            }

            long Rez;

            if (binary_n[0] == '1') {
                Rez = a;
            } else {
                Rez = 1;
            }

            Console.Write( Rez );

            for (int i = 1; i < binary_n.Length; i++) {

                a = a * a;
                if (binary_n[i] == '1') {
                    Console.Write( " * " + a );
                    Rez *= a;
                }

            }


            Console.WriteLine( "\na^n: " + Rez );


            Console.ReadKey();
        }
    }
}
