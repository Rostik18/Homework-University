using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ReliabilityTheory
{
    public partial class EmpiricalDistributionFunctionsForm : Form
    {
        public EmpiricalDistributionFunctionsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            var file = new StreamReader(@"C:\Homework-University\ReliabilityTheory\ReliabilityTheory\TaskData1.txt");

            string data = file.ReadToEnd();
            file.Close();

            var t_data = data.Split(new char[] { ' ', '\n' }).ToList();

            t_data.Sort();
            int n = t_data.Count;
            double[] t = new double[n];

            for (int i = 0; i < n; i++)
            {
                t[i] = Convert.ToDouble(t_data[i]);
            }

            double[] F1 = new double[n];
            double[] F2 = new double[n];
            double[] F3 = new double[n];
            double[] F4 = new double[n];

            for (int i = 0; i < n; i++)
            {
                F1[i] = (i + 1.0) / n;
                F2[i] = i / (n - 1.0);
                F3[i] = (i + 1.0) / (n + 1.0);
                F4[i] = (i + 0.7) / (n + 0.4);
            }

            DrawingHelper.PrintFunction(richTextBox1, F1, t, "F1", "");
            DrawingHelper.PrintFunction(richTextBox1, F2, t, "F2", "");
            DrawingHelper.PrintFunction(richTextBox1, F3, t, "F3", "");
            DrawingHelper.PrintFunction(richTextBox1, F4, t, "F4", "");

            DrawingHelper.DrawGraph(chart1, F1, t, n, "F1 Частотна", Color.Red);
            DrawingHelper.DrawGraph(chart1, F2, t, n, "F2 Модна", Color.Green);
            DrawingHelper.DrawGraph(chart1, F3, t, n, "F3 Сподівана", Color.Blue);
            DrawingHelper.DrawGraph(chart1, F4, t, n, "F4 Медіанна", Color.Yellow);
        }
    }
}
