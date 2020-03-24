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

            double c = (a + b) / 2;

            if ((b - a) < e)
            {
                return c;
            }
            else if (F(c - e) < F(c + e))
            {
                return DichotomyMethod(a, c);
            }
            else
            {
                return DichotomyMethod(c, b);
            }
        }

        static double FibonacciMethod(double a, double b)
        {
            CalculateFibonacciNumbers(a, b);

            int n = fibNumbs.Count - 1;

            double x1, x2;

            x1 = a + (b - a) * (fibNumbs[n - 2] / fibNumbs[n]);
            x2 = a + (b - a) * (fibNumbs[n - 1] / fibNumbs[n]);

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
            }

            while (F(x) >= F(x + h))
            {
                x = x + h;
                h = 2 * h;
            }

            a = x - h;
            b = (x + h) - (h / 2);
        }

        static void Main(string[] args)
        {
            DCK(out double a, out double b);

            Console.WriteLine($"Local interval [{a} - {b}]\n");

            Console.WriteLine($"DichotomyMethod: {DichotomyMethod(a, b)}\n");
            Console.WriteLine($"FibonacciMethod: {FibonacciMethod(a, b)}\n");

            Console.ReadKey();
        }
    }
}
