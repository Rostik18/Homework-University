
using Services.Functions.Common;

namespace Services.Functions
{
    public class FXParapola : IFunction
    {
        public double F(double x)
        {
            return 1 * x * x + 5 * x + 0;
        }

        public override string ToString()
        {
            return "x^2 + 5x";
        }
    }
}