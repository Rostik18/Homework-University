using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Services.Functions;
using Services.Functions.Common;
using Services.Helpers;

namespace SimpleSearch
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

            double.TryParse(APointTextBox.Text, out double a);
            double.TryParse(BPointTextBox.Text, out double b);

            var xAxis = new List<double>();
            var yAxis = new List<double>();

            while (a <= b)
            {
                xAxis.Add(a);
                yAxis.Add(_selectedFunction.F(a));

                a += step;
            }

            DrawHelper.DrawGraph(Chart, yAxis.ToArray(), xAxis.ToArray(), _selectedFunction.ToString(), Color.Red, clearChart: true);
        }

        private void DrawFunction(object sender, EventArgs e)
        {
            DrawFunction();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            DrawFunction();
            OutputRichTextBox.Text = string.Empty;

            double.TryParse(EpsilonTextBox.Text, out double epsilon);
            double.TryParse(APointTextBox.Text, out double a);
            double.TryParse(BPointTextBox.Text, out double b);
            int.TryParse(NTextBox.Text, out int N);

            OutputRichTextBox.Text += $"0: [{a:f5}; {b:f5}]\n";

            for (int k = 0; ;)
            {
                //крок 2
                var x = a;

                var h = (b - a) / N;

                for (int j = 0; ;)
                {
                    //крок 5
                    var xNext = x + h;

                    var f = _selectedFunction.F(x);

                    var fNext = _selectedFunction.F(xNext);

                    DrawHelper.AddPointToGraph(Chart, xNext, fNext, Color.Green);

                    if (fNext > f)
                    {
                        if (j == 0) //крок 7
                        {
                            //a = a;
                            b = xNext;
                            //перейти на крок 9
                        }
                        else
                        {
                            a = x - h; //?
                            b = xNext;
                            //перейти на крок 9
                        }
                    }
                    else
                    {
                        if (j < N - 1) // крок 8
                        {
                            j++;
                            x = xNext;
                            //перейти на крок 5
                            continue;
                        }
                        else
                        {
                            a = xNext;
                            //b = b;
                            //перейти на крок 9
                        }
                    }

                    //крок 9
                    if (b - a > epsilon)
                    {
                        //крок 10
                        k++;
                        OutputRichTextBox.Text += $"{k}: [{a:f5}; {b:f5}]\n";

                        DrawHelper.DrawGraph(Chart, new double[] { fNext, fNext }, new double[] { a, b }, $"ітер {k}", Color.Blue);

                        //перейти на крок 2
                        break;
                    }
                    else
                    {
                        //фінал
                        var result = (a + b) / 2;
                        OutputRichTextBox.Text += $"x*: {result}";
                        return;
                    }
                }
                if (k == 500) { MessageBox.Show("Too many iterations", "Error"); break; }
            }
        }
    }
}