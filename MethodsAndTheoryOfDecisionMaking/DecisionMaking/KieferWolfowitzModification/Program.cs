using System;
using System.Text;

namespace KieferWolfowitzModification
{
    //Модифікація Кіцера Вольфовиця для функції 2х змінних
    class Program
    {
        static double F(double x, double y) => -4 * x * x - 2 * y * y;

        static double GetDelta(double ro) => Math.Sin(ro);

        static (double xNext, double yNext) FindNext(double x, double y, double ro, double delta)
        {
            var z1 = F(x + delta, y);
            var z2 = F(x, y + delta);
            var z3 = F(x - delta, y);
            var z4 = F(x, y - delta);

            var xNext = x + (ro / delta) * (z1 - z3);
            var yNext = y + (ro / delta) * (z2 - z4);

            return (xNext, yNext);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("*** Модифікація Кіцера Вольфовиця для функції 2х змінних ***");
            Console.WriteLine("***          F = -4 * x * x - 2 * y * y  -> max          ***");
            Console.WriteLine("***        Підготувала команда ПМа - 41 \"Кицики\"         ***");
            Console.WriteLine();

            double e = 0.001;
            double x = 10;
            double y = 10;

            for (int k = 0; k < 100; k++)
            {
                var ro = 1.0 / (k + 1.0);
                var delta = GetDelta(ro);

                Console.WriteLine($"k = {k}: F({x:f3};{y:f3}) = {F(x, y)}");

                var (xNext, yNext) = FindNext(x, y, ro, delta);

                if (Math.Abs(F(x, y) - F(xNext, yNext)) < e)
                    break;

                x = xNext;
                y = yNext;
            }

        }
    }
}