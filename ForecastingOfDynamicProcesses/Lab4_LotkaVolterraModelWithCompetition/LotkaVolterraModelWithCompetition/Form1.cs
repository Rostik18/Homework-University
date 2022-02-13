using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LotkaVolterraModelWithCompetition
{
    public partial class Form1 : Form
    {
        private double l = 1;
        private double q = 1;
        private double k = 1;
        private double p = 1;
        private double m = 1;
        private double r = 1;

        private const int Ticks = 500;

        public Form1()
        {
            InitializeComponent();

            OnParamsChange(new object(), new EventArgs());
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            logRichTextBox.Text = string.Empty;
            chart1.Series.Clear();

            // initial population x - victims, y - predators
            var x = 30.0;
            var y = 10.0;

            var victimsLine = new List<(int t, double population)>(Ticks);
            var predatorsLine = new List<(int t, double population)>(Ticks);

            victimsLine.Add((0, x));
            predatorsLine.Add((0, y));

            var h = 0.1;
            for (int t = 1; t <= Ticks; t++)
            {
                // Runge - Kutta for system of 2
                var k1 = FVictim(x, y);
                var l1 = FPredator(x, y);

                var k2 = FVictim(x + h / 2 * k1, y + h / 2 * l1);
                var l2 = FPredator(x + h / 2 * k1, y + h / 2 * l1);

                var k3 = FVictim(x + h / 2 * k2, y + h / 2 * l2);
                var l3 = FPredator(x + h / 2 * k2, y + h / 2 * l2);

                var k4 = FVictim(x + h * k3, y + h * l3);
                var l4 = FPredator(x + h * k3, y + h * l3);

                x += (k1 + 2.0 * k2 + 2.0 * k3 + k4) / 6.0 * h;
                y += (l1 + 2.0 * l2 + 2.0 * l3 + l4) / 6.0 * h;

                victimsLine.Add((t, x));
                predatorsLine.Add((t, y));
            }

            try
            {
                DrawLine(victimsLine, "Жертви", Color.Blue);
                DrawLine(predatorsLine, "Хижаки", Color.Red);
            }
            catch
            {
                chart1.Series.Clear();
                logRichTextBox.Text = "Неможливо побудувати модель";
            }
        }

        private void OnParamsChange(object sender, EventArgs e)
        {
            l = double.Parse(lTextBox.Text);
            q = double.Parse(qTextBox.Text);
            k = double.Parse(kTextBox.Text);
            p = double.Parse(pTextBox.Text);
            m = double.Parse(mTextBox.Text);
            r = double.Parse(rTextBox.Text);
        }

        // x - victims current population, y - predators current population
        private (double victimPopulationGrowth, double predatorPopulationGrowth) CalculatePopulation(double x, double y)
        {
            var victimPopulationGrowth = k * x - l * x * x - m * x * y;
            var predatorPopulationGrowth = -p * y - q * y * y + r * x * y;

            return (victimPopulationGrowth, predatorPopulationGrowth);
        }

        // lecture values
        private double FVictim(double x, double y) => (k * x) - (l * x * x) - (m * x * y);
        private double FPredator(double x, double y) => (-p * y) - (q * y * y) + (r * x * y);

        // wiki values 
        //private double FVictim(double x, double y) => (k - m * y) * x;
        //private double FPredator(double x, double y) => (-p + r * x) * y;

        private void DrawLine(List<(int t, double population)> line, string name, Color color)
        {
            var series = new Series
            {
                Color = color,
                Name = name,
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Line
            };

            foreach (var point in line)
            {
                if (double.IsInfinity(point.population) || double.IsNaN(point.population))
                    continue;

                series.Points.AddXY(point.t, point.population);
            }

            chart1.Series.Add(series);

            chart1.Update();
        }
    }
}
