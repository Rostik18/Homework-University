using System;

namespace Services.Functions
{
    public class FCosine : IFunction
    {
        public double F(double x)
        {
            return Math.Cos(x);
        }

        public override string ToString()
        {
            return "cos(x)";
        }
    }
}