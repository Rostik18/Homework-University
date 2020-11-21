using System;
using System.Text;

namespace LocalRandomSearchMethods
{
    //  Методи локального випадкового пошуку
    //Алгоритм локального випадкового пошуку з парною пробою 
    class Program
    {
        static double F(double x, double y) => 4 * x * x + 2 * y * y;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("*** Алгоритм локального випадкового пошуку з парною пробою  ***");
            Console.WriteLine("***             F = 4 * x * x + 2 * y * y -> min            ***");
            Console.WriteLine("***          Підготувала команда ПМа - 41 \"Кицики\"          ***");
            Console.WriteLine();

            double x = 1;
            double y = 1;

            double e = 0.001;

            var gamma = 2.0;
            var ro = e / 0.7;

            var xi = (0.71, 0.71);

            for (int k = 0; k < 10000; k++)
            {
                Console.WriteLine($"k = {k}: F({x:f3};{y:f3}) = {F(x, y)}");

                var fNeg = F(x - gamma * xi.Item1, y - gamma * xi.Item2);
                var fPoz = F(x + gamma * xi.Item1, y + gamma * xi.Item2);

                var h = (xi.Item1 * Math.Sign(fNeg - fPoz),
                         xi.Item2 * Math.Sign(fNeg - fPoz));

                var xNext = x + ro * h.Item1;
                var yNext = y + ro * h.Item2;

                if (Math.Abs(F(x, y) - F(xNext, yNext)) < e)
                    break;

                x = xNext;
                y = yNext;
            }
        }
    }
}