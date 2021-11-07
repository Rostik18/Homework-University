using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

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
                vec.X * vec.X,
                vec.Y * vec.Y,
                vec.Z * vec.Z
                );
        }

        // todo: what is operator P?
        private Vector3 P(Vector3 vec)
        {
            return vec;
        }

        // todo: what is Frechet derivative?
        private Matrix F_Frechet(Vector3 vec)
        {
            return new Matrix(3, new double[]
            {

            });
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            logRichTextBox.Text = string.Empty;

            var x0Str = x0TextBox.Text.Split(new[] { '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var x = new Vector3(x0Str.Select(double.Parse).ToArray());

            var I = new Matrix(3);
            I[0, 0] = 1;
            I[1, 1] = 1;
            I[2, 2] = 1;

            for (var i = 0; i < 100; i++)
            {
                var p = P(x);

                var matrixSubtract = I.Subtract(F_Frechet(p));
                var inverseMatrixSubtract = matrixSubtract.CalculateInverse();

                var sub = x.Subtract(F(x));

                var xNext = (Vector3)x.Subtract(inverseMatrixSubtract.Multiply(sub));

                if (Math.Abs(xNext.X - x.X) < epsilon && Math.Abs(xNext.Y - x.Y) < epsilon && Math.Abs(xNext.Z - x.Z) < epsilon)
                {
                    break;
                }

                x = xNext;
            }


        }
    }
}
