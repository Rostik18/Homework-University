
namespace Laba2_FactorioCognitiveModeling
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
            this.matrixRichTextBox = new System.Windows.Forms.RichTextBox();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixRichTextBox
            // 
            this.matrixRichTextBox.Location = new System.Drawing.Point(39, 38);
            this.matrixRichTextBox.Name = "matrixRichTextBox";
            this.matrixRichTextBox.Size = new System.Drawing.Size(177, 102);
            this.matrixRichTextBox.TabIndex = 0;
            this.matrixRichTextBox.Text = "0 1,5 1,5 -0,25 -2,5 1,5\n0 0 1 0 0 2\n0 0,1 0 0 0 0,25\n0 0 0 0 0 -1\n-1 -1 -1 0 0,2" +
    "5 -2\n0 0 0 0 2 0";
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logTextBox.Location = new System.Drawing.Point(12, 190);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(437, 294);
            this.logTextBox.TabIndex = 1;
            this.logTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Подати імпульс в u1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "u1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "u1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "u2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "u3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "u4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "u5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "u6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "u2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "u3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "u4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "u5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "u6";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(222, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 17);
            this.label13.TabIndex = 17;
            this.label13.Text = "Кількість ітерацій";
            // 
            // mainChart
            // 
            this.mainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(455, 12);
            this.mainChart.Name = "mainChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.mainChart.Series.Add(series1);
            this.mainChart.Size = new System.Drawing.Size(816, 472);
            this.mainChart.TabIndex = 18;
            this.mainChart.Text = "chart1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(222, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 38);
            this.button2.TabIndex = 19;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 38);
            this.button3.TabIndex = 20;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 496);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mainChart);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.matrixRichTextBox);
            this.Name = "Form1";
            this.Text = "Когнітивне моделювання Факторіо";
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox matrixRichTextBox;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

