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
            ((System.ComponentModel.ISupportInitialize)(this.expSmooth)).BeginInit();
            this.SuspendLayout();
            // 
            // expSmooth
            // 
            chartArea1.Name = "ChartArea1";
            this.expSmooth.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.expSmooth.Legends.Add(legend1);
            this.expSmooth.Location = new System.Drawing.Point(12, 12);
            this.expSmooth.Name = "expSmooth";
            this.expSmooth.Size = new System.Drawing.Size(652, 426);
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
            // ExpSmoothChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 451);
            this.Controls.Add(this.alphaChart);
            this.Controls.Add(this.MChart);
            this.Controls.Add(this.expSmooth);
            this.Name = "ExpSmoothChart";
            this.Text = "Экспоненциальное сглаживание";
            this.Load += new System.EventHandler(this.ExpSmoothChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expSmooth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart expSmooth;
        private System.Windows.Forms.CheckBox MChart;
        private System.Windows.Forms.CheckBox alphaChart;
    }
}