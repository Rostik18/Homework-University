using System;

namespace NumericalZeidel
{
    static class ZeidelMethod
    {
        static int n;
        static int iterationNum = 0;
        static double[,] A;
        static double[] b;
        static double[] xk;
        static double[] xk1;
        static readonly double epselon = 0.001;

        static void ReadData(double[,] Matrix, double[] vector)
        {
            n = vector.Length;
            A = Matrix;
            b = vector;
            xk = new double[n];
            xk1 = new double[n];
        }
        static double SubVektors(double[] _xk, double[] _xk1)
        {
            double rez = _xk[0] - _xk1[0];
            for (int i = 1; i < n; i++)
            {
                if (_xk[i] - _xk1[i] > rez)
                    rez = _xk1[i] - _xk[i];
            }
            return rez;
        }
        static void Zeidel_Iterations()
        {
            for (int i = 0; i < n; i++)
            {
                xk[i] = 1;
            }

            double sub = 2 * epselon;
            while (sub > epselon)
            {
                for (int i = 0; i < n; i++)
                {
                    double d = b[i] / A[i, i];
                    double sum = 0;
                    for (int j = 0; j < n; j++)
                    {
                        double c = -(A[i, j] / A[i, i]);
                        if (i != j)
                        {
                            if (i > j)
                                sum += c * xk1[j];
                            else
                                sum += c * xk[j];
                        }
                    }
                    xk1[i] = sum + d;
                }
                iterationNum++;

                sub = Math.Abs(SubVektors(xk, xk1));
                for (int i = 0; i < n; i++)
                {
                    xk[i] = xk1[i];
                }
            }
        }

        static public void Calculate(double[,] Matrix, double[] vector, out double[] rez, out int iterationsCount)
        {
            ReadData(Matrix, vector);
            Zeidel_Iterations();

            rez = xk1;
            iterationsCount = iterationNum;
        }
    }
}
