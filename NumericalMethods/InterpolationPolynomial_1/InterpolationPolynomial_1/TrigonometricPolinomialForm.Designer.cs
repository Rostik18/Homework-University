namespace InterpolationPolynomial_1 {
    partial class TrigonometricPolinomialForm {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.funcErrorLabel = new System.Windows.Forms.Label();
            this.clearChartButton = new System.Windows.Forms.Button();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.runButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.funcComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // funcErrorLabel
            // 
            this.funcErrorLabel.AutoSize = true;
            this.funcErrorLabel.Location = new System.Drawing.Point(12, 422);
            this.funcErrorLabel.Name = "funcErrorLabel";
            this.funcErrorLabel.Size = new System.Drawing.Size(57, 17);
            this.funcErrorLabel.TabIndex = 33;
            this.funcErrorLabel.Text = "epsilon:";
            // 
            // clearChartButton
            // 
            this.clearChartButton.Location = new System.Drawing.Point(16, 115);
            this.clearChartButton.Name = "clearChartButton";
            this.clearChartButton.Size = new System.Drawing.Size(119, 27);
            this.clearChartButton.TabIndex = 32;
            this.clearChartButton.Text = "Clear Chart";
            this.clearChartButton.UseVisualStyleBackColor = true;
            this.clearChartButton.Click += new System.EventHandler(this.clearChartButton_Click);
            // 
            // mainChart
            // 
            this.mainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea9.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.mainChart.Legends.Add(legend9);
            this.mainChart.Location = new System.Drawing.Point(141, 12);
            this.mainChart.Name = "mainChart";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.mainChart.Series.Add(series9);
            this.mainChart.Size = new System.Drawing.Size(647, 427);
            this.mainChart.TabIndex = 31;
            this.mainChart.Text = "mainChart";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(17, 84);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(119, 25);
            this.runButton.TabIndex = 30;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 395);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 22;
            // 
            // funcComboBox
            // 
            this.funcComboBox.FormattingEnabled = true;
            this.funcComboBox.Items.AddRange(new object[] {
            "1/(1 + 25x^2)",
            "ln(x + 2)"});
            this.funcComboBox.Location = new System.Drawing.Point(17, 41);
            this.funcComboBox.Name = "funcComboBox";
            this.funcComboBox.Size = new System.Drawing.Size(119, 24);
            this.funcComboBox.TabIndex = 28;
            this.funcComboBox.SelectedIndexChanged += new System.EventHandler(this.funcComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "n";
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(35, 12);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(100, 22);
            this.nTextBox.TabIndex = 25;
            // 
            // TrigonometricPolinomialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.funcErrorLabel);
            this.Controls.Add(this.clearChartButton);
            this.Controls.Add(this.mainChart);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.funcComboBox);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label3);
            this.Name = "TrigonometricPolinomialForm";
            this.Text = "TrigonometricPolinomialForm";
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label funcErrorLabel;
        private System.Windows.Forms.Button clearChartButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.ComboBox funcComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nTextBox;
    }
}