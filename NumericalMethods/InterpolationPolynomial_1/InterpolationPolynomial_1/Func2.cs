using System;

namespace InterpolationPolynomial_1 {

    class Func2 : IFunction {

        public double F( double x ) {

            return Math.Log( x + 2 );
        }
    }
}
