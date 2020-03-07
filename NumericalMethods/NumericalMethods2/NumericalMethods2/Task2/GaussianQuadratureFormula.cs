using NumericalMethods2.Functions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NumericalMethods2.Task2
{
    public partial class GaussianQuadratureFormula : Form
    {
        private IFunсtion _func; //підінтегральна функція
        //double e = 0.000001; //епсилон, похибка

        public GaussianQuadratureFormula()
        {
            InitializeComponent();

            Func_ComboBox.DataSource = new List<IFunсtion>() { new Function1(), new Function2(), new Function3() };
        }

        private void button1_Click(object sender, EventArgs eventArgs)
        {
            double a = 0, b = 0;
            int m = 1;

            if (!double.TryParse(a_TextBox.Text, out a) || !double.TryParse(b_TextBox.Text, out b) || !int.TryParse(m_TextBox.Text, out m))
            {
                MessageBox.Show("неправильні дані");
                return;
            }

            double I = _func.PrimitiveF(b) - _func.PrimitiveF(a); // I - точне значення інтегралу

            exactRez_TextBox.Text = I.ToString(); //вивести точний результат

            double h = (b - a) / m;

            int n = 4;

            double[] x = new double[] //вузли
            {
                -0.86113631,
                -0.33998104,
                0.33998104,
                0.86113631
            };

            double[] A = new double[] //ваги
            {
                0.34785485,
                0.65214515,
                0.65214515,
                0.34785485
            };

            double Igauss = 0;

            for (int j = 0; j <= m - 1; j++)
            {
                for (int k = 0; k <= n - 1; k++)
                {
                    Igauss += A[k] * _func.F(a + j * h + (h / 2) + (h * x[k] / 2));
                }
            }
            Igauss *= (h / 2);

            approxRez_TextBox.Text = Igauss.ToString(); //вивести результат інтегрування
            error_TextBox.Text = Math.Abs(Math.Abs(I) - Math.Abs(Igauss)).ToString(); // похибка
        }

        private void Func_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _func = Func_ComboBox.SelectedItem as IFunсtion;
        }
    }
}
