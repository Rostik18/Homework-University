using System;
using System.IO;
using System.Linq;
using System.Text;

namespace UserBasedRecomendationSystem
{
    class Pair : IComparable<Pair>
    {
        public Vector v1, v2;

        public double r; //коеф Пірсона

        public Pair(Vector vector1, Vector vector2)
        {
            v1 = vector1;
            v2 = vector2;
        }

        public void CalculatePirson()
        {
            int n = 0;  //ксть ненульових пар

            for (int i = 0; i < v1.point.Length; i++)
            {
                if (v1.point[i] * v2.point[i] != 0)
                {
                    n++;
                }
            }
            double[] xVector = new double[n];
            double[] yVector = new double[n];
            int index = 0;
            for (int i = 0; i < v1.point.Length; i++)
            {
                if (v1.point[i] * v2.point[i] != 0)
                {
                    xVector[index] = v1.point[i];
                    yVector[index] = v2.point[i];
                    index++;
                }
            }


            double sumOfXYDifference = SumOfDifferenceTwo(xVector, yVector);
            double sumOfXY = SumOfTwo(xVector, yVector);
            double sumOfX = Sum(xVector);
            double sumOfY = Sum(yVector);
            double sumOfXQuad = QuadSum(xVector);
            double sumOfYQuad = QuadSum(yVector);


            r = (n * sumOfXY - sumOfX * sumOfY) /
                Math.Sqrt((n * sumOfXQuad - Math.Pow(sumOfX, 2)) * (n * sumOfYQuad - Math.Pow(sumOfY, 2)));

            double SumOfDifferenceTwo(double[] x, double[] y)
            {
                double sum = 0;

                for (int i = 0; i < x.Length; i++)
                {
                    sum += x[i] - y[i];
                }

                return sum;
            }
            double Sum(double[] x)
            {
                double sum = 0;

                for (int i = 0; i < x.Length; i++)
                {
                    sum += x[i];
                }

                return sum;
            }
            double SumOfTwo(double[] x, double[] y)
            {
                double sum = 0;

                for (int i = 0; i < x.Length; i++)
                {
                    sum += x[i] * y[i];
                }

                return sum;
            }
            double QuadSum(double[] x)
            {
                return SumOfTwo(x, x);
            }
        }

        public int CompareTo(Pair other)
        {
            return this.r.CompareTo(other.r);
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

        public override string ToString()
        {
            StringBuilder view = new StringBuilder(point.Length * 3 + 7);

            view.Append($"{name} = ({point[0]:f2}");

            for (int i = 1; i < point.Length; i++)
            {
                view.Append($"; {point[i]:f2}");
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
            int n = 10; //кількість користувачівв
            int m = 10; //кількість товарів

            StreamReader streamReader = new StreamReader(@"C:\Homework-University\MachineLearning\UserBasedRecomendationSystem\UserBasedRecomendationSystem\data.txt");

            string data = streamReader.ReadToEnd();

            string[] splitedDataByLine = data.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            Vector[] user = new Vector[n];

            for (int i = 0; i < n; i++)
            {
                user[i] = new Vector(m, $"u{i + 1:d2}");
            }

            for (int i = 0; i < n; i++)
            {
                string[] splitedLine = splitedDataByLine[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < m; j++)
                {
                    user[i].point[j] = Convert.ToDouble(splitedLine[j]);
                }

                Console.WriteLine($"{user[i]}\n");
            }

            //Тут потрібно вибрати свого користувача.
            Vector U1 = user[0];

            Console.WriteLine($"My Item:\n{U1}");

            int pairsCount = (n * (n - 1)) / 2;

            Pair[] pairs = new Pair[pairsCount];

            int pairIndex = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (i != j)
                    {
                        pairs[pairIndex] = new Pair(user[i], user[j]);
                        pairs[pairIndex].CalculatePirson();

                        Console.WriteLine($"\nPair {pairIndex:d2}:\n{user[i]}\n{user[j]}\nr: {pairs[pairIndex].r}");
                        pairIndex++;
                    }
                }
            }

            var similarItems = pairs.Where(p => p.v1 == U1 && p.r > 0.5).Select(p => p).ToList();

            similarItems.Sort();

            Console.WriteLine("\nUsers with similar tastes:");

            for (int i = similarItems.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"\nPair {i + 1}:\n{similarItems[i].v1}\n{similarItems[i].v2}\nr = {similarItems[i].r}");
            }

            for (int i = 0; i < U1.point.Length; i++)
            {
                if (U1.point[i] == 0)
                {
                    double numerator = 0;
                    double rSum = 0;

                    for (int j = 0; j < similarItems.Count; j++)
                    {
                        if (similarItems[j].v2.point[i] != 0)
                        {
                            numerator += similarItems[j].v2.point[i] * similarItems[j].r;
                            rSum += similarItems[j].r;
                        }
                    }

                    U1.point[i] = numerator / rSum;
                }
            }

            Console.WriteLine($"\nThe user is likely to rate:\n{U1}");

            Console.ReadKey();
        }
    }
}
