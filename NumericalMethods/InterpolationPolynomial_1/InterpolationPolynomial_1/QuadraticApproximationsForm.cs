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
    public partial class QuadraticApproximationsForm : Form
    {
        public QuadraticApproximationsForm()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            CheckIfDataValid(out double[] x, out double[] y);

            int n = x.Length;
            int m = 3;

            double[,] matrix = new double[m, m];
            double[] vector = new double[m];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = RowSumForMatrix(n, x, m + 1 - i - j);
                }

                vector[i] = RowSumForVector(n, y, x, m - 1 - i);
            }

            double[] rez = GaussMethod.Calculate(m, matrix, vector);

            mainChart.Series.Clear();

            int p = 100 * n;
            double[] approximatedFunc = new double[p];
            double[] t = new double[p];
            double h = (x[x.Length - 1] - x[0]) / p;

            for (int i = 0; i < p; i++)
            {
                t[i] = x[0] + i * h;
                approximatedFunc[i] = Polinom(m, rez, t[i]);
            }

            DrawHelper.DrawGraph(mainChart, y, x, n - 1, "points", Color.Green);
            DrawHelper.DrawGraph(mainChart, approximatedFunc, t, p - 1, "approximated", Color.Red);
        }

        private double Polinom(int n, double[] abc, double x)
        {
            double rez = 0;

            for (int i = 0; i < n; i++)
            {
                rez += abc[i] * Math.Pow(x, n - 1 - i);
            }

            return rez;
        }

        private double RowSumForVector(int n, double[] y, double[] x, int xPower)
        {
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += y[i] * Math.Pow(x[i], xPower);
            }

            return sum;
        }

        private double RowSumForMatrix(int n, double[] x, double xPower)
        {
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += Math.Pow(x[i], xPower);
            }

            return sum;
        }

        private void CheckIfDataValid(out double[] x, out double[] y)
        {
            var rows = dataGridView1.Rows;

            x = new double[rows.Count - 1];
            y = new double[rows.Count - 1];

            for (int i = 0; i < rows.Count - 1; i++)
            {
                if (!double.TryParse(rows[i].Cells[0].Value?.ToString(), out x[i]) ||
                    !double.TryParse(rows[i].Cells[1].Value?.ToString(), out y[i]))
                {
                    MessageBox.Show($"Типи не співпадають.\n{i + 1} рядок", "Помилка");
                    return;
                }
            }
        }
    }
}

