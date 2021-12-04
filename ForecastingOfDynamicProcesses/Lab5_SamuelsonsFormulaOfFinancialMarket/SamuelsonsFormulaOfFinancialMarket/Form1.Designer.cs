
namespace SamuelsonsFormulaOfFinancialMarket
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.startPriceNumeric = new System.Windows.Forms.NumericUpDown();
            this.lNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.miNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.sigmaNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPriceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(236, 12);
            this.chart1.Name = "chart1";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(725, 521);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logTextBox.Location = new System.Drawing.Point(15, 273);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(215, 260);
            this.logTextBox.TabIndex = 2;
            this.logTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Початкова ціна акції S0";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 232);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(218, 35);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Розрахувати вартість акції";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // startPriceNumeric
            // 
            this.startPriceNumeric.Location = new System.Drawing.Point(15, 28);
            this.startPriceNumeric.Name = "startPriceNumeric";
            this.startPriceNumeric.Size = new System.Drawing.Size(127, 22);
            this.startPriceNumeric.TabIndex = 1;
            this.startPriceNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.startPriceNumeric.ValueChanged += new System.EventHandler(this.calculateButton_Click);
            // 
            // lNumeric
            // 
            this.lNumeric.DecimalPlaces = 2;
            this.lNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lNumeric.Location = new System.Drawing.Point(15, 72);
            this.lNumeric.Name = "lNumeric";
            this.lNumeric.Size = new System.Drawing.Size(127, 22);
            this.lNumeric.TabIndex = 2;
            this.lNumeric.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.lNumeric.ValueChanged += new System.EventHandler(this.calculateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "l";
            // 
            // miNumeric
            // 
            this.miNumeric.DecimalPlaces = 2;
            this.miNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.miNumeric.Location = new System.Drawing.Point(15, 116);
            this.miNumeric.Name = "miNumeric";
            this.miNumeric.Size = new System.Drawing.Size(127, 22);
            this.miNumeric.TabIndex = 3;
            this.miNumeric.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.miNumeric.ValueChanged += new System.EventHandler(this.calculateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "mi";
            // 
            // sigmaNumeric
            // 
            this.sigmaNumeric.DecimalPlaces = 2;
            this.sigmaNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sigmaNumeric.Location = new System.Drawing.Point(15, 160);
            this.sigmaNumeric.Name = "sigmaNumeric";
            this.sigmaNumeric.Size = new System.Drawing.Size(127, 22);
            this.sigmaNumeric.TabIndex = 4;
            this.sigmaNumeric.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.sigmaNumeric.ValueChanged += new System.EventHandler(this.calculateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "sigma";
            // 
            // nNumeric
            // 
            this.nNumeric.Location = new System.Drawing.Point(15, 204);
            this.nNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nNumeric.Name = "nNumeric";
            this.nNumeric.Size = new System.Drawing.Size(127, 22);
            this.nNumeric.TabIndex = 5;
            this.nNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nNumeric.ValueChanged += new System.EventHandler(this.calculateButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ітерацій";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 545);
            this.Controls.Add(this.nNumeric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sigmaNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.miNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startPriceNumeric);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Формула Самуельсона ринку фінансів";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startPriceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sigmaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.NumericUpDown startPriceNumeric;
        private System.Windows.Forms.NumericUpDown lNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown miNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sigmaNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nNumeric;
        private System.Windows.Forms.Label label5;
    }
}

