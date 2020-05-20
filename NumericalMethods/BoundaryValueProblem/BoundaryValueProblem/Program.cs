using System;

namespace BoundaryValueProblem
{
    class BoundaryValueProgram
    {
        int n = 10;

        double a = 0;
        double b = 1;

        double h;

        double alfa0 = 1;
        double alfa1 = 0;

        double beta0 = 1;
        double beta1 = 1;

        double gama0 = 1;
        double gama1 = 4;

        GaussProgram gauss = new GaussProgram();

        public BoundaryValueProgram() { h = (b - a) / n; }

        double P(double x) { return 2; }
        double Q(double x) { return 3; }
        double F(double x) { return -6 * x * x + 8 * x + 1; }

        double ExectF(double x) { return 2 * x * x + 1; }

        public void ConstantsVariationMethod()
        {
            var (Z, T) = RungeKuttaMethod1(a, 0, 0, h);
            var (Z1, T1) = RungeKuttaMethod2(a, 0, 1, h);
            var (Z2, T2) = RungeKuttaMethod3(a, 1, 0, h);

            var A = new double[,]
            {
                { beta0, alfa0 },
                { alfa1 * Z1 + beta1 * T1, alfa1 * Z2 + beta1 * T2 }
            };
            var bVector = new double[]
            {
                gama0,
                gama1 - alfa1 * Z - beta1 * T
            };

            var c1c2 = gauss.Run(2, A, bVector);

            Console.WriteLine($"c1 = {c1c2[0]}\nc2 = {c1c2[1]}");
            Console.WriteLine($"y({b}) = {Z + c1c2[0] * Z1 + c1c2[1] * Z2}");
            Console.WriteLine($"y*({b}) = {ExectF(b)}");
        }

        double Tstrih(double x, double Z, double T) { return -P(x) * T + Q(x) * Z + F(x); }
        double Zstrih(double x, double Z, double T) { return T; }

        public (double, double) RungeKuttaMethod1(double x, double Z, double T, double h)
        {
            var a = x;

            for (int i = 0; i < n; i++)
            {
                x = a + i * h;

                var k1 = Zstrih(x, Z, T);
                var l1 = Tstrih(x, Z, T);

                var k2 = Zstrih(x + (h / 2), Z + (h / 2) * k1, T + (h / 2) * l1);
                var l2 = Tstrih(x + (h / 2), Z + (h / 2) * k1, T + (h / 2) * l1);

                var k3 = Zstrih(x + (h / 2), Z + (h / 2) * k2, T + (h / 2) * l2);
                var l3 = Tstrih(x + (h / 2), Z + (h / 2) * k2, T + (h / 2) * l2);

                var k4 = Zstrih(x + h, Z + h * k3, T + h * l3);
                var l4 = Tstrih(x + h, Z + h * k3, T + h * l3);

                Z = Z + (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
                T = T + (h / 6) * (l1 + 2 * l2 + 2 * l3 + l4);
            }

            return (Z, T);
        }

        double T1strih(double x, double Z, double T) { return -P(x) * T + Q(x) * Z; }
        double Z1strih(double x, double Z, double T) { return T; }

        public (double, double) RungeKuttaMethod2(double x, double Z, double T, double h)
        {
            var a = x;

            for (int i = 0; i < n; i++)
            {
                x = a + i * h;

                var k1 = Z1strih(x, Z, T);
                var l1 = T1strih(x, Z, T);

                var k2 = Z1strih(x + (h / 2), Z + (h / 2) * k1, T + (h / 2) * l1);
                var l2 = T1strih(x + (h / 2), Z + (h / 2) * k1, T + (h / 2) * l1);

                var k3 = Z1strih(x + (h / 2), Z + (h / 2) * k2, T + (h / 2) * l2);
                var l3 = T1strih(x + (h / 2), Z + (h / 2) * k2, T + (h / 2) * l2);

                var k4 = Z1strih(x + h, Z + h * k3, T + h * l3);
                var l4 = T1strih(x + h, Z + h * k3, T + h * l3);

                Z = Z + (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
                T = T + (h / 6) * (l1 + 2 * l2 + 2 * l3 + l4);
            }

            return (Z, T);
        }
        double T2strih(double x, double Z, double T) { return -P(x) * T + Q(x) * Z; }
        double Z2strih(double x, double Z, double T) { return T; }
        public (double, double) RungeKuttaMethod3(double x, double Z, double T, double h)
        {
            var a = x;

            for (int i = 0; i < n; i++)
            {
                x = a + i * h;

                var k1 = Z2strih(x, Z, T);
                var l1 = T2strih(x, Z, T);

                var k2 = Z2strih(x + (h / 2), Z + (h / 2) * k1, T + (h / 2) * l1);
                var l2 = T2strih(x + (h / 2), Z + (h / 2) * k1, T + (h / 2) * l1);

                var k3 = Z2strih(x + (h / 2), Z + (h / 2) * k2, T + (h / 2) * l2);
                var l3 = T2strih(x + (h / 2), Z + (h / 2) * k2, T + (h / 2) * l2);

                var k4 = Z2strih(x + h, Z + h * k3, T + h * l3);
                var l4 = T2strih(x + h, Z + h * k3, T + h * l3);

                Z = Z + (h / 6) * (k1 + 2 * k2 + 2 * k3 + k4);
                T = T + (h / 6) * (l1 + 2 * l2 + 2 * l3 + l4);
            }

            return (Z, T);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BoundaryValueProgram boundaryValueProgram = new BoundaryValueProgram();

            boundaryValueProgram.ConstantsVariationMethod();
        }
    }
}
