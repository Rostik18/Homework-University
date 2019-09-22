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
    public partial class Task4 : Form
    {
        string s_text,s_code;

        TextHandler th = new TextHandler();
        List<int> list_text = new List<int>();
        List<int> list_code = new List<int>();
        List<int> list_shyfr = new List<int>();
        List<char> list = new List<char>();
        public Task4()
        {
            InitializeComponent();
            comboBox2.SelectedItem = "Англійська";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            th.set_lang(comboBox2.SelectedIndex);
            list.AddRange(th.Latter_mas);
            s_code = comboBox1.Text.ToLower();
            s_text = richTextBox1.Text.ToLower();
            for (int j = 0; j < s_text.Length; ++j)
            {
                for (int i = 0; i < list.Count; ++i)
                {
                    if (s_text[j] == list[i])
                    {
                        s += s_text[j];
                        break;
                    }
                }
            }
            s_text = s;
        }

        private void button_Encode_Click(object sender, EventArgs e)
        {
            th.set_lang(comboBox2.SelectedIndex);
            list.AddRange(th.Latter_mas);
            for (int i = 0; i < s_text.Length; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (s_text[i] == list[j])
                    {
                        list_text.Add(j);
                        break;
                    }
                }
            }
            int k = 0;
            for (int i = 0; i < s_text.Length; i++)
            {
                for(int j=0;j<list.Count;j++)
                    {
                        if (k < s_code.Length)
                        {
                            if (s_code[k] == list[j])
                            {
                                list_code.Add(j);
                                break;
                            }
                        }
                        else
                        {
                            k = 0;
                            if (s_code[k] == list[j])
                            {
                                list_code.Add(j);
                                break;
                            }
                        }
                     }
                ++k;
            }
            string s="";
            for (int i = 0; i < s_text.Length; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (((list_text[i] + list_code[i]) % list.Count) == j)
                    {
                        list_shyfr.Add(j);
                        s += list[j];
                        break;
                    }
                }
            }
            richTextBox2.Text = s;
        }
        private void button_Decode_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            string s="";
            for (int i = 0; i < list_shyfr.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    int suma=(list_shyfr[i] - list_code[i] + list.Count) % list.Count;
                    if (suma == j)
                    {
                        s += list[j];
                        break;
                    }
                }
            }
            richTextBox1.Text = s;
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            th.set_lang(comboBox1.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
           SaveFileDialog savedialog = new SaveFileDialog();
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(savedialog.FileName, richTextBox2.Text);
            }
        }

    }
}
