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
    public partial class Task11 : Form
    {
        public Task11()
        {
            InitializeComponent();
        }
        long[] fj;
        long[] aj;
        long _p;

        public long LagrangeInterpolation(long[] f, List<int> j, long p, double x = 0.0)
        {
            double result = 0;
            double Li = 1.0;
            int parts = j.Count;
            for (int m = 0; m < parts; ++m)
            {
                Li = 1.0;
                for (int i = 0; i < parts; ++i)
                {
                    if (i != m)
                    {
                        Li *= (x - j[i]) / (j[m] - j[i]);
                    }
                }
                //Li %= _p;
                result += f[j[m]] * Li;
            }
            long res = Convert.ToInt64(result);
            //result %= p;
            res %= p;
            return res;//result;
        }
        public void SplitSecret(long s, long n, long k)
        {
            aj = new long[k];
            aj[0] = s;
            //TODO p > n, p > k
            _p = Convert.ToInt64(textBox_p.Text);

            Random Rand = new Random();
            for (int i = 1; i < k; ++i)
            {
                aj[i] = Rand.Next(0, 100);
            }

            fj = new long[n + 1];
            fj[0] = s;

            for (int j = 1; j < fj.Length; ++j)
            {
                fj[j] = CalculateFj(j, k, _p);// % _p;
            }
        }
        public long CalculateFj(int j, long k, long p)
        {
            long f = 0;
            for (int i = 0; i < k; ++i)
            {
                f += aj[i] * BinaryPower(j, i);
            }
            f %= p;
            return f;
        }
        public long BinaryPower(long a, long n)
        {
            if (n == 0)
                return 1;
            if (n % 2 == 1)
                return BinaryPower(a, n - 1) * a;
            else
            {
                long b = BinaryPower(a, n / 2);
                return b * b;
            }
        }
        long secret, _n, _k;
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                secret = long.Parse(textBox_s.Text);
                _n = long.Parse(textBox_n.Text);
                _k = long.Parse(textBox_k.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SplitSecret(secret, _n, _k);
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add((int)_n);
            int ii;
            for (int i = 0; i < dataGridView1.RowCount - 1; ++i)
            {
                ii = i + 1;
                dataGridView1.Rows[i].Cells[0].Value = ii;
                dataGridView1.Rows[i].Cells[1].Value = fj[ii];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                fj[i] = int.Parse(dataGridView1.Rows[i - 1].Cells[1].Value.ToString());
            }
            List<int> ind = new List<int>();//[num_selected];

            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1[j, i].Selected)
                        ind.Add(i + 1);
                }
            long restored = LagrangeInterpolation(fj, ind, _p);

            textBox_finish.Text = restored.ToString();
        }
    }
}
