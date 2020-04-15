using System;

namespace CauchyProblem
{
    class CauchyProgram
    {
        double a, b, h;
        int n;

        double F(double x, double y)
        {
            return Math.Cos(y - x);
        }
        //double F(double x, double y)
        //{
        //    return y + (1 + x) * y * y;
        //}

        public CauchyProgram(double a, double b, int n)
        {
            this.a = a;
            this.b = b;
            this.n = n;
            h = (b - a) / n;
        }

        public void EulerMethod(double x, double y, double h)
        {
            double exectY = x + 2 * Math.Atan(1 / x);

            for (int i = 0; i < 10; i++)
            {
                x = x + i * h;
                y = y + h * F(x, y);
            }

            Console.WriteLine($"Euler method\ny = {y}");
            Console.WriteLine($"Exact solution y* = {exectY}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CauchyProgram cauchyProgram = new CauchyProgram(a: 0, b: 1, n: 10);

            cauchyProgram.EulerMethod(1, 2.57, 0.1);
            //cauchyProgram.EulerMethod(1, -1, 0.1);
        }
    }
}
