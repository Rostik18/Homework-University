namespace InterpolationPolynomial_1 {
    partial class Form1 {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.mTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.funcComboBox = new System.Windows.Forms.ComboBox();
            this.runButton = new System.Windows.Forms.Button();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.clearChartButton = new System.Windows.Forms.Button();
            this.funcErrorLabel = new System.Windows.Forms.Label();
            this.trigonometricStartButton = new System.Windows.Forms.Button();
            this.splineStartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "m";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "x";
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 295);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 5;
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(35, 12);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 22);
            this.aTextBox.TabIndex = 6;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(35, 42);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 22);
            this.bTextBox.TabIndex = 7;
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(35, 70);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(100, 22);
            this.nTextBox.TabIndex = 8;
            // 
            // mTextBox
            // 
            this.mTextBox.Location = new System.Drawing.Point(35, 103);
            this.mTextBox.Name = "mTextBox";
            this.mTextBox.Size = new System.Drawing.Size(100, 22);
            this.mTextBox.TabIndex = 9;
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(35, 136);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 22);
            this.xTextBox.TabIndex = 10;
            // 
            // funcComboBox
            // 
            this.funcComboBox.FormattingEnabled = true;
            this.funcComboBox.Items.AddRange(new object[] {
            "1/(1 + 25x^2)",
            "ln(x + 2)"});
            this.funcComboBox.Location = new System.Drawing.Point(16, 164);
            this.funcComboBox.Name = "funcComboBox";
            this.funcComboBox.Size = new System.Drawing.Size(119, 24);
            this.funcComboBox.TabIndex = 11;
            this.funcComboBox.SelectedIndexChanged += new System.EventHandler(this.funcComboBox_SelectedIndexChanged);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(15, 227);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(119, 25);
            this.runButton.TabIndex = 13;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // methodComboBox
            // 
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Items.AddRange(new object[] {
            "Newton",
            "Lagrange"});
            this.methodComboBox.Location = new System.Drawing.Point(16, 194);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(119, 24);
            this.methodComboBox.TabIndex = 12;
            this.methodComboBox.SelectedIndexChanged += new System.EventHandler(this.methodComboBox_SelectedIndexChanged);
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
            this.mainChart.Location = new System.Drawing.Point(141, 12);
            this.mainChart.Name = "mainChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.mainChart.Series.Add(series1);
            this.mainChart.Size = new System.Drawing.Size(647, 426);
            this.mainChart.TabIndex = 14;
            this.mainChart.Text = "mainChart";
            // 
            // clearChartButton
            // 
            this.clearChartButton.Location = new System.Drawing.Point(15, 258);
            this.clearChartButton.Name = "clearChartButton";
            this.clearChartButton.Size = new System.Drawing.Size(119, 27);
            this.clearChartButton.TabIndex = 14;
            this.clearChartButton.Text = "Clear Chart";
            this.clearChartButton.UseVisualStyleBackColor = true;
            this.clearChartButton.Click += new System.EventHandler(this.clearChartButton_Click);
            // 
            // funcErrorLabel
            // 
            this.funcErrorLabel.AutoSize = true;
            this.funcErrorLabel.Location = new System.Drawing.Point(12, 322);
            this.funcErrorLabel.Name = "funcErrorLabel";
            this.funcErrorLabel.Size = new System.Drawing.Size(57, 17);
            this.funcErrorLabel.TabIndex = 15;
            this.funcErrorLabel.Text = "epsilon:";
            // 
            // trigonometricStartButton
            // 
            this.trigonometricStartButton.Location = new System.Drawing.Point(16, 408);
            this.trigonometricStartButton.Name = "trigonometricStartButton";
            this.trigonometricStartButton.Size = new System.Drawing.Size(118, 31);
            this.trigonometricStartButton.TabIndex = 16;
            this.trigonometricStartButton.Text = "Trigonometric";
            this.trigonometricStartButton.UseVisualStyleBackColor = true;
            this.trigonometricStartButton.Click += new System.EventHandler(this.trigonometricStartButton_Click);
            // 
            // splineStartButton
            // 
            this.splineStartButton.Location = new System.Drawing.Point(15, 373);
            this.splineStartButton.Name = "splineStartButton";
            this.splineStartButton.Size = new System.Drawing.Size(119, 29);
            this.splineStartButton.TabIndex = 17;
            this.splineStartButton.Text = "Spline";
            this.splineStartButton.UseVisualStyleBackColor = true;
            this.splineStartButton.Click += new System.EventHandler(this.splineStartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splineStartButton);
            this.Controls.Add(this.trigonometricStartButton);
            this.Controls.Add(this.funcErrorLabel);
            this.Controls.Add(this.clearChartButton);
            this.Controls.Add(this.mainChart);
            this.Controls.Add(this.methodComboBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.funcComboBox);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.mTextBox);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Interpolation polynomial";
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.TextBox mTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.ComboBox funcComboBox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.ComboBox methodComboBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Button clearChartButton;
        private System.Windows.Forms.Label funcErrorLabel;
        private System.Windows.Forms.Button trigonometricStartButton;
        private System.Windows.Forms.Button splineStartButton;
    }
}

