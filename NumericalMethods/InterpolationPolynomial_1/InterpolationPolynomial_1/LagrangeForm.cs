
namespace InterpolationPolynomial_1 {

    class LagrangeForm : IPolynomialForm {

        public double CalcPolynomial( int n, double[] x, double[] y, double point ) {

            double p = 0;

            for (int i = 0; i < n; i++) {
                p += y[i] * l( point, x, i, n );
            }

            return p;
        }

        private double l( double point, double[] x, int k, int n ) {    // k - Ітерація яку потрібно пропускати.

            double rez = 1;

            for (int i = 0; i < n; i++) {

                if (i != k) {

                    rez *= (point - x[i]) / (x[k] - x[i]);
                }
            }

            return rez;
        }

        public override string ToString() {

            return "Lagrange form";
        }
    }
}
