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
            double[,] A;
            double[] b;

            try
            {
                m = Convert.ToInt32(mTextBox.Text);
                n = Convert.ToInt32(nTextBox.Text);

                string[] matrix = matrixRichTextBox.Text.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string[] vector = vectorRichTextBox.Text.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                A = new double[m, n];
                b = new double[m];

                int matrixCounter = 0;
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        A[i, j] = Convert.ToDouble(matrix[matrixCounter++]);
                    }
                    b[i] = Convert.ToDouble(vector[i]);
                }
            }
            catch
            {
                MessageBox.Show("Incorrect input.");
                return;
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
                        AtA[i, j] += At[i, k] * A[k, j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Atb[i] += At[i, j] * b[j];
                }
            }

            ZeidelMethod.Calculate(AtA, Atb, out double[] x, out int iterations);

            //Норма.
            double[] AxMinb = new double[m];

            for (int i = 0; i < m; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    AxMinb[i] += A[i, k] * x[k];
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
                resultTextBox.Text += $"{xi:f4}; ";
            }

            iterationsTextBox.Text = iterations.ToString();
            normaTextBox.Text = $"{norma:f10}";
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

        private void matrixRichTextBox_TextChanged(object sender, EventArgs e)
        {
            matrixRichTextBox.Text = "3,6 1,8 -4,7 \n2,7 -3,6 1,9 \n1,5 4,5 3,3";

            vectorRichTextBox.Text = "3,8 0,4 -1,6";
        }
    }
}
