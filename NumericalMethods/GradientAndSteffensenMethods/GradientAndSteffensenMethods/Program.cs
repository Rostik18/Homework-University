using System;

namespace GradientAndSteffensenMethods
{
    class MethodsProgram
    {
        const double e = 0.000001;

        double F(double x1, double x2)
        {
            return x1 * x1 + 2 * x2 * x2 + Math.Pow(Math.E, x1 * x1 + x2 * x2) - x1 + 2 * x2;
        }

        double[] DerivativeF(double x1, double x2)
        {
            return new double[]
            {
                2 * x1 + 2 * x1 * Math.Pow(Math.E, x1 * x1 + x2 * x2) - 1,
                4 * x2 + 2 * x2 * Math.Pow(Math.E, x1 * x1 + x2 * x2) + 2
            };
        }

        public void GradientMethod(double x, double y)
        {
            double a;
            double xk1;
            double yk1;

            Console.WriteLine($"F({x} ; {y}) = {F(x, y)}");

            while (true)
            {
                a = 1;

                while (true)
                {
                    var h = DerivativeF(x, y);

                    xk1 = x - a * h[0];
                    yk1 = y - a * h[1];

                    if (F(xk1, yk1) > F(x, y)) a /= 2;
                    else break;
                }

                Console.WriteLine($"F({xk1} ; {yk1}) = {F(xk1, yk1)}");

                if (Math.Sqrt((xk1 - x) * (xk1 - x) + (yk1 - y) * (yk1 - y)) < e) break;

                x = xk1;
                y = yk1;
            }
        }

        //public void SteffensenMethod(double x, double y)
        //{

        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            MethodsProgram program = new MethodsProgram();

            Console.WriteLine("Gradient method:");
            program.GradientMethod(1, 1);
        }
    }
}
