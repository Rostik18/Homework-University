using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RandomCoordinateDescent
{
    public partial class Form1 : Form
    {
        private const int N = 3;
        private const double Epsilon = 0.0001;
        private double _gamma = 1;
        private readonly Random _random = new Random();

        private static double F(Vector x) =>
            Math.Pow(x[0], 2) + Math.Pow(x[1], 4) + Math.Pow(x[2], 6);

        private static double[] F_Derivative(Vector x) => new[]
            {
                2 * x[0],
                4 * x[1] * x[1] * x[1],
                6 * x[2] * x[2] * x[2] * x[2] * x[2]
            };

        public Form1()
        {
            InitializeComponent();
        }

        // ZINKO book, page 227
        private void calculateButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text = string.Empty;

            if (!TrySetupGamma())
                return;

            if (!TrySetupLimits(out var a, out var b))
                return;

            // step 1
            if (!TryGetStartPoint(out var x))
                return;

            // step 2
            var eVectors = new List<Vector>(N);
            for (var i = 0; i < N; i++)
            {
                var eVector = new Vector(N) { [i] = 1 };
                eVectors.Add(eVector);
            }

            // step 3
            var k = 0;
            var iRand = _random.Next(0, N);
            while (true)
            {
                // step 4
                iRand = GetNewRandomIndex(iRand);

                // step 5
                var fDer = F_Derivative(x)[iRand];

                // step 6
                var ro = CalculateRo(fDer, x[iRand], a[iRand], b[iRand]);

                logTextBox.Text += $"іт {k++:D3}: F({x}) = {F(x):F4}  | інд {iRand + 1}\n";

                // step 7
                var xNext = x - ro * eVectors[iRand];

                if (Vector.DistanceBetween(xNext, x) < Epsilon || k > 200)
                {
                    logTextBox.Text += $"іт {k++:D3}: F({xNext}) = {F(xNext):F4}  | інд {iRand + 1}\n";
                    break;
                }

                // step 8
                x = xNext;
            }
        }

        private double CalculateRo(double fDer, double x, double a, double b)
        {
            if (fDer >= 0)
                return -Math.Min(x - a, fDer / _gamma);
            else
                return -Math.Min(b - x, Math.Abs(fDer) / _gamma);
        }

        private bool TrySetupLimits(out Vector a, out Vector b)
        {
            a = new Vector(N);
            b = new Vector(N);

            var rowA = aLimitTextBox.Text.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var rowB = bLimitTextBox.Text.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            if (rowA.Length != N || rowB.Length != N)
            {
                logTextBox.Text = "Очікується вектор 3";
                return false;
            }

            for (var i = 0; i < N; i++)
            {
                a[i] = double.Parse(rowA[i]);
                b[i] = double.Parse(rowB[i]);
            }

            return true;
        }

        private bool TryGetStartPoint(out Vector x)
        {
            x = new Vector(N);

            var row = startPointTextBox.Text.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            if (row.Length != N)
            {
                logTextBox.Text = "Очікується вектор 3";
                return false;
            }

            for (var i = 0; i < N; i++)
                x[i] = double.Parse(row[i]);

            return true;
        }

        private int GetNewRandomIndex(int previousIndex)
        {
            var newIndex = _random.Next(0, N);

            while (newIndex == previousIndex)
            {
                newIndex = _random.Next(0, N);
            }

            return newIndex;
        }

        private bool TrySetupGamma()
        {
            if (double.TryParse(gammaTextBox.Text, out _gamma) || !(_gamma < 0))
                return true;

            logTextBox.Text = "Значення gamma не підходить";
            return false;
        }
    }
}
