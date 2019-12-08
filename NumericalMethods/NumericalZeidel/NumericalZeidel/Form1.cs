using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericalZeidel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int m, n;

            m = Convert.ToInt32(mTextBox.Text);
            n = Convert.ToInt32(nTextBox.Text);

            string[] matrix = matrixRichTextBox.Text.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string[] vector = vectorRichTextBox.Text.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            double[,] A = new double[m, n];
            double[] b = new double[m];

            int matrixCounter = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToInt32(matrix[matrixCounter++]);
                }
                b[i] = Convert.ToInt32(vector[i]);
            }

            double[,] At = TransponateMatrix(A, m, n);

            double[,] AtA = new double[n, n];
            double[] Atb = new double[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < m; k++)
                    {
                        AtA[i, j] += At[i, k] * A[k, i];
                    }
                    Atb[i] += At[i, j] * b[j];
                }
            }

            ZeidelMethod.Calculate(AtA, Atb, out double[] x, out int iterations);

            //Норма.
            double[] AxMinb = new double[n];

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < m; k++)
                {
                    AxMinb[i] += AtA[i, k] * x[k];
                }
                AxMinb[i] -= b[i];
            }

            double norma = 0;
            for (int i = 0; i < n; i++)
            {
                norma += AxMinb[i] * AxMinb[i];
            }
            norma = Math.Sqrt(norma);

            //Запис результатів.
            resultTextBox.Text = string.Empty;
            foreach (var xi in x)
            {
                resultTextBox.Text += $"{xi:f5} ";
            }

            iterationsTextBox.Text = iterations.ToString();
            normaTextBox.Text = norma.ToString();
        }

        private double[,] TransponateMatrix(double[,] A, int m, int n)
        {
            double[,] At = new double[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    At[i, j] = A[j, i];
                }
            }

            return At;
        }
    }
}
