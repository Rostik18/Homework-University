using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace EntropyClassifier
{
    enum Colors
    {
        white = 0,
        black = 1
    }

    class ClassifierProgram
    {
        public int N = 20; //кількість кубиків
        public List<Colors> colors = new List<Colors>();

        public void Classifier(int indexL, int indexR)
        {
            int indexM = FindMiddleIndex(indexL, indexR, out double entropy);

            if (entropy <= 0.001)
            {
                return;
            }
            else
            {
                Console.WriteLine($"\nleft {indexL} - {indexM}");
                Classifier(indexL, indexM);

                Console.WriteLine($"\nright {indexM} - {indexR}");
                Classifier(indexM, indexR);
            }
        }

        public int FindMiddleIndex(int indexL, int indexR, out double entropy)
        {
            Dictionary<double, int> entropies = new Dictionary<double, int>();

            List<Colors> left;
            List<Colors> right;

            int wl, bl; // ліві білі, чорні
            int wr, br; // праві білі, чорні

            Console.WriteLine(" x  || nl | ml |  Il   || nr | mr |  Ir   || Ix");

            for (int i = indexL + 1; i < indexR; i++)
            {
                SplitList(i, indexL, indexR, out left, out right);

                wl = left.Where(c => c == Colors.white).Count();
                bl = left.Where(c => c == Colors.black).Count();
                wr = right.Where(c => c == Colors.white).Count();
                br = right.Where(c => c == Colors.black).Count();

                double pw, pb;
                pw = Convert.ToDouble(wl) / (wl + bl);
                pb = Convert.ToDouble(bl) / (wl + bl);
                double Il = -pw * Math.Log2(pw) - pb * Math.Log2(pb);
                if (double.IsNaN(Il)) Il = 0;

                pw = Convert.ToDouble(wr) / (wr + br);
                pb = Convert.ToDouble(br) / (wr + br);
                double Ir = -pw * Math.Log2(pw) - pb * Math.Log2(pb);
                if (double.IsNaN(Ir)) Ir = 0;

                double I = (wl + bl) / Convert.ToDouble(N) * Il +
                           (wr + br) / Convert.ToDouble(N) * Ir;

                Console.WriteLine($" {i:d2} || {wl:d2} | {bl:d2} | {Il:f3} || {wr:d2} | {br:d2} | {Ir:f3} || {I:f3}");

                entropies[I] = i;
            }
            Console.WriteLine($"Middle Index {entropies[entropies.Keys.Min()]}");

            entropy = entropies.Keys.Min();
            return entropies[entropies.Keys.Min()];
        }

        public void SplitList(int indexM, int indexL, int indexR, out List<Colors> left, out List<Colors> right)
        {
            left = new List<Colors>();
            right = new List<Colors>();

            for (int i = indexL; i < indexR; i++)
            {
                if (i < indexM)
                {
                    left.Add(colors[i]);
                }
                else
                {
                    right.Add(colors[i]);
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Homework-University\MachineLearning\EntropyClassifier\EntropyClassifier\data.txt");

            var data = sr.ReadToEnd();
            // 0 - white;   1  - black;
            var strColors = data.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            ClassifierProgram classifier = new ClassifierProgram();

            for (int i = 0; i < strColors.Length; i++)
            {
                if (strColors[i] == "0")
                {
                    classifier.colors.Add(Colors.white);
                }
                else
                {
                    classifier.colors.Add(Colors.black);
                }
            }

            classifier.Classifier(0, classifier.colors.Count);
        }
    }
}
