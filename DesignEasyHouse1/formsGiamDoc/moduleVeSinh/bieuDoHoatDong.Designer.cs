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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grbChonthoiGian = new System.Windows.Forms.GroupBox();
            this.lblChonThoiGian = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnChonThoiGian = new System.Windows.Forms.Button();
            this.dtpChonThoiGian = new System.Windows.Forms.DateTimePicker();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Button();
            this.lblDanhGiaQuaChiPhi = new System.Windows.Forms.Label();
            this.txtDanhGia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.grbChonthoiGian.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(159, 204);
            this.chart1.Name = "chart1";
            series1.BorderColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Yellow;
            series1.Legend = "Legend1";
            series1.Name = "Chi phí dự kiến";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Chi phí thực tế";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(370, 220);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(568, 204);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Chi phí thực tế";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series4.Legend = "Legend1";
            series4.Name = "Doanh thu";
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(370, 220);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // grbChonthoiGian
            // 
            this.grbChonthoiGian.Controls.Add(this.lblChonThoiGian);
            this.grbChonthoiGian.Controls.Add(this.dateTimePicker1);
            this.grbChonthoiGian.Controls.Add(this.btnChonThoiGian);
            this.grbChonthoiGian.Controls.Add(this.dtpChonThoiGian);
            this.grbChonthoiGian.Location = new System.Drawing.Point(137, 107);
            this.grbChonthoiGian.Name = "grbChonthoiGian";
            this.grbChonthoiGian.Size = new System.Drawing.Size(915, 74);
            this.grbChonthoiGian.TabIndex = 22;
            this.grbChonthoiGian.TabStop = false;
            this.grbChonthoiGian.Text = "Hãy chọn mốc thời gian bạn muốn xem";
            // 
            // lblChonThoiGian
            // 
            this.lblChonThoiGian.AutoSize = true;
            this.lblChonThoiGian.Location = new System.Drawing.Point(361, 37);
            this.lblChonThoiGian.Name = "lblChonThoiGian";
            this.lblChonThoiGian.Size = new System.Drawing.Size(31, 16);
            this.lblChonThoiGian.TabIndex = 5;
            this.lblChonThoiGian.Text = "Đến";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(433, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(315, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btnChonThoiGian
            // 
            this.btnChonThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnChonThoiGian.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChonThoiGian.Location = new System.Drawing.Point(769, 28);
            this.btnChonThoiGian.Name = "btnChonThoiGian";
            this.btnChonThoiGian.Size = new System.Drawing.Size(82, 34);
            this.btnChonThoiGian.TabIndex = 3;
            this.btnChonThoiGian.Text = "xem";
            this.btnChonThoiGian.UseVisualStyleBackColor = false;
            // 
            // dtpChonThoiGian
            // 
            this.dtpChonThoiGian.Location = new System.Drawing.Point(6, 35);
            this.dtpChonThoiGian.Name = "dtpChonThoiGian";
            this.dtpChonThoiGian.Size = new System.Drawing.Size(315, 22);
            this.dtpChonThoiGian.TabIndex = 2;
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnTroLai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTroLai.Location = new System.Drawing.Point(28, 78);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 33);
            this.btnTroLai.TabIndex = 21;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
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
            this.lblDanhGiaQuaChiPhi.Location = new System.Drawing.Point(156, 448);
            this.lblDanhGiaQuaChiPhi.Name = "lblDanhGiaQuaChiPhi";
            this.lblDanhGiaQuaChiPhi.Size = new System.Drawing.Size(114, 16);
            this.lblDanhGiaQuaChiPhi.TabIndex = 23;
            this.lblDanhGiaQuaChiPhi.Text = "Đánh giá hiệu quả";
            this.lblDanhGiaQuaChiPhi.Click += new System.EventHandler(this.lblDanhGiaQuaChiPhi_Click);
            // 
            // txtDanhGia
            // 
            this.txtDanhGia.Location = new System.Drawing.Point(276, 448);
            this.txtDanhGia.Name = "txtDanhGia";
            this.txtDanhGia.Size = new System.Drawing.Size(662, 22);
            this.txtDanhGia.TabIndex = 24;
            this.txtDanhGia.Text = "Hệ thống sẽ thực hiện và cho đánh giá ở đây";
            // 
            // bieuDoHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 534);
            this.Controls.Add(this.txtDanhGia);
            this.Controls.Add(this.lblDanhGiaQuaChiPhi);
            this.Controls.Add(this.grbChonthoiGian);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "bieuDoHoatDong";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.grbChonthoiGian.ResumeLayout(false);
            this.grbChonthoiGian.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox grbChonthoiGian;
        private System.Windows.Forms.Label lblChonThoiGian;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnChonThoiGian;
        private System.Windows.Forms.DateTimePicker dtpChonThoiGian;
        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lblDoanhThu;
        private System.Windows.Forms.Label lblDanhGiaQuaChiPhi;
        private System.Windows.Forms.TextBox txtDanhGia;
    }
}