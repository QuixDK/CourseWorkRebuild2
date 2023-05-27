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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.expSmooth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MChart = new System.Windows.Forms.CheckBox();
            this.alphaChart = new System.Windows.Forms.CheckBox();
            this.chartSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.chartTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.markerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelsOnMarksCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.markerSizeComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.expSmooth)).BeginInit();
            this.chartSettingsGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // expSmooth
            // 
            chartArea1.Name = "ChartArea1";
            this.expSmooth.ChartAreas.Add(chartArea1);
            this.expSmooth.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.expSmooth.Legends.Add(legend1);
            this.expSmooth.Location = new System.Drawing.Point(0, 0);
            this.expSmooth.Margin = new System.Windows.Forms.Padding(4);
            this.expSmooth.Name = "expSmooth";
            this.expSmooth.Size = new System.Drawing.Size(867, 550);
            this.expSmooth.TabIndex = 0;
            this.expSmooth.Text = "chart1";
            // 
            // MChart
            // 
            this.MChart.AutoSize = true;
            this.MChart.Location = new System.Drawing.Point(12, 17);
            this.MChart.Margin = new System.Windows.Forms.Padding(4);
            this.MChart.Name = "MChart";
            this.MChart.Size = new System.Drawing.Size(149, 20);
            this.MChart.TabIndex = 1;
            this.MChart.Text = "Длина вектора (M)";
            this.MChart.UseVisualStyleBackColor = true;
            this.MChart.CheckedChanged += new System.EventHandler(this.MChart_CheckedChanged);
            // 
            // alphaChart
            // 
            this.alphaChart.AutoSize = true;
            this.alphaChart.Location = new System.Drawing.Point(12, 45);
            this.alphaChart.Margin = new System.Windows.Forms.Padding(4);
            this.alphaChart.Name = "alphaChart";
            this.alphaChart.Size = new System.Drawing.Size(79, 20);
            this.alphaChart.TabIndex = 2;
            this.alphaChart.Text = "Угол (a)";
            this.alphaChart.UseVisualStyleBackColor = true;
            this.alphaChart.CheckedChanged += new System.EventHandler(this.alphaChart_CheckedChanged);
            // 
            // chartSettingsGroupBox
            // 
            this.chartSettingsGroupBox.Controls.Add(this.chartTypeComboBox);
            this.chartSettingsGroupBox.Controls.Add(this.label4);
            this.chartSettingsGroupBox.Controls.Add(this.markerTypeComboBox);
            this.chartSettingsGroupBox.Controls.Add(this.label3);
            this.chartSettingsGroupBox.Controls.Add(this.labelsOnMarksCheckBox);
            this.chartSettingsGroupBox.Controls.Add(this.label2);
            this.chartSettingsGroupBox.Controls.Add(this.label1);
            this.chartSettingsGroupBox.Controls.Add(this.markerSizeComboBox);
            this.chartSettingsGroupBox.Location = new System.Drawing.Point(4, 73);
            this.chartSettingsGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.chartSettingsGroupBox.Name = "chartSettingsGroupBox";
            this.chartSettingsGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.chartSettingsGroupBox.Size = new System.Drawing.Size(242, 473);
            this.chartSettingsGroupBox.TabIndex = 3;
            this.chartSettingsGroupBox.TabStop = false;
            this.chartSettingsGroupBox.Text = "Настройки диаграммы";
            // 
            // chartTypeComboBox
            // 
            this.chartTypeComboBox.FormattingEnabled = true;
            this.chartTypeComboBox.Location = new System.Drawing.Point(12, 55);
            this.chartTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.chartTypeComboBox.Name = "chartTypeComboBox";
            this.chartTypeComboBox.Size = new System.Drawing.Size(160, 24);
            this.chartTypeComboBox.TabIndex = 7;
            this.chartTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.chartTypeComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Вид графика";
            // 
            // markerTypeComboBox
            // 
            this.markerTypeComboBox.FormattingEnabled = true;
            this.markerTypeComboBox.Location = new System.Drawing.Point(12, 159);
            this.markerTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.markerTypeComboBox.Name = "markerTypeComboBox";
            this.markerTypeComboBox.Size = new System.Drawing.Size(160, 24);
            this.markerTypeComboBox.TabIndex = 5;
            this.markerTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.markerTypeComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вид маркеров";
            // 
            // labelsOnMarksCheckBox
            // 
            this.labelsOnMarksCheckBox.AutoSize = true;
            this.labelsOnMarksCheckBox.Location = new System.Drawing.Point(12, 214);
            this.labelsOnMarksCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.labelsOnMarksCheckBox.Name = "labelsOnMarksCheckBox";
            this.labelsOnMarksCheckBox.Size = new System.Drawing.Size(46, 20);
            this.labelsOnMarksCheckBox.TabIndex = 3;
            this.labelsOnMarksCheckBox.Text = "Да";
            this.labelsOnMarksCheckBox.UseVisualStyleBackColor = true;
            this.labelsOnMarksCheckBox.Click += new System.EventHandler(this.labelsOnMarksCheckBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Включить метки над точками";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размер маркеров";
            // 
            // markerSizeComboBox
            // 
            this.markerSizeComboBox.FormattingEnabled = true;
            this.markerSizeComboBox.Location = new System.Drawing.Point(12, 107);
            this.markerSizeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.markerSizeComboBox.Name = "markerSizeComboBox";
            this.markerSizeComboBox.Size = new System.Drawing.Size(160, 24);
            this.markerSizeComboBox.TabIndex = 0;
            this.markerSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.markerSizeComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.expSmooth);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 550);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.MChart);
            this.panel2.Controls.Add(this.chartSettingsGroupBox);
            this.panel2.Controls.Add(this.alphaChart);
            this.panel2.Location = new System.Drawing.Point(875, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 550);
            this.panel2.TabIndex = 5;
            // 
            // ExpSmoothChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ExpSmoothChart";
            this.Text = "Экспоненциальное сглаживание";
            this.Load += new System.EventHandler(this.ExpSmoothChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expSmooth)).EndInit();
            this.chartSettingsGroupBox.ResumeLayout(false);
            this.chartSettingsGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ComboBox chartTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}