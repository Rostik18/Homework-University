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

namespace DrawingСharts
{
    public partial class Form1 : Form
    {
        private float a;
        private float b;
        private float[] X;
        private float[] Y;
        private int breaker;
        private int numbOfChart;

        public Form1()
        {
            InitializeComponent();
            numbOfChart = 0;
            breaker = 20;
            X = new float[breaker];
            Y = new float[breaker];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            try
            {
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);
                if (a > b)
                {
                    float tmp = a;
                    a = b;
                    b = tmp;
                }
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        CalcSin();
                        break;
                    case 1:
                        CalcXquad();
                        break;
                }
            }
            catch
            {
                label3.Text = "Упс...";
                return;
            }

            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = X.Min();
            chart.AxisX.Maximum = X.Max();
            chart.AxisY.Minimum = Y.Min();
            chart.AxisY.Maximum = Y.Max();
            chart.AxisX.Interval = (b - a) / breaker;
            chart.AxisY.Interval = (Y.Max() - Y.Min()) / breaker;

            string correntChart = numbOfChart.ToString();
            numbOfChart++;

            chart1.Series.Add(correntChart);
            chart1.Series[correntChart].ChartType = SeriesChartType.Spline;

            chart1.Series[correntChart].Color = Color.Red;
            chart1.Series[0].IsVisibleInLegend = false;

            for (int i = 0; i < breaker; i++)
            {
                chart1.Series[correntChart].Points.AddXY(X[i], Y[i]);
            }
        }

        private void CalcXquad()
        {
            float step = (b - a) / breaker;
            float start = a;

            for (int i = 0; i < breaker; i++)
            {
                X[i] = start;
                Y[i] = start * start;
                start += step;
            }
        }

        private void CalcSin()
        {
            float step = (b - a) / breaker;
            float start = a;

            for (int i = 0; i < breaker; i++)
            {
                X[i] = start;
                Y[i] = (float)Math.Sin(start);
                start += step;
            }
        }
    }
}
