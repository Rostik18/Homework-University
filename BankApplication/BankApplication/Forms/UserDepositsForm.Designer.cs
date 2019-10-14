namespace BankApplication.Forms {
    partial class UserDepositsForm {
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
            this.userCreditsDataGridView = new System.Windows.Forms.DataGridView();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.addSymTextBox = new System.Windows.Forms.TextBox();
            this.putMoneyButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.moneyRetutnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userCreditsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userCreditsDataGridView
            // 
            this.userCreditsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userCreditsDataGridView.Location = new System.Drawing.Point(15, 39);
            this.userCreditsDataGridView.Name = "userCreditsDataGridView";
            this.userCreditsDataGridView.RowTemplate.Height = 24;
            this.userCreditsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userCreditsDataGridView.Size = new System.Drawing.Size(400, 200);
            this.userCreditsDataGridView.TabIndex = 0;
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Location = new System.Drawing.Point(12, 9);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(93, 17);
            this.currentUserLabel.TabIndex = 1;
            this.currentUserLabel.Text = "Current User:";
            // 
            // addSymTextBox
            // 
            this.addSymTextBox.Location = new System.Drawing.Point(421, 39);
            this.addSymTextBox.Name = "addSymTextBox";
            this.addSymTextBox.Size = new System.Drawing.Size(158, 22);
            this.addSymTextBox.TabIndex = 2;
            // 
            // putMoneyButton
            // 
            this.putMoneyButton.Location = new System.Drawing.Point(421, 67);
            this.putMoneyButton.Name = "putMoneyButton";
            this.putMoneyButton.Size = new System.Drawing.Size(158, 30);
            this.putMoneyButton.TabIndex = 3;
            this.putMoneyButton.Text = "Put money";
            this.putMoneyButton.UseVisualStyleBackColor = true;
            this.putMoneyButton.Click += new System.EventHandler(this.PutMoneyOnOpenedDepositButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 242);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 4;
            // 
            // moneyRetutnButton
            // 
            this.moneyRetutnButton.Location = new System.Drawing.Point(421, 121);
            this.moneyRetutnButton.Name = "moneyRetutnButton";
            this.moneyRetutnButton.Size = new System.Drawing.Size(158, 30);
            this.moneyRetutnButton.TabIndex = 5;
            this.moneyRetutnButton.Text = "Return the money";
            this.moneyRetutnButton.UseVisualStyleBackColor = true;
            this.moneyRetutnButton.Click += new System.EventHandler(this.MoneyRetutnButton_Click);
            // 
            // UserDepositsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 274);
            this.Controls.Add(this.moneyRetutnButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.putMoneyButton);
            this.Controls.Add(this.addSymTextBox);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.userCreditsDataGridView);
            this.Name = "UserDepositsForm";
            this.Text = "User Deposits";
            this.Load += new System.EventHandler(this.UserDepositsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userCreditsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userCreditsDataGridView;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.TextBox addSymTextBox;
        private System.Windows.Forms.Button putMoneyButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button moneyRetutnButton;
    }
}