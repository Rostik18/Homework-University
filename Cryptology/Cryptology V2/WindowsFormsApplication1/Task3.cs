using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Task3 : Form
    {
        TextHandler th = new TextHandler();
        public Task3()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "Англійська";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Clear();
                string wqe = filedialog.FileName;
                richTextBox1.LoadFile(filedialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox2.Clear();
                string wqe = filedialog.FileName;
                richTextBox2.LoadFile(filedialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        private void button_frequency_Click(object sender, EventArgs e)
        {
            List<double> percent_mas = new List<double>();
            string text = richTextBox1.Text.ToLower();
            percent_mas.AddRange(th.calc(text));
            char[] latter = th.Latter_mas;
            //double result = 0;
            //foreach (var elem in percent_mas)
            //    result += elem;
            //MessageBox.Show(result.ToString());
            dataGridView1.Rows.Clear();
            for (int i = 0; i < latter.Length; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = latter[i];
                dataGridView1.Rows[i].Cells[1].Value = percent_mas[i];
            }
        }

        private void button_frequency2_Click(object sender, EventArgs e)
        {
            List<double> percent_mas = new List<double>();
            string text = richTextBox2.Text.ToLower();
            percent_mas.AddRange(th.calc(text));
            char[] latter = th.Latter_mas;
            dataGridView2.Rows.Clear();
            for (int i = 0; i < latter.Length; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = latter[i];
                dataGridView2.Rows[i].Cells[1].Value = percent_mas[i];
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            th.set_lang(comboBox1.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Descending);
            dataGridView2.Sort(dataGridView2.Columns[1], ListSortDirection.Descending);
            dataGridView3.Rows.Clear();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView3.Rows.Add();
                dataGridView3.Rows[i].Cells[0].Value = dataGridView1.Rows[i].Cells[0].Value;
                dataGridView3.Rows[i].Cells[1].Value = dataGridView2.Rows[i].Cells[0].Value;

            }
            int n = richTextBox2.Text.Length;
            string str = richTextBox2.Text.ToLower();
            string str1 = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < dataGridView3.Rows.Count - 2; j++)
                {
                    if ((char)dataGridView3.Rows[j].Cells[1].Value == str[i])
                    {
                        str1 += dataGridView3.Rows[j].Cells[0].Value;
                    }

                }
            }
            richTextBox3.Text = str1;
        }
        string letter = "";
        int index=0;
        private void dataGridView3_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            letter = dataGridView3.Rows[row].Cells[col].Value.ToString();
            index = row;
        }

        private void dataGridView3_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string leter = dataGridView3.Rows[index].Cells[0].Value.ToString();
                for (int i = 0; i < dataGridView3.Rows.Count - 2; i++)
                    {
                         if(leter==dataGridView3.Rows[i].Cells[0].Value.ToString() && i!=index)
                            {
                                dataGridView3.Rows[i].Cells[0].Value = letter;
                            }
                    }
                int n = richTextBox2.Text.Length;
                string str = richTextBox2.Text.ToLower();
                string str1 = "";
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < dataGridView3.Rows.Count - 2; j++)
                    {
                        if ((char)dataGridView3.Rows[j].Cells[1].Value == str[i])
                        {
                            str1 += dataGridView3.Rows[j].Cells[0].Value;
                        }

                    }
                }
                richTextBox3.Text = str1;
        }

        private void dataGridView3_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Task3_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool Word = false;
            for (int i=0;i<richTextBox3.Text.Length-comboBox2.Text.Length;++i)
            {
                
                if( richTextBox3.Text[i]==comboBox2.Text[0])
                {
                    for (int j=1;j<comboBox2.Text.Length;++j)
                    {
                        if (richTextBox3.Text[i + j] == comboBox2.Text[j])
                            Word = true;
                        else
                        {
                            Word = false;
                            break;
                        }
                    }
                }

                if (Word)
                {
                    richTextBox3.Text = richTextBox3.Text.Insert(i," ");
                    richTextBox3.Text = richTextBox3.Text.Insert((i + comboBox2.Text.Length), " ");
                }
            }
        }
    }
}
