using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ReliabilityTheory
{
    public partial class TaskTwoForm : Form
    {
        public TaskTwoForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            var file = new StreamReader(@"C:\Homework-University\ReliabilityTheory\ReliabilityTheory\TaskData2.txt");
            string data = file.ReadToEnd();
            file.Close();

            var t_data = data.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            t_data.Sort();
            int n = t_data.Count;

            List<Pair> lifeTimes = new List<Pair>();

            foreach (var item in t_data)
            {
                var numbF = item.Split(new char[] { '-' });
                lifeTimes.Add(new Pair(Convert.ToInt32(numbF[0]), numbF[1]));
            }

            int sCount = lifeTimes.Where(p => p.ForS == "S").Count();
            int fCount = lifeTimes.Where(p => p.ForS == "F").Count();

            //a) Рахуєм сподівані ранги
            double[] J = new double[fCount];
            int indexJ = 0;

            double currentIncrement = 1;

            if (lifeTimes[0].ForS == "F")
            {
                J[indexJ++] = 1;
            }
            for (int i = 1; i < n; i++)
            {
                if (lifeTimes[i - 1].ForS == "S" && lifeTimes[i].ForS == "F")
                {
                    double previousJ;
                    try { previousJ = J[indexJ - 1]; }
                    catch { previousJ = 0; }

                    int notChecketYet = lifeTimes.Where(p => p.lifeTime >= lifeTimes[i].lifeTime).Count();

                    currentIncrement = (n + 1 - previousJ) / (1 + notChecketYet);

                    J[indexJ] = previousJ + currentIncrement;
                    indexJ++;
                }
                else if (lifeTimes[i - 1].ForS == "F" && lifeTimes[i].ForS == "F")
                {
                    J[indexJ] = J[indexJ - 1] + currentIncrement;
                    indexJ++;
                }
            }
            //Порахували

            //b) F(J) - медіанна ф'я розподілу
            double[] F4 = new double[fCount];

            for (int i = 0; i < fCount; i++)
            {
                F4[i] = (J[i] - 0.3) / (n + 0.4);
            }

            //c) намалювати F(J)
            DrawingHelper.DrawGraph(chart1, F4, J, fCount, "F медіанна", Color.Red);
            DrawingHelper.PrintFunction(richTextBox1, F4, J, "F4", "Медіанна функція");

            //d) втрачені спостереження
            double lCount = 12.0;

            double sCoef = 1.0 + lCount / sCount;

            //d) a) Рахуєм сподівані ранги
            double[] lJ = new double[fCount];
            int indexlJ = 0;

            currentIncrement = 1;

            if (lifeTimes[0].ForS == "F")
            {
                lJ[indexlJ++] = 1;
            }
            for (int i = 1; i < n; i++)
            {
                if (lifeTimes[i - 1].ForS == "S" && lifeTimes[i].ForS == "F")
                {
                    double previousJ;
                    try { previousJ = lJ[indexlJ - 1]; }
                    catch { previousJ = 0; }

                    int notChecketYetS = lifeTimes.Where(p => p.lifeTime >= lifeTimes[i].lifeTime && p.ForS == "S").Count();
                    int notChecketYetF = lifeTimes.Where(p => p.lifeTime >= lifeTimes[i].lifeTime && p.ForS == "F").Count();

                    currentIncrement = (n + lCount + 1 - previousJ) / (1 + notChecketYetF + notChecketYetS * sCoef);

                    lJ[indexlJ] = previousJ + currentIncrement;
                    indexlJ++;
                }
                else if (lifeTimes[i - 1].ForS == "F" && lifeTimes[i].ForS == "F")
                {
                    lJ[indexlJ] = lJ[indexlJ - 1] + currentIncrement;
                    indexlJ++;
                }
            }
            //Порахували

            //d) b) F(J) - медіанна ф'я розподілу
            double[] lF4 = new double[fCount];

            for (int i = 0; i < fCount; i++)
            {
                lF4[i] = (lJ[i] - 0.3) / (n + 0.4);
            }

            //d) c) намалювати F(J)
            DrawingHelper.DrawGraph(chart1, lF4, lJ, fCount, "F медіанна з втраченими", Color.Green);
            DrawingHelper.PrintFunction(richTextBox1, lF4, lJ, "F4", "Медіанна функція з втраченими");

            //e) погруповано
            int groupCount = 5;

            Group[] groups = new Group[]
            {
                new Group(lifeTimes.Where(p => p.lifeTime <= 2000 && p.ForS == "F").Count(),
                          lifeTimes.Where(p => p.lifeTime <= 2000 && p.ForS == "S").Count()),

                new Group(lifeTimes.Where(p => p.lifeTime > 2000 && p.lifeTime <= 3000 && p.ForS == "F").Count(),
                          lifeTimes.Where(p => p.lifeTime > 2000 && p.lifeTime <= 3000 && p.ForS == "S").Count()),

                new Group(lifeTimes.Where(p => p.lifeTime > 3000 && p.lifeTime <= 4000 && p.ForS == "F").Count(),
                          lifeTimes.Where(p => p.lifeTime > 3000 && p.lifeTime <= 4000 && p.ForS == "S").Count()),

                new Group(lifeTimes.Where(p => p.lifeTime > 4000 && p.lifeTime <= 5000 && p.ForS == "F").Count(),
                          lifeTimes.Where(p => p.lifeTime > 4000 && p.lifeTime <= 5000 && p.ForS == "S").Count()),

                new Group(lifeTimes.Where(p => p.lifeTime > 5000 && p.ForS == "F").Count(),
                          lifeTimes.Where(p => p.lifeTime > 5000 && p.ForS == "S").Count()),
            };

            //Сподівані ранги
            double[] lambdaS = new double[groupCount];
            double[] rangs = new double[groupCount];

            lambdaS[0] = (n + 1) / (1 + n - groups[0].sCount);
            rangs[0] = groups[0].fCount * lambdaS[0];

            for (int i = 1; i < groupCount; i++)
            {
                int sfCount = 0;
                for (int j = i; j >= 0; j--)
                {
                    sfCount += groups[j].fCount + groups[j].sCount;
                }

                lambdaS[i] = (n + 1 - rangs.Sum()) / (1 + n - sfCount + groups[i].fCount);
                rangs[i] = groups[i].fCount * lambdaS[i] + rangs.Sum();
            }

            //e) b) F(J) - медіанна ф'я розподілу для груп
            double[] gF4 = new double[groupCount];

            for (int i = 0; i < groupCount; i++)
            {
                gF4[i] = (rangs[i] - 0.3) / (n + 0.4);
            }

            //e) c) намалювати F(J) для груп
            DrawingHelper.DrawGraph(chart1, gF4, rangs, groupCount, "F медіанна для груп", Color.Blue);
            DrawingHelper.PrintFunction(richTextBox1, gF4, rangs, "F4", "Медіанна функція для груп");
        }
    }

    class Group
    {
        public int fCount;
        public int sCount;

        public Group(int f, int s)
        {
            fCount = f;
            sCount = s;
        }

        public override string ToString()
        {
            return $"f:{fCount} s:{sCount}";
        }
    }

    class Pair
    {
        public int lifeTime;
        public string ForS;

        public Pair(int l, string f)
        {
            lifeTime = l;
            ForS = f;
        }

        public override string ToString()
        {
            return $"{lifeTime} {ForS}";
        }
    }
}
