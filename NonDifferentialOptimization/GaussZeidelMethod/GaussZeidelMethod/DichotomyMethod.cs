using System;

namespace GaussZeidelMethod
{
    class DichotomyMethod
    {
        const double e = 0.00001;

        public static double FindMinimumArgument(Func<double, double> F, double a, double b)
        {
            var siq = e / 2;
            var c = (a + b) / 2;

            var x1 = (a + b - siq) / 2;
            var x2 = (a + b + siq) / 2;

            if (Math.Abs(b - a) < e)
            {
                return c;
            }
            else if (F(x1) < F(x2))
            {
                return FindMinimumArgument(F, a, x2);
            }
            else
            {
                return FindMinimumArgument(F, x1, b);
            }
        }
    }
}