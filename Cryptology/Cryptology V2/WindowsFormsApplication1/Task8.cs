using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace WindowsFormsApplication1
{
    public partial class Task8 : Form
    {
        List<int> list = new List<int>();
        public Task8()
        {
            InitializeComponent();
        }
        bool Simple_number(int e)
        {
            int k = 0;
            for (int i = 2; i < e; i++)
            {
                if (e % i == 0)
                    k++;
            }
            if (k == 0)
                return true;
            else
                return false;
        }
        private int extended_evklid(int a, int b)
        {
            int q, r;
            while (b > 0)
            {
                q = a / b;
                r = a - q * b;
                a = b;
                b = r;
            }
            return a;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(textBox_p.Text);
            int q = Convert.ToInt32(textBox_q.Text);
            int N = p * q;
            textBox_N.Text = N.ToString();
            int Fi_n = (p - 1) * (q - 1);
            Random rand = new Random();
            bool t = false;
            int exp = rand.Next(1, Fi_n - 1);
            while (t == false)
            {
                if (extended_evklid(Fi_n, exp) == 1 && Simple_number(exp) == true)
                {
                    t = true;
                }
                else
                {
                    exp = rand.Next(1, Fi_n - 1);
                }
            }
            int d = 1;
            bool chek = false;
            while (chek == false)
            {
                if ((d * exp) % Fi_n == 1)
                {
                    chek = true;
                    break;
                }
                else
                    d++;
            }
            textBox_open.Text = exp.ToString();
            textBox_close.Text = d.ToString();

        }

        private void button_encode_Click(object sender, EventArgs e)
        {
            list.Clear();
            int exp = Convert.ToInt32(textBox_open.Text);
            int N = Convert.ToInt32(textBox_N.Text);
            string s = textBox_encode.Text;
            string s1 = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                int a = (int)BigInteger.ModPow(((int)s[i]), exp, N);
                list.Add(a);
                s1 += a.ToString() + " ";
            }

            textBox_encode.Text = s1;
        }

        private void button_decode_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(textBox_close.Text);
            int N = Convert.ToInt32(textBox_N.Text);
            string s = string.Empty;

            for (int i = 0; i < list.Count; i++)
            {
                s += (char)BigInteger.ModPow(list[i], d, N);
            }

            textBox_decode.Text = s;
        }
    }
}
