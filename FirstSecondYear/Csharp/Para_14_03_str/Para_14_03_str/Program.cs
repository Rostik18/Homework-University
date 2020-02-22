using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_14_03_str
{
    class Program
    {
        static void Task1()
        {
            Console.WriteLine("Enter sentens: ");
            string text = Console.ReadLine();

            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);



            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].EndsWith("."))
                {
                    for (int j = 0; j < words[i].Length; j++)
                    {
                        if (j == words[i].Length - 2)
                            continue;
                        Console.Write(words[i][j]);
                    }
                }
                else
                {
                    words[i] = words[i].Substring(0, words[i].Length - 1);
                    Console.Write(words[i] + " ");
                }

            }
        }

        static void Task2()
        {
            Console.WriteLine("Enter sentens: ");
            string text = Console.ReadLine();

            string[] words = text.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                bool canPrint = true;
                for (int j = 0; j < words[i].Length; j++)
                {
                    char symbol = words[i][j];
                    int symbolCount = 0;
                    for (int k = 0; k < words[i].Length; k++)
                    {
                        if (symbol == words[i][k])
                            symbolCount++;
                    }
                    if (symbolCount < 2)
                    {
                        canPrint = false;
                        break;
                    }
                }
                if (canPrint)
                {
                    Console.Write(words[i] + " ");
                }
            }


        }
        static void Main(string[] args)
        {
            Human Tom = new Human();

            Tom.About();
            Tom.EducateSun();
            Tom.getMoney();


            Console.ReadKey();
        }
    }
}
