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

        double ExectY(double x)
        {
            return x + 2 * Math.Atan(1 / x);
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
            var a = x;

            for (int i = 0; i < 10; i++)
            {
                x = a + i * h;
                y = y + h * F(x, y);
            }

            x += h;

            Console.WriteLine($"Euler method\ny = {y}");
            Console.WriteLine($"Exect\ny = {ExectY(x)}");
            Console.WriteLine($"epsilon {Math.Abs(y - ExectY(x))}\n");
        }

        public void HeineMethod(double x, double y, double h)
        {
            var a = x;

            for (int i = 0; i < 10; i++)
            {
                x = a + i * h;

                var _y = y + h * F(x, y);
                y = y + (h / 2) * (F(x, y) + F(x + h, _y));

            }

            x += h;

            Console.WriteLine($"Heine method\ny = {y}");
            Console.WriteLine($"Exect\ny = {ExectY(x)}");
            Console.WriteLine($"epsilon {Math.Abs(y - ExectY(x))}\n");
        }

        public void RungeKuttaMethod(double x, double y, double h)
        {
            var a = x;

            for (int i = 0; i < 10; i++)
            {
                x = a + i * h;

                var k1 = F(x, y);
                var k2 = F(x + (h / 2), y + (h / 2) * k1);
                var k3 = F(x + (h / 2), y + (h / 2) * k2);
                var k4 = F(x + h, y + h * k3);

                y += (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
            }

            x += h;

            Console.WriteLine($"Runge - Kutta method\ny = {y}");
            Console.WriteLine($"Exect\ny = {ExectY(x)}");
            Console.WriteLine($"epsilon {Math.Abs(y - ExectY(x))}\n");
        }
    }

    // Розв'язування систем задач Коші.
    class CauchySystemProgram
    {
        double[] Fg(double x, double y, double z)
        {
            return new double[] {
               (2 * y) + z,
               (3 * y) + (4 * z)
            };
        }

        double[] ExectYz(double x)
        {
            return new double[] {
               Math.Pow(Math.E, 5 * x) - Math.Pow(Math.E, x),
               Math.Pow(Math.E, x) + (3 * Math.Pow(Math.E, 5 * x))
            };
        }

        public void EulerMethod(double x, double y, double z, double h)
        {
            var a = x;

            for (int i = 0; i < 50; i++)
            {
                x = a + i * h;

                var fg = Fg(x, y, z);

                y = y + h * fg[0];
                z = z + h * fg[1];
            }

            //x += h;

            Console.WriteLine($"System Euler method\ny = {y}\nz = {z}");
            Console.WriteLine($"Exect\ny = {ExectYz(x)[0]}\nz = {ExectYz(x)[1]}");
            Console.WriteLine($"epsilon\ny = {Math.Abs(y - ExectYz(x)[0])}\nz = {Math.Abs(z - ExectYz(x)[1])}\n");
        }

        public void HeineMethod(double x, double y, double z, double h)
        {
            var a = x;

            for (int i = 0; i < 50; i++)
            {
                x = a + i * h;

                var fg = Fg(x, y, z);

                var _y = y + h * fg[0];
                var _z = z + h * fg[1];

                var fPlusF = Fg(x, y, z)[0] + Fg(x + h, _y, _z)[0];
                var gPlusG = Fg(x, y, z)[1] + Fg(x + h, _y, _z)[1];

                y = y + (h / 2) * fPlusF;
                z = z + (h / 2) * gPlusG;
            }

            x += h;

            Console.WriteLine($"System Heine method\ny = {y}\nz = {z}");
            Console.WriteLine($"Exect\ny = {ExectYz(x)[0]}\nz = {ExectYz(x)[1]}");
            Console.WriteLine($"epsilon\ny = {Math.Abs(y - ExectYz(x)[0])}\nz = {Math.Abs(z - ExectYz(x)[1])}\n");
        }

        public void RungeKuttaMethod(double x, double y, double z, double h)
        {
            var a = x;

            for (int i = 0; i < 50; i++)
            {
                x = a + (i + 1) * h;

                var k1 = Fg(x, y, z)[0];
                var l1 = Fg(x, y, z)[1];

                var k2 = Fg(x + (h / 2), y + (h / 2) * k1, z + (h / 2) * l1)[0];
                var l2 = Fg(x + (h / 2), y + (h / 2) * k1, z + (h / 2) * l1)[1];

                var k3 = Fg(x + (h / 2), y + (h / 2) * k2, z + (h / 2) * l2)[0];
                var l3 = Fg(x + (h / 2), y + (h / 2) * k2, z + (h / 2) * l2)[1];

                var k4 = Fg(x + h, y + h * k3, z + h * l3)[0];
                var l4 = Fg(x + h, y + h * k3, z + h * l3)[1];

                y = y + (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
                z = z + (h / 6) * (l1 + 2 * l2 + 2 * l3 + l4);
            }

            //x += h;

            Console.WriteLine($"System Runge - Kutta method\ny = {y}\nz = {z}");
            Console.WriteLine($"Exect\ny = {ExectYz(x)[0]}\nz = {ExectYz(x)[1]}");
            Console.WriteLine($"epsilon\ny = {Math.Abs(y - ExectYz(x)[0])}\nz = {Math.Abs(z - ExectYz(x)[1])}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CauchyProgram cauchyProgram = new CauchyProgram(a: 0, b: 1, n: 10);

            cauchyProgram.EulerMethod(1, 2.57, 0.1);
            cauchyProgram.HeineMethod(1, 2.57, 0.1);
            cauchyProgram.RungeKuttaMethod(1, 2.57, 0.1);

            CauchySystemProgram cauchySystemProgram = new CauchySystemProgram();

            cauchySystemProgram.EulerMethod(0, 0, 4, 0.01);
            cauchySystemProgram.HeineMethod(0, 0, 4, 0.01);
            cauchySystemProgram.RungeKuttaMethod(0, 0, 4, 0.01);
        }
    }
}
