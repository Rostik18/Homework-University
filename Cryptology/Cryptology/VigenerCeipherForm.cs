using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Cryptology {

    public partial class VigenerCeipherForm : Form {

        public VigenerCeipherForm() {

            InitializeComponent();
        }

        private void codeButton_Click( object sender, EventArgs e ) {


            var cipher = new VigenereCipher( "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ" );

            string kay, inputText;

            try {

                kay = kayTextBox.Text.ToUpper();
                inputText = inputRichTextBox.Text.ToUpper();
            } catch {

                return;
            }

            outputRichTextBox.Text = cipher.Encrypt( inputText, kay );
        }

        private void decodeButton_Click( object sender, EventArgs e ) {

            var cipher = new VigenereCipher( "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ" );

            string kay, inputText;

            try {

                kay = kayTextBox.Text.ToUpper();
                inputText = inputRichTextBox.Text.ToUpper();
            } catch {

                return;
            }

            outputRichTextBox.Text = cipher.Decrypt( inputText, kay );
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

    public class VigenereCipher {
        const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        readonly string letters;

        public VigenereCipher( string alphabet = null ) {
            letters = string.IsNullOrEmpty( alphabet ) ? defaultAlphabet : alphabet;
        }

        //генерування повторюваного пароля
        private string GetRepeatKey( string s, int n ) {
            var p = s;
            while (p.Length < n) {
                p += p;
            }

            return p.Substring( 0, n );
        }

        private string Vigenere( string text, string password, bool encrypting = true ) {
            var gamma = GetRepeatKey( password, text.Length );
            var retValue = "";
            var q = letters.Length;

            for (int i = 0; i < text.Length; i++) {
                var letterIndex = letters.IndexOf( text[i] );
                var codeIndex = letters.IndexOf( gamma[i] );
                if (letterIndex < 0) {
                    //якщо літера не знайдена, додаємо її в незмінному вигляді
                    retValue += text[i].ToString();
                } else {
                    retValue += letters[(q + letterIndex + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
                }
            }

            return retValue;
        }

        //шифрування тексту
        public string Encrypt( string plainMessage, string password )
            => Vigenere( plainMessage, password );

        //дешифрування тексту
        public string Decrypt( string encryptedMessage, string password )
            => Vigenere( encryptedMessage, password, false );
    }
}
