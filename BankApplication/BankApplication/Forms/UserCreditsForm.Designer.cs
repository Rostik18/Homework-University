namespace BankApplication.Forms {
    partial class UserCreditsForm {
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
            this.moneyReturnButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.payOffSymTextBox = new System.Windows.Forms.TextBox();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.userCreditsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.userCreditsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // moneyReturnButton
            // 
            this.moneyReturnButton.Location = new System.Drawing.Point(418, 65);
            this.moneyReturnButton.Name = "moneyReturnButton";
            this.moneyReturnButton.Size = new System.Drawing.Size(158, 30);
            this.moneyReturnButton.TabIndex = 11;
            this.moneyReturnButton.Text = "Return the money";
            this.moneyReturnButton.UseVisualStyleBackColor = true;
            this.moneyReturnButton.Click += new System.EventHandler(this.MoneyReturnButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(9, 240);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 10;
            // 
            // payOffSymTextBox
            // 
            this.payOffSymTextBox.Location = new System.Drawing.Point(418, 37);
            this.payOffSymTextBox.Name = "payOffSymTextBox";
            this.payOffSymTextBox.Size = new System.Drawing.Size(158, 22);
            this.payOffSymTextBox.TabIndex = 8;
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Location = new System.Drawing.Point(9, 7);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(93, 17);
            this.currentUserLabel.TabIndex = 7;
            this.currentUserLabel.Text = "Current User:";
            // 
            // userCreditsDataGridView
            // 
            this.userCreditsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userCreditsDataGridView.Location = new System.Drawing.Point(12, 37);
            this.userCreditsDataGridView.Name = "userCreditsDataGridView";
            this.userCreditsDataGridView.RowTemplate.Height = 24;
            this.userCreditsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userCreditsDataGridView.Size = new System.Drawing.Size(400, 200);
            this.userCreditsDataGridView.TabIndex = 6;
            // 
            // UserCreditsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 295);
            this.Controls.Add(this.moneyReturnButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.payOffSymTextBox);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.userCreditsDataGridView);
            this.Name = "UserCreditsForm";
            this.Text = "UserCreditsForm";
            this.Load += new System.EventHandler(this.UserCreditsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userCreditsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moneyReturnButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox payOffSymTextBox;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.DataGridView userCreditsDataGridView;
    }
}