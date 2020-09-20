﻿
namespace KieferWolfowitzAlgorithm.Functions
{
    class FXSquare : IFunction
    {
        public double F(double x)
        {
            return -x * x;
        }

        public override string ToString()
        {
            return "x^2";
        }
    }
}
