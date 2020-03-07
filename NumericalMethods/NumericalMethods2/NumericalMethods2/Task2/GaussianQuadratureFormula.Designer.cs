namespace NumericalMethods2.Task2
{
    partial class GaussianQuadratureFormula
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
            this.label7 = new System.Windows.Forms.Label();
            this.error_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.approxRez_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.exactRez_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.b_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Func_ComboBox = new System.Windows.Forms.ComboBox();
            this.a_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.m_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "похибка";
            // 
            // error_TextBox
            // 
            this.error_TextBox.Location = new System.Drawing.Point(180, 151);
            this.error_TextBox.Name = "error_TextBox";
            this.error_TextBox.Size = new System.Drawing.Size(162, 22);
            this.error_TextBox.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Наближений результат";
            // 
            // approxRez_TextBox
            // 
            this.approxRez_TextBox.Location = new System.Drawing.Point(177, 92);
            this.approxRez_TextBox.Name = "approxRez_TextBox";
            this.approxRez_TextBox.Size = new System.Drawing.Size(162, 22);
            this.approxRez_TextBox.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Точний результат";
            // 
            // exactRez_TextBox
            // 
            this.exactRez_TextBox.Location = new System.Drawing.Point(180, 32);
            this.exactRez_TextBox.Name = "exactRez_TextBox";
            this.exactRez_TextBox.Size = new System.Drawing.Size(162, 22);
            this.exactRez_TextBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Функція";
            // 
            // b_TextBox
            // 
            this.b_TextBox.Location = new System.Drawing.Point(35, 39);
            this.b_TextBox.Name = "b_TextBox";
            this.b_TextBox.Size = new System.Drawing.Size(100, 22);
            this.b_TextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "b";
            // 
            // Func_ComboBox
            // 
            this.Func_ComboBox.FormattingEnabled = true;
            this.Func_ComboBox.Location = new System.Drawing.Point(13, 112);
            this.Func_ComboBox.Name = "Func_ComboBox";
            this.Func_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Func_ComboBox.TabIndex = 4;
            this.Func_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Func_ComboBox_SelectedIndexChanged);
            // 
            // a_TextBox
            // 
            this.a_TextBox.Location = new System.Drawing.Point(35, 12);
            this.a_TextBox.Name = "a_TextBox";
            this.a_TextBox.Size = new System.Drawing.Size(100, 22);
            this.a_TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "a";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "порахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_TextBox
            // 
            this.m_TextBox.Location = new System.Drawing.Point(35, 67);
            this.m_TextBox.Name = "m_TextBox";
            this.m_TextBox.Size = new System.Drawing.Size(100, 22);
            this.m_TextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "m";
            // 
            // GaussianQuadratureFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 183);
            this.Controls.Add(this.m_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.error_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.approxRez_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exactRez_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Func_ComboBox);
            this.Controls.Add(this.a_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "GaussianQuadratureFormula";
            this.Text = "GaussianQuadratureFormula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox error_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox approxRez_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox exactRez_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox b_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Func_ComboBox;
        private System.Windows.Forms.TextBox a_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox m_TextBox;
        private System.Windows.Forms.Label label4;
    }
}