using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InterpolationPolynomial_1 {

    public partial class Form1 : Form {

        private IPolynomialForm _polynomialForm;
        private IFunction _function;

        public Form1() {

            InitializeComponent();

            funcComboBox.DataSource = new List<IFunction> { new Func1(), new Func2() };
            methodComboBox.DataSource = new List<IPolynomialForm> { new NewtonForm(), new LagrangeForm() };
        }

        private void runButton_Click( object sender, EventArgs e ) {

            if (!IsFildsValid()) {
                return;
            }

            double a, b, faultX, h1, h2;
            int n, m;

            try {
                a = Convert.ToDouble( aTextBox.Text );
                b = Convert.ToDouble( bTextBox.Text );
                faultX = Convert.ToDouble( xTextBox.Text );
                n = Convert.ToInt32( nTextBox.Text );
                m = Convert.ToInt32( mTextBox.Text );
            } catch {
                errorLabel.Text = "Invalid data";
                return;
            }

            h1 = (b - a) / n;
            h2 = (b - a) / m;

            double[] x = new double[n + 1];
            double[] t = new double[m + 1];
            double[] x_ch = new double[n + 1];
            double[] y = new double[n + 1];
            double[] accurate_y = new double[m + 1];
            double[] y_ch = new double[n + 1];

            for (int k = 0; k < n + 1; k++) {

                x[k] = a + k * h1;
                y[k] = _function.F( x[k] );
            }
            for (int k = 0; k < m + 1; k++) {

                t[k] = a + k * h2;
                accurate_y[k] = _function.F( t[k] );
            }
            for (int k = 0; k < n + 1; k++) {

                x_ch[k] = ((a + b) / 2) + ((b - a) / 2) * Math.Cos( ((double)(2 * k + 1) / (double)(2 * (n + 1))) * Math.PI );
                y_ch[k] = _function.F( x_ch[k] );
            }

            double[] p = new double[m + 1];
            double[] p_ch = new double[m + 1];

            for (int k = 0; k < m + 1; k++) {

                p[k] = _polynomialForm.CalcPolynomial( n + 1, x, y, t[k] );
            }
            for (int k = 0; k < m + 1; k++) {

                p_ch[k] = _polynomialForm.CalcPolynomial( n + 1, x_ch, y_ch, t[k] );
            }

            mainChart.Series.Clear();

            DrawHelper.DrawGraph( mainChart, accurate_y, t, m, "accurate", Color.Green );
            DrawHelper.DrawGraph( mainChart, p, t, m, "simple polynomial", Color.Blue );
            DrawHelper.DrawGraph( mainChart, p_ch, t, m, "Chebyshev polynomial", Color.Pink );

            double polynomialError = Math.Abs( _function.F( faultX ) - _polynomialForm.CalcPolynomial( n, x, y, faultX ) );

            funcErrorLabel.Text = String.Format( "Error: \n{0:f13}", polynomialError );
        }

        private bool IsFildsValid() {

            errorLabel.Text = "";

            if (String.IsNullOrEmpty( aTextBox.Text ) ||
                String.IsNullOrEmpty( bTextBox.Text ) ||
                String.IsNullOrEmpty( nTextBox.Text ) ||
                String.IsNullOrEmpty( mTextBox.Text ) ||
                String.IsNullOrEmpty( xTextBox.Text ) ||
                _polynomialForm == null ||
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

        private void methodComboBox_SelectedIndexChanged( object sender, EventArgs e ) {

            errorLabel.Text = "";

            _polynomialForm = methodComboBox.SelectedItem as IPolynomialForm;
        }

        private void clearChartButton_Click( object sender, EventArgs e ) {

            mainChart.Series.Clear();
        }

        private void trigonometricStartButton_Click( object sender, EventArgs e ) {

            var trigonometricPolinomialForm = new TrigonometricPolinomialForm();

            trigonometricPolinomialForm.ShowDialog();
        }

        private void splineStartButton_Click(object sender, EventArgs e)
        {
            SplineForm splineForm = new SplineForm();

            splineForm.ShowDialog();
        }
    }
}
