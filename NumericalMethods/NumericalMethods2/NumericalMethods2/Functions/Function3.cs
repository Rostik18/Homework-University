using System;

namespace NumericalMethods2.Functions
{
    class Function3 : IFunсtion
    {
        public double F(double x)
        {
            return Math.Sin(x);
        }

        public double PrimitiveF(double x)
        {
            return -Math.Cos(x);
        }

        public override string ToString()
        {
            return "sin(x)";
        }
    }
}
