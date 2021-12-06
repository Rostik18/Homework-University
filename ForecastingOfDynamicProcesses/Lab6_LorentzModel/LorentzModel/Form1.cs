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

namespace LorentzModel
{
    public partial class Form1 : Form
    {
        private int N = 100;

        private double _sigma = 10;
        private double _r = 10;
        private double _b = 2.66;

        private double _dt = 0.01;

        public Form1()
        {
            InitializeComponent();

            splitContainer1.Panel1.Controls.Add(chart1);
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer2.Panel1.Controls.Add(chart2);
            splitContainer2.Panel2.Controls.Add(chart3);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            N = (int)nNumeric.Value;
            _sigma = (double)sigmaNumeric.Value;
            _r = (double)rNumeric.Value;
            _b = (double)bNumeric.Value;

            var xAxis = new double[N + 1];
            var yAxis = new double[N + 1];
            var zAxis = new double[N + 1];

            xAxis[0] = 0;
            yAxis[0] = 1;
            zAxis[0] = 1.05;

            for (int i = 0; i < N; i++)
            {
                var (xNext, yNext, zNext) = LorenzStep(xAxis[i], yAxis[i], zAxis[i]);

                xAxis[i + 1] = Math.Round(xAxis[i] + xNext * _dt, 1);
                yAxis[i + 1] = Math.Round(yAxis[i] + yNext * _dt, 1);
                zAxis[i + 1] = Math.Round(zAxis[i] + zNext * _dt, 1);
            }

            DrawLine(xAxis, yAxis, Color.Blue, chart1);
            DrawLine(xAxis, zAxis, Color.Blue, chart2);
            DrawLine(yAxis, zAxis, Color.Blue, chart3);
        }

        private (double x, double y, double z) LorenzStep(double x, double y, double z)
        {
            var xNext = _sigma * (y - x);
            var yNext = _r * x - y - x * z;
            var zNext = x * y - _b * z;

            return (xNext, yNext, zNext);
        }

        private void DrawLine(double[] AxisA, double[] AxisB, Color color, Chart chart)
        {
            foreach (var s in chart.Series)
                s.Points.Clear();
            chart.Series.Clear();
            chart.Legends.Clear();

            var series = new Series
            {
                Color = color,
                IsVisibleInLegend = false,
                IsValueShownAsLabel = false,
                ChartType = SeriesChartType.Line
            };

            for (int i = 0; i < AxisA.Count(); i++)
            {
                series.Points.AddXY(AxisA[i], AxisB[i]);

            }

            chart.Series.Add(series);
        }
    }
}
