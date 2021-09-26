using System;

namespace MethodOfPossibleDirectionsStochasticAnalogue
{
    public class Function2To1
    {
        public string Label { get; set; }
        public Func<double, double, double> F { get; set; }

        public override string ToString() => Label;
    }
}
