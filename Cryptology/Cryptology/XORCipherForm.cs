using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptology {

    public partial class XORCipherForm : Form {

        byte[] _kay;

        public XORCipherForm() {

            InitializeComponent();
        }

        private void codeButton_Click( object sender, EventArgs e ) {

            inputIsBytesRichTextBox.Clear();
            outputIsBytesRichTextBox.Clear();
            kayTextBox.Clear();
            outputRichTextBox.Clear();

            string inputText = inputRichTextBox.Text;

            byte[] inputTextInByte = Encoding.ASCII.GetBytes( inputText );

            _kay = GenereteKay( inputTextInByte.Length );

            byte[] criptoTextInByte = CodeDecode( inputTextInByte, _kay );


            foreach(var b in inputTextInByte) {

                inputIsBytesRichTextBox.Text += b;
            }
            foreach (var b in criptoTextInByte) {

                outputIsBytesRichTextBox.Text += b;
            }
            foreach (var b in criptoTextInByte) {

                outputRichTextBox.Text += (char)b;
            }
            foreach (var b in _kay) {

                kayTextBox.Text += b;
            }

        }

        private byte[] CodeDecode(byte[] input, byte[] kay ) {

            byte[] rezultTextInByte = new byte[input.Length];

            for (int i = 0; i < input.Length; i++) {

                rezultTextInByte[i] = (byte) (input[i] ^ kay[i]);
            }

            return rezultTextInByte;
        }

        private byte[] GenereteKay(int length ) {

            Random random = new Random();

            byte[] kay = new byte[length];

            for(int i = 0; i < length; i++) {

                kay[i] = (byte) random.Next( 0, 2 );
            }

            return kay;
        }

        private void decodeButton_Click( object sender, EventArgs e ) {

            if(_kay == null) {
                return;
            }

            outputRichTextBox.Clear();
            inputIsBytesRichTextBox.Clear();
            outputIsBytesRichTextBox.Clear();

            string inputText = inputRichTextBox.Text;

            byte[] inputTextInByte = Encoding.ASCII.GetBytes( inputText );

            byte[] decriptoTextInByte = CodeDecode( inputTextInByte, _kay );


            foreach (var b in inputTextInByte) {

                inputIsBytesRichTextBox.Text += b;
            }
            foreach (var b in decriptoTextInByte) {

                outputIsBytesRichTextBox.Text += b;
            }
            foreach (var b in decriptoTextInByte) {

                outputRichTextBox.Text += (char)b;
            }
        }

        private void openFileButton_Click( object sender, EventArgs e ) {

            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                inputRichTextBox.Clear();

                inputRichTextBox.LoadFile( openFileDialog.FileName, RichTextBoxStreamType.PlainText );
            }
        }

        private void saveFileButton_Click( object sender, EventArgs e ) {

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {

                File.WriteAllText( saveFileDialog.FileName, outputRichTextBox.Text, Encoding.UTF8 );
            }
        }
    }
}
