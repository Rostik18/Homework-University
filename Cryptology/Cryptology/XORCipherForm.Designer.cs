namespace Cryptology {
    partial class XORCipherForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.decodeButton = new System.Windows.Forms.Button();
            this.codeButton = new System.Windows.Forms.Button();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.inputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.inputIsBytesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.outputIsBytesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.kayTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Результат";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Вхідний текст";
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(363, 200);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(119, 53);
            this.saveFileButton.TabIndex = 15;
            this.saveFileButton.Text = "Зберегти результат";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(363, 161);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(119, 33);
            this.openFileButton.TabIndex = 14;
            this.openFileButton.Text = "Відкрити текст";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(363, 80);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(119, 32);
            this.decodeButton.TabIndex = 13;
            this.decodeButton.Text = "Декодувати";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // codeButton
            // 
            this.codeButton.Location = new System.Drawing.Point(363, 40);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(119, 34);
            this.codeButton.TabIndex = 11;
            this.codeButton.Text = "Закодувати";
            this.codeButton.UseVisualStyleBackColor = true;
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Location = new System.Drawing.Point(488, 40);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(300, 280);
            this.outputRichTextBox.TabIndex = 10;
            this.outputRichTextBox.Text = "";
            // 
            // inputRichTextBox
            // 
            this.inputRichTextBox.Location = new System.Drawing.Point(12, 40);
            this.inputRichTextBox.Name = "inputRichTextBox";
            this.inputRichTextBox.Size = new System.Drawing.Size(345, 280);
            this.inputRichTextBox.TabIndex = 9;
            this.inputRichTextBox.Text = "";
            // 
            // inputIsBytesRichTextBox
            // 
            this.inputIsBytesRichTextBox.Location = new System.Drawing.Point(12, 326);
            this.inputIsBytesRichTextBox.Name = "inputIsBytesRichTextBox";
            this.inputIsBytesRichTextBox.Size = new System.Drawing.Size(345, 112);
            this.inputIsBytesRichTextBox.TabIndex = 18;
            this.inputIsBytesRichTextBox.Text = "";
            // 
            // outputIsBytesRichTextBox
            // 
            this.outputIsBytesRichTextBox.Location = new System.Drawing.Point(488, 326);
            this.outputIsBytesRichTextBox.Name = "outputIsBytesRichTextBox";
            this.outputIsBytesRichTextBox.Size = new System.Drawing.Size(300, 112);
            this.outputIsBytesRichTextBox.TabIndex = 19;
            this.outputIsBytesRichTextBox.Text = "";
            // 
            // kayTextBox
            // 
            this.kayTextBox.Location = new System.Drawing.Point(10, 444);
            this.kayTextBox.Name = "kayTextBox";
            this.kayTextBox.Size = new System.Drawing.Size(778, 22);
            this.kayTextBox.TabIndex = 20;
            // 
            // XORCipherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.kayTextBox);
            this.Controls.Add(this.outputIsBytesRichTextBox);
            this.Controls.Add(this.inputIsBytesRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.codeButton);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.inputRichTextBox);
            this.Name = "XORCipherForm";
            this.Text = "XORCipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.RichTextBox inputRichTextBox;
        private System.Windows.Forms.RichTextBox inputIsBytesRichTextBox;
        private System.Windows.Forms.RichTextBox outputIsBytesRichTextBox;
        private System.Windows.Forms.TextBox kayTextBox;
    }
}