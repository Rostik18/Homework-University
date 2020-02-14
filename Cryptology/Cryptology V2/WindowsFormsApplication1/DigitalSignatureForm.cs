using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class DigitalSignatureForm : Form
    {
        int n;
        int exp; //open key.
        double d; //close key.
        List<int> S; //digital signature.

        public DigitalSignatureForm()
        {
            InitializeComponent();

            signDocButton.Enabled = false;
            S = new List<int>();
        }

        private void generateRSAKeyButton_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(pTextBox.Text);
            int q = Convert.ToInt32(qTextBox.Text);

            n = p * q;
            int Fi_n = (p - 1) * (q - 1);
            Random rand = new Random();
            bool t = false;
            exp = rand.Next(1, Fi_n - 1);

            while (t == false)
            {
                if (ExtendedEvklid(Fi_n, exp) == 1 && IsNumberSimple(exp))
                {
                    t = true;
                }
                else
                {
                    exp = rand.Next(1, Fi_n - 1);
                }
            }

            double k = 0;

            while (true)
            {
                d = (k * Fi_n + 1) / exp;

                if (d == Math.Floor(d))
                {
                    break;
                }
                else
                {
                    k++;
                }
            }

            openKeyTextBox.Text = $"{{{n}, {exp}}}";
            closeKeyTextBox.Text = $"{{{d}, {n}}}";

            signDocButton.Enabled = true;
        }

        private void signDocButton_Click(object sender, EventArgs e)
        {
            S.Clear();

            foreach (var symb in docRichTextBox.Text)
            {
                S.Add((int)BigInteger.ModPow((int)symb, (int)d, n));
            }

            StringBuilder stringBuilder = new StringBuilder(S.Count);
            foreach (var letter in S)
            {
                stringBuilder.Append($"{letter} ");
            }

            signTextBox.Text = stringBuilder.ToString();
        }

        private int ExtendedEvklid(int a, int b)
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

        bool IsNumberSimple(int e)
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

        private void controlButton_Click(object sender, EventArgs e)
        {
            List<char> decodedSign = new List<char>();
            rezLabel.Text = String.Empty;

            foreach (var symb in S)
            {
                decodedSign.Add((char)BigInteger.ModPow(symb, exp, n));
            }

            if (decodedSign.Count != docRichTextBox.Text.Length)
            {
                rezLabel.Text = "Документ підроблено.";
                return;
            }

            for (int i = 0; i < decodedSign.Count; i++)
            {
                if (decodedSign[i] != docRichTextBox.Text[i])
                {
                    rezLabel.Text = "Документ підроблено.";
                    return;
                }
            }
            rezLabel.Text = "підпис вірний.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog filedialog = new OpenFileDialog
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            };
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                docRichTextBox.Clear();

                docRichTextBox.LoadFile(filedialog.FileName, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
