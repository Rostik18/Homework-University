
namespace RandomCoordinateDescent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startPointTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.gammaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aLimitTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bLimitTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Формула F = x^2 + y^4 + z^6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Початкове наближення x";
            // 
            // startPointTextBox
            // 
            this.startPointTextBox.Location = new System.Drawing.Point(13, 61);
            this.startPointTextBox.Name = "startPointTextBox";
            this.startPointTextBox.Size = new System.Drawing.Size(219, 22);
            this.startPointTextBox.TabIndex = 2;
            this.startPointTextBox.Text = "1 1 1";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(11, 227);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(219, 47);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Знайти arg min F";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.Location = new System.Drawing.Point(238, 9);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(550, 429);
            this.logTextBox.TabIndex = 4;
            this.logTextBox.Text = "";
            // 
            // gammaTextBox
            // 
            this.gammaTextBox.Location = new System.Drawing.Point(11, 199);
            this.gammaTextBox.Name = "gammaTextBox";
            this.gammaTextBox.Size = new System.Drawing.Size(219, 22);
            this.gammaTextBox.TabIndex = 6;
            this.gammaTextBox.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "константа Ліпшиця (gamma > 0)";
            // 
            // aLimitTextBox
            // 
            this.aLimitTextBox.Location = new System.Drawing.Point(13, 107);
            this.aLimitTextBox.Name = "aLimitTextBox";
            this.aLimitTextBox.Size = new System.Drawing.Size(219, 22);
            this.aLimitTextBox.TabIndex = 8;
            this.aLimitTextBox.Text = "-10 -10 -10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Обмеження a";
            // 
            // bLimitTextBox
            // 
            this.bLimitTextBox.Location = new System.Drawing.Point(13, 153);
            this.bLimitTextBox.Name = "bLimitTextBox";
            this.bLimitTextBox.Size = new System.Drawing.Size(219, 22);
            this.bLimitTextBox.TabIndex = 10;
            this.bLimitTextBox.Text = "10 10 10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Обмеження b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bLimitTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aLimitTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gammaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.startPointTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Випадковий покоординатний спуск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startPointTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.TextBox gammaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aLimitTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bLimitTextBox;
        private System.Windows.Forms.Label label5;
    }
}

