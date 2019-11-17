using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InterpolationPolynomial_1 {

    public partial class TrigonometricPolinomialForm : Form {

        private IFunction _function;

        public TrigonometricPolinomialForm() {

            InitializeComponent();

            funcComboBox.DataSource = new List<IFunction> { new Func1(), new Func2(), new Func3() };
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

            int m = 500;

            double[] accurateY = new double[m + 1];
            double[] accurateX = new double[m + 1];

            for (int i = 0; i < m + 1; i++) {

                accurateX[i] = i * 2 * Math.PI / m;
                accurateY[i] = _function.F( accurateX[i] );
            }

            double[] y = new double[2 * n + 1];
            double[] t = new double[2 * n + 1];

            double[] a = new double[n + 1];
            double[] b = new double[n];

            for (int j = 0; j < 2 * n + 1; j++) {

                t[j] = (2 * Math.PI * j) / (2 * n + 1);
                y[j] = _function.F( t[j] );
            }

            //a[k]
            for (int k = 0; k < n + 1; k++) {

                double sum = 0;

                for (int j = 0; j < 2 * n + 1; j++) {

                    sum += y[j] * Math.Cos( 2 * Math.PI * j * k / (2 * n + 1) );
                }

                a[k] = (2 * sum) / (2 * n + 1);
            }

            //b[k]
            for (int k = 0; k < n; k++) {

                double sum = 0;

                for (int j = 0; j < 2 * n + 1; j++) {

                    sum += y[j] * Math.Sin( 2 * Math.PI * j * (k + 1) / (2 * n + 1) );
                }

                b[k] = (2 * sum) / (2 * n + 1);
            }

            double[] q = new double[m + 1];

            for (int i = 0; i < m + 1; i++) {

                q[i] = Q( accurateX[i], n, a, b );
            }

            mainChart.Series.Clear();

            DrawHelper.DrawGraph( mainChart, accurateY, accurateX, m, "accurate", Color.Green );
            DrawHelper.DrawGraph( mainChart, q, accurateX, m, "trigonometric", Color.Blue );
        }

        private double Q( double t, int n, double[] _a, double[] _b ) {

            double sum = 0;

            for (int k = 1; k < n + 1; k++) {

                sum += _a[k] * Math.Cos( k * t ) + _b[k - 1] * Math.Sin( k * t );
            }

            return (_a[0] / 2) + sum;
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
