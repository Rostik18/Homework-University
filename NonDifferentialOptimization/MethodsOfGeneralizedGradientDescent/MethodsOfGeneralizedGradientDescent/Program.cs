using System;
using System.Text;

namespace MethodsOfGeneralizedGradientDescent
{
    // Методи узагальненого градієнтного спуску
    // Перший метод із спеціальним вибором крокового множника
    class Program
    {
        const double PI = Math.PI;

        static double F(double x, double y) =>
            x * x + y * y;

        static double[] G(double x, double y) =>
            new double[]
            {
                2 * x,
                2 * y
            };

        static void RunAlgorithm(double x, double y)
        {
            var e = 0.001;
            var fi = Math.PI / 4;

            var beta = CalculateBeta(fi);

            var ro = CalculateRo(fi, x, y);

            for (int k = 0; k < 500; k++)
            {
                Console.WriteLine($"{k}: F({x:f4}; {y:f4}) = {F(x, y):f4}");

                var g = G(x, y);
                var normG = Norma(g);

                double[] h = new double[]
                {
                    - g[0] / normG,
                    - g[1] / normG
                };

                var nextX = x + ro * h[0];
                var nextY = y + ro * h[1];

                if (Norma(new double[] { x - nextX, y - nextY }) < e)
                {
                    Console.WriteLine($"{k}: F({x:f4}; {y:f4}) = {F(x, y):f4}");
                    break;
                }

                x = nextX;
                y = nextY;

                ro *= beta;
            }
        }

        static double CalculateBeta(double fi)
        {
            if (PI / 4 <= fi && fi < PI / 2)
                return Math.Sin(fi);
            if (0 <= fi && fi < PI / 4)
                return 1 / (2 * Math.Cos(fi));
            else
            {
                Console.WriteLine("algorithm error");
                return 0;
            }
        }

        static double CalculateRo(double fi, double x, double y)
        {
            if (PI / 4 <= fi && fi < PI / 2)
                return Norma(new double[] { 0 - x, 0 - y }) * Math.Cos(fi);
            if (0 <= fi && fi < PI / 4)
                return Norma(new double[] { 0 - x, 0 - y }) / (2 * Math.Cos(fi));
            else
            {
                Console.WriteLine("algorithm error");
                return 0;
            }
        }

        static double Norma(double[] x)
        {
            double rez = 0;
            for (int i = 0; i < x.Length; i++)
            {
                rez += x[i] * x[i];
            }
            return Math.Sqrt(rez);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Байцар, ПМа - 41\nЛаб. роб. 3\nМетоди узагальненого градієнтного спуску:\nПерший метод із спеціальним вибором крокового множника\nF = x^2 + y^2");
            RunAlgorithm(1, 1);
        }
    }
}