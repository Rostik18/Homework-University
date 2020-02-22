using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {

    public partial class BinaryExaltation : Form {

        public BinaryExaltation() {

            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e ) {

            long a, n;

            try {

                a = Convert.ToInt64( textBox1.Text );
                n = Convert.ToInt64( textBox2.Text );
            } catch {

                return;
            }

            textBox3.Text = string.Empty;

            string binary_n = string.Empty;

            while (n > 0) {
                binary_n += n % 2;        //Інвертований бінарний запис.
                n /= 2;
            }

            long Rez;

            if (binary_n[0] == '1') {
                Rez = a;
            } else {
                Rez = 1;
            }


            textBox3.Text = Rez.ToString();

            for (int i = 1; i < binary_n.Length; i++) {

                a = a * a;
                if (binary_n[i] == '1') {
                    textBox3.Text += (" * " + a);
                    Rez *= a;
                }

            }

            textBox3.Text += " = " + Rez;
        }

        private void button2_Click( object sender, EventArgs e ) {

            long a, b;

            try {

                a = Convert.ToInt64( textBox6.Text );
                b = Convert.ToInt64( textBox5.Text );
            } catch {

                return;
            }


            long inputed_A = a, inputed_B = b;

            long x1 = 1, y1 = 0, x2 = 0, y2 = 1;

            long r = a - b * (a / b);
            long x3 = x1 - x2 * (a / b);
            long y3 = y1 - y2 * (a / b);

            while (r > 0) {
                a = b;
                b = r;
                x1 = x2;
                x2 = x3;
                y1 = y2;
                y2 = y3;

                r = a - b * (a / b);
                x3 = x1 - x2 * (a / b);
                y3 = y1 - y2 * (a / b);
            }

            long NSD = b;
            long u = x2;
            long v = y2;

            textBox4.Text = NSD.ToString() + " = " + inputed_A + " * " + u + " + " + inputed_B + " * " + v;
        }
    }
}
