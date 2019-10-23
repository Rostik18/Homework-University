using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace InterpolationPolynomial_1 {

    static class DrawHelper {

        static public void DrawGraph( Chart chart, double[] y, double[] x, int m, string seriesName, Color color ) {

            var series = new Series {
                Name = seriesName,
                Color = color,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };

            chart.Series.Add( series );

            for (int i = 0; i < m + 1; i++) {

              chart.Series[seriesName].Points.AddXY( x[i], y[i] );
            }

        }
    }
}
