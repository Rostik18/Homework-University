using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TIMS_individual2
{
    class HiQuad
    {
        List<int> Keys;
        List<int> Vals;
        List<double> Probly;
        Dictionary<int, double> HiKrit_Table;
        double X_average;
        int n;
        double HiEmp;
        double HiKrit;
        int df;
        double alfa;

        public HiQuad()
        {
            Keys = new List<int>();
            Vals = new List<int>();
            Probly = new List<double>();
            X_average = 0;
            n = 0;
            HiEmp = 0;
            HiKrit = 0;
            df = 0;
            alfa = 0.05;
            HiKrit_Table = new Dictionary<int, double> { { 1, 3.84 }, { 2, 5.99 }, { 3, 7.81 }, { 4, 9.49 }, { 5, 11.07 },
                { 6, 12.59 }, { 7, 14.07 }, { 8, 15.51 }, { 9, 16.92 }, { 10, 18.31 }, { 11, 19.68 }, { 12, 21.83 }, { 13, 22.36 },
                { 14, 23.68 }, { 15, 25.00 }, { 16, 26.30 }, { 17, 27.59 }, { 18, 28.87 }, { 19, 30.14 }, { 20, 31.41 }, };
        }

        void ReadFile()
        {
            string path = @"C:\Users\Ростик\source\repos\Csharp\TIMS_individual2\TIMS_individual2\File.txt";
            StreamReader file = new StreamReader(path);

            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] lineArr = line.Split(' ');
                Keys.Add(Convert.ToInt32(lineArr[0]));
                Vals.Add(Convert.ToInt32(lineArr[1]));
            }
            n = Vals.Sum();
        }

        void PrintGenStat()
        {
            Console.WriteLine("Генеральна сукупнiсть: ");
            for (int i = 0; i < Keys.Count; i++)
                Console.Write("{0:d3} | ", Keys[i]);
            Console.WriteLine();
            for (int i = 0; i < Keys.Count; i++)
                Console.Write("------");
            Console.WriteLine();
            for (int i = 0; i < Keys.Count; i++)
                Console.Write("{0:d3} | ", Vals[i]);
        }
        void PrintProbly()
        {
            Console.WriteLine("Ймовiрностi: ");
            for (int i = 0; i < Probly.Count; i++)
                Console.Write("{0:f4} | ", Probly[i]);
            Console.WriteLine("\nКонтрольна ймовiрнiсть {0:f3}", Probly.Sum());
        }

        void CalcX_average()
        {
            for (int i = 0; i < Keys.Count; i++)
                X_average += Keys[i] * Vals[i];
            X_average /= n;
            Console.WriteLine("\nСереднє вибiркове {0}", X_average);
        }
        void CalcProbability()
        {
            for (int i = 0; i < Keys.Count; i++)
            {
                int s = Keys[i];
                Probly.Add((Math.Pow(X_average, s) / Fact(s) * Math.Pow(Math.E, -X_average)));   //Ймовірність за Пуассоном.
            }
        }
        int Fact(int number)
        {
            int result = 1;
            if (number == 0)
                return 1;
            while (number != 1)
            {
                result *= number;
                number--;
            }
            return result;
        }
        void N_mult_Probability()
        {
            for (int i = 0; i < Probly.Count; i++)
                Probly[i] *= n;
        }
        void PrintProbly_multByN()
        {
            Console.WriteLine("n * p: ");
            for (int i = 0; i < Probly.Count; i++)
                Console.Write("{0:f3} | ", Probly[i]);
        }
        void CalcHiEmp()
        {
            for (int i = 0; i < Probly.Count; i++)
            {
                HiEmp += Math.Pow(Vals[i] - Probly[i], 2) / Probly[i];
            }
            Console.WriteLine("\nХi^2 emp: {0}", HiEmp);
        }
        void CalcHiKrit()
        {
            List<int> NotInsigVals = Vals;
            NotInsigVals.Sort();

            for (int i = NotInsigVals.Count - 1; i >= 0; i--)
            {
                if (NotInsigVals[i] < 5)
                {
                    NotInsigVals[i - 1] += NotInsigVals[i];
                    NotInsigVals.RemoveAt(i);
                }
            }
            df = NotInsigVals.Count - 2;
            Console.WriteLine("d.f. = {0}", df);

            HiKrit = HiKrit_Table[df];

            Console.WriteLine("\nХi^2 krit: {0}", HiKrit);
        }
        void PrintRezult()
        {
            if (HiEmp < HiKrit)
                Console.WriteLine($"{HiEmp:f3} < {HiKrit:f3}. Дана статистика не суперечить розподiлу за законом Пуассона. \nПохибка 5%.");
            else
                Console.WriteLine($"{HiEmp:f3} > {HiKrit:f3}. Дана статистика суперечить розподiлу за законом Пуассона. \nГiпотеза хибна.");
        }

        public void Run()
        {
            ReadFile();
            PrintGenStat();
            CalcX_average();
            CalcProbability();
            PrintProbly();
            N_mult_Probability();
            PrintProbly_multByN();
            CalcHiEmp();
            CalcHiKrit();
            PrintRezult();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HiQuad hiQuad = new HiQuad();
            hiQuad.Run();

            Console.ReadKey();
        }
    }
}
