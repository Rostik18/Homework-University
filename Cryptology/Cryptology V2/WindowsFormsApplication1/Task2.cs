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

namespace WindowsFormsApplication1
{

    public partial class Task2 : Form
    {
        int k;
        TextHandler th = new TextHandler();
        List<char> list1 = new List<char>();
        List<char> list2 = new List<char>();
        public Task2()
        {
            InitializeComponent();
            land_list.SelectedItem = "Англійська";
        }
        void Data()
        {
            k = Convert.ToInt32(textBox1.Text);
            dataGridView1.Rows.Clear();
            List<char> list11 = new List<char>();
            List<char> list22 = new List<char>();
            th.set_lang(land_list.SelectedIndex);
             list11.AddRange(th.Latter_mas);
             list22.AddRange(th.Latter_mas);
            for(int i=0;i<list11.Count;++i)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = list11[i];
                list1.Add(list11[i]);
                if(list11.Count>k)
                {
                    dataGridView1.Rows[i].Cells[1].Value = list22[k];
                    list2.Add(list22[k]);
                    k++;
                }
                else
                {
                    k = k - list11.Count;
                    dataGridView1.Rows[i].Cells[1].Value = list22[k];
                    list2.Add(list22[k]);
                    k++;
                }
            }
        }
        private void button_Load_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            th.set_lang(land_list.SelectedIndex);
            Data();
        }

        private void button_Encode_Click(object sender, EventArgs e)
        {
            List<char> list11 = new List<char>();
            List<char> list22 = new List<char>();
            list11.AddRange(list1);
            list22.AddRange(list2);
            int n = richTextBox1.Text.Length;
            string str1,str2;
            str1 = richTextBox1.Text.ToLower();
            str2 = "";
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < list11.Count; ++j)
                {
                    if (list11[j] == str1[i])
                    {
                            str2 += list22[j];
                    }
                }
            }

            richTextBox2.Text = str2;
        }

        private void button_Decode_Click(object sender, EventArgs e)
        {
            List<char> list11 = new List<char>();
            List<char> list22 = new List<char>();
            list11.AddRange(list1);
            list22.AddRange(list2);
            int n = richTextBox2.Text.Length;
            string str1,str2;
            str1 = richTextBox2.Text.ToLower();
            str2 = "";
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < list11.Count; ++j)
                {
                    if (list22[j] == str1[i])
                    {
                        str2 += list11[j];
                    }
                }
            }

            richTextBox2.Text = str2;
        }

        private void Save_data_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder dataGrid = new StringBuilder();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGrid.AppendLine(Convert.ToString(dataGridView1.Rows[i].Cells[0].Value));
                    dataGrid.AppendLine(Convert.ToString(dataGridView1.Rows[i].Cells[1].Value));
                }
                File.WriteAllText(savedialog.FileName, dataGrid.ToString());
            }
        }

        private void Load_data_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            string line;
            int counter = 0;
            int counter1 = 0;
            int counter2 = 0;
            dataGridView1.Rows.Clear();
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(filedialog.FileName);
                while ((line = file.ReadLine()) != "" && line != null)
                {
                    if (counter % 2 == 0)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[counter1].Cells[0].Value = Convert.ToString(line);
                        counter1++;
                    }
                    else
                    {
                        dataGridView1.Rows[counter2].Cells[1].Value = Convert.ToString(line);
                        counter2++;
                    }
                    counter++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k = Convert.ToInt32(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<char> list11 = new List<char>();
            List<char> list22 = new List<char>();
            List<char> list33 = new List<char>();
            th.set_lang(land_list.SelectedIndex);
            list11.AddRange(list1);
            list22.AddRange(list2);
            list33.AddRange(th.Latter_mas);
            int n = richTextBox2.Text.Length;
            string str1, str2;
            str1 = richTextBox2.Text.ToLower();
            str2 = "";
            for (int i = 0; i < list33.Count; i++)
            {
                list33[i] = Convert.ToChar(dataGridView1.Rows[i].Cells[1].Value);
            }
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < list11.Count; ++j)
                {
                    if (list33[j] == str1[i])
                    {
                        str2 += list11[j];
                    }
                }
            }

            richTextBox2.Text = str2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<char> list11 = new List<char>();
            List<char> list22 = new List<char>();
            list11.AddRange(list1);
            list22.AddRange(list2);
            int n = richTextBox1.Text.Length;
            string str1, str2;
            str1 = richTextBox1.Text.ToLower();
            str2 = "";
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < list11.Count; ++j)
                {
                    if (list11[j] == str1[i])
                    {
                        str2 += list22[j];
                    }
                }
            }
            list11.AddRange(list1);
            list22.AddRange(list2);
            n = richTextBox2.Text.Length;
            str1 = richTextBox2.Text.ToLower();
            str2 = "";
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < list11.Count; ++j)
                {
                    if (list22[j] == str1[i])
                    {
                        str2 += list11[j];
                    }
                }
            }
            richTextBox2.Clear();
            richTextBox2.Text = str2;
        }

    }
}
