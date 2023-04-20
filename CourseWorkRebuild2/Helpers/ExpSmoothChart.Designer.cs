namespace CourseWorkRebuild2.Helpers
{
    partial class ExpSmoothChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.expSmooth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MChart = new System.Windows.Forms.CheckBox();
            this.alphaChart = new System.Windows.Forms.CheckBox();
            this.chartSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.markerSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelsOnMarksCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.markerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chartTypeComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expSmooth)).BeginInit();
            this.chartSettingsGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // expSmooth
            // 
            chartArea6.Name = "ChartArea1";
            this.expSmooth.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.expSmooth.Legends.Add(legend6);
            this.expSmooth.Location = new System.Drawing.Point(12, 13);
            this.expSmooth.Name = "expSmooth";
            this.expSmooth.Size = new System.Drawing.Size(639, 426);
            this.expSmooth.TabIndex = 0;
            this.expSmooth.Text = "chart1";
            // 
            // MChart
            // 
            this.MChart.AutoSize = true;
            this.MChart.Location = new System.Drawing.Point(670, 12);
            this.MChart.Name = "MChart";
            this.MChart.Size = new System.Drawing.Size(139, 19);
            this.MChart.TabIndex = 1;
            this.MChart.Text = "Длина вектора (M)";
            this.MChart.UseVisualStyleBackColor = true;
            this.MChart.CheckedChanged += new System.EventHandler(this.MChart_CheckedChanged);
            // 
            // alphaChart
            // 
            this.alphaChart.AutoSize = true;
            this.alphaChart.Location = new System.Drawing.Point(670, 37);
            this.alphaChart.Name = "alphaChart";
            this.alphaChart.Size = new System.Drawing.Size(74, 19);
            this.alphaChart.TabIndex = 2;
            this.alphaChart.Text = "Угол (a)";
            this.alphaChart.UseVisualStyleBackColor = true;
            this.alphaChart.CheckedChanged += new System.EventHandler(this.alphaChart_CheckedChanged);
            // 
            // chartSettingsGroupBox
            // 
            this.chartSettingsGroupBox.Controls.Add(this.groupBox1);
            this.chartSettingsGroupBox.Controls.Add(this.chartTypeComboBox);
            this.chartSettingsGroupBox.Controls.Add(this.label4);
            this.chartSettingsGroupBox.Controls.Add(this.markerTypeComboBox);
            this.chartSettingsGroupBox.Controls.Add(this.label3);
            this.chartSettingsGroupBox.Controls.Add(this.labelsOnMarksCheckBox);
            this.chartSettingsGroupBox.Controls.Add(this.label2);
            this.chartSettingsGroupBox.Controls.Add(this.label1);
            this.chartSettingsGroupBox.Controls.Add(this.markerSizeComboBox);
            this.chartSettingsGroupBox.Location = new System.Drawing.Point(657, 93);
            this.chartSettingsGroupBox.Name = "chartSettingsGroupBox";
            this.chartSettingsGroupBox.Size = new System.Drawing.Size(187, 346);
            this.chartSettingsGroupBox.TabIndex = 3;
            this.chartSettingsGroupBox.TabStop = false;
            this.chartSettingsGroupBox.Text = "Настройки диаграммы";
            // 
            // markerSizeComboBox
            // 
            this.markerSizeComboBox.FormattingEnabled = true;
            this.markerSizeComboBox.Location = new System.Drawing.Point(9, 87);
            this.markerSizeComboBox.Name = "markerSizeComboBox";
            this.markerSizeComboBox.Size = new System.Drawing.Size(121, 21);
            this.markerSizeComboBox.TabIndex = 0;
            this.markerSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.markerSizeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размер маркеров";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Включить метки над точками";
            // 
            // labelsOnMarksCheckBox
            // 
            this.labelsOnMarksCheckBox.AutoSize = true;
            this.labelsOnMarksCheckBox.Location = new System.Drawing.Point(9, 174);
            this.labelsOnMarksCheckBox.Name = "labelsOnMarksCheckBox";
            this.labelsOnMarksCheckBox.Size = new System.Drawing.Size(45, 19);
            this.labelsOnMarksCheckBox.TabIndex = 3;
            this.labelsOnMarksCheckBox.Text = "Да";
            this.labelsOnMarksCheckBox.UseVisualStyleBackColor = true;
            this.labelsOnMarksCheckBox.Click += new System.EventHandler(this.labelsOnMarksCheckBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вид маркеров";
            // 
            // markerTypeComboBox
            // 
            this.markerTypeComboBox.FormattingEnabled = true;
            this.markerTypeComboBox.Location = new System.Drawing.Point(9, 129);
            this.markerTypeComboBox.Name = "markerTypeComboBox";
            this.markerTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.markerTypeComboBox.TabIndex = 5;
            this.markerTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.markerTypeComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вид графика";
            // 
            // chartTypeComboBox
            // 
            this.chartTypeComboBox.FormattingEnabled = true;
            this.chartTypeComboBox.Location = new System.Drawing.Point(9, 45);
            this.chartTypeComboBox.Name = "chartTypeComboBox";
            this.chartTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.chartTypeComboBox.TabIndex = 7;
            this.chartTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.chartTypeComboBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 141);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка осей";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 20);
            this.textBox4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "MaxY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "MaxX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "MinY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "MinX";
            // 
            // ExpSmoothChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 451);
            this.Controls.Add(this.chartSettingsGroupBox);
            this.Controls.Add(this.alphaChart);
            this.Controls.Add(this.MChart);
            this.Controls.Add(this.expSmooth);
            this.Name = "ExpSmoothChart";
            this.Text = "Экспоненциальное сглаживание";
            this.Load += new System.EventHandler(this.ExpSmoothChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expSmooth)).EndInit();
            this.chartSettingsGroupBox.ResumeLayout(false);
            this.chartSettingsGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart expSmooth;
        private System.Windows.Forms.CheckBox MChart;
        private System.Windows.Forms.CheckBox alphaChart;
        private System.Windows.Forms.GroupBox chartSettingsGroupBox;
        private System.Windows.Forms.ComboBox markerTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox labelsOnMarksCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox markerSizeComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox chartTypeComboBox;
        private System.Windows.Forms.Label label4;
    }
}