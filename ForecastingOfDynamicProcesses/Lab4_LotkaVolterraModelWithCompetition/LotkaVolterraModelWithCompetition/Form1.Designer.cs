
namespace LotkaVolterraModelWithCompetition
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.lTextBox = new System.Windows.Forms.TextBox();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.qTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "l:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(17, 182);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(195, 38);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Порахувати";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // lTextBox
            // 
            this.lTextBox.Location = new System.Drawing.Point(85, 14);
            this.lTextBox.Name = "lTextBox";
            this.lTextBox.Size = new System.Drawing.Size(127, 22);
            this.lTextBox.TabIndex = 2;
            this.lTextBox.Text = "1";
            this.lTextBox.TextChanged += new System.EventHandler(this.OnParamsChange);
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logRichTextBox.Location = new System.Drawing.Point(17, 226);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(195, 212);
            this.logRichTextBox.TabIndex = 3;
            this.logRichTextBox.Text = "";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(218, 12);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(570, 426);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // qTextBox
            // 
            this.qTextBox.Location = new System.Drawing.Point(85, 42);
            this.qTextBox.Name = "qTextBox";
            this.qTextBox.Size = new System.Drawing.Size(127, 22);
            this.qTextBox.TabIndex = 6;
            this.qTextBox.Text = "1";
            this.qTextBox.TextChanged += new System.EventHandler(this.OnParamsChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "q:";
            // 
            // kTextBox
            // 
            this.kTextBox.Location = new System.Drawing.Point(85, 70);
            this.kTextBox.Name = "kTextBox";
            this.kTextBox.Size = new System.Drawing.Size(127, 22);
            this.kTextBox.TabIndex = 8;
            this.kTextBox.Text = "2";
            this.kTextBox.TextChanged += new System.EventHandler(this.OnParamsChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "k:";
            // 
            // pTextBox
            // 
            this.pTextBox.Location = new System.Drawing.Point(85, 98);
            this.pTextBox.Name = "pTextBox";
            this.pTextBox.Size = new System.Drawing.Size(127, 22);
            this.pTextBox.TabIndex = 10;
            this.pTextBox.Text = "1";
            this.pTextBox.TextChanged += new System.EventHandler(this.OnParamsChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "p:";
            // 
            // rTextBox
            // 
            this.rTextBox.Location = new System.Drawing.Point(85, 154);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(127, 22);
            this.rTextBox.TabIndex = 14;
            this.rTextBox.Text = "1";
            this.rTextBox.TextChanged += new System.EventHandler(this.OnParamsChange);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "r (r>0):";
            // 
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(85, 126);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(127, 22);
            this.mTextBox.TabIndex = 12;
            this.mTextBox.Text = "2";
            this.mTextBox.TextChanged += new System.EventHandler(this.OnParamsChange);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "m (m>0):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.kTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.logRichTextBox);
            this.Controls.Add(this.lTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Модель Лотка-Вольтерра з конкуренцією";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox lTextBox;
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox qTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.Label label6;
    }
}

