
namespace Lab1_Game_Theory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.matrixATextBox = new System.Windows.Forms.RichTextBox();
            this.matrixBTextBox = new System.Windows.Forms.RichTextBox();
            this.binarMatrixTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateMatrixGameButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.validateInputButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.defaultTasksComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // matrixATextBox
            // 
            this.matrixATextBox.Location = new System.Drawing.Point(15, 36);
            this.matrixATextBox.Name = "matrixATextBox";
            this.matrixATextBox.Size = new System.Drawing.Size(300, 250);
            this.matrixATextBox.TabIndex = 2;
            this.matrixATextBox.Text = "";
            // 
            // matrixBTextBox
            // 
            this.matrixBTextBox.Location = new System.Drawing.Point(321, 36);
            this.matrixBTextBox.Name = "matrixBTextBox";
            this.matrixBTextBox.Size = new System.Drawing.Size(300, 250);
            this.matrixBTextBox.TabIndex = 3;
            this.matrixBTextBox.Text = "";
            // 
            // binarMatrixTextBox
            // 
            this.binarMatrixTextBox.Location = new System.Drawing.Point(627, 36);
            this.binarMatrixTextBox.Name = "binarMatrixTextBox";
            this.binarMatrixTextBox.ReadOnly = true;
            this.binarMatrixTextBox.Size = new System.Drawing.Size(300, 250);
            this.binarMatrixTextBox.TabIndex = 0;
            this.binarMatrixTextBox.Text = "";
            this.binarMatrixTextBox.ZoomFactor = 1.8F;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Стратегії першого гравця";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Стратегії другого гравця";
            // 
            // calculateMatrixGameButton
            // 
            this.calculateMatrixGameButton.Location = new System.Drawing.Point(627, 292);
            this.calculateMatrixGameButton.Name = "calculateMatrixGameButton";
            this.calculateMatrixGameButton.Size = new System.Drawing.Size(300, 40);
            this.calculateMatrixGameButton.TabIndex = 1;
            this.calculateMatrixGameButton.Text = "Розв\'язати матричну гру";
            this.calculateMatrixGameButton.UseVisualStyleBackColor = true;
            this.calculateMatrixGameButton.Click += new System.EventHandler(this.calculateMatrixGameButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(15, 338);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(912, 289);
            this.logTextBox.TabIndex = 0;
            this.logTextBox.Text = "";
            this.logTextBox.ZoomFactor = 3F;
            // 
            // validateInputButton
            // 
            this.validateInputButton.Location = new System.Drawing.Point(321, 292);
            this.validateInputButton.Name = "validateInputButton";
            this.validateInputButton.Size = new System.Drawing.Size(300, 40);
            this.validateInputButton.TabIndex = 4;
            this.validateInputButton.Text = "Валідувати вхідні дані";
            this.validateInputButton.UseVisualStyleBackColor = true;
            this.validateInputButton.Click += new System.EventHandler(this.validateInputButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(624, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Матрична гра";
            // 
            // defaultTasksComboBox
            // 
            this.defaultTasksComboBox.FormattingEnabled = true;
            this.defaultTasksComboBox.Location = new System.Drawing.Point(15, 292);
            this.defaultTasksComboBox.Name = "defaultTasksComboBox";
            this.defaultTasksComboBox.Size = new System.Drawing.Size(300, 24);
            this.defaultTasksComboBox.TabIndex = 9;
            this.defaultTasksComboBox.SelectedIndexChanged += new System.EventHandler(this.defaultTasksComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 639);
            this.Controls.Add(this.defaultTasksComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.validateInputButton);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.calculateMatrixGameButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.binarMatrixTextBox);
            this.Controls.Add(this.matrixBTextBox);
            this.Controls.Add(this.matrixATextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Матрична гра";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox matrixATextBox;
        private System.Windows.Forms.RichTextBox matrixBTextBox;
        private System.Windows.Forms.RichTextBox binarMatrixTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateMatrixGameButton;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.Button validateInputButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox defaultTasksComboBox;
    }
}

