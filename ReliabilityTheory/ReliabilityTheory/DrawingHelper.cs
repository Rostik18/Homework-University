using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReliabilityTheory
{
    public static class DrawingHelper
    {
        public static void DrawGraph(Chart chart, double[] y, double[] x, int m, string seriesName, Color color)
        {

            var series = new Series
            {
                Name = seriesName,
                Color = color,
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Line
            };

            for (int i = 0; i < m; i++)
            {

                series.Points.AddXY(x[i], y[i]);
            }

            chart.Series.Add(series);
        }

        public static void PrintFunction(RichTextBox richTextBox, double[] F, double[] x, string name, string subject)
        {
            richTextBox.Text += subject + "\n";
            for (int i = 0; i < F.Length; i++)
            {
                richTextBox.Text += $"{name}({x[i]:f3}) = {F[i]:f4}\n";
            }
            richTextBox.Text += "-----------------\n";
        }
    }
}
