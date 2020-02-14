﻿
namespace InterpolationPolynomial_1 {

    class Func1 : IFunction {

        public double F( double x ) {

            return 1 / (1 + 25 * x * x);
        }

        public override string ToString() {

            return "1 / (1 + 25 * x^2)";
        }
    }
}
