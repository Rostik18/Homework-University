using Services.Functions.Common;

namespace Services.Functions
{
    public class FXDerivativeble : IDerivative3to3
    {
        public double[] D(double x1, double x2, double x3)
        {
            return new double[]
            {
                2 * x1,
                2 * x2,
                2 * x3
            };
        }

        public double F(double x1, double x2, double x3)
        {
            return x1 * x1 + x2 * x2 + x3 * x3;
        }

        public override string ToString()
        {
            return "x1^2 + x2^2 + x3^2";
        }
    }
}