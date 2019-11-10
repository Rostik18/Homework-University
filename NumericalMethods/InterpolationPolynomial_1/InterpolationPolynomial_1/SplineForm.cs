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
    public partial class SplineForm : Form
    {
        public SplineForm()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            double a, b, h1, h2;
            int n, p;

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

            p = 100 * n;

            h1 = (b - a) / n;
            h2 = (b - a) / p;

            double[] x = new double[n + 1];
            double[] t = new double[p + 1];

            for (int i = 0; i < n + 1; i++)
            {
                x[i] = a + i * h1;
            }
            for (int i = 0; i < p + 1; i++)
            {
                t[i] = a + i * h2;
            }

            mainChart.Series.Clear();
            chart1.Series.Clear();

            for (int k = 0; k < n + 1; k++)
            {
                var spline = Bk1(x, x[k], h1);
                DrawHelper.DrawGraph(mainChart, spline, x, n, $"B{k},1", Color.FromArgb(10 * k, 128, 128));
            }

            for (int k = 0; k < n + 1; k++)
            {
                var spline = Bk1(t, x[k], h1);
                DrawHelper.DrawGraph(chart1, spline, t, p, $"B{k},1", Color.FromArgb(10 * k, 255, 128));
            }

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

        double[] Bk1(double[] x, double xk, double h)
        {
            double[] rez = new double[x.Length];

            for (int i = 0; i < x.Length; i++)
            {
                rez[i] = B1((x[i] - xk) / h);
            }

            return rez;
        }
    }
}
