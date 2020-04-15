using System;

namespace CauchyProblem
{
    // Розв'язування одновимірних задач Коші.
    class CauchyProgram
    {
        double a, b, h;
        int n;

        double F(double x, double y)
        {
            return Math.Cos(y - x);
        }

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
            Console.WriteLine($"Exact solution y* = {exectY} for x = {x}");

            for (int i = 0; i < 10; i++)
            {
                x = x + i * h;
                y = y + h * F(x, y);
            }

            Console.WriteLine($"Euler method\ny = {y}");
        }

        public void HeineMethod(double x, double y, double h)
        {
            double exectY = x + 2 * Math.Atan(1 / x);
            Console.WriteLine($"Exact solution y* = {exectY} for x = {x}");

            for (int i = 0; i < 10; i++)
            {
                x = x + i * h;

                var _y = y + h * F(x, y);
                y = y + (h / 2) * (F(x, y) + F(x, _y));

            }

            Console.WriteLine($"Heine method\ny = {y}");           
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CauchyProgram cauchyProgram = new CauchyProgram(a: 0, b: 1, n: 10);

            cauchyProgram.EulerMethod(1, 2.57, 0.1);
            cauchyProgram.HeineMethod(1, 2.57, 0.1);
        }
    }
}
