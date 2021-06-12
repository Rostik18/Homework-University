using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Laba2_FactorioCognitiveModeling.Extensions;

namespace Laba2_FactorioCognitiveModeling
{
    public partial class Form1 : Form
    {
        private readonly double[,] I;

        private int iterations;
        private int n = 6; //розмірність матриці
        private double[,] A; //початкова матриця

        public Form1()
        {
            InitializeComponent();

            I = new double[6, 6];
            I[0, 0] = 1;
            I[1, 1] = 1;
            I[2, 2] = 1;
            I[3, 3] = 1;
            I[4, 4] = 1;
            I[5, 5] = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logTextBox.Text = string.Empty;

            double[,] multiplaedA; //оновлюється кожної ітерації
            double[,] IplusMatrix; //оновлюється кожної ітерації

            try
            {
                iterations = int.Parse(textBox1.Text);

                var matrix = matrixRichTextBox.Text.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                A = new double[n, n];

                var matrixCounter = 0;
                for (var i = 0; i < n; i++)
                {
                    for (var j = 0; j < n; j++)
                    {
                        A[i, j] = Convert.ToDouble(matrix[matrixCounter++]);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Incorrect input.");
                return;
            }

            //Розрахунки коли імпульс пішов до u1
            var u1Line = new double[iterations + 1];
            var u2Line = new double[iterations + 1];
            var u3Line = new double[iterations + 1];
            var u4Line = new double[iterations + 1];
            var u5Line = new double[iterations + 1];
            var u6Line = new double[iterations + 1];

            u1Line[0] = I[0, 0];
            u2Line[0] = I[0, 1];
            u3Line[0] = I[0, 2];
            u4Line[0] = I[0, 3];
            u5Line[0] = I[0, 4];
            u6Line[0] = I[0, 5];

            //перша ітерація захардкоджено
            IplusMatrix = MatrixSum(I, A);

            u1Line[1] = IplusMatrix[0, 0];
            u2Line[1] = IplusMatrix[0, 1];
            u3Line[1] = IplusMatrix[0, 2];
            u4Line[1] = IplusMatrix[0, 3];
            u5Line[1] = IplusMatrix[0, 4];
            u6Line[1] = IplusMatrix[0, 5];

            LogMatrix(A, "матриця А");
            LogMatrix(IplusMatrix, "I + А");

            multiplaedA = MatrixMultiplication(A, A);

            for (var i = 2; i < iterations + 1; i++)
            {
                LogMatrix(multiplaedA, $"матриця А^{i}");

                IplusMatrix = MatrixSum(IplusMatrix, multiplaedA);

                LogMatrix(IplusMatrix, $"I + ... + А^{i}");

                multiplaedA = MatrixMultiplication(A, multiplaedA);

                u1Line[i] = IplusMatrix[0, 0];
                u2Line[i] = IplusMatrix[0, 1];
                u3Line[i] = IplusMatrix[0, 2];
                u4Line[i] = IplusMatrix[0, 3];
                u5Line[i] = IplusMatrix[0, 4];
                u6Line[i] = IplusMatrix[0, 5];
            }

            mainChart.Series.Clear();

            DrawLine(u1Line, "u1 Виробничі потужності", Color.BlueViolet);
            DrawLine(u2Line, "u2 Видобуток корисних копалин", Color.Brown);
            DrawLine(u3Line, "u3 Виробництво електроенергії", Color.DarkSlateBlue);
            DrawLine(u4Line, "u4 Середовище", Color.GreenYellow);
            DrawLine(u5Line, "u5 Шкідники", Color.Red);
            DrawLine(u6Line, "u6 Забруднення середовища", Color.CadetBlue);
        }

        private void DrawLine(double[] line, string name, Color color)
        {
            var series = new Series
            {
                Name = name,
                Color = color,
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Line
            };

            for (var i = 0; i < iterations + 1; i++)
            {
                series.Points.AddXY(i, line[i]);
            }

            mainChart.Series.Add(series);
        }

        private void LogMatrix(double[,] matrix, string name)
        {
            logTextBox.Text += $"{name}\n";

            for (var i = 0; i < matrix.RowsCount(); i++)
            {
                for (var j = 0; j < matrix.ColumnsCount(); j++)
                {
                    logTextBox.Text += $"{matrix[i, j]:f2} \t";
                }
                logTextBox.Text += "\n";
            }
            logTextBox.Text += "\n";
        }

        // метод для множення матриць
        static double[,] MatrixMultiplication(double[,] matrixA, double[,] matrixB)
        {
            if (matrixA.ColumnsCount() != matrixB.RowsCount())
            {
                throw new Exception("Множення не можливе! Кількість стовпців першої матриці не рівно кількості рядків другої матриці.");
            }

            var matrixC = new double[matrixA.RowsCount(), matrixB.ColumnsCount()];

            for (var i = 0; i < matrixA.RowsCount(); i++)
            {
                for (var j = 0; j < matrixB.ColumnsCount(); j++)
                {
                    matrixC[i, j] = 0;

                    for (var k = 0; k < matrixA.ColumnsCount(); k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            return matrixC;
        }

        // метод для додавання матриць
        public static double[,] MatrixSum(double[,] matrixA, double[,] matrixB)
        {
            if (matrixA.ColumnsCount() != matrixB.RowsCount())
            {
                throw new Exception("Для матриць різного розміру додавання не можливе!");
            }

            var matrixC = new double[matrixA.RowsCount(), matrixB.ColumnsCount()];

            for (var i = 0; i < matrixA.RowsCount(); i++)
            {
                for (var j = 0; j < matrixB.ColumnsCount(); j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            return matrixC;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            iterations = int.Parse(textBox1.Text);
            iterations++;

            textBox1.Text = iterations.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iterations = int.Parse(textBox1.Text);
            iterations--;

            textBox1.Text = iterations.ToString();
        }
    }
}
