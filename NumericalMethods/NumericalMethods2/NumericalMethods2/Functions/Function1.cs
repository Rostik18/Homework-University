﻿
namespace NumericalMethods2.Functions
{
    public class Function1 : IFunсtion
    {
        public double F(double x)
        {
            return x * x;
        }

        public double PrimitiveF(double x)
        {
            return (x * x * x) / 3;
        }

        public override string ToString()
        {
            return "x^2";
        }
    }
}
