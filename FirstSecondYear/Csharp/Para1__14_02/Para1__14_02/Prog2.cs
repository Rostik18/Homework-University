using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para1__14_02
{
    class Prog2
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

            int[,] matr = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matr[i, j] = random.Next(-5, 5);
                    Console.Write(matr[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int a = 0, b = 0, c = 0, d = 0;
                    int div = 4;
                    try
                    {
                        a = matr[i - 1, j];
                    }
                    catch (Exception ex)
                    {
                        div--;
                    }
                    try 
                    {
                        b = matr[i, j + 1];
                    }
                    catch (Exception ex)
            {
                        div--;
                    }
                    try
                    {
                        c = matr[i + 1, j];
                    }
                    catch (Exception ex)
                    {
                        div--;
                    }
                    try
                    {
                        d = matr[i, j - 1];
                    }
                    catch (Exception ex)
                    {
                        div--;
                    }
                    if (div == 0) throw  new Exception("divyne is 0 in " + i + "," + j + " iter");
                    matr[i, j] = a + b + c + d / div;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matr[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                try
                {
                    sum += Math.Abs(matr[i + 1, i]);
                }
                catch
                {
                    continue;
                }
            }
            Console.WriteLine("sum in Abs is: " + sum);


                    Console.WriteLine("prog2 is finished.");
            Console.ReadKey();
        }

    }
}
