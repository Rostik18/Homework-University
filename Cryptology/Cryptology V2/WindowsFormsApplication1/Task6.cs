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
    public partial class Task6 : Form
    {
        public Task6()
        {
            InitializeComponent();
        }
        private void extended_evklid(int a, int b, out int x, out int y, out int d)
        {
            if (b == 0)
            {

                d = a;
                x = 1;
                y = 0;
                return;
            }
            int q, r, x1, x2, y1, y2;
            x2 = 1; x1 = 0; y2 = 0; y1 = 1;
            while (b > 0)
            {
                q = a / b;
                r = a - q * b;
                x = x2 - q * x1;
                y = y2 - q * y1;
                a = b;
                b = r;
                x2 = x1;
                x1 = x;
                y2 = y1;
                y1 = y;
            }
            d = a;
            x = x2;
            y = y2;
        }


        private void culc_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int x;
            int y;
            int d;
            extended_evklid(a, b, out x, out y, out d);
            textBox3.Text = x.ToString();
            textBox4.Text = y.ToString();
            textBox5.Text = d.ToString();
        }
    }
}
