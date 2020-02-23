using System;

namespace NumericalMethods2.Functions
{
    public class Function2 : IFunсtion
    {
        public double F(double x)
        {
            return 1 / (2 + x);
        }

        public double PrimitiveF(double x)
        {
            return Math.Log(2 + x);
        }

        public override string ToString()
        {
            return "1 / (2 + x)";
        }
    }
}
