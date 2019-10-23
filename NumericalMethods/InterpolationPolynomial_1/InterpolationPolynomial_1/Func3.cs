using System;

namespace InterpolationPolynomial_1 {

    class Func3 : IFunction {

        public double F( double x ) {

            return 3 * Math.Sin( x ) + 2 * Math.Cos( x );
        }
    }
}
