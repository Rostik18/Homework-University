using System.IO;
using System.Linq;
using System.Text;
using System;

namespace RecommendationSystem
{
    class Pair : IComparable<Pair>
    {
        public Vector v1, v2;

        public double cosA;

        public Pair(Vector vector1, Vector vector2, double cosA)
        {
            v1 = vector1;
            v2 = vector2;

            this.cosA = cosA;
        }

        public int CompareTo(Pair other)
        {
            return this.cosA.CompareTo(other.cosA);
        }
    }

    struct Vector
    {
        string name;
        public double[] point;

        public Vector(int n, string name)
        {
            this.name = name;
            point = new double[n];
        }

        public double ScalarProduct(Vector vector)
        {
            double product = 0.0;

            for (int i = 0; i < point.Length; i++)
            {
                product += vector.point[i] * point[i];
            }

            return product;
        }

        public double Norm()
        {
            double product = 0.0;

            for (int i = 0; i < point.Length; i++)
            {
                product += point[i] * point[i];
            }

            return Math.Sqrt(product);
        }

        public override string ToString()
        {
            StringBuilder view = new StringBuilder(point.Length * 3 + 7);

            view.Append($"{name} = ({point[0]}");

            for (int i = 1; i < point.Length; i++)
            {
                view.Append($", {point[i]}");
            }
            view.Append(")");

            return view.ToString();
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            for (int i = 0; i < v1.point.Length; i++)
            {
                if (v1.point[i] != v2.point[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int m = 50;

            StreamReader streamReader = new StreamReader(@"C:\Homework-University\MachineLearning\RecommendationSystem\RecommendationSystem\Data.txt");

            string data = streamReader.ReadToEnd();

            string[] splitedDataByLine = data.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            Vector[] t = new Vector[n];

            for (int i = 0; i < n; i++)
            {
                t[i] = new Vector(m, $"t{i + 1}");
            }

            for (int i = 0; i < n; i++)
            {
                string[] splitedLine = splitedDataByLine[i].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var index in splitedLine)
                {
                    t[i].point[Convert.ToInt32(index) - 1] = 1.0;
                }

                Console.WriteLine($"{t[i]}\n");
            }

            //Тут потрібно вибрати свій товар.
            Vector T1 = t[0];

            Console.WriteLine($"My Item:\n{T1}");

            int pairsCount = (n * (n - 1)) / 2;

            Pair[] pairs = new Pair[pairsCount];

            int pairIndex = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (i != j)
                    {
                        double cosA = t[j].ScalarProduct(t[i]) / (t[j].Norm() * t[i].Norm());

                        pairs[pairIndex++] = new Pair(t[j], t[i], cosA);

                        Console.WriteLine($"\nPair {pairIndex:d2}:\n{t[i]}\n{t[j]}\nCosA: {cosA}");
                    }
                }
            }

            var similarItems = pairs.Where(p => p.v2 == T1).Select(p => p).ToList();

            similarItems.Sort();

            Console.WriteLine("\nSimilar to my Item:");

            for (int i = similarItems.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"\nPair {i + 1}:\n{similarItems[i].v2}\n{similarItems[i].v1}\nCosA = {similarItems[i].cosA}");
            }

            Console.ReadKey();
        }
    }
}
