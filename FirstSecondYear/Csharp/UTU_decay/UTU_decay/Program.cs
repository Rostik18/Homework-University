using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UTU_decay
{
    class Method
    {
        private int n;
        private double[,] A;
        private double[] b;
        private double[] x;
        private double[] y;
        private double[,] U;

        public void Init()
        {
            x = new double[n];
            y = new double[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = 0;
                y[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    U[i, j] = 0;
                }
            }
        }

        public string ChoosePath()
        {
            string path;
            Console.Write("Виберiть файл (1 - 3): ");
            int file = Convert.ToInt32(Console.ReadLine());
            switch (file)
            {
                case 1: path = @"C:\Users\Ростик\source\repos\UTU_decay\UTU_decay\File1.txt"; break;
                case 2: path = @"C:\Users\Ростик\source\repos\UTU_decay\UTU_decay\File2.txt"; break;
                case 3: path = @"C:\Users\Ростик\source\repos\UTU_decay\UTU_decay\File3.txt"; break;
                case 4: path = @"C:\Users\Ростик\source\repos\UTU_decay\UTU_decay\File4.txt"; break;
                default:
                    Console.WriteLine("Такого файлу немає. Вибираю перший файл.");
                    path = @"C:\Users\Ростик\source\repos\UTU_decay\UTU_decay\File1.txt";
                    break;
            }
            return path;
        }

        public void ReadFile(string path)
        {
            StreamReader file = new StreamReader(path);

            n = Convert.ToInt32(file.ReadLine());
            U = new double[n, n];
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


        private double sumU(int i, int j)
        {
            double rez = 0;
            for (int k = 0; k < i; k++)
            {
                rez += U[k, i] * U[k, j];
            }
            return rez;
        }
        private double sumY(int i)
        {
            double rez = 0;
            for (int k = 0; k < i; k++)
            {
                rez += U[k, i] * y[k];
            }
            return rez;
        }
        private double sumX(int i)
        {
            double rez = 0;
            for (int k = i + 1; k < n; k++)
            {
                rez += U[i, k] * x[k];
            }
            return rez;
        }
        private double sumUq(int i)
        {
            double rez = 0;
            for (int k = 0; k < i; k++)
            {
                rez += U[k, i] * U[k, i];
            }
            return rez;
        }

        public void UTU()
        {
            Init();

            for (int i = 0; i < n; i++)
            {
                U[i, i] = Math.Sqrt(A[i, i] - sumUq(i));
                for (int j = 1; j < n; j++)
                {
                    U[i, j] = (A[i, j] - sumU(i, j)) / U[i, i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                y[i] = (b[i] - sumY(i)) / U[i, i];
            }
            for (int i = n - 1; i >= 0; i--)
            {
                x[i] = (y[i] - sumX(i)) / U[i, i];
            }
        }
        
        private void printRez()
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0:f5} ", x[i]);
            }
        }
        public void Run()
        {
            ReadFile(ChoosePath());
            UTU();
            printRez();

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
