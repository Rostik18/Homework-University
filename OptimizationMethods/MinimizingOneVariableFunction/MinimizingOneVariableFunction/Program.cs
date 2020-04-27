using System;
using System.Collections.Generic;

namespace MinimizingOneVariableFunction
{
    class Program
    {
        const double e = 0.00001;
        static int dichotomyIterationCount = 0;

        static List<double> fibNumbs = new List<double>();

        static void CalculateFibonacciNumbers(double a, double b)
        {
            double lastFib = (b - a) / e;

            fibNumbs.Add(1);
            fibNumbs.Add(1);

            while (!(fibNumbs[fibNumbs.Count - 2] <= lastFib && fibNumbs[fibNumbs.Count - 1] > lastFib))
            {
                fibNumbs.Add(fibNumbs[fibNumbs.Count - 2] + fibNumbs[fibNumbs.Count - 1]);
            }
        }

        static double F(double x)
        {
            return x * Math.Sin(x) + 2 * Math.Cos(x);
        }

        static double DichotomyMethod(double a, double b)
        {
            dichotomyIterationCount++;

            Console.WriteLine($"Iteration {dichotomyIterationCount:d2}: [{a:f3} - {b:f3}]");

            var siq = e / 2;
            var c = (a + b) / 2;

            var x1 = (a + b - siq) / 2;
            var x2 = (a + b + siq) / 2;

            if ((Math.Abs(b - a)) < e)
            {
                return c;
            }
            else if (F(x1) < F(x2))
            {
                return DichotomyMethod(a, x2);
            }
            else
            {
                return DichotomyMethod(x1, b);
            }
        }

        static double FibonacciMethod(double a, double b)
        {
            CalculateFibonacciNumbers(a, b);

            int n = fibNumbs.Count - 1;

            var x1 = a + (b - a) * (fibNumbs[n - 2] / fibNumbs[n]);
            var x2 = a + (b - a) * (fibNumbs[n - 1] / fibNumbs[n]);

            double f1 = F(x1);
            double f2 = F(x2);

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"Iteration {i + 1:d2}: f({x1:f3}) = {f1:f3} | f({x2:f3}) = {f2:f3} : [{a:f3} - {b:f3}]");

                if (f1 > f2)
                {
                    a = x1;
                    x1 = x2;
                    x2 = b - (x1 - a);
                    f1 = f2;
                    f2 = F(x2);
                }
                else
                {
                    b = x2;
                    x2 = x1;
                    x1 = a + (b - x2);
                    f2 = f1;
                    f1 = F(x1);
                }
            }

            return (a + b) / 2;
        }

        static void DCK(out double a, out double b)
        {
            double x = 0;
            double h = 1;

            if (F(x) < F(x + h))
            {
                h = -h;
            };

            while (F(x) >= F(x + h))
            {
                x = x + h;
                h = 2.0 * h;
            }

            var xm1 = x + h;
            var xm2 = x;
            var xm3 = x - h / 2;
            var xm4 = x + h / 2;

            if (F(xm3) > F(xm1))
            {
                a = xm2;
                b = xm1;
            }
            else
            {
                a = xm3;
                b = xm4;
            }
        }

        static void Main(string[] args)
        {
            DCK(out double a, out double b);

            if (a > b)
            {
                double swapTmp = a;
                a = b;
                b = swapTmp;
            }

            Console.WriteLine($"Local interval [{a} - {b}]\n");

            Console.WriteLine($"DichotomyMethod: {DichotomyMethod(a, b)}\n");
            Console.WriteLine($"FibonacciMethod: {FibonacciMethod(a, b)}\n");

            Console.ReadKey();
        }
    }
}
