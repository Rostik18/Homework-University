using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progresii
{
    class Progression
    {
        protected double a0;
        protected double step;
        protected int n;

        protected Progression(double a0, double step, int n)
        {
            this.a0 = a0;
            this.step = step;
            this.n = n;
        }
    }

    class ArithmeticProgression: Progression
    {
        public ArithmeticProgression(double a0, double step, int n) : base(a0, step, n) { }

        public double N_el()
        {
            return a0 + (n-1) * step;
        }
        public double SumN_el()
        {
            return ((a0 + N_el()) / 2 ) * n;
        }

    }

    class GeometricProgression: Progression
    {
        public GeometricProgression(double a0, double step, int n) : base(a0, step, n) { }

        public double N_el()
        {
            return a0 * Math.Pow(step, n - 1);
        }
        public double SumN_el()
        {
            return (N_el() * step - a0) / step - 1;
        }
    }

    class EndlessGeometricProgression: GeometricProgression
    {
        public EndlessGeometricProgression(double a0, double step, int n) : base(a0, step, n) { }

        public double SumEndless()
        {
            if (step != 0 && step >= 1 && step <= -1)
                throw new Exception("Неiснує суми.");

            return a0 / (1 - step);
        }

    }
}
