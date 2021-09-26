using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MethodOfPossibleDirectionsStochasticAnalogue
{
    public partial class Form1 : Form
    {
        private const int n = 2;

        private List<Function2To1> _availableFunctions = new List<Function2To1>
        {
            new Function2To1{Label = "x^2 + y^2", F = (double x, double y) => x*x + y*y }
        };

        public Form1()
        {
            InitializeComponent();

            availableFunctionsComboBox.DataSource = _availableFunctions;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var alfa = 1;
            var ro0 = 1 / (n + 1.0);

            var x = (0, 0);

            for (int k = 0; k < 100; k++)
            {
                //  var eps = ;

                //  ro 

                //step 6
                //  x = x + ro * h;
            }

        }

        private Func<double, double, double> GetCurrentFunction() => ((Function2To1)availableFunctionsComboBox.SelectedItem).F;
    }
}
