using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para1__14_02
{
    class Prog1
    {
        public void Run()
        {
            double a = 0, b = 0, h = 0;

            try
            {
                Console.Write("Enter a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter h: ");
                h = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("TypeEror.");
                Console.ReadKey();
                return;
            }

            if (a > b) { Console.WriteLine("a is bigger than b."); return; }

            double dob = 1;

            for (double x = a; x <= b; x += h)
            {
                double y = Math.Tan(x / 2) - 2 * Math.Cos(x);
                Console.WriteLine("{0} = tg({1} / 2) - 2 * cos({1})", y, x);
                if (y > 0)
                {
                    dob *= y * y;
                }
            }
            Console.WriteLine(dob);

            Console.WriteLine("finish prog1.");
            Console.ReadKey();

        }
    }
}
