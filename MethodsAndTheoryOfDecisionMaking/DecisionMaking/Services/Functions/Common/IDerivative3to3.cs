
namespace Services.Functions.Common
{
    public interface IDerivative3to3 : IFunction3to1
    {
        double[] D(double x1, double x2, double x3);
    }
}