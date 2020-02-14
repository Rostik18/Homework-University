using System;

namespace InterpolationPolynomial_1
{

    class Func3 : IFunction
    {

        public double F(double x)
        {
            return x * x * x * x;
        }
    }
}
