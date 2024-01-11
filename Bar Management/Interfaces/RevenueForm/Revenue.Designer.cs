namespace Bar_Management.RevenueForm
{
    partial class Revenue
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
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxNam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.thang = new System.Windows.Forms.Button();
            this.rightThang = new System.Windows.Forms.Button();
            this.leftThang = new System.Windows.Forms.Button();
            this.leftTuan = new System.Windows.Forms.Button();
            this.rightTuan = new System.Windows.Forms.Button();
            this.tuan = new System.Windows.Forms.Button();
            this.selectThang = new System.Windows.Forms.RadioButton();
            this.selectTuan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            this.chart2.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text;
            this.chart2.BackImageTransparentColor = System.Drawing.Color.Black;
            this.chart2.BackSecondaryColor = System.Drawing.Color.DarkGray;
            this.chart2.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(94, 307);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(1526, 548);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "chart1";
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025"});
            this.comboBoxNam.Location = new System.Drawing.Point(171, 270);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(121, 30);
            this.comboBoxNam.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(545, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tuần";
            // 
            // thang
            // 
            this.thang.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.thang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thang.Location = new System.Drawing.Point(339, 262);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(156, 39);
            this.thang.TabIndex = 20;
            this.thang.Text = "Thg 1";
            this.thang.UseVisualStyleBackColor = false;
            // 
            // rightThang
            // 
            this.rightThang.BackColor = System.Drawing.Color.White;
            this.rightThang.Location = new System.Drawing.Point(459, 262);
            this.rightThang.Name = "rightThang";
            this.rightThang.Size = new System.Drawing.Size(36, 39);
            this.rightThang.TabIndex = 21;
            this.rightThang.Text = ">";
            this.rightThang.UseVisualStyleBackColor = false;
            this.rightThang.Click += new System.EventHandler(this.rightThang_Click);
            // 
            // leftThang
            // 
            this.leftThang.BackColor = System.Drawing.Color.White;
            this.leftThang.Location = new System.Drawing.Point(339, 262);
            this.leftThang.Name = "leftThang";
            this.leftThang.Size = new System.Drawing.Size(40, 39);
            this.leftThang.TabIndex = 22;
            this.leftThang.Text = "<";
            this.leftThang.UseVisualStyleBackColor = false;
            this.leftThang.Click += new System.EventHandler(this.leftThang_Click);
            // 
            // leftTuan
            // 
            this.leftTuan.BackColor = System.Drawing.Color.White;
            this.leftTuan.Location = new System.Drawing.Point(549, 261);
            this.leftTuan.Name = "leftTuan";
            this.leftTuan.Size = new System.Drawing.Size(40, 39);
            this.leftTuan.TabIndex = 25;
            this.leftTuan.Text = "<";
            this.leftTuan.UseVisualStyleBackColor = false;
            this.leftTuan.Click += new System.EventHandler(this.leftTuan_Click);
            // 
            // rightTuan
            // 
            this.rightTuan.BackColor = System.Drawing.Color.White;
            this.rightTuan.Location = new System.Drawing.Point(669, 261);
            this.rightTuan.Name = "rightTuan";
            this.rightTuan.Size = new System.Drawing.Size(36, 39);
            this.rightTuan.TabIndex = 24;
            this.rightTuan.Text = ">";
            this.rightTuan.UseVisualStyleBackColor = false;
            this.rightTuan.Click += new System.EventHandler(this.rightTuan_Click);
            // 
            // tuan
            // 
            this.tuan.BackColor = System.Drawing.Color.White;
            this.tuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuan.Location = new System.Drawing.Point(549, 261);
            this.tuan.Name = "tuan";
            this.tuan.Size = new System.Drawing.Size(156, 39);
            this.tuan.TabIndex = 23;
            this.tuan.Text = "08/01";
            this.tuan.UseVisualStyleBackColor = false;
            // 
            // selectThang
            // 
            this.selectThang.AutoSize = true;
            this.selectThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectThang.Location = new System.Drawing.Point(170, 175);
            this.selectThang.Name = "selectThang";
            this.selectThang.Size = new System.Drawing.Size(84, 27);
            this.selectThang.TabIndex = 26;
            this.selectThang.TabStop = true;
            this.selectThang.Text = "Tháng";
            this.selectThang.UseVisualStyleBackColor = true;
            this.selectThang.CheckedChanged += new System.EventHandler(this.selectThang_CheckedChanged);
            // 
            // selectTuan
            // 
            this.selectTuan.AutoSize = true;
            this.selectTuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTuan.Location = new System.Drawing.Point(270, 175);
            this.selectTuan.Name = "selectTuan";
            this.selectTuan.Size = new System.Drawing.Size(72, 27);
            this.selectTuan.TabIndex = 27;
            this.selectTuan.TabStop = true;
            this.selectTuan.Text = "Tuần";
            this.selectTuan.UseVisualStyleBackColor = true;
            this.selectTuan.CheckedChanged += new System.EventHandler(this.selectNam_CheckedChanged);
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1918, 1028);
            this.Controls.Add(this.selectTuan);
            this.Controls.Add(this.selectThang);
            this.Controls.Add(this.leftTuan);
            this.Controls.Add(this.rightTuan);
            this.Controls.Add(this.tuan);
            this.Controls.Add(this.leftThang);
            this.Controls.Add(this.rightThang);
            this.Controls.Add(this.thang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNam);
            this.Controls.Add(this.chart2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(20000, 200000);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "Revenue";
            this.Text = "Revenue";
            this.Load += new System.EventHandler(this.Revenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ComboBox comboBoxNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button thang;
        private System.Windows.Forms.Button rightThang;
        private System.Windows.Forms.Button leftThang;
        private System.Windows.Forms.Button leftTuan;
        private System.Windows.Forms.Button rightTuan;
        private System.Windows.Forms.Button tuan;
        private System.Windows.Forms.RadioButton selectThang;
        private System.Windows.Forms.RadioButton selectTuan;
    }
}