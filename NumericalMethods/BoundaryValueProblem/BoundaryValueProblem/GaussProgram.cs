using System;

namespace BoundaryValueProblem
{
    class GaussProgram
    {
        public int n;
        public double[,] A;
        public double[] b;
        public double[] x;
        public double det_A;
        private static int swapCount;

        public GaussProgram()
        {
            swapCount = 0;
            det_A = 1;
        }

        private void SwapLines(int k)
        {
            int goodLine = k;
            double max = A[k, k];
            for (int i = k; i < n; i++)
            {
                if (A[i, i] != 0 && i != k && Math.Abs(A[i, i]) > Math.Abs(max))
                {
                    max = A[i, i];
                    goodLine = i;
                }
            }
            for (int j = 0; j < n; j++)
            {
                double swap_tmp = A[k, j];
                A[k, j] = A[goodLine, j];
                A[goodLine, j] = swap_tmp;
            }
            double tmp_b = b[k];
            b[k] = b[goodLine];
            b[goodLine] = tmp_b;
            swapCount++;

        }

        public void Method()
        {
            x = new double[n];

            for (int k = 0; k < n - 1; k++)
            {
                if (A[k, k] == 0) SwapLines(k);

                for (int i = k + 1; i < n; i++)
                {
                    double m = -A[i, k] / A[k, k];
                    b[i] = b[i] + m * b[k];
                    for (int j = k + 1; j < n; j++)
                    {
                        A[i, j] = A[i, j] + m * A[k, j];
                    }
                    A[i, k] = 0;
                }
            }
            x[n - 1] = b[n - 1] / A[n - 1, n - 1];
            for (int k = n - 2; k >= 0; k--)
            {
                x[k] = (b[k] - sum(k, x)) / A[k, k];
            }
            //det_A = 1;
            for (int i = 0; i < n; i++)
            {
                det_A *= A[i, i];
            }
            if (swapCount % 2 == 1)
                det_A *= -1;
        }

        private double sum(int k, double[] x)
        {
            double rez = 0;
            for (int j = k + 1; j < n; j++)
            {
                rez += A[k, j] * x[j];
            }
            return rez;
        }

        public double[] Run(int n, double[,] A, double[] b)
        {
            this.n = n;
            this.A = (double[,])A.Clone();
            this.b = (double[])b.Clone();

            Method();

            return x;
        }
    }
}
