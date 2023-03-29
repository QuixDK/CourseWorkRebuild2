namespace CourseWorkRebuild2
{
    partial class ChartForm
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
            this.functionDiagrams = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.listBox9 = new System.Windows.Forms.ListBox();
            this.listBox10 = new System.Windows.Forms.ListBox();
            this.listBox11 = new System.Windows.Forms.ListBox();
            this.listBox12 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.functionDiagrams)).BeginInit();
            this.SuspendLayout();
            // 
            // functionDiagrams
            // 
            chartArea2.Name = "ChartArea1";
            this.functionDiagrams.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.functionDiagrams.Legends.Add(legend2);
            this.functionDiagrams.Location = new System.Drawing.Point(12, 12);
            this.functionDiagrams.Name = "functionDiagrams";
            this.functionDiagrams.Size = new System.Drawing.Size(1159, 410);
            this.functionDiagrams.TabIndex = 0;
            this.functionDiagrams.Text = "chart1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1188, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.showResponseFunctionSelectBox_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1188, 47);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 20);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.forecastResponseFunctionSelectBox_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(1188, 83);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(95, 20);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.bottomLineSelectBox_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(1188, 121);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(95, 20);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Click += new System.EventHandler(this.forecastBottomValues_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(1188, 157);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(95, 20);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Click += new System.EventHandler(this.topLineSelectBox_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(1188, 199);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(95, 20);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Click += new System.EventHandler(this.forecastTopLineValues_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 444);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(77, 132);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(95, 445);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(77, 132);
            this.listBox2.TabIndex = 8;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(178, 444);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(77, 132);
            this.listBox3.TabIndex = 8;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(261, 444);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(77, 132);
            this.listBox4.TabIndex = 9;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(344, 444);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(77, 132);
            this.listBox5.TabIndex = 9;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 16;
            this.listBox6.Location = new System.Drawing.Point(427, 445);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(77, 132);
            this.listBox6.TabIndex = 10;
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 16;
            this.listBox7.Location = new System.Drawing.Point(468, 465);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(77, 132);
            this.listBox7.TabIndex = 11;
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.ItemHeight = 16;
            this.listBox8.Location = new System.Drawing.Point(562, 444);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(121, 212);
            this.listBox8.TabIndex = 11;
            // 
            // listBox9
            // 
            this.listBox9.FormattingEnabled = true;
            this.listBox9.ItemHeight = 16;
            this.listBox9.Location = new System.Drawing.Point(689, 444);
            this.listBox9.Name = "listBox9";
            this.listBox9.Size = new System.Drawing.Size(144, 212);
            this.listBox9.TabIndex = 12;
            // 
            // listBox10
            // 
            this.listBox10.FormattingEnabled = true;
            this.listBox10.ItemHeight = 16;
            this.listBox10.Location = new System.Drawing.Point(839, 444);
            this.listBox10.Name = "listBox10";
            this.listBox10.Size = new System.Drawing.Size(156, 212);
            this.listBox10.TabIndex = 13;
            // 
            // listBox11
            // 
            this.listBox11.FormattingEnabled = true;
            this.listBox11.ItemHeight = 16;
            this.listBox11.Location = new System.Drawing.Point(1001, 444);
            this.listBox11.Name = "listBox11";
            this.listBox11.Size = new System.Drawing.Size(181, 212);
            this.listBox11.TabIndex = 14;
            // 
            // listBox12
            // 
            this.listBox12.FormattingEnabled = true;
            this.listBox12.ItemHeight = 16;
            this.listBox12.Location = new System.Drawing.Point(1188, 444);
            this.listBox12.Name = "listBox12";
            this.listBox12.Size = new System.Drawing.Size(171, 212);
            this.listBox12.TabIndex = 15;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 667);
            this.Controls.Add(this.listBox12);
            this.Controls.Add(this.listBox11);
            this.Controls.Add(this.listBox10);
            this.Controls.Add(this.listBox9);
            this.Controls.Add(this.listBox8);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.functionDiagrams);
            this.Name = "ChartForm";
            this.Text = "График";
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.functionDiagrams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart functionDiagrams;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.ListBox listBox9;
        private System.Windows.Forms.ListBox listBox10;
        private System.Windows.Forms.ListBox listBox11;
        private System.Windows.Forms.ListBox listBox12;
    }
}