using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Matrix
{
    enum Operation
    {
        plus = 1,
        minus,
        mult,
        trans
    }
    public partial class Form1 : Form
    {
        private int n;
        private int m;

        Operation operation;

        DataTable matrixA;
        DataTable matrixB;
        DataTable matrixC;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            RezLabel.Visible = false;
            OperationLabel.Visible = false;
            CalcButton.Enabled = false;
            SaveButton.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            operation = Operation.plus;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            operation = Operation.minus;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            operation = Operation.mult;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            operation = Operation.trans;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
            try
            {
                n = Convert.ToInt32(maskedTextBox1.Text);
                m = Convert.ToInt32(maskedTextBox2.Text);
            }
            catch
            {
                MessageLabel.Text = "Задайте розмірність.";
                return;
            }
            if(n == 0 || m == 0)
            {
                MessageLabel.Text = "Неприпустима розмірність.";
                return;
            }

            switch (operation)
            {
                case Operation.plus:
                    Init_MatrixAdd();
                    break;
                case Operation.minus:
                    Init_MatrixMin();
                    break;
                case Operation.mult:
                    Init_MatrixMult();
                    break;
                case Operation.trans:
                    Init_MatrixTrans();
                    break;
                default:
                    MessageLabel.Text = "Виберіть операцію.";
                    break;
            }
        }
        void Init_MatrixAdd()
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            dataGridView3.Visible = true;
            RezLabel.Visible = true;
            OperationLabel.Text = "+";
            OperationLabel.Visible = true;

            matrixA = new DataTable();
            matrixB = new DataTable();
            matrixC = new DataTable();

            for (int i = 0; i < m; i++)
                matrixA.Columns.Add((i + 1).ToString(), typeof(int));
            for (int i = 0; i < n; i++)
                matrixA.Rows.Add(matrixA.NewRow());
            dataGridView1.DataSource = matrixA;

            for (int i = 0; i < m; i++)
                matrixB.Columns.Add((i + 1).ToString(), typeof(int));
            for (int i = 0; i < n; i++)
                matrixB.Rows.Add(matrixB.NewRow());
            dataGridView2.DataSource = matrixB;

            for (int i = 0; i < m; i++)
                matrixC.Columns.Add((i + 1).ToString(), typeof(int));
            for (int i = 0; i < n; i++)
                matrixC.Rows.Add(matrixC.NewRow());
            dataGridView3.DataSource = matrixC;

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrixA.Rows[i][j] = random.Next(-10, 10);
                    matrixB.Rows[i][j] = random.Next(-10, 10);
                }
            }
            CalcButton.Enabled = true;
        }
        void Init_MatrixMin()
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            dataGridView3.Visible = true;
            RezLabel.Visible = true;
            OperationLabel.Text = "-";
            OperationLabel.Visible = true;

            matrixA = new DataTable();
            matrixB = new DataTable();
            matrixC = new DataTable();

            for (int i = 0; i < m; i++)
                matrixA.Columns.Add((i + 1).ToString(), typeof(int));
            for (int i = 0; i < n; i++)
                matrixA.Rows.Add(matrixA.NewRow());
            dataGridView1.DataSource = matrixA;

            for (int i = 0; i < m; i++)
                matrixB.Columns.Add((i + 1).ToString(), typeof(int));
            for (int i = 0; i < n; i++)
                matrixB.Rows.Add(matrixB.NewRow());
            dataGridView2.DataSource = matrixB;

            for (int i = 0; i < m; i++)
                matrixC.Columns.Add((i + 1).ToString(), typeof(int));
            for (int i = 0; i < n; i++)
                matrixC.Rows.Add(matrixC.NewRow());
            dataGridView3.DataSource = matrixC;

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrixA.Rows[i][j] = random.Next(-10, 10);
                    matrixB.Rows[i][j] = random.Next(-10, 10);
                }
            }
            CalcButton.Enabled = true;
        }
        void Init_MatrixMult()
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = true;
            dataGridView3.Visible = true;
            RezLabel.Visible = true;
            OperationLabel.Text = "*";
            OperationLabel.Visible = true;

            matrixA = new DataTable();
            matrixB = new DataTable();
            matrixC = new DataTable();

            for (int i = 0; i < m; i++)
                matrixA.Columns.Add((i + 1).ToString(), typeof(int));
            for (int i = 0; i < n; i++)
                matrixA.Rows.Add(matrixA.NewRow());
            dataGridView1.DataSource = matrixA;

            for (int i = 0; i < n; i++)
                matrixB.Columns.Add((i + 1).ToString(), typeof(int));
            for (int i = 0; i < m; i++)
                matrixB.Rows.Add(matrixB.NewRow());
            dataGridView2.DataSource = matrixB;

            for (int i = 0; i < n; i++)
                matrixC.Columns.Add((i + 1).ToString(), typeof(int));
            for (int i = 0; i < n; i++)
                matrixC.Rows.Add(matrixC.NewRow());
            dataGridView3.DataSource = matrixC;

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrixA.Rows[i][j] = random.Next(-10, 10);
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixB.Rows[i][j] = random.Next(-10, 10);
                }
            }
            CalcButton.Enabled = true;
        }
        void Init_MatrixTrans()
        {
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            RezLabel.Visible = true;
            OperationLabel.Text = "t";
            OperationLabel.Visible = true;
            
            matrixA = new DataTable();
            matrixC = new DataTable();

            for (int i = 0; i < m; i++)
                matrixA.Columns.Add((i + 1).ToString(), typeof(int));
            for (int i = 0; i < n; i++)
                matrixA.Rows.Add(matrixA.NewRow());
            dataGridView1.DataSource = matrixA;

            for (int i = 0; i < n; i++)
                matrixC.Columns.Add((i + 1).ToString(), typeof(int));
            for (int i = 0; i < m; i++)
                matrixC.Rows.Add(matrixC.NewRow());
            dataGridView3.DataSource = matrixC;

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrixA.Rows[i][j] = random.Next(-10, 10);
                }
            }
            
            CalcButton.Enabled = true;
        }
        private void CalcButton_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case Operation.plus:
                    MatrixAdd();
                    SaveButton.Enabled = true;
                    break;
                case Operation.minus:
                    MatrixMin();
                    SaveButton.Enabled = true;
                    break;
                case Operation.mult:
                    MatrixMult();
                    SaveButton.Enabled = true;
                    break;
                case Operation.trans:
                    MatrixTrans();
                    SaveButton.Enabled = true;
                    break;
            }
        }
        void MatrixAdd()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrixC.Rows[i][j] = (int)matrixA.Rows[i][j] + (int)matrixB.Rows[i][j];
                }
            }
        }
        void MatrixMin()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrixC.Rows[i][j] = (int)matrixA.Rows[i][j] - (int)matrixB.Rows[i][j];
                }
            }
        }
        void MatrixMult()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < m; k++)
                    {
                        sum += (int)matrixA.Rows[i][k] * (int)matrixB.Rows[k][j];
                    }
                    matrixC.Rows[i][j] = sum;
                }
            }
        }
        void MatrixTrans()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixC.Rows[i][j] = matrixA.Rows[j][i];
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string Path = @"C:\Users\Ростик\source\repos\Matrix\Matrix\Rezult.txt";
            using (StreamWriter sw = new StreamWriter(Path, false, Encoding.Default))
            {
                string[] RezMatr = new string[matrixC.Rows.Count];
                for (int i = 0; i < matrixC.Rows.Count; i++)
                {
                    RezMatr[i] = "";
                    for (int j = 0; j < matrixC.Columns.Count; j++)
                    {
                        RezMatr[i] += matrixC.Rows[i][j] + " ";
                    }
                    sw.WriteLine(RezMatr[i]);
                }
            }
        }

        private void ReadFile()
        {
            string path = @"C:\Users\Ростик\source\repos\Matrix\Matrix\Rezult.txt";
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                matrixA = new DataTable();
                List<List<string>> nums = new List<List<string>>();
                string line;
                int _n = 0;
                int _m = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    if(line != "")
                        nums.Add(new List<string>(line.Split(new char[] {' '} , StringSplitOptions.RemoveEmptyEntries)));

                }
                _n = nums.Count;
                _m = nums[0].Count;
                for (int i = 0; i < _m; i++)
                    matrixA.Columns.Add((i + 1).ToString(), typeof(int));
                for (int i = 0; i < _n; i++)
                    matrixA.Rows.Add(matrixA.NewRow());

                for (int i = 0; i < _n; i++)
                {
                    for (int j = 0; j < _m; j++)
                    {
                        matrixA.Rows[i][j] = Convert.ToInt32(nums[i][j]);
                    }
                }
                dataGridView1.DataSource = matrixA;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadFile();
        }
    }
}