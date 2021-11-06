using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laba1_Bullet_Speed
{
    public partial class Form1 : Form
    {
        private int _sessionExperiments;
        private decimal _averageSessionSpeed;

        public Form1()
        {
            InitializeComponent();

            CalculateLinearCase.Click += CleanLogAndChart;
            CalculateLinearCase.Click += CalculateLinearCase_Click;
            CalculateStochasticCase.Click += CleanLogAndChart;
            CalculateStochasticCase.Click += CalculateStochasticCase_Click; slider.ValueChanged += ResetSession;
            slider.SliderMax = 35;
        }

        private void slider_ValueChanged(object sender, EventArgs e)
        {
            angleTextBoxFrom.Text = slider.SliderMin.ToString();
            angleTextBoxTo.Text = slider.SliderMax.ToString();
        }

        private void CleanLogAndChart(object sender, EventArgs e)
        {
            logTextBox.Text = string.Empty;
            chart1.Series.Clear();
            chart1.Series.Add(new Series
            {
                Color = Color.Black,
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Point,
                MarkerSize = 0,
                Points = { new DataPoint(0, 0) }
            });
            chart1.Series.Add(new Series
            {
                Color = Color.Black,
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Point,
                MarkerSize = 0,
                Points = { new DataPoint(90, 600) }
            });
        }

        private void CalculateLinearCase_Click(object sender, EventArgs e)
        {
            FreezeButtons();

            logTextBox.Text += "Залежність швидкості від кута нахилу\n\n";

            var m = double.Parse(textBox1.Text, NumberStyles.Any);
            var M = double.Parse(textBox2.Text, NumberStyles.Any);
            var l = double.Parse(textBox3.Text, NumberStyles.Any);
            var g = double.Parse(textBox4.Text, NumberStyles.Any);

            m /= 1000; //to kg

            var line = new Dictionary<int, double>();

            for (int i = slider.Minimum; i < slider.Maximum + 1; i++)
            {
                line.Add(i, CalculateSpeed(M, m, g, l, i));
            }

            DrawLine(line);
            LogLine(line);

            UnfreezeButtons();
        }

        private void CalculateStochasticCase_Click(object sender, EventArgs e)
        {
            FreezeButtons();

            logTextBox.Text += "Експеремент з випадковим кутом нахилу\n";

            var N = int.Parse(textBox5.Text, NumberStyles.Any);
            var m = double.Parse(textBox1.Text, NumberStyles.Any);
            var M = double.Parse(textBox2.Text, NumberStyles.Any);
            var l = double.Parse(textBox3.Text, NumberStyles.Any);
            var g = double.Parse(textBox4.Text, NumberStyles.Any);
            var from = slider.SliderMin;
            var to = slider.SliderMax;

            m /= 1000; //to kg

            var random = new Random();

            var points = new List<(int number, int angle, double speed)>();

            var mu = (from + to) / 2.0;
            var sigma = (to - mu) / 4.2;

            for (int i = 0; i < N; i++)
            {
                var angle = gaussianDistributionCheckBox.BoolValue
                    ? (int)Math.Round(random.NextGaussian(mu, sigma))
                    : random.Next(from, to);

                points.Add((i, angle, CalculateSpeed(M, m, g, l, angle)));
            }

            DrawPoints(points);

            var averageSpeed = points.Average(x => x.speed);
            _averageSessionSpeed = (_averageSessionSpeed * _sessionExperiments++ + (decimal)averageSpeed) / _sessionExperiments;

            LogPoints(points, averageSpeed);

            UnfreezeButtons();
        }

        private void ResetSession(object sender, EventArgs e)
        {
            CleanLogAndChart(sender, e);

            _sessionExperiments = 0;
            _averageSessionSpeed = 0;

            logTextBox.Text = "Розпочато нову сесію";
        }

        private void FreezeButtons()
        {
            CalculateLinearCase.Enabled = false;
            CalculateStochasticCase.Enabled = false;
        }
        private void UnfreezeButtons()
        {
            CalculateLinearCase.Enabled = true;
            CalculateStochasticCase.Enabled = true;
        }

        private void LogPoints(List<(int number, int angle, double speed)> points, double averageSpeed)
        {
            logTextBox.Text += $"середньостатистичне значення швидкості: {averageSpeed:F} м/с\n";
            logTextBox.Text += $"                     за сесію з {_sessionExperiments:D3} експерементів: {_averageSessionSpeed:F} м/с\n\n";

            foreach (var point in points.OrderBy(x => x.angle))
            {
                logTextBox.Text += $"[{point.number}]\t{point.angle}\t{point.speed:F} м/с\n";
            }
        }

        private void DrawPoints(List<(int number, int angle, double speed)> points)
        {
            foreach (var point in points)
            {
                var series = new Series
                {
                    Color = Color.Red,
                    IsVisibleInLegend = false,
                    ChartType = SeriesChartType.Point,
                    MarkerSize = 8
                };
                series.Points.AddXY(point.angle, point.speed);

                chart1.Series.Add(series);
            }

            chart1.Update();
        }

        private void DrawLine(Dictionary<int, double> line)
        {
            var series = new Series
            {
                Color = Color.Red,
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Line
            };

            foreach (var pair in line)
            {
                series.Points.AddXY(pair.Key, pair.Value);
            }

            chart1.Series.Add(series);
            chart1.Update();
        }

        private void LogLine(Dictionary<int, double> line)
        {
            foreach (var pair in line)
            {
                logTextBox.Text += $"{pair.Key}\t{pair.Value:F} м/с\n";
            }
        }

        private double CalculateSpeed(double M, double m, double g, double l, double a)
        {
            var aRad = a * 0.0174532925;
            return Math.Sqrt(2 * (M + m) * g * l * (1 - Math.Cos(aRad)) / m);
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Update();
        }
    }
}
