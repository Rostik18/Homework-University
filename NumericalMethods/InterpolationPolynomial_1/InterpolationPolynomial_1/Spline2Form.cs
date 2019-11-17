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

            funcComboBox.DataSource = new List<IFunction> { new Func1(), new Func2() };
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
            double[] y = new double[m + 1];
            double[] t = new double[m + 1];

            for (int i = 0; i < n; i++)
            {
                x[i] = a + i * h1;
                alfa[i] = _function.F(x[i]);
            }
            for (int i = 0; i < m; i++)
            {
                t[i] = a + i * h2;
                y[i] = _function.F(t[i]);
            }

            double[] S1 = new double[n + 1];
            double[] S3 = new double[n + 3];

            for (int i = 0; i < n + 1; i++)
            {
                S1[i] = SumForS1(n, alfa, x[i], x, h1);
            }

            

            mainChart.Series.Clear();

            DrawHelper.DrawGraph(mainChart, y, t, m - 2, "Exact", Color.Green);
            DrawHelper.DrawGraph(mainChart, S1, x, n -1, "S1", Color.Indigo);
        }

        double SumForS1(int n, double[] alfa, double x, double[] xi, double h)
        {
            double rez = 0;

            for (int i = 1; i < n + 1; i++)
            {
                rez += alfa[i] * B1((x - xi[i]) / h);
            }

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
            double rez = 1 / 6;

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

        private void funcComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _function = funcComboBox.SelectedItem as IFunction;
        }
    }
}
