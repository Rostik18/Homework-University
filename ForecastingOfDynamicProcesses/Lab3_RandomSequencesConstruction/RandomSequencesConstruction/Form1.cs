using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RandomSequencesConstruction
{
    public partial class Form1 : Form
    {
        private int N = 10000;
        private int Parts = 10;
        private Random Random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            logRichTextBox.Text = "";
            chart.Series.Clear();

            N = int.Parse(nTextBox.Text);
            Parts = int.Parse(partsTextBox.Text);

            double a = 0;
            double b = 1;

            var randomSequence = new List<double>();

            for (int i = 0; i < N; i++)
                randomSequence.Add(Random.NextDouble());

            var histogramData = new List<(double randNumb, int count)>();

            var step = 1.0 / Parts;
            var part = 0.0;
            for (int i = 0; i < Parts; i++)
            {
                var count = randomSequence.Count(x => x >= part && x < (part + step));
                histogramData.Add((part, count));
                part += step;
            }

            DrawChart(histogramData, step);

            //Середнє значення
            var avarage = randomSequence.Average();
            logRichTextBox.Text += $"Середнє: {avarage}\n";

            //Стандартна помилка ??
            var avarageSqure = avarage * avarage;
            var standardDeviation = randomSequence.Sum(x => x * x - avarageSqure) / N;
            logRichTextBox.Text += $"Стандартна помилка: {standardDeviation}\n";

            //Медіана
            var median = randomSequence.OrderBy(x => x).ToArray()[N / 2];
            logRichTextBox.Text += $"Медіана: {median}\n";

            //Мода
            var unical = randomSequence.Distinct();

            if (unical.Count() != randomSequence.Count)
            {
                var numberFrequencyPair = new List<(double randNumb, int freq)>();

                foreach (var item in unical)
                {
                    numberFrequencyPair.Add((item, randomSequence.Count(x => x == item)));
                }
                var moda = numberFrequencyPair.OrderByDescending(x => x.freq).First();
                logRichTextBox.Text += $"Мода: {moda.randNumb} (кількість: {moda.freq})\n";
            }
            else
            {
                logRichTextBox.Text += $"Мода відсутня, всі елементи унікальні\n";
            }

            //Cтандартне відхилення
            var sigma = Math.Sqrt(standardDeviation);
            logRichTextBox.Text += $"Стандартне відхилення: {sigma}\n";

            //Дисперсія вибірки
            logRichTextBox.Text += $"Дисперсія: {standardDeviation}\n";

            //Ексцес
            var u4 = randomSequence.Sum(x => Math.Pow(x - avarage, 4) / N);
            var exes = (u4 / (standardDeviation * standardDeviation)) - 3;
            logRichTextBox.Text += $"Ексцес: {exes}\n";

            //Асиметричність
            var u3 = randomSequence.Sum(x => Math.Pow(x - avarage, 3) / N);
            var asymp = u3 / (standardDeviation * sigma);
            logRichTextBox.Text += $"Асиметричність: {asymp}\n";

            //Інтервал ??
            logRichTextBox.Text += $"Інтервал: {0}\n";

            //Мінімум
            logRichTextBox.Text += $"Мінімум: {randomSequence.Min()}\n";

            //Максимум
            logRichTextBox.Text += $"Максимум: {randomSequence.Max()}\n";

            //Сума
            logRichTextBox.Text += $"Сума: {randomSequence.Sum()}\n";

        }

        private void DrawChart(List<(double randNumb, int count)> histogramData, double interval)
        {
            var series = new Series
            {
                Color = Color.Blue,
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Column
            };

            foreach (var data in histogramData)
            {
                var rangeStartPoint = data.randNumb + (interval / 2);
                series.Points.AddXY(rangeStartPoint, data.count);
            }

            chart.Series.Add(series);
        }
    }
}
