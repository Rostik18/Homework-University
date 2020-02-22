using System;

namespace Euclidean_algorithm_cript
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int inputed_A = a, inputed_B = b;

            int x1 = 1, y1 = 0, x2 = 0, y2 = 1;

            int r = a - b * (a / b);
            int x3 = x1 - x2 * (a / b);
            int y3 = y1 - y2 * (a / b);

            while (r>0) {
                a = b;
                b = r;
                x1 = x2;
                x2 = x3;
                y1 = y2;
                y2 = y3;

                r = a - b * (a / b);
                x3 = x1 - x2 * (a / b);
                y3 = y1 - y2 * (a / b);
            }

            int NSD = b;
            int u = x2;
            int v = y2;

            Console.WriteLine(" NSD = au + bv ");
            Console.WriteLine(NSD.ToString() + " = " + inputed_A + " * " + u + " + " + inputed_B + " * " + v);

            Console.ReadKey();
        }
    }
}
