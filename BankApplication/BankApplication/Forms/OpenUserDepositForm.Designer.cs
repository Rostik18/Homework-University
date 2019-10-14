namespace BankApplication.Forms {
    partial class OpenUserDepositForm {
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
            this.label4 = new System.Windows.Forms.Label();
            this.openCreditButton = new System.Windows.Forms.Button();
            this.startSumTextBox = new System.Windows.Forms.TextBox();
            this.depositTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.currentAccountLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select deposit type";
            // 
            // openCreditButton
            // 
            this.openCreditButton.Location = new System.Drawing.Point(52, 133);
            this.openCreditButton.Name = "openCreditButton";
            this.openCreditButton.Size = new System.Drawing.Size(92, 29);
            this.openCreditButton.TabIndex = 12;
            this.openCreditButton.Text = "Open";
            this.openCreditButton.UseVisualStyleBackColor = true;
            this.openCreditButton.Click += new System.EventHandler(this.OpenCreditButton_Click);
            // 
            // startSumTextBox
            // 
            this.startSumTextBox.Location = new System.Drawing.Point(11, 105);
            this.startSumTextBox.Name = "startSumTextBox";
            this.startSumTextBox.Size = new System.Drawing.Size(172, 22);
            this.startSumTextBox.TabIndex = 11;
            // 
            // depositTypeComboBox
            // 
            this.depositTypeComboBox.FormattingEnabled = true;
            this.depositTypeComboBox.Location = new System.Drawing.Point(11, 57);
            this.depositTypeComboBox.Name = "depositTypeComboBox";
            this.depositTypeComboBox.Size = new System.Drawing.Size(172, 24);
            this.depositTypeComboBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Deposit sum";
            // 
            // currentAccountLabel
            // 
            this.currentAccountLabel.AutoSize = true;
            this.currentAccountLabel.Location = new System.Drawing.Point(12, 9);
            this.currentAccountLabel.Name = "currentAccountLabel";
            this.currentAccountLabel.Size = new System.Drawing.Size(113, 17);
            this.currentAccountLabel.TabIndex = 8;
            this.currentAccountLabel.Text = "Current account:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 172);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 14;
            // 
            // OpenUserDepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 224);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.openCreditButton);
            this.Controls.Add(this.startSumTextBox);
            this.Controls.Add(this.depositTypeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentAccountLabel);
            this.Name = "OpenUserDepositForm";
            this.Text = "Open Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button openCreditButton;
        private System.Windows.Forms.TextBox startSumTextBox;
        private System.Windows.Forms.ComboBox depositTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentAccountLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}