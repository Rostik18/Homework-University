using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace KieferWolfowitzAlgorithm
{
    class DrawHelper
    {
        static public void DrawGraph(Chart chart, double[] y, double[] x, string seriesName, Color color)
        {
            chart.Series.Clear();
            chart.ResetAutoValues();

            var series = new Series
            {
                Name = seriesName,
                Color = color,
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Line
            };

            for (int i = 0; i < x.Length; i++)
            {

                series.Points.AddXY(x[i], y[i]);
            }

            chart.Series.Add(series);
        }
    }
}
