using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterpolationPolynomial_1 {

    public partial class TrigonometricPolinomialForm : Form {

        private IFunction _function;

        public TrigonometricPolinomialForm() {

            InitializeComponent();

            funcComboBox.DataSource = new List<IFunction> { new Func1(), new Func2() };
        }

        private void runButton_Click( object sender, EventArgs e ) {

            if (!IsFildsValid()) {
                return;
            }

            int n;

            try {
                n = Convert.ToInt32( nTextBox.Text );
            } catch {
                errorLabel.Text = "Invalid data";
                return;
            }

            double[] y = new double[2 * n];
            double[] t = new double[2 * n];

            double[] a = new double[n + 2];
            double[] b = new double[n + 1];

            for (int j = 0; j < 2 * n; j++) {

                t[j] = (Math.PI * j) / n;
                y[j] = _function.F( t[j] );
            }

            //a[k]
            for (int k = 0; k < n + 1; k++) {

                double sum = 0;

                for (int j = 0; j < 2 * n; j++) {

                    sum += y[j] * Math.Cos( (2 * Math.PI * j * k) / (2 * n + 1) );
                }

                a[k] = (2 * sum) / (2 * n + 1);
            }

            //b[k]
            for (int k = 0; k < n; k++) {

                double sum = 0;

                for (int j = 0; j < 2 * n; j++) {

                    sum += y[j] * Math.Sin( (2 * Math.PI * j * (k + 1)) / (2 * n + 1) );
                }

                b[k] = (2 * sum) / (2 * n + 1);
            }

            double[] q = new double[2 * n];

            for (int i = 0; i < 2 * n; i++) {

                double sum = 0;

                for (int k = 1; k < n; k++) {

                    sum += a[k] * Math.Cos( k * t[i] ) + b[k - 1] * Math.Sin( k * t[i] );
                }

                q[i] = (a[0] * sum) / 2;
            }

            mainChart.Series.Clear();

            DrawHelper.DrawGraph( mainChart, y, t, 2 * n - 1, "accurate", Color.Green );
            DrawHelper.DrawGraph( mainChart, q, t, 2 * n - 1, "trigonometric polynomial", Color.Blue );
        }

        private bool IsFildsValid() {

            errorLabel.Text = "";

            if (String.IsNullOrEmpty( nTextBox.Text ) ||
                _function == null) {

                errorLabel.Text = "Fill all the fields";

                return false;
            }

            return true;
        }

        private void funcComboBox_SelectedIndexChanged( object sender, EventArgs e ) {

            errorLabel.Text = "";

            _function = funcComboBox.SelectedItem as IFunction;
        }

        private void clearChartButton_Click( object sender, EventArgs e ) {

            mainChart.Series.Clear();
        }
    }
}
