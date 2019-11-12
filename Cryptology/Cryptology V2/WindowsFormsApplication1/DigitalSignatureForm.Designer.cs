namespace WindowsFormsApplication1
{
    partial class DigitalSignatureForm
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
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.docRichTextBox = new System.Windows.Forms.RichTextBox();
            this.generateRSAKeyButton = new System.Windows.Forms.Button();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openKeyTextBox = new System.Windows.Forms.TextBox();
            this.closeKeyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signDocButton = new System.Windows.Forms.Button();
            this.signTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.controlButton = new System.Windows.Forms.Button();
            this.rezLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "p";
            // 
            // pTextBox
            // 
            this.pTextBox.Location = new System.Drawing.Point(34, 6);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(134, 22);
            this.pTextBox.TabIndex = 1;
            // 
            // docRichTextBox
            // 
            this.docRichTextBox.Location = new System.Drawing.Point(189, 62);
            this.docRichTextBox.Name = "docRichTextBox";
            this.docRichTextBox.Size = new System.Drawing.Size(326, 129);
            this.docRichTextBox.TabIndex = 4;
            this.docRichTextBox.Text = "";
            // 
            // generateRSAKeyButton
            // 
            this.generateRSAKeyButton.Location = new System.Drawing.Point(15, 62);
            this.generateRSAKeyButton.Name = "generateRSAKeyButton";
            this.generateRSAKeyButton.Size = new System.Drawing.Size(153, 39);
            this.generateRSAKeyButton.TabIndex = 3;
            this.generateRSAKeyButton.Text = "задати ключ";
            this.generateRSAKeyButton.UseVisualStyleBackColor = true;
            this.generateRSAKeyButton.Click += new System.EventHandler(this.generateRSAKeyButton_Click);
            // 
            // qTextBox
            // 
            this.qTextBox.Location = new System.Drawing.Point(34, 34);
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.Size = new System.Drawing.Size(134, 22);
            this.qTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "відкритий ключ {n, e}";
            // 
            // openKeyTextBox
            // 
            this.openKeyTextBox.Location = new System.Drawing.Point(15, 124);
            this.openKeyTextBox.Name = "openKeyTextBox";
            this.openKeyTextBox.Size = new System.Drawing.Size(153, 22);
            this.openKeyTextBox.TabIndex = 7;
            // 
            // closeKeyTextBox
            // 
            this.closeKeyTextBox.Location = new System.Drawing.Point(15, 169);
            this.closeKeyTextBox.Name = "closeKeyTextBox";
            this.closeKeyTextBox.Size = new System.Drawing.Size(153, 22);
            this.closeKeyTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "закритий ключ {d, n}";
            // 
            // signDocButton
            // 
            this.signDocButton.Location = new System.Drawing.Point(189, 6);
            this.signDocButton.Name = "signDocButton";
            this.signDocButton.Size = new System.Drawing.Size(156, 33);
            this.signDocButton.TabIndex = 5;
            this.signDocButton.Text = "Підписати документ";
            this.signDocButton.UseVisualStyleBackColor = true;
            this.signDocButton.Click += new System.EventHandler(this.signDocButton_Click);
            // 
            // signTextBox
            // 
            this.signTextBox.Location = new System.Drawing.Point(81, 202);
            this.signTextBox.Name = "signTextBox";
            this.signTextBox.Size = new System.Drawing.Size(434, 22);
            this.signTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "підпис S";
            // 
            // controlButton
            // 
            this.controlButton.Location = new System.Drawing.Point(15, 230);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(153, 34);
            this.controlButton.TabIndex = 6;
            this.controlButton.Text = "перевірити підпис";
            this.controlButton.UseVisualStyleBackColor = true;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // rezLabel
            // 
            this.rezLabel.AutoSize = true;
            this.rezLabel.Location = new System.Drawing.Point(186, 239);
            this.rezLabel.Name = "rezLabel";
            this.rezLabel.Size = new System.Drawing.Size(0, 17);
            this.rezLabel.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "відкрити документ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DigitalSignatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rezLabel);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.signTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.signDocButton);
            this.Controls.Add(this.closeKeyTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.openKeyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.generateRSAKeyButton);
            this.Controls.Add(this.docRichTextBox);
            this.Controls.Add(this.pTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DigitalSignatureForm";
            this.Text = "DigitalSignatureForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.RichTextBox docRichTextBox;
        private System.Windows.Forms.Button generateRSAKeyButton;
        private System.Windows.Forms.TextBox qTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox openKeyTextBox;
        private System.Windows.Forms.TextBox closeKeyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signDocButton;
        private System.Windows.Forms.TextBox signTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.Label rezLabel;
        private System.Windows.Forms.Button button1;
    }
}