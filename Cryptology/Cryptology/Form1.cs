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

        Dictionary<char, double> _etalonFrequencyTable = new Dictionary<char, double>();

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

        private void QuantifyButton1_Click( object sender, EventArgs e ) {

            string allText = richTextBox1.Text.ToLower();

            var unnecessaryChars = new char[] { ' ', ',', '.', '"', '!', '?', '\n', '(', ')', '-', ':', '7',
                                                '1', '2', '3', '4', '5', '6', '\'', '8', '9', '0', ':', '—', ';' };

            var words = allText.Split( unnecessaryChars, StringSplitOptions.RemoveEmptyEntries );

            List<char> symbols = new List<char>();

            foreach (var word in words) {

                symbols.AddRange( word.ToCharArray() );
            }

            Dictionary<char, int> frequencyTable = new Dictionary<char, int>();

            foreach (var symbol in symbols) {

                if (frequencyTable.ContainsKey( symbol )) {

                    frequencyTable[symbol] += 1;
                } else {

                    frequencyTable.Add( symbol, 1 );
                }
            }

            dataGridView1.Rows.Clear();
            _etalonFrequencyTable.Clear();

            foreach (var keyValue in frequencyTable) {

                _etalonFrequencyTable.Add( keyValue.Key, (double)keyValue.Value / symbols.Count );
                dataGridView1.Rows.Add( keyValue.Key, $"{((double)keyValue.Value / symbols.Count):f4}" );
            }
        }

        //Зберегти еталонну таблицю.
        private void button1_Click( object sender, EventArgs e ) {

            if (_etalonFrequencyTable.Count == 0) {
                return;
            }

            string path = @"C:\Users\Ростик\Desktop\Homework-University\Cryptology\Cryptology\EtalonFrequencyTable.txt";

            using (StreamWriter streamWriter = new StreamWriter( path )) {

                foreach (var keyValue in _etalonFrequencyTable) {
                    streamWriter.WriteLine( keyValue.Key + " " + keyValue.Value );
                }
            }
        }
    }
}
