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
    public partial class Task10 : Form
    {
        List<int> x_lagrange = new List<int>();
        List<double> Fx_lagrange = new List<double>();
        List<int> x = new List<int>();
        List<double> F_x = new List<double>();
        public Task10()
        {
            InitializeComponent();
        }
        double Lagrang(List<int> X, List<double> Fx)
        {
            List<double> li = new List<double>();
            double L = 0;
            double temp = 1;
            int x = 0;
            for (int i = 0; i < X.Count; ++i)
            {
                temp = 1;
                for (int j = 0; j < X.Count; ++j)
                {
                    if (i != j)
                    {
                        temp *= (x-X[j]) / (X[i] - X[j]);
                    }

                }
                li.Add(Fx[i] * temp);
            }
            for (int i = 0; i < li.Count; ++i)
            {
                L += li[i];
            }
            return L;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<int> a = new List<int>();
            a.Add(Int32.Parse(textBox_s.Text));
            int n = Convert.ToInt32(textBox_n.Text);
            int p = Convert.ToInt32(textBox_p.Text);
            Random rand = new Random();
            //int k = rand.Next(2, n);
            int k = 3;
            for (int i = 1; i < k; i++)
            {
                a.Add(rand.Next(1, a[0]-1));
            }
            for (int i = 1; i <= n; ++i)
            {
                x.Add(i);
            }
            double sum = 0;
            textBox_polinom.Clear();
            for (int i = 0; i < n; ++i)
            {
                for (int j = k - 1; j >= 0; --j)
                {
                    sum += a[j] * Math.Pow(i+1, j);
                }
                F_x.Add(sum % p);
                sum = 0;
            }
            for (int i = 0; i < F_x.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = x[i];
                dataGridView1.Rows[i].Cells[1].Value = F_x[i];
            }
            double z = Lagrang(x, F_x) % p;
            textBox_polinom.Text += z.ToString();

        }
    }
}
