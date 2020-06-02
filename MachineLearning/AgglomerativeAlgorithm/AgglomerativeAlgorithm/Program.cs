using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgglomerativeAlgorithm
{
    class Country
    {
        public string Name { get; set; }
        public double Square { get; set; }
        public double Population { get; set; }

        public Country(string name, double square, double population)
        {
            Name = name;
            Square = square;
            Population = population;
        }
    }

    class EuclideanGroup
    {
        public string CountryGroupOne { get; set; }
        public string CountryGroupTwo { get; set; }
        public double Norm { get; set; }

        public EuclideanGroup(string countryOne, string countryTwo, double norm)
        {
            CountryGroupOne = countryOne;
            CountryGroupTwo = countryTwo;
            Norm = norm;
        }
    }

    static class SupportMethods
    {
        public static void SignsStandardization(List<Country> countries)
        {
            var maxSquare = countries.Select(c => c.Square).Max();
            var minSquare = countries.Select(c => c.Square).Min();

            var maxPopulation = countries.Select(c => c.Population).Max();
            var minPopulation = countries.Select(c => c.Population).Min();

            for (int k = 0; k < countries.Count; k++)
            {
                var square = (countries[k].Square - minSquare) / (maxSquare - minSquare);
                var population = (countries[k].Population - minPopulation) / (maxPopulation - minPopulation);

                countries[k].Square = square;
                countries[k].Population = population;
            }
        }

        public static List<List<EuclideanGroup>> InitializeEuclideanMatrix(List<Country> countries)
        {
            List<List<EuclideanGroup>> euclideanGroups = new List<List<EuclideanGroup>>();

            for (int i = 0; i < countries.Count; i++)
            {
                List<EuclideanGroup> row = new List<EuclideanGroup>();

                for (int j = 0; j < countries.Count; j++)
                {
                    var norm = Math.Sqrt(Math.Pow(countries[i].Square - countries[j].Square, 2) +
                                         Math.Pow(countries[i].Population - countries[j].Population, 2));

                    row.Add(new EuclideanGroup(countries[i].Name, countries[j].Name, norm));
                }
                euclideanGroups.Add(row);
            }

            return euclideanGroups;
        }

        public static List<List<EuclideanGroup>> CalculateEuclideanMatrix(List<List<EuclideanGroup>> matrix)
        {
            int N = matrix[0].Count;

            EuclideanGroup nearestGroup = matrix[0][1];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i][j].Norm < nearestGroup.Norm && i != j)
                    {
                        nearestGroup = matrix[i][j];
                    }
                }
            }

            // переставити стовпці і рядки в матриці
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {

                }
            }



            List<List<EuclideanGroup>> newMatrix = new List<List<EuclideanGroup>>();

            for (int i = 0; i < N; i++)
            {
                List<EuclideanGroup> row = new List<EuclideanGroup>();

                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        row.Add(new EuclideanGroup($"{nearestGroup.CountryGroupOne} {nearestGroup.CountryGroupTwo} ", $"{nearestGroup.CountryGroupOne} {nearestGroup.CountryGroupTwo} ", 0));
                    }
                    else if (nearestGroup.CountryGroupOne == matrix[i][j].CountryGroupOne ||
                             nearestGroup.CountryGroupTwo == matrix[i][j].CountryGroupTwo ||
                             nearestGroup.CountryGroupOne == matrix[i][j].CountryGroupTwo ||
                             nearestGroup.CountryGroupTwo == matrix[i][j].CountryGroupOne)
                    {
                        continue;
                    }
                    else
                    {
                        var norm1 = matrix.Select(list => list.FirstOrDefault(g => g.CountryGroupTwo == nearestGroup.CountryGroupOne)).Select(g => g.Norm).ToArray()[j];
                        var norm2 = matrix.Select(list => list.FirstOrDefault(g => g.CountryGroupTwo == nearestGroup.CountryGroupOne)).Select(g => g.Norm).ToArray()[i];

                        row.Add(new EuclideanGroup($"{nearestGroup.CountryGroupOne} {nearestGroup.CountryGroupTwo} ", matrix[i][j].CountryGroupOne, (norm1 + norm2) / 2));
                    }
                }
                newMatrix.Add(row);
            }


            return null;
        }

        public static void PrintEuclideanMatrix(List<List<EuclideanGroup>> matrix)
        {
            int N = matrix[0].Count;

            Console.Write($"{" ",12} |");
            for (int i = 0; i < N; i++)
            {
                Console.Write($"{matrix[i][0].CountryGroupOne,12} |");
            }
            Console.Write("\n");


            for (int i = 0; i < N; i++)
            {
                Console.Write($"{matrix[0][i].CountryGroupTwo,12} |");

                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matrix[i][j].Norm:f10} |");
                }
                Console.Write("\n");
            }
            Console.WriteLine();

        }

        public static void PrintTable(List<Country> countries)
        {
            Console.WriteLine("    Name     | Square  | Population");
            for (int k = 0; k < countries.Count; k++)
            {
                Console.WriteLine($"{countries[k].Name,12} | {countries[k].Square:f8} | {countries[k].Population:f8}");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Country> countries = new List<Country>
            {
                new Country("Австрія", 83858, 8169929),
                new Country("Албанія", 28748 , 3544841),
                new Country("Бельгія", 30510, 11007020),
                new Country("Білорусь", 207600, 10335382),
                new Country("Болгарія", 110910, 7621337),
                new Country("Боснія і Гер", 51129, 3964388)
            };

            SupportMethods.SignsStandardization(countries);
            SupportMethods.PrintTable(countries);

            var euclideanMatrix = SupportMethods.InitializeEuclideanMatrix(countries);
            SupportMethods.PrintEuclideanMatrix(euclideanMatrix);

           // euclideanMatrix = SupportMethods.CalculateEuclideanMatrix(euclideanMatrix);
           // SupportMethods.PrintEuclideanMatrix(euclideanMatrix);

        }
    }
}
