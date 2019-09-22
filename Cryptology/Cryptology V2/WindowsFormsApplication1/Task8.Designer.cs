namespace WindowsFormsApplication1
{
    partial class Task8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_q = new System.Windows.Forms.TextBox();
            this.textBox_open = new System.Windows.Forms.TextBox();
            this.textBox_close = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.textBox_encode = new System.Windows.Forms.TextBox();
            this.button_encode = new System.Windows.Forms.Button();
            this.textBox_decode = new System.Windows.Forms.TextBox();
            this.button_decode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "p=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "q=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Відкритий ключ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Закритий ключ";
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(37, 6);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(35, 20);
            this.textBox_p.TabIndex = 4;
            // 
            // textBox_q
            // 
            this.textBox_q.Location = new System.Drawing.Point(113, 6);
            this.textBox_q.Name = "textBox_q";
            this.textBox_q.Size = new System.Drawing.Size(39, 20);
            this.textBox_q.TabIndex = 5;
            // 
            // textBox_open
            // 
            this.textBox_open.Location = new System.Drawing.Point(101, 42);
            this.textBox_open.Name = "textBox_open";
            this.textBox_open.Size = new System.Drawing.Size(73, 20);
            this.textBox_open.TabIndex = 6;
            // 
            // textBox_close
            // 
            this.textBox_close.Location = new System.Drawing.Point(276, 39);
            this.textBox_close.Name = "textBox_close";
            this.textBox_close.Size = new System.Drawing.Size(73, 20);
            this.textBox_close.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Порахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "N=";
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(276, 6);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(39, 20);
            this.textBox_N.TabIndex = 10;
            // 
            // textBox_encode
            // 
            this.textBox_encode.Location = new System.Drawing.Point(15, 113);
            this.textBox_encode.Multiline = true;
            this.textBox_encode.Name = "textBox_encode";
            this.textBox_encode.Size = new System.Drawing.Size(168, 158);
            this.textBox_encode.TabIndex = 11;
            // 
            // button_encode
            // 
            this.button_encode.Location = new System.Drawing.Point(15, 85);
            this.button_encode.Name = "button_encode";
            this.button_encode.Size = new System.Drawing.Size(92, 22);
            this.button_encode.TabIndex = 12;
            this.button_encode.Text = "Зашифрувати";
            this.button_encode.UseVisualStyleBackColor = true;
            this.button_encode.Click += new System.EventHandler(this.button_encode_Click);
            // 
            // textBox_decode
            // 
            this.textBox_decode.Location = new System.Drawing.Point(195, 113);
            this.textBox_decode.Multiline = true;
            this.textBox_decode.Name = "textBox_decode";
            this.textBox_decode.Size = new System.Drawing.Size(168, 158);
            this.textBox_decode.TabIndex = 13;
            // 
            // button_decode
            // 
            this.button_decode.Location = new System.Drawing.Point(195, 85);
            this.button_decode.Name = "button_decode";
            this.button_decode.Size = new System.Drawing.Size(90, 22);
            this.button_decode.TabIndex = 14;
            this.button_decode.Text = "Розшифрувати";
            this.button_decode.UseVisualStyleBackColor = true;
            this.button_decode.Click += new System.EventHandler(this.button_decode_Click);
            // 
            // Task8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 283);
            this.Controls.Add(this.button_decode);
            this.Controls.Add(this.textBox_decode);
            this.Controls.Add(this.button_encode);
            this.Controls.Add(this.textBox_encode);
            this.Controls.Add(this.textBox_N);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_close);
            this.Controls.Add(this.textBox_open);
            this.Controls.Add(this.textBox_q);
            this.Controls.Add(this.textBox_p);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Task8";
            this.Text = "Task8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.TextBox textBox_q;
        private System.Windows.Forms.TextBox textBox_open;
        private System.Windows.Forms.TextBox textBox_close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.TextBox textBox_encode;
        private System.Windows.Forms.Button button_encode;
        private System.Windows.Forms.TextBox textBox_decode;
        private System.Windows.Forms.Button button_decode;
    }
}