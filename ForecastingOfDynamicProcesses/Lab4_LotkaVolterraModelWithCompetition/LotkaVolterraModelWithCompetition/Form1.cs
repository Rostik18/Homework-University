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

        private const int Ticks = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            logRichTextBox.Text = string.Empty;
            chart1.Series.Clear();

            // initial population
            var x = 10.0;
            var y = 10.0;

            var victimsLine = new List<(int t, double population)>(Ticks);
            var predatorsLine = new List<(int t, double population)>(Ticks);
            for (int t = 0; t < Ticks; t++)
            {
                var (xGrowth, yGrowth) = CalculatePopulation(x, y);

                x += xGrowth;
                y += yGrowth;

                victimsLine.Add((t, x));
                predatorsLine.Add((t, y));
            }

            DrawLine(victimsLine, "Жертви", Color.Blue);
            DrawLine(predatorsLine, "Хижаки", Color.Red);
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

        private void DrawLine(List<(int t, double population)> line, string name, Color color)
        {
            var series = new Series
            {
                Color = color,
                Name = name,
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Line,
                MarkerSize = 8
            };

            foreach (var point in line)
            {
                series.Points.AddXY(point.t, point.population);
            }

            chart1.Series.Add(series);

            chart1.Update();
        }
    }
}
