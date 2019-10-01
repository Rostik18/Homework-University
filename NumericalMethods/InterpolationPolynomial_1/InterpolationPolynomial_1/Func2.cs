using System;

namespace InterpolationPolynomial_1 {

    class Func2 : IFunction {

        public double F( double x ) {

            return Math.Log( x + 2 );
        }

        public override string ToString() {

            return "ln( x + 2 )";
        }
    }
}
