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

        //static void DCK()
        //{
        //    double x0 = 0;
        //    double h = 1;

        //    double f0 = F(x0);

        //    double x = x0 + h;
        //    double fx = F(x);

        //    if (fx <= f0)
        //    {
        //        x0 = x;
        //        f1 = fx;
        //    }
        //    x = x0 - h;
        //    fx = F(x);

        //    if (fx <= f0)
        //    {
        //        h = -h;
        //        x1 = x;
        //        f1 = fx;
        //    }

        //    h = h / 2;

        //    x2 = x1 + h;
        //    f2 = F(x2);

        //    if (f2 <= f1)
        //    {
        //        x0 = x1;
        //        f0 = f1;
        //        x1 = x2;
        //        f1 = f2;
        //    }

        //    if (h > 0)
        //    {
        //        a = x0;
        //        b = x2;
        //        fa = f0;
        //        fb = f2;
        //    }
        //    else
        //    {
        //        a = x2;
        //        b = x0;
        //        fa = f2;
        //        fb = f0;
        //    }


        //}

        static void Main(string[] args)
        {
            double a = 0;
            double b = 10;

            Console.WriteLine($"DichotomyMethod: {DichotomyMethod(a, b)}\n");
            Console.WriteLine($"FibonacciMethod: {FibonacciMethod(a, b)}\n");



            Console.ReadKey();
        }
    }
}
