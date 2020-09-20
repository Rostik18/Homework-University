using KieferWolfowitzAlgorithm.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KieferWolfowitzAlgorithm
{
    public partial class Form1 : Form
    {
        private IFunction _selectedFunction;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FunctionsComboBox.DataSource = new List<IFunction> { new FCosine(), new FXSquare(), new FXParapola() };

            _selectedFunction = (IFunction)FunctionsComboBox.SelectedItem;
        }

        private void FunctionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedFunction = (IFunction)FunctionsComboBox.SelectedItem;

            DrawFunction();
        }

        private void DrawFunction()
        {
            double step = 0.01;
            double a = 0, b = 1;

            double.TryParse(APointTextBox.Text, out a);
            double.TryParse(BPointTextBox.Text, out b);

            var xAxis = new List<double>();
            var yAxis = new List<double>();

            while (a <= b)
            {
                xAxis.Add(a);
                yAxis.Add(_selectedFunction.F(a));

                a += step;
            }

            DrawHelper.DrawGraph(Chart, yAxis.ToArray(), xAxis.ToArray(), _selectedFunction.ToString(), Color.Red);
        }

        private void DrawFunction(object sender, EventArgs e)
        {
            DrawFunction();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            OutputRichTextBox.Text = string.Empty;

            double epsilon = 0.001;
            double a = 0, b = 1, x = 0;

            double.TryParse(APointTextBox.Text, out a);
            double.TryParse(BPointTextBox.Text, out b);
            double.TryParse(InitialApproximationTextBox.Text, out x);

            for (int k = 0; ; k++)
            {
                OutputRichTextBox.Text += $"[{k}]: F({x:f4}) = {_selectedFunction.F(x):f4}\n";

                var zPos = (_selectedFunction.F(x) + Delta(k));
                var zNeg = (_selectedFunction.F(x) - Delta(k));

                var xNext = x + (Ro(k) / Delta(k)) * (zPos - zNeg);

                if (k == 500) { MessageBox.Show("Too many iterations", "Error"); break; }

                if ((xNext - x) < epsilon) { OutputRichTextBox.Text += $"x* = {xNext:f4}"; break; }
                else x = xNext;
            }
        }

        private double Ro(double k)
        {
            return 1 / (k + 1);
        }

        private double Delta(double k)
        {
            return Math.Pow(1 / (k + 1), 2);
        }
    }
}
