namespace BankApplication.Forms {
    partial class OpenUserCreditForm {
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
            this.currentAccountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.creditTypeComboBox = new System.Windows.Forms.ComboBox();
            this.startSumTextBox = new System.Windows.Forms.TextBox();
            this.openCreditButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentAccountLabel
            // 
            this.currentAccountLabel.AutoSize = true;
            this.currentAccountLabel.Location = new System.Drawing.Point(13, 13);
            this.currentAccountLabel.Name = "currentAccountLabel";
            this.currentAccountLabel.Size = new System.Drawing.Size(113, 17);
            this.currentAccountLabel.TabIndex = 0;
            this.currentAccountLabel.Text = "Current account:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Credit sum";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(9, 172);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 3;
            // 
            // creditTypeComboBox
            // 
            this.creditTypeComboBox.FormattingEnabled = true;
            this.creditTypeComboBox.Location = new System.Drawing.Point(12, 61);
            this.creditTypeComboBox.Name = "creditTypeComboBox";
            this.creditTypeComboBox.Size = new System.Drawing.Size(172, 24);
            this.creditTypeComboBox.TabIndex = 4;
            // 
            // startSumTextBox
            // 
            this.startSumTextBox.Location = new System.Drawing.Point(12, 109);
            this.startSumTextBox.Name = "startSumTextBox";
            this.startSumTextBox.Size = new System.Drawing.Size(172, 22);
            this.startSumTextBox.TabIndex = 5;
            // 
            // openCreditButton
            // 
            this.openCreditButton.Location = new System.Drawing.Point(53, 137);
            this.openCreditButton.Name = "openCreditButton";
            this.openCreditButton.Size = new System.Drawing.Size(92, 29);
            this.openCreditButton.TabIndex = 6;
            this.openCreditButton.Text = "Open";
            this.openCreditButton.UseVisualStyleBackColor = true;
            this.openCreditButton.Click += new System.EventHandler(this.openCreditButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select credit type";
            // 
            // OpenUserCreditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 236);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.openCreditButton);
            this.Controls.Add(this.startSumTextBox);
            this.Controls.Add(this.creditTypeComboBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentAccountLabel);
            this.Name = "OpenUserCreditForm";
            this.Text = "Open Credit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentAccountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ComboBox creditTypeComboBox;
        private System.Windows.Forms.TextBox startSumTextBox;
        private System.Windows.Forms.Button openCreditButton;
        private System.Windows.Forms.Label label4;
    }
}