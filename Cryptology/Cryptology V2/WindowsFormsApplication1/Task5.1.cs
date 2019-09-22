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
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
        }

        string[] cipherText;
        string[] key;
        private string[] createKey(int length)
        {
            string[] key = new string[length];
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                key[i] = (Convert.ToString(rand.Next(97, 122), 2).PadLeft(15,'0'));
            }
            return key;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = richTextBox1.Text.ToLower();
            int length = text.Length;
            int[] number_presentation = new int[length];
            for (int i = 0; i < length; i++)
            {
                number_presentation[i] = (int)text[i];
            }
            string[] binary_type = new string[length];
            cipherText = new string[length];
            key = createKey(length);
            StringBuilder cipherLetter = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                binary_type[i] = Convert.ToString(number_presentation[i], 2);
                string binary_letter = binary_type[i];
                string binary_key_letter = key[i];
                for (int j = 0; j < binary_type[i].Length; j++)
                {
                    if (binary_letter[j] == binary_key_letter[j])
                        cipherLetter.Append('0');
                    else
                        cipherLetter.Append('1');
                }
                cipherText[i] = cipherLetter.ToString();
                cipherLetter.Clear();
            }
            for (int i = 0; i < length; i++)
            {
                string cipher_letter = cipherText[i];
                int power = cipher_letter.Length - 1;
                for (int j = 0; j < cipher_letter.Length; j++)
                {
                    number_presentation[i] += Convert.ToInt32(cipher_letter[j].ToString().PadLeft(15, '0')) * (int)Math.Pow(2, power);
                    power--;
                }
            }
            richTextBox1.Clear();
            StringBuilder normal_text = new StringBuilder();
            for (int i = 0; i < number_presentation.Length; i++)
            {
                normal_text.Append((char)number_presentation[i]);
            }
            richTextBox2.Text = normal_text.ToString();
            for (int i = 0; i < key.Length; i++)
            {
                richTextBox3.Text += key[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder cipherLetter = new StringBuilder();
            int length = cipherText.Length;
            string[] clear_binary_letter = new string[length];
            for (int i = 0; i < length; i++)
            {
                string binary_letter = cipherText[i];
                string binary_key_letter = key[i];
                for (int j = 0; j < cipherText[i].Length; j++)
                {
                    if (binary_letter[j] == binary_key_letter[j])
                        cipherLetter.Append('0');
                    else
                        cipherLetter.Append('1');
                }
                clear_binary_letter[i] = cipherLetter.ToString();
                cipherLetter.Clear();
            }
            double[] number_presentation = new double[length];
            for (int i = 0; i < length; i++)
            {
                string cipher_letter = clear_binary_letter[i];
                int power = cipher_letter.Length - 1;
                for (int j = 0; j < cipher_letter.Length; j++)
                {
                    number_presentation[i] += Convert.ToInt32(cipher_letter[j].ToString().PadLeft(15, '0')) * Math.Pow(2, power);
                    power--;
                }
            }
            richTextBox1.Clear();
            StringBuilder decipher_text = new StringBuilder();
            for (int i = 0; i < number_presentation.Length; i++)
            {
                decipher_text.Append((char)number_presentation[i]);
            }
            richTextBox1.Text = decipher_text.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string key_val = richTextBox3.Text;
            int q = 0;
            int count = 15;
            for (int j = 0; j < key.Length; j++)
            {
                key[j] = "";
                for ( q = 0; q < count; q++)
                {
                    key[j] += key_val[q];
                }
                q = count;
                count += 15;
            }
            StringBuilder cipherLetter = new StringBuilder();
            int length = cipherText.Length;
            string[] clear_binary_letter = new string[length];
            for (int i = 0; i < length; i++)
            {
                string binary_letter = cipherText[i];
                string binary_key_letter = key[i];
                for (int j = 0; j < cipherText[i].Length; j++)
                {
                    if (binary_letter[j] == binary_key_letter[j])
                        cipherLetter.Append('0');
                    else
                        cipherLetter.Append('1');
                }
                clear_binary_letter[i] = cipherLetter.ToString();
                cipherLetter.Clear();
            }
            double[] number_presentation = new double[length];
            for (int i = 0; i < length; i++)
            {
                string cipher_letter = clear_binary_letter[i];
                int power = cipher_letter.Length - 1;
                for (int j = 0; j < cipher_letter.Length; j++)
                {
                    number_presentation[i] += Convert.ToInt32(cipher_letter[j].ToString().PadLeft(15, '0')) * Math.Pow(2, power);
                    power--;
                }
            }
            richTextBox1.Clear();
            StringBuilder decipher_text = new StringBuilder();
            for (int i = 0; i < number_presentation.Length; i++)
            {
                decipher_text.Append((char)number_presentation[i]);
            }
            richTextBox1.Text = decipher_text.ToString();
            
        }
    }
}
