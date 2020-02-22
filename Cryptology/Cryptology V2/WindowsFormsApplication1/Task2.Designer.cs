namespace WindowsFormsApplication1
{
    partial class Task2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Encode = new System.Windows.Forms.Button();
            this.button_Decode = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.land_list = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Save_data = new System.Windows.Forms.Button();
            this.Load_data = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Encode
            // 
            this.button_Encode.Location = new System.Drawing.Point(16, 288);
            this.button_Encode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Encode.Name = "button_Encode";
            this.button_Encode.Size = new System.Drawing.Size(100, 28);
            this.button_Encode.TabIndex = 1;
            this.button_Encode.Text = "Закодувати";
            this.button_Encode.UseVisualStyleBackColor = true;
            this.button_Encode.Click += new System.EventHandler(this.button_Encode_Click);
            // 
            // button_Decode
            // 
            this.button_Decode.Location = new System.Drawing.Point(124, 288);
            this.button_Decode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Decode.Name = "button_Decode";
            this.button_Decode.Size = new System.Drawing.Size(100, 28);
            this.button_Decode.TabIndex = 2;
            this.button_Decode.Text = "Декодувати";
            this.button_Decode.UseVisualStyleBackColor = true;
            this.button_Decode.Click += new System.EventHandler(this.button_Decode_Click);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(232, 288);
            this.button_Load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(100, 28);
            this.button_Load.TabIndex = 3;
            this.button_Load.Text = "Завантажити текст";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.button_Load_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(327, 266);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ABC_1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ABC_2";
            this.Column2.Name = "Column2";
            // 
            // land_list
            // 
            this.land_list.FormattingEnabled = true;
            this.land_list.Items.AddRange(new object[] {
            "Англійська",
            "Українська",
            "Російська"});
            this.land_list.Location = new System.Drawing.Point(16, 420);
            this.land_list.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.land_list.Name = "land_list";
            this.land_list.Size = new System.Drawing.Size(156, 24);
            this.land_list.TabIndex = 5;
            this.land_list.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(351, 15);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox1.Size = new System.Drawing.Size(365, 198);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(351, 222);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox2.Size = new System.Drawing.Size(365, 223);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // Save_data
            // 
            this.Save_data.Location = new System.Drawing.Point(16, 324);
            this.Save_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save_data.Name = "Save_data";
            this.Save_data.Size = new System.Drawing.Size(100, 28);
            this.Save_data.TabIndex = 8;
            this.Save_data.Text = "Save_data";
            this.Save_data.UseVisualStyleBackColor = true;
            this.Save_data.Click += new System.EventHandler(this.Save_data_Click);
            // 
            // Load_data
            // 
            this.Load_data.Location = new System.Drawing.Point(124, 324);
            this.Load_data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Load_data.Name = "Load_data";
            this.Load_data.Size = new System.Drawing.Size(100, 28);
            this.Load_data.TabIndex = 9;
            this.Load_data.Text = "Load_data";
            this.Load_data.UseVisualStyleBackColor = true;
            this.Load_data.Click += new System.EventHandler(this.Load_data_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 420);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 384);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Задати ключ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 324);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Decode_2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 359);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 13;
            this.button3.Text = "Decode_3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 460);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Load_data);
            this.Controls.Add(this.Save_data);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.land_list);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Decode);
            this.Controls.Add(this.button_Encode);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Task2";
            this.Text = "Task2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Encode;
        private System.Windows.Forms.Button button_Decode;
        private System.Windows.Forms.Button button_Load;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox land_list;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button Save_data;
        private System.Windows.Forms.Button Load_data;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}