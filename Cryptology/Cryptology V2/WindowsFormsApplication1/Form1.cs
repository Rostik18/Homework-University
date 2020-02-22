using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {

        TextHandler th = new TextHandler();
        int k;
        List<char> list1 = new List<char>();       //Таблиця ключі.
        List<char> list2 = new List<char>();       //Таблиця значення.

        public Form1() {

            InitializeComponent();
            lang_list1.SelectedItem = "Українська";
            lang_list2.SelectedItem = "Українська";
        }

        private void calc_btn_Click( object sender, EventArgs e ) {

            List<double> percent_mas = new List<double>();
            percent_mas.AddRange( th.calc( richTextBox1.Text ) );

            char[] latter = th.Latter_mas;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < latter.Length; i++) {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = latter[i];
                dataGridView1.Rows[i].Cells[1].Value = percent_mas[i];
            }
        }

        private void load_btn_Click( object sender, EventArgs e ) {

            OpenFileDialog filedialog = new OpenFileDialog {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            };
            if (filedialog.ShowDialog() == DialogResult.OK) {
                richTextBox1.Clear();
                string wqe = filedialog.FileName;
                richTextBox1.LoadFile( filedialog.FileName, RichTextBoxStreamType.PlainText );
            }

        }

        private void save_btn_Click( object sender, EventArgs e ) {

            SaveFileDialog savedialog = new SaveFileDialog();
            if (savedialog.ShowDialog() == DialogResult.OK) {
                StringBuilder dataGrid = new StringBuilder();
                for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                    dataGrid.AppendLine( Convert.ToString( dataGridView1.Rows[i].Cells[0].Value ) );
                    dataGrid.AppendLine( Convert.ToString( dataGridView1.Rows[i].Cells[1].Value ) );
                }
                File.WriteAllText( savedialog.FileName, dataGrid.ToString() );

            }
        }

        private void lang_list_SelectedIndexChanged( object sender, EventArgs e ) {
            th.set_lang( lang_list1.SelectedIndex );
        }

        private void datagrid_load_Click( object sender, EventArgs e ) {
            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            string line;
            int counter = 0;
            int counter1 = 0;
            int counter2 = 0;
            if (filedialog.ShowDialog() == DialogResult.OK) {
                StreamReader file = new StreamReader( filedialog.FileName );
                while ((line = file.ReadLine()) != "" && line != null) {
                    if (counter % 2 == 0) {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[counter1].Cells[0].Value = Convert.ToString( line );
                        counter1++;
                    } else {
                        dataGridView1.Rows[counter2].Cells[1].Value = Convert.ToDouble( line );
                        counter2++;
                    }
                    counter++;
                }
            }
        }

        private void aboutToolStripMenuItem_Click( object sender, EventArgs e ) {

            AboutAuthorForm aboutAuthorForm = new AboutAuthorForm();

            aboutAuthorForm.Show();
        }

        /// <summary>
        /// Program 2.
        /// </summary>
        void Data() {
            k = Convert.ToInt32( textBox1.Text );
            dataGridView2.Rows.Clear();
            List<char> list11 = new List<char>();        //Таблиця ключі.
            List<char> list22 = new List<char>();        //Таблиця значення.
            th.set_lang( lang_list2.SelectedIndex );
            list11.AddRange( th.Latter_mas );
            list22.AddRange( th.Latter_mas );
            for (int i = 0; i < list11.Count; ++i) {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = list11[i];
                list1.Add( list11[i] );
                if (list11.Count > k) {
                    dataGridView2.Rows[i].Cells[1].Value = list22[k];
                    list2.Add( list22[k] );
                    k++;
                } else {
                    k = k - list11.Count;
                    dataGridView2.Rows[i].Cells[1].Value = list22[k];
                    list2.Add( list22[k] );
                    k++;
                }
            }
        }

        private void button_Load_Click( object sender, EventArgs e ) {
            OpenFileDialog filedialog1 = new OpenFileDialog {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            };
            if (filedialog1.ShowDialog() == DialogResult.OK) {
                richTextBox3.Clear();
                string wqe = filedialog1.FileName;
                richTextBox3.LoadFile( filedialog1.FileName, RichTextBoxStreamType.PlainText );
            } else {
                MessageBox.Show( "Error" );
            }
        }

        private void comboBox1_SelectedIndexChanged( object sender, EventArgs e ) {
            th.set_lang( lang_list2.SelectedIndex );
            Data();
        }

        private void button_Encode_Click( object sender, EventArgs e ) {

            List<char> list11 = new List<char>();
            List<char> list22 = new List<char>();
            list11.AddRange( list1 );
            list22.AddRange( list2 );
            int n = richTextBox3.Text.Length;
            string str1, str2;
            str1 = richTextBox3.Text.ToLower();
            str2 = "";
            for (int i = 0; i < n; ++i) {
                for (int j = 0; j < list11.Count; ++j) {
                    if (list11[j] == str1[i]) {
                        str2 += list22[j];
                    }
                }
            }

            richTextBox2.Text = str2;
        }

        private void button_Decode_Click( object sender, EventArgs e ) {

            List<char> list11 = new List<char>();
            List<char> list22 = new List<char>();
            list11.AddRange( list1 );
            list22.AddRange( list2 );
            int n = richTextBox2.Text.Length;
            string str1, str2;
            str1 = richTextBox2.Text.ToLower();
            str2 = "";
            for (int i = 0; i < n; ++i) {
                for (int j = 0; j < list11.Count; ++j) {
                    if (list22[j] == str1[i]) {
                        str2 += list11[j];
                    }
                }
            }

            richTextBox2.Text = str2;
        }

        private void Save_data_Click( object sender, EventArgs e ) {

            SaveFileDialog savedialog = new SaveFileDialog();
            if (savedialog.ShowDialog() == DialogResult.OK) {
                StringBuilder dataGrid = new StringBuilder();
                for (int i = 0; i < dataGridView2.Rows.Count; i++) {
                    dataGrid.AppendLine( Convert.ToString( dataGridView2.Rows[i].Cells[0].Value ) );
                    dataGrid.AppendLine( Convert.ToString( dataGridView2.Rows[i].Cells[1].Value ) );
                }
                File.WriteAllText( savedialog.FileName, dataGrid.ToString() );
            }
        }

        private void Load_data_Click( object sender, EventArgs e ) {

            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            string line;
            int counter = 0;
            int counter1 = 0;
            int counter2 = 0;
            dataGridView2.Rows.Clear();
            if (filedialog.ShowDialog() == DialogResult.OK) {
                StreamReader file = new StreamReader( filedialog.FileName );
                while ((line = file.ReadLine()) != "" && line != null) {
                    if (counter % 2 == 0) {
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[counter1].Cells[0].Value = Convert.ToString( line );
                        counter1++;
                    } else {
                        dataGridView2.Rows[counter2].Cells[1].Value = Convert.ToString( line );
                        counter2++;
                    }
                    counter++;
                }
            }
        }

        private void button1_Click( object sender, EventArgs e ) {

            Data();
        }

        private void button2_Click( object sender, EventArgs e ) {
            List<char> list11 = new List<char>();
            List<char> list22 = new List<char>();
            List<char> list33 = new List<char>();
            th.set_lang( lang_list2.SelectedIndex );
            list11.AddRange( list1 );
            list22.AddRange( list2 );
            list33.AddRange( th.Latter_mas );
            int n = richTextBox2.Text.Length;
            string str1, str2;
            str1 = richTextBox2.Text.ToLower();
            str2 = "";
            for (int i = 0; i < list33.Count; i++) {
                list33[i] = Convert.ToChar( dataGridView2.Rows[i].Cells[1].Value );
            }
            for (int i = 0; i < n; ++i) {
                for (int j = 0; j < list11.Count; ++j) {
                    if (list33[j] == str1[i]) {
                        str2 += list11[j];
                    }
                }
            }

            richTextBox2.Text = str2;
        }

        private void button3_Click( object sender, EventArgs e ) {
            List<char> list11 = new List<char>();
            List<char> list22 = new List<char>();
            list11.AddRange( list1 );
            list22.AddRange( list2 );
            int n = richTextBox3.Text.Length;
            string str1, str2;
            str1 = richTextBox1.Text.ToLower();
            str2 = "";
            for (int i = 0; i < n; ++i) {
                for (int j = 0; j < list11.Count; ++j) {
                    if (list11[j] == str1[i]) {
                        str2 += list22[j];
                    }
                }
            }
            list11.AddRange( list1 );
            list22.AddRange( list2 );
            n = richTextBox2.Text.Length;
            str1 = richTextBox2.Text.ToLower();
            str2 = "";
            for (int i = 0; i < n; ++i) {
                for (int j = 0; j < list11.Count; ++j) {
                    if (list22[j] == str1[i]) {
                        str2 += list11[j];
                    }
                }
            }
            richTextBox2.Clear();
            richTextBox2.Text = str2;
        }

        private void button2_Click_1( object sender, EventArgs e ) {

            SaveFileDialog savedialog = new SaveFileDialog();
            if (savedialog.ShowDialog() == DialogResult.OK) {
                StringBuilder dataGrid = new StringBuilder();

                File.WriteAllText( savedialog.FileName, richTextBox2.Text );
            }
        }

        private void  button3_Click_1( object sender, EventArgs e ) {

            OpenFileDialog filedialog = new OpenFileDialog();
            filedialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (filedialog.ShowDialog() == DialogResult.OK) {
                StreamReader file = new StreamReader( filedialog.FileName );

                richTextBox2.Text =  file.ReadToEnd();
            }
        }

        private void button4_Click( object sender, EventArgs e ) {

            Task3 task = new Task3();

            task.ShowDialog();
        }

        private void button5_Click( object sender, EventArgs e ) {

            Task4 task = new Task4();

            task.ShowDialog();
        }

        private void button6_Click( object sender, EventArgs e ) {

            BinaryExaltation task = new BinaryExaltation();

            task.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Task7 task = new Task7();

            task.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Task8 task = new Task8();

            task.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DigitalSignatureForm task = new DigitalSignatureForm();

            task.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShamirForm shamirForm = new ShamirForm();

            shamirForm.ShowDialog();
        }
    }
}
