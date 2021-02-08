using System;

namespace BroydensMethod
{
    class DCKMethod
    {
        public static (double a, double b) FindSegment(Func<double, double> F)
        {
            double a, b;

            double x = 0;
            double h = 1;

            if (F(x) < F(x + h))
            {
                h = -h;
            };

            while (F(x) >= F(x + h))
            {
                x = x + h;
                h = 2.0 * h;
            }

            var xm1 = x + h;
            var xm2 = x;
            var xm3 = x - h / 2;
            var xm4 = x + h / 2;

            if (F(xm3) > F(xm1))
            {
                a = xm2;
                b = xm1;
            }
            else
            {
                a = xm3;
                b = xm4;
            }

            if (a <= b)
                return (a, b);
            else
                return (b, a);
        }
    }
}