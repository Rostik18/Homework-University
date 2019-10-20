using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zeidel_Method
{
    class Method
    {
        public int n;
        public double[,] A;
        public double[] b;
        public double[] xk;
        public double[] xk1;
        public double epselon = 0.001;

        public string ChoosePath()
        {
            string path;
            Console.Write("Виберiть файл (1 - 3): ");
            int file = Convert.ToInt32(Console.ReadLine());
            switch (file)
            {
                case 1: path = @"C:\Users\Ростик\source\repos\Csharp\Zeidel_Method\Zeidel_Method\File1.txt"; break;
                case 2: path = @"C:\Users\Ростик\source\repos\Csharp\Zeidel_Method\Zeidel_Method\File2.txt"; break;
                case 3: path = @"C:\Users\Ростик\source\repos\Csharp\Zeidel_Method\Zeidel_Method\File3.txt"; break;
                default:
                    Console.WriteLine("Такого файлу немає. Вибираю перший файл.");
                    path = @"C:\Users\Ростик\source\repos\Csharp\Zeidel_Method\Zeidel_Method\File1.txt";
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
            xk = new double[n];
            xk1 = new double[n];
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
        double SubVektors(double[] _xk, double[] _xk1)
        {
            double rez = _xk[0] - _xk1[0];
            for (int i = 1; i < n; i++)
            {
                if (_xk[i] - _xk1[i] > rez)
                    rez = _xk1[i] - _xk[i];
            }
            return rez;
        }
        void Zeidel_Iterations()
        {
            for (int i = 0; i < n; i++)
            {
                xk[i] = 1;
            }
            int iterationNum = 0;
            double sub = 2 * epselon;
            while (sub > epselon)
            {
                Console.Write($"iтерацiя {++iterationNum}: ");
                for (int i = 0; i < n; i++)
                {
                    double d = b[i] / A[i, i];
                    double sum = 0;
                    for (int j = 0; j < n; j++)
                    {
                        double c = -(A[i, j] / A[i, i]);
                        if (i != j)
                        {
                            if (i > j)
                                sum += c * xk1[j];
                            else
                                sum += c * xk[j];
                        }
                    }
                    xk1[i] = sum + d;
                    Console.Write($"{xk1[i]:f10}" + " ");
                }
                Console.WriteLine();
                sub = Math.Abs(SubVektors(xk, xk1));
                for (int i = 0; i < n; i++)
                {
                    xk[i] = xk1[i];
                }
            }
        }
        public void Run()
        {
            ReadFile(ChoosePath());
            Zeidel_Iterations();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Method method = new Method();
            method.Run();

            Console.ReadKey();
        }
    }
}
