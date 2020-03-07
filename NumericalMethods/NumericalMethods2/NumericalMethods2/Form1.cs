using NumericalMethods2.Task1;
using NumericalMethods2.Task2;
using System;
using System.Windows.Forms;

namespace NumericalMethods2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new IntegralCalculation();

            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new GaussianQuadratureFormula();

            form.ShowDialog();
        }
    }
}
