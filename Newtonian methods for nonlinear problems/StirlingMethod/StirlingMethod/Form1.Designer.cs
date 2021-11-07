
namespace StirlingMethod
{
    partial class Form1
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
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.x0TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Location = new System.Drawing.Point(194, 13);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(594, 425);
            this.logRichTextBox.TabIndex = 0;
            this.logRichTextBox.Text = "";
            // 
            // x0TextBox
            // 
            this.x0TextBox.Location = new System.Drawing.Point(16, 33);
            this.x0TextBox.Name = "x0TextBox";
            this.x0TextBox.Size = new System.Drawing.Size(161, 22);
            this.x0TextBox.TabIndex = 1;
            this.x0TextBox.Text = "1 1 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Початвоке наближення";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(16, 64);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(161, 36);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Обчислити";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x0TextBox);
            this.Controls.Add(this.logRichTextBox);
            this.Name = "Form1";
            this.Text = "Метод Стірлінга";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.TextBox x0TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateButton;
    }
}

