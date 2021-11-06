
namespace Laba1_Bullet_Speed
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.CalculateLinearCase = new System.Windows.Forms.Button();
            this.CalculateStochasticCase = new System.Windows.Forms.Button();
            this.angleTextBoxTo = new System.Windows.Forms.TextBox();
            this.angleTextBoxFrom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.slider = new Syncfusion.Windows.Forms.Tools.RangeSlider();
            this.gaussianDistributionCheckBox = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianDistributionCheckBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(424, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(499, 479);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Маса кулі m:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Маса тіла M:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Довжина мотузки l:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Прискорення";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "12";
            this.textBox1.TextChanged += new System.EventHandler(this.ResetSession);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "г";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "80";
            this.textBox2.TextChanged += new System.EventHandler(this.ResetSession);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "кг";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "м";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "2";
            this.textBox3.TextChanged += new System.EventHandler(this.ResetSession);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(160, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "9,80665";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "вільного падіння g:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "м/c^2";
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logTextBox.Location = new System.Drawing.Point(12, 299);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(406, 192);
            this.logTextBox.TabIndex = 0;
            this.logTextBox.Text = "";
            // 
            // CalculateLinearCase
            // 
            this.CalculateLinearCase.Location = new System.Drawing.Point(12, 243);
            this.CalculateLinearCase.Name = "CalculateLinearCase";
            this.CalculateLinearCase.Size = new System.Drawing.Size(200, 50);
            this.CalculateLinearCase.TabIndex = 6;
            this.CalculateLinearCase.Text = "порахувати залежність швидкості від кута нахилу";
            this.CalculateLinearCase.UseVisualStyleBackColor = true;
            // 
            // CalculateStochasticCase
            // 
            this.CalculateStochasticCase.Location = new System.Drawing.Point(218, 243);
            this.CalculateStochasticCase.Name = "CalculateStochasticCase";
            this.CalculateStochasticCase.Size = new System.Drawing.Size(200, 50);
            this.CalculateStochasticCase.TabIndex = 7;
            this.CalculateStochasticCase.Text = "Порахувати для випадкового кута нахилу";
            this.CalculateStochasticCase.UseVisualStyleBackColor = true;
            // 
            // angleTextBoxTo
            // 
            this.angleTextBoxTo.Location = new System.Drawing.Point(389, 168);
            this.angleTextBoxTo.Name = "angleTextBoxTo";
            this.angleTextBoxTo.ReadOnly = true;
            this.angleTextBoxTo.Size = new System.Drawing.Size(29, 22);
            this.angleTextBoxTo.TabIndex = 18;
            // 
            // angleTextBoxFrom
            // 
            this.angleTextBoxFrom.Location = new System.Drawing.Point(354, 168);
            this.angleTextBoxFrom.Name = "angleTextBoxFrom";
            this.angleTextBoxFrom.ReadOnly = true;
            this.angleTextBoxFrom.Size = new System.Drawing.Size(29, 22);
            this.angleTextBoxFrom.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Діапазон ймовірності кута відхилу";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Кількість пострілів:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(160, 196);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "10";
            this.textBox5.TextChanged += new System.EventHandler(this.ResetSession);
            // 
            // slider
            // 
            this.slider.BeforeTouchSize = new System.Drawing.Size(355, 27);
            this.slider.ChannelHeight = 5;
            this.slider.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.slider.ForeColor = System.Drawing.Color.Black;
            this.slider.Location = new System.Drawing.Point(-7, 163);
            this.slider.Maximum = 90;
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(355, 27);
            this.slider.SliderMax = 35;
            this.slider.SliderMin = 25;
            this.slider.SliderSize = new System.Drawing.Size(13, 17);
            this.slider.TabIndex = 0;
            this.slider.Text = "rangeSlider1";
            this.slider.ValueChanged += new System.EventHandler(this.slider_ValueChanged);
            // 
            // gaussianDistributionCheckBox
            // 
            this.gaussianDistributionCheckBox.BeforeTouchSize = new System.Drawing.Size(402, 21);
            this.gaussianDistributionCheckBox.ImageCheckBoxSize = new System.Drawing.Size(16, 16);
            this.gaussianDistributionCheckBox.Location = new System.Drawing.Point(16, 219);
            this.gaussianDistributionCheckBox.Name = "gaussianDistributionCheckBox";
            this.gaussianDistributionCheckBox.Size = new System.Drawing.Size(402, 21);
            this.gaussianDistributionCheckBox.TabIndex = 5;
            this.gaussianDistributionCheckBox.Text = "Застосовувати нормальний розподіл";
            this.gaussianDistributionCheckBox.CheckStateChanged += new System.EventHandler(this.ResetSession);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 503);
            this.Controls.Add(this.gaussianDistributionCheckBox);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.angleTextBoxFrom);
            this.Controls.Add(this.angleTextBoxTo);
            this.Controls.Add(this.CalculateStochasticCase);
            this.Controls.Add(this.CalculateLinearCase);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Швидкість кулі";
            this.Load += new System.EventHandler(this.CleanLogAndChart);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaussianDistributionCheckBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.Button CalculateLinearCase;
        private System.Windows.Forms.Button CalculateStochasticCase;
        private System.Windows.Forms.TextBox angleTextBoxTo;
        private System.Windows.Forms.TextBox angleTextBoxFrom;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private Syncfusion.Windows.Forms.Tools.RangeSlider slider;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv gaussianDistributionCheckBox;
    }
}

