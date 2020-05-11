using System;
using System.Text;

namespace MultiStepMethods
{
    class MultiStepProgram
    {
        readonly int n;

        public MultiStepProgram(int n)
        {
            this.n = n;
        }

        double F(double x, double y)
        {
            return Math.Cos(y - x);
        }

        public double ExectY(double x)
        {
            return x + 2 * Math.Atan(1 / x);
        }

        public void ThirdOrderAdamsMethod(double y0, double y1, double y2, double xZero, double a)
        {
            var h = a / n;

            for (int i = 2; i < n; i++)
            {
                var x2 = xZero + i * h;
                var x1 = xZero + (i - 1) * h;
                var x0 = xZero + (i - 2) * h;

                var y3 = y2 + (h / 12) * (23 * F(x2, y2) - 16 * F(x1, y1) + 5 * F(x0, y0));

                y0 = y1;
                y1 = y2;
                y2 = y3;
            }

            var x = xZero + a;

            Console.WriteLine($"y{n - 1}: {y2}\nepsilon {Math.Abs(y2 - ExectY(x))}\n");
        }

        public double EulerMethod(double x, double y, int N, double h)
        {
            var a = x;

            for (int i = 0; i <= N; i++)
            {
                x = a + i * h;
                y += h * F(x, y);
            }

            return y;
        }

        public double RungeKuttaMethod(double x, double y, int n, double h)
        {
            var a = x;

            for (int i = 0; i <= n; i++)
            {
                x = a + i * h;

                var k1 = F(x, y);
                var k2 = F(x + (h / 2), y + (h / 2) * k1);
                var k3 = F(x + (h / 2), y + (h / 2) * k2);
                var k4 = F(x + h, y + h * k3);

                y += (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
            }

            return y;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var n = 100;
            var program = new MultiStepProgram(n);

            var y0 = 2.57;
            var x0 = 1.0;
            var a = 1.0;

            var h = a / n;

            Console.WriteLine("y обчислені точно");
            var y1 = program.ExectY(x0 + h);
            var y2 = program.ExectY(x0 + 2 * h);
            program.ThirdOrderAdamsMethod(y0, y1, y2, x0, a);

            Console.WriteLine("y обчислені методом Ейлера");
            y1 = program.EulerMethod(x0, y0, 1, h);
            y2 = program.EulerMethod(x0, y0, 2, h);
            program.ThirdOrderAdamsMethod(y0, y1, y2, x0, a);

            Console.WriteLine("y обчислені методом Рунге-Кутта");
            y1 = program.RungeKuttaMethod(x0, y0, 1, h);
            y2 = program.RungeKuttaMethod(x0, y0, 2, h);
            program.ThirdOrderAdamsMethod(y0, y1, y2, x0, a);
        }
    }
}
