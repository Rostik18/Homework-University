using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace Services.Helpers
{
    public static class DrawHelper
    {
        static public void DrawGraph(Chart chart, double[] y, double[] x, string seriesName, Color color, bool clearChart = false)
        {
            if (clearChart)
            {
                chart.Series.Clear();
                chart.ResetAutoValues();
            }

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

        static public void AddPointToGraph(Chart chart, double x, double y, Color color, bool clearChart = false)
        {
            if (clearChart)
            {
                chart.Series.Clear();
                chart.ResetAutoValues();
            }

            var series = new Series
            {
                Color = color,
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Point
            };

            series.Points.AddXY(x, y);

            chart.Series.Add(series);
        }
    }
}