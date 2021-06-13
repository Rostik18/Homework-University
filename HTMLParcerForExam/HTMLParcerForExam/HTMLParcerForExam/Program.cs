using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HTMLParcerForExam
{
    class Program
    {
        const string WritePath = @"C:\Users\rosti\Desktop\HTMLParcerForExam\HTMLParcerForExam\HTMLParcerForExam\UnitedFile.html";
        static string ReadPath = @"C:\Users\rosti\Desktop\Державний іспит\Tasks\{0}.html";
        static int FirstItem = 100;
        static int LastItem = 417;

        static void BeginHTMLDoc(StreamWriter streamWriter)
        {
            try
            {
                streamWriter.Write(
                    "<!DOCTYPE html>\n" +
                    "<html lang=\"en\">\n" +
                    "<head>\n" +
                    "<meta charset=\"utf - 8\">\n" +
                    "<title>UnitedFile</title>\n" +
                    "</head>\n" +
                    "<body>\n\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception on BeginHTMLDoc: " + e.Message);
            }
        }

        static void EndHTMLDoc(StreamWriter streamWriter)
        {
            try
            {
                streamWriter.Write(
                    "\n</body>\n" +
                    "</html>");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception on BeginHTMLDoc: " + e.Message);
            }
        }

        static void ParceFile(int number, StreamWriter streamWriter)
        {
           const string patternFrom1To19 =
                "<div id=\"q{0}\"" +
                @"(.*)" +
                "<div id=\"q{1}\"";

            const string patternFor20 =
                "<div id=\"q20\"" +
                @"(.*)" +
                "<input type=\"hidden\" name=\"sesskey\"";

            const string patternForExectQuestion =
                "<h4 class=\"accesshide\">Текст питання</h4>" +
                @"(.*)" +
                "<div class=\"outcome clearfix";

            const string patternForExectAnswer =
                "<div class=\"rightanswer" +
                @"(.*)" +
                "<div id=\"q";

            const string patternForExectAnswer20 =
                "<div class=\"rightanswer" +
                @"(.*)" +
                "<input type=\"hidden\" name=\"sesskey";

            const string rubbishPatternFroQuestion1 =
                "Відповідь" +
                @"(.*)" +
                "<div class=\"outcome clearfix";

            const string rubbishPatternFroQuestion2 =
                "<h4 class=\"accesshide\">Текст питання</h4>";

            const string rubbishPatternFroAnswer =
                @"(</div>\s*){5}" +
                "<div id=\"q";

            const string rubbishPatternFroAnswer20 =
                @"(</div>\s*){5}" +
                "<input type=\"hidden\" name=\"sesskey";

            try
            {
                StreamReader sr = new StreamReader(string.Format(ReadPath, number));

                streamWriter.Write($"<h1>File number {number}</h1>\n");

                var htmlDoc = sr.ReadToEnd().Replace('\n', ' ');

                for (int question = 1; question <= 19; question++)
                {
                    var fullQuestionPattern = string.Format(patternFrom1To19, question, question + 1);
                    var fullQuestionMatch = Regex.Match(htmlDoc, fullQuestionPattern, RegexOptions.IgnoreCase);

                    var cleanQuestion = Regex.Match(fullQuestionMatch.Value, patternForExectQuestion, RegexOptions.IgnoreCase);
                    var cleanQuestionString = Regex.Replace(cleanQuestion.Value, rubbishPatternFroQuestion1, "</div>");
                    cleanQuestionString = Regex.Replace(cleanQuestionString, rubbishPatternFroQuestion2, "");

                    var cleanAnswer = Regex.Match(fullQuestionMatch.Value, patternForExectAnswer, RegexOptions.IgnoreCase);
                    var cleanAnswerString = Regex.Replace(cleanAnswer.Value, rubbishPatternFroAnswer, "</div>");

                    if (string.IsNullOrWhiteSpace(cleanQuestionString) || string.IsNullOrWhiteSpace(cleanAnswerString))
                        Console.WriteLine($"Error if file {number}, question {question}");

                    streamWriter.Write($"<h3>Питання номер {question}:</h3>");
                    streamWriter.Write(cleanQuestionString);
                    streamWriter.Write(cleanAnswerString);
                    streamWriter.Write("\n");
                }

                var fullQuestion20Match = Regex.Match(htmlDoc, patternFor20, RegexOptions.IgnoreCase);

                var cleanQuestion20 = Regex.Match(fullQuestion20Match.Value, patternForExectQuestion, RegexOptions.IgnoreCase);
                var cleanQuestion20String = Regex.Replace(cleanQuestion20.Value, rubbishPatternFroQuestion1, "</div>");
                cleanQuestion20String = Regex.Replace(cleanQuestion20String, rubbishPatternFroQuestion2, "");

                var cleanAnswer20 = Regex.Match(fullQuestion20Match.Value, patternForExectAnswer20, RegexOptions.IgnoreCase);
                var cleanAnswer20String = Regex.Replace(cleanAnswer20.Value, rubbishPatternFroAnswer20, "</div>");

                if (string.IsNullOrWhiteSpace(cleanQuestion20String) || string.IsNullOrWhiteSpace(cleanAnswer20String))
                    Console.WriteLine($"Error if file {number}, question 20");

                streamWriter.Write($"<h3>Питання номер 20:</h3>");
                streamWriter.Write(cleanQuestion20String);
                streamWriter.Write(cleanAnswer20String);
                streamWriter.Write("\n");
                streamWriter.Write("\n");

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception on ParceFile number {number}: {e.Message}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            StreamWriter streamWriter = new StreamWriter(WritePath, false, Encoding.UTF8);

            BeginHTMLDoc(streamWriter);

            var startTime = DateTimeOffset.Now;

            Console.WriteLine($"Started at {startTime}");

            for (var i = FirstItem; i <= LastItem; i++)
            {
                Console.WriteLine($"Writing file number {i}");

                ParceFile(i, streamWriter);
            }

            var endTime = DateTimeOffset.Now;

            Console.WriteLine($"Finished at {endTime}");
            Console.WriteLine($"It took {endTime - startTime}");

            EndHTMLDoc(streamWriter);

            streamWriter.Close();
        }
    }
}
