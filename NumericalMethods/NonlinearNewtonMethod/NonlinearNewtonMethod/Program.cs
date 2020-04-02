using System;

namespace NonlinearNewtonMethod
{
    // Метод Ньютона для розв'язування нелінійних систем з ДВОМА рівняннями.
    class NonlinearNewtonProgram
    {
        const double e = 0.000001;
        GaussProgram gauss = new GaussProgram();

        double[] F(double x, double y)
        {
            return new double[]
            {
                Math.Sin(x+1) - y - 1,
                2*x + Math.Cos(y) - 2
            };
        }

        double[,] JF(double x, double y)
        {
            return new double[,]
            {
                {
                    Math.Cos(x + 1), -1
                },
                {
                    2, -Math.Sin(y)
                }
            };
        }

        public double[] Run(double x0, double y0)
        {
            int iter = 0;

            double x;
            double y;

            while (true)
            {
                var jF = JF(x0, y0);
                var f = F(x0, y0);

                Console.WriteLine($"{iter++}: f({x0:f8} ; {y0:f8}) = ({f[0]:f5} ; {f[1]:f5})");

                var dxy = gauss.Run(2, jF, new double[] { -f[0], -f[1] });

                x = x0 + dxy[0];
                y = y0 + dxy[1];

                if (Math.Max(Math.Abs(-x + x0), Math.Abs(-y + y0)) < e) break;

                x0 = x;
                y0 = y;
            }

            return new double[] { x, y };
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            NonlinearNewtonProgram program = new NonlinearNewtonProgram();

            program.Run(1, 1);
        }
    }
}
