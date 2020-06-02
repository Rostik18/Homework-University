using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace SpamClassifier
{
    class Word
    {
        public string word;
        public string spam;

        public Word(string w, string s)
        {
            word = w;
            spam = s;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Байцар Ростислав Пма-31 В-1");

            StreamReader streamReader = new StreamReader(@"C:\Homework-University\MachineLearning\SpamClassifier\SpamClassifier\Spam.txt");
            string spamText = streamReader.ReadToEnd();
            var spamWords = spamText.Split(new char[] { ' ', ',', '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Слова що належать до спаму:");
            foreach (var word in spamWords) Console.Write($"{word} ");
            Console.WriteLine();

            streamReader = new StreamReader(@"C:\Homework-University\MachineLearning\SpamClassifier\SpamClassifier\NotSpam.txt");
            string notSpamText = streamReader.ReadToEnd();
            var notSpamWords = notSpamText.Split(new char[] { ' ', ',', '\n', '\r' }, System.StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Слова що НЕ належать до спаму:");
            foreach (var word in notSpamWords) Console.Write($"{word} ");
            Console.WriteLine();

            var myMessage = new string[]
            {
                "Сталась",  "кумедна", "історія", "з", "вчителем"                  //1
                //"Гарячою", "кавою", "залюбки", "пригостять", "у", "дорозі"         //19
                //"надо", "купить", "сигареты"                                      //тест
                //"Нова", "модель", "телефону", "виправдала", "сподівання"            //11
            };

            Console.WriteLine("Слова у моєму повідомленні:");
            foreach (var word in myMessage) Console.Write($"{word} ");
            Console.WriteLine();

            //перевести всі слова в верхній регістр
            for (int i = 0; i < spamWords.Length; i++)
            {
                spamWords[i] = spamWords[i].ToUpper();
            }
            for (int i = 0; i < notSpamWords.Length; i++)
            {
                notSpamWords[i] = notSpamWords[i].ToUpper();
            }
            for (int i = 0; i < myMessage.Length; i++)
            {
                myMessage[i] = myMessage[i].ToUpper();
            }
            //

            List<string> allWords = new List<string>(spamWords);
            allWords.AddRange(notSpamWords);

            int V = allWords.Distinct().Count(); // кількість слів у словнику.
            Console.WriteLine($"Кількість слів у словнику {V}");

            int D = allWords.Where(w => myMessage.Any(mw => mw == w)).Count(); // як часто слова у моєму повідомленні зустрічаються в словнику
            int Ds = spamWords.Where(w => myMessage.Any(mw => mw == w)).Count(); // як часто слова у моєму повідомленні зустрічаються в спамі
            int Dns = notSpamWords.Where(w => myMessage.Any(mw => mw == w)).Count(); // як часто слова у моєму повідомленні зустрічаються не в спамі
            Console.WriteLine($"як часто слова у моєму повідомленні зустрічаються в словнику {D}");
            Console.WriteLine($"як часто слова у моєму повідомленні зустрічаються в спамі {Ds}");
            Console.WriteLine($"як часто слова у моєму повідомленні зустрічаються не в спамі {Dns}");

            double Hs = Convert.ToDouble(Dns) / D;   // гіпотеза що повідомлення спам
            double Hns = Convert.ToDouble(Ds) / D; // гіпотеза що повідомлення не спам

            double logPs = Math.Log(Hs);
            double logPns = Math.Log(Hns);

            for (int i = 0; i < myMessage.Length; i++)
            {
                int ws = spamWords.Where(w => w == myMessage[i]).Count();
                logPs += Math.Log((ws + 1.0) / (V + spamWords.Length));
            }
            for (int i = 0; i < myMessage.Length; i++)
            {
                int wns = notSpamWords.Where(w => w == myMessage[i]).Count();
                logPns += Math.Log((wns + 1.0) / (V + notSpamWords.Length));
            }

            double Ps = Math.Pow(Math.E, logPs) / (Math.Pow(Math.E, logPs) + Math.Pow(Math.E, logPns));
            double Pns = Math.Pow(Math.E, logPns) / (Math.Pow(Math.E, logPs) + Math.Pow(Math.E, logPns));

            Console.WriteLine($"Probability that the message is spam: {Ps}");
            Console.WriteLine($"Probability that the message is not spam: {Pns}");

            Console.ReadKey();
        }
    }
}
