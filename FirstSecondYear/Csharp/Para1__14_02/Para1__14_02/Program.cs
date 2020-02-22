using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Para1__14_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Prog1 prog1 = new Prog1();
            Prog2 prog2 = new Prog2();
            Prog3 prog3 = new Prog3();

            prog3.Run();

            Console.ReadKey();
        }
    }
}
