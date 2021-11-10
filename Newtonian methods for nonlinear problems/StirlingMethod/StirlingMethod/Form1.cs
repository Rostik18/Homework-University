using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace StirlingMethod
{
    public partial class Form1 : Form
    {
        private const double epsilon = 0.00001;

        public Form1()
        {
            InitializeComponent();
        }

        private Vector3 F(Vector3 vec)
        {
            return new Vector3(
                vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z,
                vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z,
                vec.X * vec.X + vec.Y * vec.Y + vec.Z * vec.Z
                );
        }

        private Vector3 P(Vector3 vec)
        {
            return vec.Subtract(F(vec)); // x - F(x)
        }

        private Matrix F_Frechet(Vector3 vec)
        {
            return new Matrix(3, new double[]
            {
                2*vec.X,  2*vec.Y,  2*vec.Z,
                2*vec.X,  2*vec.Y,  2*vec.Z,
                2*vec.X,  2*vec.Y,  2*vec.Z
            });
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            logRichTextBox.Text = string.Empty;

            // read start points
            var x0Str = x0TextBox.Text.Split(new[] { '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries); 

            var x = new Vector3(x0Str.Select(double.Parse).ToArray());

            var I = new Matrix(3);
            I[0, 0] = 1;
            I[1, 1] = 1;
            I[2, 2] = 1;

            for (var i = 0; i < 100; i++)
            {
                logRichTextBox.Text += $"{i:D2}: {x}\n";

                var p = P(x);
                var fFrechet = F_Frechet(p);
                var matrixSubtract = I.Subtract(fFrechet);
                var inverseMatrixSubtract = matrixSubtract.CalculateInverse(); // [I - F(P(x))]^-1
                var f = F(x);
                var xSubtractF = x.Subtract(f); // x - F(x)
                var matrixVectorProduct = new Vector3(inverseMatrixSubtract.Multiply(xSubtractF).ToArray()); // [I - F(P(x))]^-1 * x - F(x)

                var xNext = x.Subtract(matrixVectorProduct); // x - [I - F(P(x))]^-1 * x - F(x)

                if (xNext.DistanceTo(x) < epsilon)
                {
                    logRichTextBox.Text += $"{i + 1:D2}: {xNext}\n";
                    break;
                }

                x = xNext;
            }
        }
    }
}
