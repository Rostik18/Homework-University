using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class Form1 : Form
    {

        Pen p1, p2, p3;
        Point center;
        Matrix m1, m2, m3;

        int h, m, s;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        float a1, a2, a3;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            
            center = new Point(0, 0);

            p1 = new Pen(Color.Red, 2);     //Секунди.
            p2 = new Pen(Color.Black, 8);   //Годиники.
            p3 = new Pen(Color.Gray, 4);    //Хвилини.


            m1 = new Matrix();
            m2 = new Matrix();
            m3 = new Matrix();

            GetTime();
            pictureBox1.Invalidate();
        }

        private void GetTime()
        {
            h = DateTime.Now.Hour;
            m = DateTime.Now.Minute;
            s = DateTime.Now.Second;

            a1 = s * 2;
            a2 = (float)(m *2 + s * 0.1);
            a3 = (float)(h * 30 + m * 0.5 + s * 0.5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetTime();
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int x = pictureBox1.Width / 2;
            int y = pictureBox1.Height / 2;
            center = new Point(x, y);

            m1.RotateAt(a1, center);
            g.Transform = m1; 
            g.DrawLine(p1, x, y, x + (float)0.19 * this.Width, y + (float)0.19 * this.Height);    //Секунди.
            m1.Reset();

            m2.RotateAt(a2, center);
            g.Transform = m2;
            g.DrawLine(p2, x, y, x + (float)0.15 * this.Width, y + (float)0.15 * this.Height);    //Годиники.
            m2.Reset();

            m3.RotateAt(a3, center);
            g.Transform = m3;
            g.DrawLine(p3, x, y, x + (float)0.2 * this.Width, y + (float)0.2 * this.Height);    //Хвилини.
            m3.Reset();
        }
    }
}
