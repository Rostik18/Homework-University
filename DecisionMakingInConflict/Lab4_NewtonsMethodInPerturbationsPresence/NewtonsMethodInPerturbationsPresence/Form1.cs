using System;
using System.Windows.Forms;

namespace NewtonsMethodInPerturbationsPresence
{
    public partial class Form1 : Form
    {
        const double epselon = 0.000001;
        const int N = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private double F(Vector x) => x[0] * x[0] + x[1] * x[1] * x[1] * x[1] + x[2] * x[2] - 4;

        private Vector GradientF(Vector x) => new Vector(2 * x[0], 4 * x[1] * x[1] * x[1], 2 * x[2]);

        private Matrix JacobiMatrixForF(Vector x) => new Matrix(
            new Vector(2, 0, 0),
            new Vector(0, 12 * x[1] * x[1], 0),
            new Vector(0, 0, 2)
            );

        private void calculateButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text = "";

            if (!TryReadStartPoint(out var x))
                return;

            for (int k = 0; k < 100; k++)
            {
                var h = GradientF(x);
                var A = JacobiMatrixForF(x);

                var xNext = x - h;

                var dif = xNext - x;

                var left = (A * dif) + h;
                var right = dif / dif.Norm();

                double sigma = 1.0 / (k + 1);

                while (Vector.DistanceBetween(left, right) > sigma)
                {
                    h *= 0.5;
                    xNext = x - h;

                    dif = xNext - x;
                    left = (A * dif) + h;
                    right = dif / dif.Norm();
                }

                logTextBox.Text = $"{k:D2} f({x}) = {F(x)}\n";

                if (Vector.DistanceBetween(xNext, x) < epselon)
                {
                    logTextBox.Text = $"{k + 1:D2} f({xNext}) = {F(xNext)}\n";
                    break;
                }

                x = xNext;
            }
        }

        private bool TryReadStartPoint(out Vector startPoint)
        {
            startPoint = new Vector(N);

            var row = startPointTextBox.Text.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            if (row.Length != N)
            {
                logTextBox.Text = "Очікується вектор 3";
                return false;
            }

            for (var i = 0; i < N; i++)
                startPoint[i] = double.Parse(row[i]);

            return true;
        }



    }
}
