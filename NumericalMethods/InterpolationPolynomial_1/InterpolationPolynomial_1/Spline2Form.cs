using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterpolationPolynomial_1
{
    public partial class Spline2Form : Form
    {
        private IFunction _function;

        public Spline2Form()
        {
            InitializeComponent();

            _function = new Func3();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            double a, b, h1, h2;
            int n, m;

            try
            {
                a = Convert.ToDouble(aTextBox.Text);
                b = Convert.ToDouble(bTextBox.Text);
                n = Convert.ToInt32(nTextBox.Text);
            }
            catch
            {
                MessageBox.Show("incorrect input.", "Error");
                return;
            }

            m = 100 * n;

            h1 = (b - a) / n;
            h2 = (b - a) / m;

            double[] x = new double[n + 1];
            double[] alfa = new double[n + 1];
            double[] beta = new double[n + 3];
            double[] y = new double[m + 1];
            double[] t = new double[m + 1];

            for (int i = 0; i < n + 1; i++)
            {
                x[i] = a + i * h1;
                alfa[i] = _function.F(x[i]);
            }
            for (int i = 0; i < m + 1; i++)
            {
                t[i] = a + i * h2;
                y[i] = _function.F(t[i]);
            }

            double[] S1 = new double[n + 1];
            double[] S3 = new double[n + 1];

            for (int i = 0; i < n + 1; i++)
            {
                S1[i] = SumForS1(n, alfa, x[i], x, h1);
            }

            //matrix.
            double[,] _A = new double[n + 3, n + 3];
            double[] _b = new double[n + 3];

            _A[0, 0] = -0.5;
            _A[0, 2] = 0.5;
            _A[n + 2, n] = -0.5;
            _A[n + 2, n + 2] = 0.5;
            _b[0] = h1 * 3 * a * a;
            _b[n + 2] = h1 * 3 * b * b;

            for (int i = 1; i < n + 2; i++)
            {
                _A[i, i - 1] = 1 / 6.0;
                _A[i, i] = 2 / 3.0;
                _A[i, i + 1] = 1 / 6.0;
                _b[i] = _function.F(x[i - 1]);
            }

            beta = GaussMethod.Calculate(n + 3, _A, _b);

            for (int i = 0; i < n + 1; i++)
            {
                S3[i] = SumForS3(n, beta, x[i], x, h1);
            }

            mainChart.Series.Clear();

            DrawHelper.DrawGraph(mainChart, y, t, m - 1, "Exact", Color.Green);
            DrawHelper.DrawGraph(mainChart, S1, x, n, "S1", Color.Indigo);
            DrawHelper.DrawGraph(mainChart, S3, x, n, "S3", Color.Red);
        }

        double SumForS1(int n, double[] alfa, double x, double[] xi, double h)
        {
            double rez = 0;

            for (int i = 0; i < n + 1; i++)
            {
                rez += alfa[i] * B1((x - xi[i]) / h);
            }

            return rez;
        }

        double SumForS3(int n, double[] beta, double x, double[] xi, double h)
        {
            double rez = beta[0] * B3((x - (xi[0] - h)) / h);

            for (int i = 0; i <= n; i++)
            {
                rez += beta[i + 1] * B3((x - xi[i]) / h);
            }

            rez += beta[beta.Length - 1] * B3((x - (xi[n] + h)) / h);

            return rez;
        }

        double B1(double x)
        {
            if (Math.Abs(x) <= 1)
            {
                return 1 - Math.Abs(x);
            }
            else
            {
                return 0;
            }
        }

        double[] B1i(double[] x, double xi, double h)
        {
            double[] rez = new double[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                rez[i] = B1((x[i] - xi) / h);
            }

            return rez;
        }

        double B3(double x)
        {
            double rez = 1 / 6.0;

            if (Math.Abs(x) <= 1)
            {
                rez *= Math.Pow(2 - Math.Abs(x), 3) - 4 * Math.Pow(1 - Math.Abs(x), 3);
            }
            else if (1 <= Math.Abs(x) && Math.Abs(x) <= 2)
            {
                rez *= Math.Pow(2 - Math.Abs(x), 3);
            }
            else
            {
                rez = 0;
            }

            return rez;
        }

        double[] B3i(double[] x, double xi, double h)
        {
            double[] rez = new double[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                rez[i] = B3((x[i] - xi) / h);
            }

            return rez;
        }

    }
}
