using System;
using System.Text;

namespace QuasiGradientMethods
{
    // Квазіградієнтні методи
    // Квазіградієнтний метод мінімізації слабоопуклої вниз функції
    class Program
    {
        static double F(double x1, double x2) =>
            x1 * x1 + x2 * x2;




        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("*** Квазіградієнтний метод мінімізації слабоопуклої вниз функції ***");
            Console.WriteLine("***                      F = x * x + y * y                       ***");
            Console.WriteLine("***            Підготувала команда ПМа - 41 \"Кицики\"             ***");

            double x1 = 10;
            double x2 = 10;

            double delta = 0.1;
            double ro = 0.5;


            for (int k = 0; k < 1000; k++)
            {

            }

        }
    }
}