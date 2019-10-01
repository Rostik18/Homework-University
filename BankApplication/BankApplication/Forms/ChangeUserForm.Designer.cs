namespace BankApplication.Forms {
    partial class ChangeUserForm {
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
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.emailOrPhoneLabel = new System.Windows.Forms.Label();
            this.loginEmailOrPhoneTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.RowTemplate.Height = 24;
            this.UsersDataGridView.Size = new System.Drawing.Size(223, 338);
            this.UsersDataGridView.TabIndex = 0;
            // 
            // emailOrPhoneLabel
            // 
            this.emailOrPhoneLabel.AutoSize = true;
            this.emailOrPhoneLabel.Location = new System.Drawing.Point(265, 25);
            this.emailOrPhoneLabel.Name = "emailOrPhoneLabel";
            this.emailOrPhoneLabel.Size = new System.Drawing.Size(155, 17);
            this.emailOrPhoneLabel.TabIndex = 1;
            this.emailOrPhoneLabel.Text = "Email or phone number";
            // 
            // loginEmailOrPhoneTextBox
            // 
            this.loginEmailOrPhoneTextBox.Location = new System.Drawing.Point(268, 62);
            this.loginEmailOrPhoneTextBox.Name = "loginEmailOrPhoneTextBox";
            this.loginEmailOrPhoneTextBox.Size = new System.Drawing.Size(200, 22);
            this.loginEmailOrPhoneTextBox.TabIndex = 2;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(268, 138);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 22);
            this.passwordTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(265, 102);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 17);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // loginErrorLabel
            // 
            this.loginErrorLabel.AutoSize = true;
            this.loginErrorLabel.Location = new System.Drawing.Point(12, 357);
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.Size = new System.Drawing.Size(0, 17);
            this.loginErrorLabel.TabIndex = 5;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(268, 179);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(200, 25);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(268, 226);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(200, 25);
            this.addUserButton.TabIndex = 7;
            this.addUserButton.Text = "Register new User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // ChangeUserForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(482, 383);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginErrorLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginEmailOrPhoneTextBox);
            this.Controls.Add(this.emailOrPhoneLabel);
            this.Controls.Add(this.UsersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeUserForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.ChangeUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.Label emailOrPhoneLabel;
        private System.Windows.Forms.TextBox loginEmailOrPhoneTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginErrorLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button addUserButton;
    }
}