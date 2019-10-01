
namespace InterpolationPolynomial_1 {

    class NewtonForm : IPolynomialForm {

        public double CalcPolynomial( int n, double[] x, double[] y, double point ) {

            double[] a = D( n, x, y );

            double p = 0;

            for (int i = 0; i < n; i++) {

                double xProduct = 1;
                for (int j = 0; j < i; j++) {
                    xProduct *= point - x[j];
                }

                p += a[i] * xProduct;
            }

            return p;
        }

        private double[] D( int n, double[] x, double[] y ) {

            double[,] d = new double[n, n];

            for (int i = 0; i < n; i++) {

                d[0, i] = y[i];
            }

            for (int k = 1; k < n; k++) {
                for (int i = 0; i < n - k; i++) {

                    d[k, i] = (d[k - 1, i + 1] - d[k - 1, i]) / (x[i + k] - x[i]);
                }
            }

            double[] rez = new double[n];

            for (int i = 0; i < n; i++) {

                rez[i] = d[i, 0];
            }

            return rez;
        }

        public override string ToString() {

            return "Newton form";
        }
    }
}
