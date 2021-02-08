using Services.Functions;
using Services.Functions.Common;
using Services.MinimizingOneVariableFunction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ConjugateDirectionsMethod
{
    public partial class Form1 : Form
    {
        private IDerivative3to3 _selectedFunction;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FunctionsComboBox.DataSource = new List<IDerivative3to3> { new FXDerivativeble() };

            _selectedFunction = (IDerivative3to3)FunctionsComboBox.SelectedItem;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            OutputRichTextBox.Text = string.Empty;

            int N = 3;

            double[] x = new double[N];
            double[,] I = new double[,]
            {
                { 1, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 1 }
            };
            double[,] H = (double[,])I.Clone();

            x = StartPointsTextBox.Text.Split(new char[] { ' ', ';' }).Select(Convert.ToDouble).ToArray();

            var h = new double[] { 0, 0, 0 };
            var p = 0.5; //кроковий множник

            var xNext = (double[])x.Clone();

            for (int k = 0; k < 500; k++)
            {
                //крок 2
                var fD = _selectedFunction.D(x[0], x[1], x[2]);
                var fDNext = _selectedFunction.D(xNext[0], xNext[1], xNext[2]);

                x = (double[])xNext.Clone();

                //крок 3
                if (Math.Round(fDNext[0], 5) == 0 && Math.Round(fDNext[1], 5) == 0 && Math.Round(fDNext[2], 5) == 0)
                {
                    OutputRichTextBox.Text += $"x* = ({x[0]}; {x[1]}; {x[2]})";
                    return;
                }

                //крок 4
                if (k != 0)
                {
                    //крок 5
                    if (k % N == 0)
                    {
                        H = (double[,])I.Clone();
                    }
                    //крок 6
                    else
                    {
                        var r = VectorMultiplicationOnScalar(h, p);
                        var g = VectorDifference(fDNext, fD);

                        //крок 7
                        H = CalculateNextMatrix(I, fDNext, fD, h);
                    }
                }

                //крок 8
                h = NegMatrixMultiplication(MatrixTransposition(H, N), fDNext, N);

                //крок 9
                Func<double, double> compressedFunk = arg => _selectedFunction.F(x[0] + arg * h[0], x[1] + arg * h[1], x[2] + arg * h[2]);
                (var a, var b) = DCKMethod.FindSegment(compressedFunk);
                p = DichotomyMethod.FindMinimumArgument(compressedFunk, a, b);

                //крок 10
                xNext = VectorSum(x, VectorMultiplicationOnScalar(h, p));

                OutputRichTextBox.Text += $"k{k} = ({x[0]:f5}; {x[1]:f5}; {x[2]:f5})\n";
            }
        }

        private double[,] CalculateNextMatrix(double[,] I, double[] fDNext, double[] fD, double[] h)
        {
            var M = new double[fD.Length, fD.Length];

            var A = MultiplyMatrix(I, MultiplyVectorsToMatrix(fDNext, h));

            var scalarProduct = ScalarProduct(h, fD);

            for (int i = 0; i < fD.Length; i++)
            {
                for (int j = 0; j < fD.Length; j++)
                {
                    M[i, j] = I[i, j] + A[i, j] / scalarProduct;
                }
            }

            return M;
        }

        private double[,] MultiplyVectorsToMatrix(double[] a, double[] b)
        {
            var A = new double[a.Length, a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    A[i, j] = a[i] * b[j];
                }
            }

            return A;
        }

        private double[,] MultiplyMatrix(double[,] A, double[,] B)
        {
            int rA = A.GetLength(0);
            int cA = A.GetLength(1);
            int rB = B.GetLength(0);
            int cB = B.GetLength(1);
            double temp = 0;
            double[,] kHasil = new double[rA, cB];
            if (cA == rB)
            {
                for (int i = 0; i < rA; i++)
                {
                    for (int j = 0; j < cB; j++)
                    {
                        temp = 0;
                        for (int k = 0; k < cA; k++)
                        {
                            temp += A[i, k] * B[k, j];
                        }
                        kHasil[i, j] = temp;
                    }
                }
            }
            return kHasil;
        }

        private double ScalarProduct(double[] a, double[] b)
        {
            double rez = 0;

            for (int i = 0; i < a.Length; i++)
            {
                rez += a[i] * b[i];
            }

            return rez;
        }

        private double[,] MatrixTransposition(double[,] A, int n)
        {
            var M = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    M[i, j] = A[j, i];
                }
            }

            return M;
        }

        private double[] NegMatrixMultiplication(double[,] A, double[] f, int n)
        {
            var M = new double[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    M[i] += A[i, j] * f[j];
                }
                M[i] = -M[i];
            }

            return M;
        }

        private double[] VectorMultiplicationOnScalar(double[] a, double b)
        {
            var rez = new double[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                rez[i] = a[i] * b;
            }

            return rez;
        }

        private double[] VectorSum(double[] a, double[] b)
        {
            var rez = new double[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                rez[i] = a[i] + b[i];
            }

            return rez;
        }

        private double[] VectorDifference(double[] a, double[] b)
        {
            var rez = new double[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                rez[i] = a[i] - b[i];
            }

            return rez;
        }
    }
}