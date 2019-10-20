using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progresii
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression arithmetic = new ArithmeticProgression(0, 5, 5);
            Console.WriteLine("Арифметична:");
            Console.WriteLine(arithmetic.N_el());
            Console.WriteLine(arithmetic.SumN_el());

            GeometricProgression geometric = new GeometricProgression(1, 2, 10);
            Console.WriteLine("Геометрична:");
            Console.WriteLine(geometric.N_el());
            Console.WriteLine(geometric.SumN_el());

            EndlessGeometricProgression endless = new EndlessGeometricProgression(5, 0.5, 10);
            Console.WriteLine("Сума нескiнченної:");
            Console.WriteLine(endless.SumEndless());


            Console.ReadKey();
        }
    }
}
