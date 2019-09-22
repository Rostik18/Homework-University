using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace WindowsFormsApplication1
{
    public partial class Task7 : Form
    {
        public Task7()
        {
            InitializeComponent();
        }
        private void button19_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBox_xmodstep.Text = CalculateBinaryPower(Convert.ToInt32(textBox_x.Text), Convert.ToInt32(textBox_d.Text), Convert.ToInt32(textBox_n.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public long CalculateBinaryPower(long x, long d, long n)
        {
            textBox_x_d_step.Text = Math.Pow(x, d).ToString();
            string bin = Convert.ToString(d, 2);

            int len = bin.Length;

            bin = Reverse(bin);
            bin.ToCharArray();
            long z = 1;

            for (int i = 2; i <= len + 1; ++i)
            {
                if (bin[len - i + 1] == '0')
                    z = (z * z) % n;
                else
                {

                    z = (z * z * x) % n;
                }
            }
            return z;
        }

        public string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new String(chars);
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            textBox_Zn.Text = ChoiceZn(Convert.ToInt32(textBox_nn.Text)).ToString();
            textBox_ZNN.Text = ChoiceZns(Convert.ToInt32(textBox_nn.Text)).ToString();
        }

        public int ChoiceZn(int n)
        {
            int l = (int)Math.Log(n, 2);
            if (l == 0) l = 1;
            Random random = new Random();
            int x;
            do
            {
                x = random.Next((int)Math.Pow(2, l));
            } while (x >= n);

            return x;
        }

        public int ChoiceZns(int n)
        {
            Random rnd = new Random();
            int x;
            do
            {
                x = rnd.Next(1, n);
            } while (GCD(x, n) > 1);

            return x;
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            textBox_result.Text = FindJacobySymbol(Convert.ToInt32(textBox_xx.Text), Convert.ToInt32(textBox1.Text)).ToString();
        }

        public int FindJacobySymbol(int x, int n)
        {

            if (GCD(x, n) != 1)
                return 0;

            int r = 1;

            if (x < 0)
            {
                x = -x;
                if ((n % 4) == 3) r = -r;
            }
            int c;
            do
            {

                int t = 0;
                while ((x % 2) == 0)
                {
                    t++;
                    x /= 2;
                }
                if ((t % 2) == 1)
                {
                    if (((n % 8) == 3) || ((n % 8) == 5))
                        r = -r;
                }

                if (((x % 4) == 3) && ((n % 4) == 3))
                    r = -r;
                c = x;
                x = n % c;
                n = c;
            } while (x != 0);
            return r;
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            int n;
            int k;
            try
            {
                n = Convert.ToInt32(textBox_nst.Text);
                k = Convert.ToInt32(textBox_kst.Text);
                if (n < 3)
                {
                    MessageBox.Show("Помилка! N повинне буте більше, ніж 3!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    if (n % 2 == 0)
                    {
                        MessageBox.Show("Помилка! N мусить бути непарним !", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        textBox_resyltst.Text = PrimalityTest_SolovayShtrassen(n, k).ToString();
                    }



            }
            catch (Exception ex)
            {
                MessageBox.Show(" Помилка! " + ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public string PrimalityTest_SolovayShtrassen(int n, int k)
        {
            Random R = new Random();
            int a = 0;
            for (int i = 1; i <= k; ++i)
            {
                a = R.Next(2, n - 1);

                if (gcd(a, n) > 1) return "n - composite";

                if ((Math.Pow(a, (n - 1) / 2) % n) == (a / n)) return "n - composite";
            }
            double prob = 1 - Math.Pow(2, -k);
            return "n - prime with probability " + prob;
        }

        private int gcd(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        int I=0,a=0,b=0;
        public int GCD(int first, int second)
        {
            if (first == 0)
                throw new Exception("Перший аргумент 0");
            if (second == 0)
                throw new Exception("Другий аргумент 0");
            first = Math.Abs(first);
            second = Math.Abs(second);

            int r0, r1, a0, a1, b0, b1, i;
            r0 = first;
            r1 = second;
            a0 = b1 = 1;
            b0 = a1 = 0;
            i = 1;
            int a_next = 0, b_next = 0;
            int q = 0;
            while ((r0 % r1) != 0)
            {
                q = r0 / r1;
                a_next = a0 - q * a1;
                b_next = b0 - q * b1;
                int value = r0 % r1;

                r0 = r1; r1 = value;
                a0 = a1; a1 = a_next;
                b0 = b1; b1 = b_next;
                ++i;
            }
            I = i;
            if (r1 == first)
                a = 1;
            else
                a = a_next;
            if (r1 == second && r1 != first)
            {
                a = 1;
                b = -1;
            }
            else
                b = b_next;
            return r1;
        }

    }
}
