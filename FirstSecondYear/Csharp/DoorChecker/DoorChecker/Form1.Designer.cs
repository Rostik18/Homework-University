namespace DoorChecker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DoorH = new System.Windows.Forms.TextBox();
            this.DoorW = new System.Windows.Forms.TextBox();
            this.wardrobeH = new System.Windows.Forms.TextBox();
            this.wardrobeW = new System.Windows.Forms.TextBox();
            this.wardrobeL = new System.Windows.Forms.TextBox();
            this.Check_button = new System.Windows.Forms.Button();
            this.RezText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Двері";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Шафа";
            // 
            // DoorH
            // 
            this.DoorH.Location = new System.Drawing.Point(40, 80);
            this.DoorH.Name = "DoorH";
            this.DoorH.Size = new System.Drawing.Size(100, 22);
            this.DoorH.TabIndex = 2;
            this.DoorH.TextChanged += new System.EventHandler(this.DoorH_TextChanged);
            this.DoorH.Text = "h";
            // 
            // DoorW
            // 
            this.DoorW.Location = new System.Drawing.Point(40, 120);
            this.DoorW.Name = "DoorW";
            this.DoorW.Size = new System.Drawing.Size(100, 22);
            this.DoorW.TabIndex = 3;
            this.DoorW.TextChanged += new System.EventHandler(this.DoorW_TextChanged);
            this.DoorW.Text = "w";
            // 
            // wardrobeH
            // 
            this.wardrobeH.Location = new System.Drawing.Point(580, 80);
            this.wardrobeH.Name = "wardrobeH";
            this.wardrobeH.Size = new System.Drawing.Size(100, 22);
            this.wardrobeH.TabIndex = 4;
            this.wardrobeH.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.wardrobeH.Text = "h";
            // 
            // wardrobeW
            // 
            this.wardrobeW.Location = new System.Drawing.Point(580, 120);
            this.wardrobeW.Name = "wardrobeW";
            this.wardrobeW.Size = new System.Drawing.Size(100, 22);
            this.wardrobeW.TabIndex = 5;
            this.wardrobeW.TextChanged += new System.EventHandler(this.wardrobeW_TextChanged_1);
            this.wardrobeW.Text = "w";
            // 
            // wardrobeL
            // 
            this.wardrobeL.Location = new System.Drawing.Point(580, 160);
            this.wardrobeL.Name = "wardrobeL";
            this.wardrobeL.Size = new System.Drawing.Size(100, 22);
            this.wardrobeL.TabIndex = 6;
            this.wardrobeL.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.wardrobeL.Text = "l";
            // 
            // Check_button
            // 
            this.Check_button.Location = new System.Drawing.Point(357, 229);
            this.Check_button.Name = "Check_button";
            this.Check_button.Size = new System.Drawing.Size(75, 23);
            this.Check_button.TabIndex = 7;
            this.Check_button.Text = "Check";
            this.Check_button.UseVisualStyleBackColor = true;
            this.Check_button.Click += new System.EventHandler(this.Check_button_Click);
            // 
            // RezText
            // 
            this.RezText.AutoSize = true;
            this.RezText.Location = new System.Drawing.Point(357, 314);
            this.RezText.Name = "RezText";
            this.RezText.Size = new System.Drawing.Size(0, 17);
            this.RezText.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RezText);
            this.Controls.Add(this.Check_button);
            this.Controls.Add(this.wardrobeL);
            this.Controls.Add(this.wardrobeW);
            this.Controls.Add(this.wardrobeH);
            this.Controls.Add(this.DoorW);
            this.Controls.Add(this.DoorH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Checker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DoorH;
        private System.Windows.Forms.TextBox DoorW;
        private System.Windows.Forms.TextBox wardrobeH;
        private System.Windows.Forms.TextBox wardrobeW;
        private System.Windows.Forms.TextBox wardrobeL;
        private System.Windows.Forms.Button Check_button;
        private System.Windows.Forms.Label RezText;
        
    }
}

