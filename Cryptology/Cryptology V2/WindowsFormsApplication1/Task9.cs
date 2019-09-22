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
    public partial class Task9 : Form
    {
        string text = "";
        int hh = 0;
        string qw = "";
        string m = "";
        public Task9()
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
        private int NSD(int a, int b)
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
            int P = Convert.ToInt32(textBox_P.Text);
            int G = Convert.ToInt32(textBox_G.Text);
            int X = Convert.ToInt32(textBox_X.Text);
            int a, b;
            m = textBox1.Text;
            text = m;
            textBox_key_open.Text = BigInteger.ModPow(G, X, P).ToString();
            Random rand = new Random();
            int K = rand.Next(2, P - 1);
            int H = Math.Abs((int)m.GetHashCode());
            H = H - (H-rand.Next(2,P-2));
            hh = H + (rand.Next(4, 20));
            textBox_H.Text = H.ToString();
            bool temp=false;
            while(temp!=true)
            {
                if (NSD(K, P - 1) == 1)
                    temp = true;
                else
                    K = rand.Next(2, P - 1);
            }
            a = (int)BigInteger.ModPow(G, K, P);
            temp = false;
            b=1;
            int ff = (X * a + K * b) % (P - 1);
            while (temp != true)
            {
                if (ff== H)
                    temp = true;
                else
                    b++;
                    ff=(X * a + K * b) % (P - 1);
            }
            textBox_key.Text = a.ToString();
            textBox_key2.Text = b.ToString();
        }

        private void Task9_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_text.Clear();
            int P = Convert.ToInt32(textBox_P.Text);
            int G = Convert.ToInt32(textBox_G.Text);
            int X = Convert.ToInt32(textBox_X.Text);
            int H = Convert.ToInt32(textBox_H.Text);
            int Y = Convert.ToInt32(textBox_key_open.Text);
            int a = Convert.ToInt32(textBox_key.Text);
            int b = Convert.ToInt32(textBox_key2.Text);
            int A1 = (int)(BigInteger.Remainder(BigInteger.Pow(Y, a) * BigInteger.Pow(a, b), P));
            int A2 = (int)BigInteger.ModPow(G, H, P);
            if ((A1 == A2)&&(qw==m))
            {
                textBox_text.Text += 1.ToString() + Environment.NewLine;
                textBox_text.Text += m;
            }
            else
            {
                textBox_text.Text += 0.ToString() + Environment.NewLine;
                //textBox_text.Text += hh.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            qw = textBox1.Text;
        }
    }
}
