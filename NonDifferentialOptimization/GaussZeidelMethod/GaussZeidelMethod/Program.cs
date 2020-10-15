using System;

namespace GaussZeidelMethod
{
    //Метод Гауса - Зейделя для мінімізації функції багатьох змінних
    class Program
    {
        static double F(double u1, double u2)
        {
            //Еталонна функція u* = (1; 1)
            //return 100 * Math.Pow(u2 - u1 * u1, 2) + Math.Pow(1 - u1, 2);

            return 8 * u1 * u1 + 4 * u1 * u2 + 5 * u2 * u2;
        }

        static void Main(string[] args)
        {
            double epselon = 0.00001;
            int m = 2; //розмірність функції

            int[,] e = new int[,]
            {
                { 1, 0 },
                { 0, 1 }
            };

            double[] u = new double[] { 10, 10 };

            for (int k = 0; k < 5000; k++)
            {
                var f = F(u[0], u[1]);
                Console.WriteLine($"k {k}: F({u[0]:f6}, {u[1]:f6}) = {f:f6}");

                for (int j = 0; j < m; j++)
                {
                    Func<double, double> compressedFunc = x => F(u[0] + x * e[j, 0], u[1] + x * e[j, 1]);
                    (var a, var b) = DCKMethod.FindSegment(compressedFunc);
                    var h = DichotomyMethod.FindMinimumArgument(compressedFunc, a, b);

                    u[j] = u[j] + h;
                }

                if (Math.Abs(f - F(u[0], u[1])) < epselon)
                {
                    Console.WriteLine($"k {k}: F({u[0]:f6}, {u[1]:f6}) = {f:f6}");
                    break;
                }
            }
        }
    }
}