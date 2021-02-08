namespace KieferWolfowitzAlgorithm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.InitialApproximationTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BPointTextBox = new System.Windows.Forms.TextBox();
            this.APointTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FunctionsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(6, 206);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(128, 50);
            this.CalculateButton.TabIndex = 19;
            this.CalculateButton.Text = "Порахувати";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ітераційний процес";
            // 
            // OutputRichTextBox
            // 
            this.OutputRichTextBox.Location = new System.Drawing.Point(654, 25);
            this.OutputRichTextBox.Name = "OutputRichTextBox";
            this.OutputRichTextBox.Size = new System.Drawing.Size(278, 482);
            this.OutputRichTextBox.TabIndex = 17;
            this.OutputRichTextBox.Text = "";
            // 
            // InitialApproximationTextBox
            // 
            this.InitialApproximationTextBox.Location = new System.Drawing.Point(5, 158);
            this.InitialApproximationTextBox.Name = "InitialApproximationTextBox";
            this.InitialApproximationTextBox.Size = new System.Drawing.Size(61, 22);
            this.InitialApproximationTextBox.TabIndex = 16;
            this.InitialApproximationTextBox.Text = "0";
            this.InitialApproximationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Початвоке наближення";
            // 
            // BPointTextBox
            // 
            this.BPointTextBox.Location = new System.Drawing.Point(73, 90);
            this.BPointTextBox.Name = "BPointTextBox";
            this.BPointTextBox.Size = new System.Drawing.Size(61, 22);
            this.BPointTextBox.TabIndex = 14;
            this.BPointTextBox.Text = "6.28";
            this.BPointTextBox.TextChanged += new System.EventHandler(this.DrawFunction);
            // 
            // APointTextBox
            // 
            this.APointTextBox.Location = new System.Drawing.Point(6, 90);
            this.APointTextBox.Name = "APointTextBox";
            this.APointTextBox.Size = new System.Drawing.Size(61, 22);
            this.APointTextBox.TabIndex = 13;
            this.APointTextBox.Text = "0";
            this.APointTextBox.TextChanged += new System.EventHandler(this.DrawFunction);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Встановіть проміжок";
            // 
            // FunctionsComboBox
            // 
            this.FunctionsComboBox.FormattingEnabled = true;
            this.FunctionsComboBox.Location = new System.Drawing.Point(6, 25);
            this.FunctionsComboBox.Name = "FunctionsComboBox";
            this.FunctionsComboBox.Size = new System.Drawing.Size(128, 24);
            this.FunctionsComboBox.TabIndex = 11;
            this.FunctionsComboBox.SelectedIndexChanged += new System.EventHandler(this.FunctionsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Оберіть функцію";
            // 
            // Chart
            // 
            chartArea4.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.Chart.Legends.Add(legend4);
            this.Chart.Location = new System.Drawing.Point(155, 12);
            this.Chart.Name = "Chart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.Chart.Series.Add(series4);
            this.Chart.Size = new System.Drawing.Size(490, 491);
            this.Chart.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 515);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OutputRichTextBox);
            this.Controls.Add(this.InitialApproximationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BPointTextBox);
            this.Controls.Add(this.APointTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FunctionsComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " Алгоритми Кіфера-Вольфовиця ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox OutputRichTextBox;
        private System.Windows.Forms.TextBox InitialApproximationTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BPointTextBox;
        private System.Windows.Forms.TextBox APointTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FunctionsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
    }
}

