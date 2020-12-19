using System;

namespace GradientTypeMethodsWithSpaceStretching
{
    //Методи градієнтного типу з розтягненням простору
    //Метод градієнтного типу з розтягненням простору в напрямку майже градієнта
    class Program
    {
        static readonly double[,] I = new double[,] { { 1, 0 }, { 0, 1 } };
        static double F(double x, double y)
        {
            return x * x + y * y;
        }

        static double[] DF(double x, double y)
        {
            return new double[]
            {
                2 * x,
                2 * y
            };
        }

        static void RunMethod(double[] x)
        {
            var eps = 0.001;

            double gamma = 9.9;

            double[,] B = new double[,] { { 0, 0 }, { 0, 0 } };
            double[,] BT;

            for (int k = 0; k < 500; k++)
            {
                var f = F(x[0], x[1]);

                Console.WriteLine($"{k}: F({x[0]:f6}; {x[1]:f6}) = {f:f6}");

                var h = DF(x[0], x[1]);

                if (k == 0)
                    BT = TransposeMatrix2x2(I);
                else
                    BT = TransposeMatrix2x2(B);

                var g = MultiplyMatrix2x2ByVector(BT, h);

                var gNorm = Vector2Norm(g);
                var ksi = new double[] { g[0] / gNorm, g[1] / gNorm }; // Напрямок розтягнення простору

                var ro = 2 * gamma * f / (gamma + 1) * gNorm;

                var alpha = (gamma + 1) / (gamma - 1);
                var beta = 1 / alpha;

                var bKsi = MultiplyMatrix2x2ByVector(B, ksi);
                var xNext = new double[]
                {
                    x[0] - ro * bKsi[0],
                    x[1] - ro * bKsi[1]
                };

                if (k != 0 && Vector2Norm(new double[] { xNext[0] - x[0], xNext[1] - x[1] }) < eps)
                {
                    Console.WriteLine($"x*: F({x[0]:f8}; {x[1]:f8}) = {f:f8}");
                    break;
                }

                B = Matrix2x2PlusVector(I, new double[] { (beta - 1) * ksi[0], (beta - 1) * ksi[1] });

                x = xNext;
            }
        }

        static double[,] TransposeMatrix2x2(double[,] matrix)
        {
            return new double[,]
            {
                { matrix[0,0], matrix[1,0] },
                { matrix[0,1], matrix[1,1] }
            };
        }

        static double[] MultiplyMatrix2x2ByVector(double[,] m, double[] v)
        {
            return new double[]
            {
                m[0,0] * v[0] + m[0,1] * v[1],
                m[1,0] * v[0] + m[1,1] * v[1]
            };
        }

        static double[,] Matrix2x2PlusVector(double[,] m, double[] v)
        {
            return new double[,]
            {
               { m[0,0] + v[0], m[0,1] + v[1] },
               { m[1,0] + v[0], m[1,1] + v[1] }
            };
        }

        static double Vector2Norm(double[] v)
        {
            return Math.Sqrt(v[0] * v[0] + v[1] * v[1]);
        }

        static void Main(string[] args)
        {
            RunMethod(new double[] { 0.5, 0.5 });
        }
    }
}