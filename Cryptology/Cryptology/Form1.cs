using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptology {
    public partial class Form1 : Form {
        public Form1() {

            InitializeComponent();
        }

        private void aboutProgramToolStripMenuItem_Click( object sender, EventArgs e ) {

            MessageBox.Show( "This is cryptographic software.", "About program" );
        }

        private void aboutToolStripMenuItem1_Click( object sender, EventArgs e ) {

            AboutAuthorForm aboutAuthorForm = new AboutAuthorForm();

            aboutAuthorForm.Show();
        }

        private void FromFileButton1_Click( object sender, EventArgs e ) {

            string path = @"C:\Users\Ростик\Desktop\Homework-University\Cryptology\Cryptology\StandardText.txt";

            using (StreamReader streamReader = new StreamReader( path )) {

                richTextBox1.Text = streamReader.ReadToEnd();
            }
        }
    }
}
