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

namespace Questionnaire
{
    public partial class Form1 : Form
    {
        private int numbOfPage;
        bool[] quests;

        public Form1()
        {
            InitializeComponent();

            numbOfPage = 0;
            quests = new bool[11];
            for (int i = 0; i < quests.Length; i++)
            {
                quests[i] = false;
            }
            quests[9] = true;
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt";
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = 11;
            toolStripProgressBar1.Step = 1;
        }

        //кнопка назад
        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;

            tabControl1.SelectedIndex = --numbOfPage;

            if (numbOfPage == 0)
                button1.Enabled = false;
            tabControl1_Click(sender, e);
        }
        //кнопка вперід
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;

            tabControl1.SelectedIndex = ++numbOfPage;

            if (numbOfPage == 2)
                button2.Enabled = false;
            tabControl1_Click(sender, e);
        }
        //кнопка збереження
        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            //збереження в лог
            string logPath = @"C:\Users\Ростик\source\repos\Questionnaire\Questionnaire\Log.txt";
            string text = richTextBox1.Text + "-------------------\n";
            using (StreamWriter sw = new StreamWriter(logPath, true))
            {
                sw.Write(text);
            }
            //збереження в діалоговому вікні
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
            SaveLabel.Text = "Анкету збережено у файл.";
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tab = (TabControl)sender;

            if (tab == null)
                return;

            numbOfPage = tab.SelectedIndex;
            if (numbOfPage == 2)
            {
                button2.Enabled = false;
                button1.Enabled = true;
            }
            if (numbOfPage == 0)
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
            if (numbOfPage == 1)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string surName = textBox2.Text;
            DateTime bd = dateTimePicker1.Value;
            string sex = "Невизначено";
            if (radioButton1.Checked == true)
                sex = "Чоловіча";
            else if (radioButton2.Checked == true)
                sex = "Жіноча";
            string nationality = textBox7.Text;
            string phoneNamb = textBox3.Text;
            string email = textBox4.Text;
            string adress = textBox5.Text;
            string education;
            try
            {
                education = comboBox1.SelectedItem.ToString();
            }
            catch
            {
                education = "Не вказано";
            }
            string languages = GetLanguages();
            string about = textBox6.Text;

            richTextBox1.Text =
                "Ім'я: " + name + " " + surName + "\n" +
                "Дата народження: " + bd.ToShortDateString() + "\n" +
                "Стать: " + sex + "\n" +
                "Національність: " + nationality + "\n" +
                "Номер телефону: " + phoneNamb + "\n" +
                "Email: " + email + "\n" +
                "Домашня адреса: " + adress + "\n" +
                "Освіта: " + education + "\n" +
                "Мови: " + languages + "\n" +
                "Про себе: " + about + "\n";
        }
        private string GetLanguages()
        {
            string rez = "";
            if (checkBox1.Checked)
                rez += checkBox1.Text + " ";
            if (checkBox2.Checked)
                rez += checkBox2.Text + " ";
            if (checkBox3.Checked)
                rez += checkBox3.Text + " ";
            if (checkBox4.Checked)
                rez += checkBox4.Text + " ";
            if (checkBox5.Checked)
                rez += checkBox5.Text + " ";
            if (checkBox6.Checked)
                rez += checkBox6.Text + " ";
            if (checkBox7.Checked)
                rez += checkBox7.Text + " ";
            if (checkBox8.Checked)
                rez += checkBox8.Text + " ";
            if (checkBox9.Checked)
                rez += checkBox9.Text + " ";
            if (checkBox10.Checked)
                rez += checkBox10.Text + " ";
            if (checkBox11.Checked)
                rez += checkBox11.Text + " ";
            return rez;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                quests[0] = true;
            else quests[0] = false;
            ChangeProgresBar();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                quests[1] = true;
            else quests[1] = false;
            ChangeProgresBar();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != DateTime.Now)
                quests[2] = true;
            else quests[2] = false;
            ChangeProgresBar();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked)
                quests[3] = true;
            else quests[3] = false;
            ChangeProgresBar();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
                quests[4] = true;
            else quests[4] = false;
            ChangeProgresBar();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
                quests[5] = true;
            else quests[5] = false;
            ChangeProgresBar();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
                quests[6] = true;
            else quests[6] = false;
            ChangeProgresBar();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
                quests[7] = true;
            else quests[7] = false;
            ChangeProgresBar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
                quests[8] = true;
            else quests[8] = false;
            ChangeProgresBar();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked ||
                checkBox4.Checked || checkBox5.Checked || checkBox6.Checked ||
                checkBox7.Checked || checkBox8.Checked || checkBox9.Checked ||
                checkBox10.Checked || checkBox11.Checked)
                quests[9] = true;
            else quests[9] = false;
            ChangeProgresBar();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
                quests[10] = true;
            else quests[10] = false;
            ChangeProgresBar();
        }
        private void ChangeProgresBar()
        {
            //quests[9] = true;
            int countOfTrueQuests = 0;
            for (int i = 0; i < quests.Length; i++)
            {
                if (quests[i] == true)
                    countOfTrueQuests++;
            }
            toolStripProgressBar1.Value = countOfTrueQuests;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToShortDateString();
            toolStripStatusLabel2.Text = time;
            ChangeProgresBar();
        }
    }
}
