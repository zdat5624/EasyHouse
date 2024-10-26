namespace DesignEasyHouse1.formsGiamDoc.moduleVeSinh
{
    partial class bieuDoHoatDong
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartChiPhi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSoSanhCPVaDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grbChonthoiGian = new System.Windows.Forms.GroupBox();
            this.btnChonThoiGian = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Button();
            this.lblDanhGiaQuaChiPhi = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartChiPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoSanhCPVaDT)).BeginInit();
            this.grbChonthoiGian.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartChiPhi
            // 
            chartArea1.Name = "ChartArea1";
            this.chartChiPhi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartChiPhi.Legends.Add(legend1);
            this.chartChiPhi.Location = new System.Drawing.Point(123, 208);
            this.chartChiPhi.Name = "chartChiPhi";
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Yellow;
            series1.Legend = "Legend1";
            series1.Name = "Chi phí dự kiến";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Chi phí thực tế";
            this.chartChiPhi.Series.Add(series1);
            this.chartChiPhi.Series.Add(series2);
            this.chartChiPhi.Size = new System.Drawing.Size(418, 263);
            this.chartChiPhi.TabIndex = 0;
            this.chartChiPhi.Text = "chart1";
            this.chartChiPhi.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chartSoSanhCPVaDT
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSoSanhCPVaDT.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSoSanhCPVaDT.Legends.Add(legend2);
            this.chartSoSanhCPVaDT.Location = new System.Drawing.Point(123, 208);
            this.chartSoSanhCPVaDT.Name = "chartSoSanhCPVaDT";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Chi phí thực tế";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series4.Legend = "Legend1";
            series4.Name = "Doanh thu";
            this.chartSoSanhCPVaDT.Series.Add(series3);
            this.chartSoSanhCPVaDT.Series.Add(series4);
            this.chartSoSanhCPVaDT.Size = new System.Drawing.Size(418, 263);
            this.chartSoSanhCPVaDT.TabIndex = 1;
            this.chartSoSanhCPVaDT.Text = "chart2";
            this.chartSoSanhCPVaDT.Click += new System.EventHandler(this.chartSoSanhCPVaDT_Click);
            // 
            // grbChonthoiGian
            // 
            this.grbChonthoiGian.Controls.Add(this.listBox1);
            this.grbChonthoiGian.Controls.Add(this.btnChonThoiGian);
            this.grbChonthoiGian.Location = new System.Drawing.Point(293, 103);
            this.grbChonthoiGian.Name = "grbChonthoiGian";
            this.grbChonthoiGian.Size = new System.Drawing.Size(514, 74);
            this.grbChonthoiGian.TabIndex = 22;
            this.grbChonthoiGian.TabStop = false;
            this.grbChonthoiGian.Text = "Hãy chọn mốc thời gian bạn muốn xem";
            // 
            // btnChonThoiGian
            // 
            this.btnChonThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnChonThoiGian.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChonThoiGian.Location = new System.Drawing.Point(420, 25);
            this.btnChonThoiGian.Name = "btnChonThoiGian";
            this.btnChonThoiGian.Size = new System.Drawing.Size(82, 40);
            this.btnChonThoiGian.TabIndex = 3;
            this.btnChonThoiGian.Text = "xem";
            this.btnChonThoiGian.UseVisualStyleBackColor = false;
            this.btnChonThoiGian.Click += new System.EventHandler(this.btnChonThoiGian_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.lblDoanhThu);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 70);
            this.panel1.TabIndex = 20;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDoanhThu.FlatAppearance.BorderSize = 0;
            this.lblDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.ForeColor = System.Drawing.Color.Transparent;
            this.lblDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.lblDoanhThu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(311, 70);
            this.lblDoanhThu.TabIndex = 1;
            this.lblDoanhThu.Text = "Báo cáo doanh thu";
            this.lblDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDoanhThu.UseVisualStyleBackColor = true;
            // 
            // lblDanhGiaQuaChiPhi
            // 
            this.lblDanhGiaQuaChiPhi.AutoSize = true;
            this.lblDanhGiaQuaChiPhi.Location = new System.Drawing.Point(567, 208);
            this.lblDanhGiaQuaChiPhi.Name = "lblDanhGiaQuaChiPhi";
            this.lblDanhGiaQuaChiPhi.Size = new System.Drawing.Size(181, 16);
            this.lblDanhGiaQuaChiPhi.TabIndex = 23;
            this.lblDanhGiaQuaChiPhi.Text = "Đánh giá hiệu quả từ hệ thống";
            this.lblDanhGiaQuaChiPhi.Click += new System.EventHandler(this.lblDanhGiaQuaChiPhi_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(570, 244);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(462, 213);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "1 tuần ",
            "1 tháng ",
            "6 tháng ",
            "1 năm "});
            this.listBox1.Location = new System.Drawing.Point(144, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 29);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bieuDoHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 534);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblDanhGiaQuaChiPhi);
            this.Controls.Add(this.grbChonthoiGian);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartSoSanhCPVaDT);
            this.Controls.Add(this.chartChiPhi);
            this.Name = "bieuDoHoatDong";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartChiPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoSanhCPVaDT)).EndInit();
            this.grbChonthoiGian.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartChiPhi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSoSanhCPVaDT;
        private System.Windows.Forms.GroupBox grbChonthoiGian;
        private System.Windows.Forms.Button btnChonThoiGian;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lblDoanhThu;
        private System.Windows.Forms.Label lblDanhGiaQuaChiPhi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}