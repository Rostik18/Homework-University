using System;

namespace TangentMethod
{
    class TangentProgram // метод Нютона (дотичних)
    {
        const double e = 0.000001;

        public double F(double x)
        {
            return x * x + 4 * Math.Sin(x) - 1;
        }

        public double DerivativeF(double x)
        {
            return 2 * x + 4 * Math.Cos(x);
        }

        public double Run(double x0)
        {
            int iterations = 0;

            Console.WriteLine($"{iterations++:d3}: f({x0:f7}) = {F(x0):f4}");

            while (true)
            {
                double x = x0 - (F(x0) / DerivativeF(x0));

                Console.WriteLine($"{iterations++:d3}: f({x:f7}) = {F(x):f4}");

                if (Math.Abs(x - x0) < e) break;

                x0 = x;
            }

            return x0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TangentProgram program = new TangentProgram();

            program.Run(x0: 00);
        }
    }
}
