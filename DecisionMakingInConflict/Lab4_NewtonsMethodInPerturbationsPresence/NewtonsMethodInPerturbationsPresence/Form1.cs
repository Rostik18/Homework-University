using System;
using System.Windows.Forms;

namespace NewtonsMethodInPerturbationsPresence
{
    public partial class Form1 : Form
    {
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

            double sigma = 0.01;

            for (int k = 0; k < 100; k++)
            {
                var A = JacobiMatrixForF(x);
                var h = GradientF(x);

                // var xNext = 

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
