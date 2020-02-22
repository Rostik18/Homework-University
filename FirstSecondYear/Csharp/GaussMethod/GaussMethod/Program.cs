using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GaussMethod
{
    class Methods
    {
        public int n;
        public double[,] A;
        public double[] b;
        public double[] x;
        public double det_A;
        private static int swapCount;

        public Methods()
        {
            swapCount = 0;
            det_A = 1;
        }

        public string ChoosePath()
        {
            string path;
            Console.Write("Виберiть файл (1 - 4): ");
            int file = Convert.ToInt32(Console.ReadLine());
            switch (file)
            {
                case 1: path = @"C:\Users\Ростик\source\repos\GaussMethod\GaussMethod\File1.txt"; break;
                case 2: path = @"C:\Users\Ростик\source\repos\GaussMethod\GaussMethod\File2.txt"; break;
                case 3: path = @"C:\Users\Ростик\source\repos\GaussMethod\GaussMethod\File3.txt"; break;
                case 4: path = @"C:\Users\Ростик\source\repos\Csharp\GaussMethod\GaussMethod\File4.txt"; break;
                default:
                    Console.WriteLine("Такого файлу немає. Вибираю перший файл.");
                    path = @"C:\Users\Ростик\source\repos\GaussMethod\GaussMethod\File1.txt";
                    break;
            }
            return path;
        }
        public void ReadFile(string path)
        {
            StreamReader file = new StreamReader(path);

            n = Convert.ToInt32(file.ReadLine());
            A = new double[n, n];
            b = new double[n];
            string line;
            string[] lineArr;

            for (int i = 0; i < n; i++)
            {
                line = file.ReadLine();
                lineArr = line.Split(' ');

                for (int j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToInt32(lineArr[j]);
                }
            }
            file.ReadLine();
            line = file.ReadLine();
            lineArr = line.Split(' ');
            for (int i = 0; i < n; i++)
                b[i] = Convert.ToInt32(lineArr[i]);
			file.Close();
        }

        public void WriteFile()
        {
            string rezPach = @"C:\Users\Ростик\source\repos\GaussMethod\GaussMethod\Result.txt";
            using (StreamWriter sw = new StreamWriter(rezPach, false, System.Text.Encoding.Default))
            {
                for(int i = 0; i < n; i++)
                {
                    sw.Write(x[i].ToString() + " ");
                }
               // sw.WriteLine(x);
                sw.WriteLine("\nDet A = " + det_A.ToString());
            }
        }


        public void PrintSystem()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] != 0 && j == 0)
                        Console.Write("{0}x{1}", A[i, j], j + 1);
                    else if (A[i, j] == 0 && j == 0)
                        Console.Write("   ");
                    else if (A[i, j] > 0)
                        Console.Write(" +{0}x{1}", A[i, j], j + 1);
                    else if (A[i, j] < 0)
                        Console.Write(" {0}x{1}", A[i, j], j + 1);
                    else
                        Console.Write("     ");
                }
                Console.Write(" = {0}\n", b[i]);
            }
        }
        public void PrintRezult()
        {
            Console.WriteLine();
            if (A[n - 1, n - 1] == 0)
            {
                Console.WriteLine("Коренiв рiвняння немає.");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("x{0}= {1:f3}", i + 1, x[i]);
            }
            Console.WriteLine("Det A = " + det_A.ToString());
        }
        private void SwapLines(int k)
        {
            int goodLine = k;
            double max = A[k, k];
            for (int i = k; i < n; i++)
            {
                if (A[i, i] != 0 && i != k && Math.Abs(A[i,i]) > Math.Abs(max) )
                {
                    max = A[i, i];
                    goodLine = i;
                }
            }
            for (int j = 0; j < n; j++)
            {
                double swap_tmp = A[k, j];
                A[k, j] = A[goodLine, j];
                A[goodLine, j] = swap_tmp;
            }
            double tmp_b = b[k];
            b[k] = b[goodLine];
            b[goodLine] = tmp_b;
            swapCount++;

        }
        
        public void Method()
        {
            x = new double[n];

            for (int k = 0; k < n - 1; k++)
            {
                if (A[k, k] == 0) SwapLines(k);

                for (int i = k + 1; i < n; i++)      
                {
                    double m = -A[i, k] / A[k, k];
                    b[i] = b[i] + m * b[k];
                    for (int j = k + 1; j < n; j++)
                    {
                        A[i, j] = A[i, j] + m * A[k, j];
                    }
                    A[i, k] = 0;
                }
            }
            x[n - 1] = b[n - 1] / A[n - 1, n - 1];
            for (int k = n - 2; k >= 0; k--)
            {
                x[k] = (b[k] - sum(k, x)) / A[k, k];
            }
            //det_A = 1;
            for (int i = 0; i < n; i++)
            {
                det_A *= A[i, i];
            }
            if (swapCount % 2 == 1)
                det_A *= -1;
        }
        private double sum(int k, double[] x)
        {
            double rez = 0;
            for (int j = k + 1; j < n; j++)
            {
                rez += A[k, j] * x[j];
            }
            return rez;
        }
        public void Run()
        {
            string path = ChoosePath();
            ReadFile(path);
            PrintSystem();
            Method();
            PrintRezult();
            WriteFile();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Methods method = new Methods();
            method.Run();

            Console.ReadKey();
        }
    }
}
