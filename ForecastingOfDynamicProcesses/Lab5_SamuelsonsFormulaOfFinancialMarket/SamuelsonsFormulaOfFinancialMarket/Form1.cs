using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SamuelsonsFormulaOfFinancialMarket
{
    public partial class Form1 : Form
    {
        private readonly Random Random = new Random();

        private int N = 100;

        private double _startPrice = 100;
        private double _l = 0.5;
        private double _mi = 0.5;
        private double _sigma = 0.5;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text = string.Empty;

            // stupid chart keeping references to points
            chart1.Series[0].Points.Clear();
            chart1.Series.Clear();

            N = (int)nNumeric.Value;

            _startPrice = (double)startPriceNumeric.Value;
            _l = (double)lNumeric.Value;
            _mi = (double)miNumeric.Value;
            _sigma = (double)sigmaNumeric.Value;

            var line = new List<(int t, double price)>();

            for (int t = 1; t <= N; t++)
            {
                var price = S(_startPrice, _l, _mi, _sigma, t);
                line.Add((t, price));

                logTextBox.Text += $"t={t}\t{price:f2}\n";
            }

            DrawLine(line, Color.Blue);
        }

        private double S(double S0, double l, double mi, double sigma, int t)
        {
            return S0 * Math.Pow(l, (mi - (sigma * sigma) / 2) * t + sigma * W(t));
        }

        private double W(int t) => Random.NextDouble();

        private void DrawLine(IEnumerable<(int t, double price)> line, Color color)
        {
            var series = new Series
            {
                Color = color,
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Line
            };

            foreach (var pair in line)
            {
                series.Points.AddXY(pair.t, pair.price);
            }

            chart1.Series.Add(series);
           // chart1.Update();
        }
    }
}
