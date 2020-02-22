namespace BankApplication.Forms {
    partial class AddCreditTypeForm {
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
            this.cteditTitleLabel = new System.Windows.Forms.Label();
            this.percentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.creditTitleTextBox = new System.Windows.Forms.TextBox();
            this.addCreditTypebutton = new System.Windows.Forms.Button();
            this.interestRoteLabel = new System.Windows.Forms.Label();
            this.interestRateTextBox = new System.Windows.Forms.TextBox();
            this.interestPeriodTextBox = new System.Windows.Forms.TextBox();
            this.interestPeriodLabel = new System.Windows.Forms.Label();
            this.persentTypeLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cteditTitleLabel
            // 
            this.cteditTitleLabel.AutoSize = true;
            this.cteditTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.cteditTitleLabel.Name = "cteditTitleLabel";
            this.cteditTitleLabel.Size = new System.Drawing.Size(75, 17);
            this.cteditTitleLabel.TabIndex = 0;
            this.cteditTitleLabel.Text = "Ctedit Title";
            // 
            // percentTypeComboBox
            // 
            this.percentTypeComboBox.FormattingEnabled = true;
            this.percentTypeComboBox.Location = new System.Drawing.Point(15, 167);
            this.percentTypeComboBox.Name = "percentTypeComboBox";
            this.percentTypeComboBox.Size = new System.Drawing.Size(150, 24);
            this.percentTypeComboBox.TabIndex = 1;
            // 
            // creditTitleTextBox
            // 
            this.creditTitleTextBox.Location = new System.Drawing.Point(15, 29);
            this.creditTitleTextBox.Name = "creditTitleTextBox";
            this.creditTitleTextBox.Size = new System.Drawing.Size(150, 22);
            this.creditTitleTextBox.TabIndex = 2;
            // 
            // addCreditTypebutton
            // 
            this.addCreditTypebutton.Location = new System.Drawing.Point(40, 197);
            this.addCreditTypebutton.Name = "addCreditTypebutton";
            this.addCreditTypebutton.Size = new System.Drawing.Size(92, 28);
            this.addCreditTypebutton.TabIndex = 3;
            this.addCreditTypebutton.Text = "Create";
            this.addCreditTypebutton.UseVisualStyleBackColor = true;
            this.addCreditTypebutton.Click += new System.EventHandler(this.AddCreditTypebutton_Click);
            // 
            // interestRoteLabel
            // 
            this.interestRoteLabel.AutoSize = true;
            this.interestRoteLabel.Location = new System.Drawing.Point(12, 54);
            this.interestRoteLabel.Name = "interestRoteLabel";
            this.interestRoteLabel.Size = new System.Drawing.Size(142, 17);
            this.interestRoteLabel.TabIndex = 4;
            this.interestRoteLabel.Text = "Interest rate (%/year)";
            // 
            // interestRateTextBox
            // 
            this.interestRateTextBox.Location = new System.Drawing.Point(15, 74);
            this.interestRateTextBox.Name = "interestRateTextBox";
            this.interestRateTextBox.Size = new System.Drawing.Size(150, 22);
            this.interestRateTextBox.TabIndex = 5;
            // 
            // interestPeriodTextBox
            // 
            this.interestPeriodTextBox.Location = new System.Drawing.Point(15, 122);
            this.interestPeriodTextBox.Name = "interestPeriodTextBox";
            this.interestPeriodTextBox.Size = new System.Drawing.Size(150, 22);
            this.interestPeriodTextBox.TabIndex = 7;
            // 
            // interestPeriodLabel
            // 
            this.interestPeriodLabel.AutoSize = true;
            this.interestPeriodLabel.Location = new System.Drawing.Point(12, 102);
            this.interestPeriodLabel.Name = "interestPeriodLabel";
            this.interestPeriodLabel.Size = new System.Drawing.Size(143, 17);
            this.interestPeriodLabel.TabIndex = 6;
            this.interestPeriodLabel.Text = "Interest period (days)";
            // 
            // persentTypeLabel
            // 
            this.persentTypeLabel.AutoSize = true;
            this.persentTypeLabel.Location = new System.Drawing.Point(12, 147);
            this.persentTypeLabel.Name = "persentTypeLabel";
            this.persentTypeLabel.Size = new System.Drawing.Size(88, 17);
            this.persentTypeLabel.TabIndex = 8;
            this.persentTypeLabel.Text = "Persent type";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 228);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 9;
            // 
            // AddCreditTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 273);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.persentTypeLabel);
            this.Controls.Add(this.interestPeriodTextBox);
            this.Controls.Add(this.interestPeriodLabel);
            this.Controls.Add(this.interestRateTextBox);
            this.Controls.Add(this.interestRoteLabel);
            this.Controls.Add(this.addCreditTypebutton);
            this.Controls.Add(this.creditTitleTextBox);
            this.Controls.Add(this.percentTypeComboBox);
            this.Controls.Add(this.cteditTitleLabel);
            this.Name = "AddCreditTypeForm";
            this.Text = "Add Credit Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cteditTitleLabel;
        private System.Windows.Forms.ComboBox percentTypeComboBox;
        private System.Windows.Forms.TextBox creditTitleTextBox;
        private System.Windows.Forms.Button addCreditTypebutton;
        private System.Windows.Forms.Label interestRoteLabel;
        private System.Windows.Forms.TextBox interestRateTextBox;
        private System.Windows.Forms.TextBox interestPeriodTextBox;
        private System.Windows.Forms.Label interestPeriodLabel;
        private System.Windows.Forms.Label persentTypeLabel;
        private System.Windows.Forms.Label errorLabel;
    }
}