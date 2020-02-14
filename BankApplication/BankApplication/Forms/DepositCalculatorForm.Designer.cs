namespace BankApplication.Forms {
    partial class DepositCalculatorForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.startSumTextBox = new System.Windows.Forms.TextBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.calculateButton = new System.Windows.Forms.Button();
            this.yearPersentTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rezultTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.finishDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorLabel = new System.Windows.Forms.Label();
            this.addMoneyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addMoneyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.recalculateButton = new System.Windows.Forms.Button();
            this.persentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start sum";
            // 
            // startSumTextBox
            // 
            this.startSumTextBox.Location = new System.Drawing.Point(16, 33);
            this.startSumTextBox.Name = "startSumTextBox";
            this.startSumTextBox.Size = new System.Drawing.Size(200, 22);
            this.startSumTextBox.TabIndex = 1;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(16, 127);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startDateTimePicker.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(16, 238);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(201, 38);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // yearPersentTextBox
            // 
            this.yearPersentTextBox.Location = new System.Drawing.Point(16, 82);
            this.yearPersentTextBox.Name = "yearPersentTextBox";
            this.yearPersentTextBox.Size = new System.Drawing.Size(200, 22);
            this.yearPersentTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "persent per year(%/year)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start date";
            // 
            // rezultTextBox
            // 
            this.rezultTextBox.Location = new System.Drawing.Point(17, 299);
            this.rezultTextBox.Name = "rezultTextBox";
            this.rezultTextBox.Size = new System.Drawing.Size(200, 22);
            this.rezultTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "rezult";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Finish date";
            // 
            // finishDateTimePicker
            // 
            this.finishDateTimePicker.Location = new System.Drawing.Point(16, 172);
            this.finishDateTimePicker.Name = "finishDateTimePicker";
            this.finishDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.finishDateTimePicker.TabIndex = 4;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(14, 335);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 13;
            // 
            // addMoneyTextBox
            // 
            this.addMoneyTextBox.Location = new System.Drawing.Point(241, 33);
            this.addMoneyTextBox.Name = "addMoneyTextBox";
            this.addMoneyTextBox.Size = new System.Drawing.Size(200, 22);
            this.addMoneyTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Add money to opened deposit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Date (between start and finish)";
            // 
            // addMoneyDateTimePicker
            // 
            this.addMoneyDateTimePicker.Location = new System.Drawing.Point(242, 82);
            this.addMoneyDateTimePicker.Name = "addMoneyDateTimePicker";
            this.addMoneyDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.addMoneyDateTimePicker.TabIndex = 8;
            // 
            // recalculateButton
            // 
            this.recalculateButton.Location = new System.Drawing.Point(242, 111);
            this.recalculateButton.Name = "recalculateButton";
            this.recalculateButton.Size = new System.Drawing.Size(201, 38);
            this.recalculateButton.TabIndex = 9;
            this.recalculateButton.Text = "Recalculate";
            this.recalculateButton.UseVisualStyleBackColor = true;
            this.recalculateButton.Click += new System.EventHandler(this.recalculateButton_Click);
            // 
            // persentTypeComboBox
            // 
            this.persentTypeComboBox.FormattingEnabled = true;
            this.persentTypeComboBox.Items.AddRange(new object[] {
            "simple",
            "complex"});
            this.persentTypeComboBox.Location = new System.Drawing.Point(17, 201);
            this.persentTypeComboBox.Name = "persentTypeComboBox";
            this.persentTypeComboBox.Size = new System.Drawing.Size(199, 24);
            this.persentTypeComboBox.TabIndex = 5;
            // 
            // DepositCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 362);
            this.Controls.Add(this.persentTypeComboBox);
            this.Controls.Add(this.recalculateButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addMoneyDateTimePicker);
            this.Controls.Add(this.addMoneyTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.finishDateTimePicker);
            this.Controls.Add(this.rezultTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearPersentTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.startSumTextBox);
            this.Controls.Add(this.label1);
            this.Name = "DepositCalculatorForm";
            this.Text = "DepositCalculatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startSumTextBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox yearPersentTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rezultTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker finishDateTimePicker;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox addMoneyTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker addMoneyDateTimePicker;
        private System.Windows.Forms.Button recalculateButton;
        private System.Windows.Forms.ComboBox persentTypeComboBox;
    }
}