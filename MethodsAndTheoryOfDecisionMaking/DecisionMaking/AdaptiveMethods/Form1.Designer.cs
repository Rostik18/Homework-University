namespace SimpleSearch
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.OutputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.BPointTextBox = new System.Windows.Forms.TextBox();
            this.APointTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FunctionsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.EpsilonTextBox = new System.Windows.Forms.TextBox();
            this.NTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(12, 252);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(128, 50);
            this.CalculateButton.TabIndex = 29;
            this.CalculateButton.Text = "Порахувати";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ітераційний процес";
            // 
            // OutputRichTextBox
            // 
            this.OutputRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputRichTextBox.Location = new System.Drawing.Point(660, 30);
            this.OutputRichTextBox.Name = "OutputRichTextBox";
            this.OutputRichTextBox.Size = new System.Drawing.Size(278, 482);
            this.OutputRichTextBox.TabIndex = 27;
            this.OutputRichTextBox.Text = "";
            // 
            // BPointTextBox
            // 
            this.BPointTextBox.Location = new System.Drawing.Point(79, 95);
            this.BPointTextBox.Name = "BPointTextBox";
            this.BPointTextBox.Size = new System.Drawing.Size(61, 22);
            this.BPointTextBox.TabIndex = 24;
            this.BPointTextBox.Text = "6.28";
            this.BPointTextBox.TextChanged += new System.EventHandler(this.DrawFunction);
            // 
            // APointTextBox
            // 
            this.APointTextBox.Location = new System.Drawing.Point(12, 95);
            this.APointTextBox.Name = "APointTextBox";
            this.APointTextBox.Size = new System.Drawing.Size(61, 22);
            this.APointTextBox.TabIndex = 23;
            this.APointTextBox.Text = "0";
            this.APointTextBox.TextChanged += new System.EventHandler(this.DrawFunction);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Встановіть проміжок";
            // 
            // FunctionsComboBox
            // 
            this.FunctionsComboBox.FormattingEnabled = true;
            this.FunctionsComboBox.Location = new System.Drawing.Point(12, 30);
            this.FunctionsComboBox.Name = "FunctionsComboBox";
            this.FunctionsComboBox.Size = new System.Drawing.Size(128, 24);
            this.FunctionsComboBox.TabIndex = 21;
            this.FunctionsComboBox.SelectedIndexChanged += new System.EventHandler(this.FunctionsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Оберіть функцію";
            // 
            // Chart
            // 
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(182, 12);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(469, 499);
            this.Chart.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "епсилон";
            // 
            // EpsilonTextBox
            // 
            this.EpsilonTextBox.Location = new System.Drawing.Point(12, 148);
            this.EpsilonTextBox.Name = "EpsilonTextBox";
            this.EpsilonTextBox.Size = new System.Drawing.Size(61, 22);
            this.EpsilonTextBox.TabIndex = 32;
            this.EpsilonTextBox.Text = "0.001";
            this.EpsilonTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NTextBox
            // 
            this.NTextBox.Location = new System.Drawing.Point(12, 202);
            this.NTextBox.Name = "NTextBox";
            this.NTextBox.Size = new System.Drawing.Size(61, 22);
            this.NTextBox.TabIndex = 34;
            this.NTextBox.Text = "100";
            this.NTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "N";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 523);
            this.Controls.Add(this.NTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EpsilonTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OutputRichTextBox);
            this.Controls.Add(this.BPointTextBox);
            this.Controls.Add(this.APointTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FunctionsComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Простий перебір ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox OutputRichTextBox;
        private System.Windows.Forms.TextBox BPointTextBox;
        private System.Windows.Forms.TextBox APointTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FunctionsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EpsilonTextBox;
        private System.Windows.Forms.TextBox NTextBox;
        private System.Windows.Forms.Label label3;
    }
}

