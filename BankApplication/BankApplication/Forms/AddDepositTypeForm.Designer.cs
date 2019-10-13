namespace BankApplication.Forms {
    partial class AddDepositTypeForm {
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.persentTypeLabel = new System.Windows.Forms.Label();
            this.interestPeriodTextBox = new System.Windows.Forms.TextBox();
            this.interestPeriodLabel = new System.Windows.Forms.Label();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.interestRoteLabel = new System.Windows.Forms.Label();
            this.addCreditTypebutton = new System.Windows.Forms.Button();
            this.depositTitleTextBox = new System.Windows.Forms.TextBox();
            this.percentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.depositTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(9, 227);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 19;
            // 
            // persentTypeLabel
            // 
            this.persentTypeLabel.AutoSize = true;
            this.persentTypeLabel.Location = new System.Drawing.Point(9, 146);
            this.persentTypeLabel.Name = "persentTypeLabel";
            this.persentTypeLabel.Size = new System.Drawing.Size(88, 17);
            this.persentTypeLabel.TabIndex = 18;
            this.persentTypeLabel.Text = "Persent type";
            // 
            // interestPeriodTextBox
            // 
            this.interestPeriodTextBox.Location = new System.Drawing.Point(12, 121);
            this.interestPeriodTextBox.Name = "interestPeriodTextBox";
            this.interestPeriodTextBox.Size = new System.Drawing.Size(150, 22);
            this.interestPeriodTextBox.TabIndex = 3;
            // 
            // interestPeriodLabel
            // 
            this.interestPeriodLabel.AutoSize = true;
            this.interestPeriodLabel.Location = new System.Drawing.Point(9, 101);
            this.interestPeriodLabel.Name = "interestPeriodLabel";
            this.interestPeriodLabel.Size = new System.Drawing.Size(143, 17);
            this.interestPeriodLabel.TabIndex = 16;
            this.interestPeriodLabel.Text = "Interest period (days)";
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(12, 73);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(150, 22);
            this.interestRateTextBox.TabIndex = 2;
            // 
            // interestRoteLabel
            // 
            this.interestRoteLabel.AutoSize = true;
            this.interestRoteLabel.Location = new System.Drawing.Point(9, 53);
            this.interestRoteLabel.Name = "interestRoteLabel";
            this.interestRoteLabel.Size = new System.Drawing.Size(142, 17);
            this.interestRoteLabel.TabIndex = 14;
            this.interestRoteLabel.Text = "Interest rate (%/year)";
            // 
            // addCreditTypebutton
            // 
            this.addCreditTypebutton.Location = new System.Drawing.Point(37, 196);
            this.addCreditTypebutton.Name = "addCreditTypebutton";
            this.addCreditTypebutton.Size = new System.Drawing.Size(92, 28);
            this.addCreditTypebutton.TabIndex = 5;
            this.addCreditTypebutton.Text = "Create";
            this.addCreditTypebutton.UseVisualStyleBackColor = true;
            this.addCreditTypebutton.Click += new System.EventHandler(this.addCreditTypebutton_Click);
            // 
            // depositTitleTextBox
            // 
            this.depositTitleTextBox.Location = new System.Drawing.Point(12, 28);
            this.depositTitleTextBox.Name = "depositTitleTextBox";
            this.depositTitleTextBox.Size = new System.Drawing.Size(150, 22);
            this.depositTitleTextBox.TabIndex = 1;
            // 
            // percentTypeComboBox
            // 
            this.percentTypeComboBox.FormattingEnabled = true;
            this.percentTypeComboBox.Location = new System.Drawing.Point(12, 166);
            this.percentTypeComboBox.Name = "percentTypeComboBox";
            this.percentTypeComboBox.Size = new System.Drawing.Size(150, 24);
            this.percentTypeComboBox.TabIndex = 4;
            // 
            // depositTitleLabel
            // 
            this.depositTitleLabel.AutoSize = true;
            this.depositTitleLabel.Location = new System.Drawing.Point(9, 8);
            this.depositTitleLabel.Name = "depositTitleLabel";
            this.depositTitleLabel.Size = new System.Drawing.Size(87, 17);
            this.depositTitleLabel.TabIndex = 10;
            this.depositTitleLabel.Text = "Deposit Title";
            // 
            // AddDepositTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 268);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.persentTypeLabel);
            this.Controls.Add(this.interestPeriodTextBox);
            this.Controls.Add(this.interestPeriodLabel);
            this.Controls.Add(this.interestRateTextBox);
            this.Controls.Add(this.interestRoteLabel);
            this.Controls.Add(this.addCreditTypebutton);
            this.Controls.Add(this.depositTitleTextBox);
            this.Controls.Add(this.percentTypeComboBox);
            this.Controls.Add(this.depositTitleLabel);
            this.Name = "AddDepositTypeForm";
            this.Text = "Add Deposit Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label persentTypeLabel;
        private System.Windows.Forms.TextBox interestPeriodTextBox;
        private System.Windows.Forms.Label interestPeriodLabel;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.Label interestRoteLabel;
        private System.Windows.Forms.Button addCreditTypebutton;
        private System.Windows.Forms.TextBox depositTitleTextBox;
        private System.Windows.Forms.ComboBox percentTypeComboBox;
        private System.Windows.Forms.Label depositTitleLabel;
    }
}