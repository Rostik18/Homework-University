using System;

namespace NumericalZeidel
{
    static class ZeidelMethod
    {
        static int n;
        static int iterationNum;
        static double[,] A;
        static double[] b;
        static double[] x;
        static double[] p;
        static readonly double epselon = 0.001;

        static void ReadData(double[,] Matrix, double[] vector)
        {
            n = vector.Length;
            A = Matrix;
            b = vector;
            x = new double[n];
            p = new double[n];

            for (int i = 0; i < n; i++)
            {
                x[i] = 1;
            }
        }
        static void Zeidel_Iterations()
        {
            iterationNum = 0;
            while (!Converge(x, p))
            {
                for (int i = 0; i < n; i++)
                {
                    double var = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j != i)
                            var += (A[i, j] * x[j]);
                    }
                    p[i] = x[i];
                    x[i] = (b[i] - var) / A[i, i];
                }

                iterationNum++;
            }

            // Умова завершення
            bool Converge(double[] xk, double[] xkp)
            {
                for (int i = 0; i < n; i++)
                {
                    if (Math.Abs(xk[i] - xkp[i]) > epselon)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        static public void Calculate(double[,] Matrix, double[] vector, out double[] rez, out int iterationsCount)
        {
            ReadData(Matrix, vector);
            Zeidel_Iterations();

            rez = x;
            iterationsCount = iterationNum;
        }
    }
}
