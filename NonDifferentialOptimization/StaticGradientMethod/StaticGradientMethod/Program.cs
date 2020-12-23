using System;

namespace StaticGradientMethod
{
    // Метод локального випадкового пошуку
    // Метод Статичного Градієнта
    class Program
    {
        static double F(double x, double y)
        {
            return x * x + y * y;
        }

        static double[] Df(double x, double y)
        {
            return new double[]
            {
                2 * x,
                2 * y
            };
        }

        static void RunMethod(double x, double y)
        {
            var eps = 0.001;

            double gamma = 0.8;
            var m = 2;
            var ro = eps / 0.7;

            var coordX = 1;
            var coordY = 1;
            var coordNorm = Vector2Norm(new double[] { coordX, coordY });

            var ksi = new double[] { coordX / coordNorm, coordY / coordNorm };

            for (int k = 0; k < 1000; k++)
            {
                var z = new double[] { x + gamma * ksi[0], y + gamma * ksi[1] };
                var delta = F(z[0], z[1]) - F(x, y);

                var g = Vector2MultByVector2(delta, ksi);

                // todo
            }
        }

        static double Vector2Norm(double[] v)
        {
            return Math.Sqrt(v[0] * v[0] + v[1] * v[1]);
        }

        static double Vector2MultByVector2(double[] v1, double[] v2)
        {
            return v1[0] * v2[0] + v1[1] * v2[2];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
