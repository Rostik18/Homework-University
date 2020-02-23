using NumericalMethods2.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericalMethods2.Task1
{
    public partial class IntegralCalculation : Form
    {

        private IFunсtion _func; //підінтегральна функція
        double e = 0.000001; //епсилон, похибка

        public IntegralCalculation()
        {
            InitializeComponent();

            Func_ComboBox.DataSource = new List<IFunсtion>() { new Function1(), new Function2() };
        }

        private void button1_Click(object sender, EventArgs eventArgs)
        {
            double a = 0, b = 0;

            if (!double.TryParse(a_TextBox.Text, out a) || !double.TryParse(b_TextBox.Text, out b))
            {
                MessageBox.Show("неправильні дані");
                return;
            }

            double I = _func.PrimitiveF(b) - _func.PrimitiveF(a); // I - точне значення інтегралу

            exactRez_TextBox.Text = I.ToString(); //вивести точний результат

            int n = 1;
            double In = Qmh(a, b, n);
            n *= 2;
            double I2n = Qmh(a, b, n); //  наближене значення інтегралу

            while (((I2n - In) / In) > e)
            {
                In = I2n;
                n *= 2;
                I2n = Qmh(a, b, n);
            }

            approxRez_TextBox.Text = I2n.ToString(); //вивести результат інтегрування
            n_TextBox.Text = n.ToString();  //вивести кількість розбиттів
            error_TextBox.Text = (I - I2n).ToString(); // похибка
        }

        private double Qmh(double a, double b, int n)
        {
            double h = (b - a) / n;

            double[] x = new double[n + 1];

            for (int k = 0; k <= n; k++)
            {
                x[k] = a + k * h;
            }

            double Q = 0;

            for (int k = 1; k <= n; k++)
            {
                Q += _func.F((x[k - 1] + x[k]) / 2);
            }
            Q *= h;

            return Q;
        }

        private void Func_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _func = Func_ComboBox.SelectedItem as IFunсtion;
        }
    }
}
