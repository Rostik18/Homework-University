using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para1__14_02
{
    class Prog3
    {
        public void Run()
        {
            int n;
            try
            {
                Console.Write("Size n: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("TypeEror.");
                Console.ReadKey();
                return;
            }

            int[] Arr = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                Arr[i] = random.Next(-5, 5);
                Console.Write(Arr[i] + " ");
            }
            Console.WriteLine();

            int max = Arr[0];
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(Arr[i]) > Math.Abs(max)) max = Arr[i];
            }
            Console.WriteLine("Max el in Abs is; " + max);

            int p1 = 0, p2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (Arr[i] > 0)
                {
                    p1 = i;
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (Arr[i] > 0 && i != p1)
                {
                    p2 = i;
                    break;
                }
            }
            int sum = 0;
            for (int i = p1 + 1; i < p2; i++)
            {
                sum += Arr[i];
            }
            Console.WriteLine("Sum el in range: " + sum);

            int lastP = n - 1;

            for (int i = 0; i <= lastP; i++)
            {
                if (Arr[i] == 0)
                {
                    int tmp = Arr[i];
                    Arr[i] = Arr[lastP];
                    Arr[lastP] = tmp;

                    lastP--;
                }

            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(Arr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("prog2 is finished.");
        }

    }
}
