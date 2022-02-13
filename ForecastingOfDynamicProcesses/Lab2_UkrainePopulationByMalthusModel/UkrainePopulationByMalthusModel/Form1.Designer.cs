
namespace UkrainePopulationByMalthusModel
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.startYearTextBox = new System.Windows.Forms.TextBox();
            this.startYearTrackBar = new System.Windows.Forms.TrackBar();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.takeYearsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stepTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startYearTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 146);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(306, 46);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "застосувати модель";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
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
            this.chart1.Location = new System.Drawing.Point(324, 11);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(646, 530);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Починати з року";
            // 
            // startYearTextBox
            // 
            this.startYearTextBox.Location = new System.Drawing.Point(218, 12);
            this.startYearTextBox.Name = "startYearTextBox";
            this.startYearTextBox.Size = new System.Drawing.Size(100, 22);
            this.startYearTextBox.TabIndex = 3;
            this.startYearTextBox.Text = "1960";
            this.startYearTextBox.TextChanged += new System.EventHandler(this.startYearTextBox_TextChanged);
            // 
            // startYearTrackBar
            // 
            this.startYearTrackBar.Location = new System.Drawing.Point(15, 39);
            this.startYearTrackBar.Maximum = 2021;
            this.startYearTrackBar.Minimum = 1960;
            this.startYearTrackBar.Name = "startYearTrackBar";
            this.startYearTrackBar.Size = new System.Drawing.Size(303, 56);
            this.startYearTrackBar.TabIndex = 4;
            this.startYearTrackBar.Value = 1960;
            this.startYearTrackBar.Scroll += new System.EventHandler(this.startYearTrackBar_Scroll);
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logTextBox.Location = new System.Drawing.Point(12, 209);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(306, 332);
            this.logTextBox.TabIndex = 5;
            this.logTextBox.Text = "";
            // 
            // takeYearsTextBox
            // 
            this.takeYearsTextBox.Location = new System.Drawing.Point(218, 75);
            this.takeYearsTextBox.Name = "takeYearsTextBox";
            this.takeYearsTextBox.Size = new System.Drawing.Size(100, 22);
            this.takeYearsTextBox.TabIndex = 7;
            this.takeYearsTextBox.Text = "15";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Взяти років";
            // 
            // stepTextBox
            // 
            this.stepTextBox.Location = new System.Drawing.Point(218, 109);
            this.stepTextBox.Name = "stepTextBox";
            this.stepTextBox.Size = new System.Drawing.Size(100, 22);
            this.stepTextBox.TabIndex = 9;
            this.stepTextBox.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "крок";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.stepTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.takeYearsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.startYearTrackBar);
            this.Controls.Add(this.startYearTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.calculateButton);
            this.Name = "Form1";
            this.Text = "Населення України за моделлю Мальтуса";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startYearTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startYearTextBox;
        private System.Windows.Forms.TrackBar startYearTrackBar;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.TextBox takeYearsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stepTextBox;
        private System.Windows.Forms.Label label3;
    }
}

