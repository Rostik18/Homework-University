namespace BankApplication.Forms {
    partial class AddAccountForm {
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
            this.currensyComboBox = new System.Windows.Forms.ComboBox();
            this.currencyLabel = new System.Windows.Forms.Label();
            this.startSumTextBox = new System.Windows.Forms.TextBox();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.moneyCountLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currensyComboBox
            // 
            this.currensyComboBox.FormattingEnabled = true;
            this.currensyComboBox.Location = new System.Drawing.Point(15, 29);
            this.currensyComboBox.Name = "currensyComboBox";
            this.currensyComboBox.Size = new System.Drawing.Size(150, 24);
            this.currensyComboBox.TabIndex = 0;
            // 
            // currencyLabel
            // 
            this.currencyLabel.AutoSize = true;
            this.currencyLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.currencyLabel.Location = new System.Drawing.Point(12, 9);
            this.currencyLabel.Name = "currencyLabel";
            this.currencyLabel.Size = new System.Drawing.Size(65, 17);
            this.currencyLabel.TabIndex = 1;
            this.currencyLabel.Text = "Currency";
            // 
            // startSumTextBox
            // 
            this.startSumTextBox.Location = new System.Drawing.Point(15, 76);
            this.startSumTextBox.Name = "startSumTextBox";
            this.startSumTextBox.Size = new System.Drawing.Size(150, 22);
            this.startSumTextBox.TabIndex = 2;
            // 
            // addAccountButton
            // 
            this.addAccountButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addAccountButton.Location = new System.Drawing.Point(43, 104);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(100, 25);
            this.addAccountButton.TabIndex = 3;
            this.addAccountButton.Text = "Create";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click);
            // 
            // moneyCountLabel
            // 
            this.moneyCountLabel.AutoSize = true;
            this.moneyCountLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.moneyCountLabel.Location = new System.Drawing.Point(12, 56);
            this.moneyCountLabel.Name = "moneyCountLabel";
            this.moneyCountLabel.Size = new System.Drawing.Size(68, 17);
            this.moneyCountLabel.TabIndex = 4;
            this.moneyCountLabel.Text = "Start sum";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.errorLabel.Location = new System.Drawing.Point(12, 144);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 5;
            // 
            // AddAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 203);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.moneyCountLabel);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.startSumTextBox);
            this.Controls.Add(this.currencyLabel);
            this.Controls.Add(this.currensyComboBox);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "AddAccountForm";
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currensyComboBox;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.TextBox startSumTextBox;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.Label moneyCountLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}