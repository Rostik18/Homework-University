namespace BankApplication.Forms {
    partial class ManeForm {
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
            this.maneMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCreditTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDepositTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserLable = new System.Windows.Forms.Label();
            this.accountsDataGridView = new System.Windows.Forms.DataGridView();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.freezeButton = new System.Windows.Forms.Button();
            this.openCreditButton = new System.Windows.Forms.Button();
            this.openDepositeButton = new System.Windows.Forms.Button();
            this.getSetMoneyTextBox = new System.Windows.Forms.TextBox();
            this.putMoneyButton = new System.Windows.Forms.Button();
            this.getMoneyButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.maneMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // maneMenuStrip
            // 
            this.maneMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.maneMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.maneMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.maneMenuStrip.Name = "maneMenuStrip";
            this.maneMenuStrip.Size = new System.Drawing.Size(832, 28);
            this.maneMenuStrip.TabIndex = 0;
            this.maneMenuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUserToolStripMenuItem,
            this.addCreditTypeToolStripMenuItem,
            this.addDepositTypeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // changeUserToolStripMenuItem
            // 
            this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            this.changeUserToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.changeUserToolStripMenuItem.Text = "Change User";
            this.changeUserToolStripMenuItem.Click += new System.EventHandler(this.ChangeUserToolStripMenuItem_Click);
            // 
            // addCreditTypeToolStripMenuItem
            // 
            this.addCreditTypeToolStripMenuItem.Name = "addCreditTypeToolStripMenuItem";
            this.addCreditTypeToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.addCreditTypeToolStripMenuItem.Text = "Add credit type";
            this.addCreditTypeToolStripMenuItem.Click += new System.EventHandler(this.AddCreditTypeToolStripMenuItem_Click);
            // 
            // addDepositTypeToolStripMenuItem
            // 
            this.addDepositTypeToolStripMenuItem.Name = "addDepositTypeToolStripMenuItem";
            this.addDepositTypeToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.addDepositTypeToolStripMenuItem.Text = "Add deposit type";
            this.addDepositTypeToolStripMenuItem.Click += new System.EventHandler(this.AddDepositTypeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // currentUserLable
            // 
            this.currentUserLable.AutoSize = true;
            this.currentUserLable.Location = new System.Drawing.Point(30, 50);
            this.currentUserLable.Name = "currentUserLable";
            this.currentUserLable.Size = new System.Drawing.Size(93, 17);
            this.currentUserLable.TabIndex = 1;
            this.currentUserLable.Text = "Current User:";
            // 
            // accountsDataGridView
            // 
            this.accountsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.accountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsDataGridView.Location = new System.Drawing.Point(30, 100);
            this.accountsDataGridView.Name = "accountsDataGridView";
            this.accountsDataGridView.RowTemplate.Height = 24;
            this.accountsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountsDataGridView.Size = new System.Drawing.Size(290, 280);
            this.accountsDataGridView.TabIndex = 2;
            this.accountsDataGridView.SelectionChanged += new System.EventHandler(this.AccountsDataGridView_SelectionChanged);
            // 
            // addAccountButton
            // 
            this.addAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addAccountButton.Location = new System.Drawing.Point(30, 400);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(120, 25);
            this.addAccountButton.TabIndex = 3;
            this.addAccountButton.Text = "Add account";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // freezeButton
            // 
            this.freezeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.freezeButton.Location = new System.Drawing.Point(157, 400);
            this.freezeButton.Name = "freezeButton";
            this.freezeButton.Size = new System.Drawing.Size(75, 25);
            this.freezeButton.TabIndex = 4;
            this.freezeButton.Text = "Freeze Account";
            this.freezeButton.UseVisualStyleBackColor = true;
            // 
            // openCreditButton
            // 
            this.openCreditButton.Enabled = false;
            this.openCreditButton.Location = new System.Drawing.Point(326, 100);
            this.openCreditButton.Name = "openCreditButton";
            this.openCreditButton.Size = new System.Drawing.Size(120, 29);
            this.openCreditButton.TabIndex = 5;
            this.openCreditButton.Text = "Open credit";
            this.openCreditButton.UseVisualStyleBackColor = true;
            this.openCreditButton.Click += new System.EventHandler(this.OpenCreditButton_Click);
            // 
            // openDepositeButton
            // 
            this.openDepositeButton.Enabled = false;
            this.openDepositeButton.Location = new System.Drawing.Point(326, 135);
            this.openDepositeButton.Name = "openDepositeButton";
            this.openDepositeButton.Size = new System.Drawing.Size(120, 29);
            this.openDepositeButton.TabIndex = 6;
            this.openDepositeButton.Text = "Open deposite";
            this.openDepositeButton.UseVisualStyleBackColor = true;
            this.openDepositeButton.Click += new System.EventHandler(this.OpenDepositeButton_Click);
            // 
            // getSetMoneyTextBox
            // 
            this.getSetMoneyTextBox.Location = new System.Drawing.Point(326, 235);
            this.getSetMoneyTextBox.Name = "getSetMoneyTextBox";
            this.getSetMoneyTextBox.Size = new System.Drawing.Size(120, 22);
            this.getSetMoneyTextBox.TabIndex = 7;
            // 
            // putMoneyButton
            // 
            this.putMoneyButton.Location = new System.Drawing.Point(326, 197);
            this.putMoneyButton.Name = "putMoneyButton";
            this.putMoneyButton.Size = new System.Drawing.Size(120, 32);
            this.putMoneyButton.TabIndex = 8;
            this.putMoneyButton.Text = "Put money";
            this.putMoneyButton.UseVisualStyleBackColor = true;
            this.putMoneyButton.Click += new System.EventHandler(this.PutMoneyButton_Click);
            // 
            // getMoneyButton
            // 
            this.getMoneyButton.Location = new System.Drawing.Point(326, 263);
            this.getMoneyButton.Name = "getMoneyButton";
            this.getMoneyButton.Size = new System.Drawing.Size(120, 28);
            this.getMoneyButton.TabIndex = 9;
            this.getMoneyButton.Text = "Get money";
            this.getMoneyButton.UseVisualStyleBackColor = true;
            this.getMoneyButton.Click += new System.EventHandler(this.GetMoneyButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(326, 400);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 10;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshButton.Location = new System.Drawing.Point(238, 400);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(82, 25);
            this.refreshButton.TabIndex = 11;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ManeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.getMoneyButton);
            this.Controls.Add(this.putMoneyButton);
            this.Controls.Add(this.getSetMoneyTextBox);
            this.Controls.Add(this.openDepositeButton);
            this.Controls.Add(this.openCreditButton);
            this.Controls.Add(this.freezeButton);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.accountsDataGridView);
            this.Controls.Add(this.currentUserLable);
            this.Controls.Add(this.maneMenuStrip);
            this.MainMenuStrip = this.maneMenuStrip;
            this.Name = "ManeForm";
            this.Text = "Bank App";
            this.Load += new System.EventHandler(this.ManeForm_Load);
            this.maneMenuStrip.ResumeLayout(false);
            this.maneMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip maneMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label currentUserLable;
        private System.Windows.Forms.DataGridView accountsDataGridView;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.Button freezeButton;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCreditTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDepositTypeToolStripMenuItem;
        private System.Windows.Forms.Button openCreditButton;
        private System.Windows.Forms.Button openDepositeButton;
        private System.Windows.Forms.TextBox getSetMoneyTextBox;
        private System.Windows.Forms.Button putMoneyButton;
        private System.Windows.Forms.Button getMoneyButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button refreshButton;
    }
}

