using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UkrainePopulationByMalthusModel
{
    public partial class Form1 : Form
    {
        private int _minYear;
        private int _maxYear;

        private List<YearPopulationPair> _yearPopulationPairs = new List<YearPopulationPair>
        {
            new YearPopulationPair{Year = 1960, Population = 42.660000},
            new YearPopulationPair{Year = 1961, Population = 43.210000},
            new YearPopulationPair{Year = 1962, Population = 43.750000},
            new YearPopulationPair{Year = 1963, Population = 44.290000},
            new YearPopulationPair{Year = 1964, Population = 44.800000},
            new YearPopulationPair{Year = 1965, Population = 45.260000},
            new YearPopulationPair{Year = 1966, Population = 45.680000},
            new YearPopulationPair{Year = 1967, Population = 46.060000},
            new YearPopulationPair{Year = 1968, Population = 46.410000},
            new YearPopulationPair{Year = 1969, Population = 46.750000},

            new YearPopulationPair{Year = 1970, Population = 47.090000},
            new YearPopulationPair{Year = 1971, Population = 47.440000},
            new YearPopulationPair{Year = 1972, Population = 47.780000},
            new YearPopulationPair{Year = 1973, Population = 48.130000},
            new YearPopulationPair{Year = 1974, Population = 48.450000},
            new YearPopulationPair{Year = 1975, Population = 48.760000},
            new YearPopulationPair{Year = 1976, Population = 49.030000},
            new YearPopulationPair{Year = 1977, Population = 49.290000},
            new YearPopulationPair{Year = 1978, Population = 49.520000},
            new YearPopulationPair{Year = 1979, Population = 49.750000},

            new YearPopulationPair{Year = 1980, Population = 49.970000},
            new YearPopulationPair{Year = 1981, Population = 50.220000},
            new YearPopulationPair{Year = 1982, Population = 50.380000},
            new YearPopulationPair{Year = 1983, Population = 50.560000},
            new YearPopulationPair{Year = 1984, Population = 50.750000},
            new YearPopulationPair{Year = 1985, Population = 50.920000},
            new YearPopulationPair{Year = 1986, Population = 51.100000},
            new YearPopulationPair{Year = 1987, Population = 51.290000},
            new YearPopulationPair{Year = 1988, Population = 51.520000},
            new YearPopulationPair{Year = 1989, Population = 51.770000},

            new YearPopulationPair{Year = 1990, Population = 51.890000},
            new YearPopulationPair{Year = 1991, Population = 51.900000},
            new YearPopulationPair{Year = 1992, Population = 52.100000},
            new YearPopulationPair{Year = 1993, Population = 52.200000},
            new YearPopulationPair{Year = 1994, Population = 52.100000},
            new YearPopulationPair{Year = 1995, Population = 51.700000},
            new YearPopulationPair{Year = 1996, Population = 51.300000},
            new YearPopulationPair{Year = 1997, Population = 50.800000},
            new YearPopulationPair{Year = 1998, Population = 50.400000},
            new YearPopulationPair{Year = 1999, Population = 49.900000},

            new YearPopulationPair{Year = 2000, Population = 49.400000},
            new YearPopulationPair{Year = 2001, Population = 48.900000},
            new YearPopulationPair{Year = 2002, Population = 48.500000},
            new YearPopulationPair{Year = 2003, Population = 48.000000},
            new YearPopulationPair{Year = 2004, Population = 47.600000},
            new YearPopulationPair{Year = 2005, Population = 47.300000},
            new YearPopulationPair{Year = 2006, Population = 46.900000},
            new YearPopulationPair{Year = 2007, Population = 46.600000},
            new YearPopulationPair{Year = 2008, Population = 46.400000},
            new YearPopulationPair{Year = 2009, Population = 46.100000},

            new YearPopulationPair{Year = 2010, Population = 46.000000},
            new YearPopulationPair{Year = 2011, Population = 45.800000},
            new YearPopulationPair{Year = 2012, Population = 45.600000},
            new YearPopulationPair{Year = 2013, Population = 45.00000},
            new YearPopulationPair{Year = 2014, Population = 45.400000},

            new YearPopulationPair{Year = 2015, Population = 42.900000},
            new YearPopulationPair{Year = 2016, Population = 42.800000},
            new YearPopulationPair{Year = 2017, Population = 42.600000},
            new YearPopulationPair{Year = 2018, Population = 42.400000},
            new YearPopulationPair{Year = 2019, Population = 42.100000},
            new YearPopulationPair{Year = 2020, Population = 41.900000},
            new YearPopulationPair{Year = 2021, Population = 41.600000}
        };

        public Form1()
        {
            InitializeComponent();

            _minYear = _yearPopulationPairs.Min(x => x.Year);
            _maxYear = _yearPopulationPairs.Max(x => x.Year);

            startYearTrackBar.Minimum = _minYear;
            startYearTrackBar.Maximum = _maxYear;

            chart1.Series.Clear();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text = string.Empty;
            chart1.Series.Clear();

            var startYear = startYearTrackBar.Value;
            var takeYears = int.Parse(takeYearsTextBox.Text);
            var step = int.Parse(stepTextBox.Text);
            step = step < 1 ? 1 : step;

            var workRange = _yearPopulationPairs.Where(x => x.Year >= startYear).Take(takeYears).ToList();

            var predictions = new List<(YearPopulationPair start, YearPopulationPair end)>();
            for (var i = 0; i < workRange.Count; i += step)
            {
                var a = i - step < 0
                    ? workRange[0].Population
                    : workRange[i - step].Population;

                var b = workRange[i].Population;

                var u = b / a;

                var N = workRange[i].Population;

                var yearPopulationPairStart = new YearPopulationPair { Year = workRange[i].Year, Population = workRange[i].Population };
                var yearPopulationPairEnd = new YearPopulationPair { Year = workRange[i].Year + step, Population = u * N };

                predictions.Add((yearPopulationPairStart, yearPopulationPairEnd));
            }

            DrawLine(workRange, Color.Blue);

            logTextBox.Text += "рік\tістор\tпрогноз\tрізниця\n";

            foreach (var (start, end) in predictions)
            {
                DrawLine(new[] { start, end }, Color.Red);

                var realPopulation = workRange.FirstOrDefault(x => x.Year == end.Year)?.Population;
                var realPopLabel = realPopulation.HasValue ? $"{realPopulation.Value:F4}" : "";
                var dif = realPopulation.HasValue ? $"{Math.Abs(end.Population - realPopulation.Value):F4}" : "";

                logTextBox.Text += $"{end.Year}\t{realPopLabel}\t{end.Population:F4}\t{dif}\n";
            }
        }

        private void DrawLine(IEnumerable<YearPopulationPair> line, Color color)
        {
            var series = new Series
            {
                Color = color,
                IsVisibleInLegend = false,
                ChartType = SeriesChartType.Line
            };

            foreach (var pair in line)
            {
                series.Points.AddXY(pair.Year, pair.Population);
            }

            chart1.Series.Add(series);
            chart1.Update();
        }

        private void startYearTrackBar_Scroll(object sender, EventArgs e)
        {
            startYearTextBox.Text = startYearTrackBar.Value.ToString();
        }

        private void startYearTextBox_TextChanged(object sender, EventArgs e)
        {
            logTextBox.Text = string.Empty;

            var year = int.Parse(startYearTextBox.Text);

            if (year < _minYear || year > _maxYear)
            {
                logTextBox.Text = "Недопустимий рік";
                return;
            }

            startYearTrackBar.Value = year;
        }
    }
}
