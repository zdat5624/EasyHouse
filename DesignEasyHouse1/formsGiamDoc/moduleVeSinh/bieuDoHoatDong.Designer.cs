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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartSoSanhCP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSoSanhCPVaDT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grbChonthoiGian = new System.Windows.Forms.GroupBox();
            this.btnChonThoiGian = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Button();
            this.btnXemBieuDo = new System.Windows.Forms.Button();
            this.cbThoiGian = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoSanhCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoSanhCPVaDT)).BeginInit();
            this.grbChonthoiGian.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartSoSanhCP
            // 
            chartArea7.Name = "MainArea";
            this.chartSoSanhCP.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartSoSanhCP.Legends.Add(legend7);
            this.chartSoSanhCP.Location = new System.Drawing.Point(172, 238);
            this.chartSoSanhCP.Name = "chartSoSanhCP";
            series13.BorderColor = System.Drawing.Color.White;
            series13.ChartArea = "MainArea";
            series13.Color = System.Drawing.Color.Yellow;
            series13.Legend = "Legend1";
            series13.Name = "Dự kiến";
            series14.ChartArea = "MainArea";
            series14.Color = System.Drawing.Color.Red;
            series14.Legend = "Legend1";
            series14.Name = "Thực tế";
            this.chartSoSanhCP.Series.Add(series13);
            this.chartSoSanhCP.Series.Add(series14);
            this.chartSoSanhCP.Size = new System.Drawing.Size(687, 263);
            this.chartSoSanhCP.TabIndex = 0;
            this.chartSoSanhCP.Text = "chart1";
            title7.Name = "Biểu đồ so sánh chi phí dự kiến và thực tế";
            title7.Text = "Biểu đồ so sánh chi phí dự kiến và thực tế";
            this.chartSoSanhCP.Titles.Add(title7);
            this.chartSoSanhCP.Click += new System.EventHandler(this.chartSoSanhCP_Click);
            // 
            // chartSoSanhCPVaDT
            // 
            chartArea8.Name = "MainArea";
            this.chartSoSanhCPVaDT.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartSoSanhCPVaDT.Legends.Add(legend8);
            this.chartSoSanhCPVaDT.Location = new System.Drawing.Point(172, 238);
            this.chartSoSanhCPVaDT.Name = "chartSoSanhCPVaDT";
            series15.ChartArea = "MainArea";
            series15.Color = System.Drawing.Color.Red;
            series15.Legend = "Legend1";
            series15.Name = "Chi phí";
            series16.ChartArea = "MainArea";
            series16.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series16.Legend = "Legend1";
            series16.Name = "Doanh thu";
            this.chartSoSanhCPVaDT.Series.Add(series15);
            this.chartSoSanhCPVaDT.Series.Add(series16);
            this.chartSoSanhCPVaDT.Size = new System.Drawing.Size(687, 263);
            this.chartSoSanhCPVaDT.TabIndex = 1;
            this.chartSoSanhCPVaDT.Text = "chart2";
            title8.Name = "Biểu đồ so sánh chi phí và doanh thu ";
            title8.Text = "Biểu đồ so sánh chi phí và doanh thu ";
            this.chartSoSanhCPVaDT.Titles.Add(title8);
            this.chartSoSanhCPVaDT.Click += new System.EventHandler(this.chartSoSanhCPVaDT_Click);
            // 
            // grbChonthoiGian
            // 
            this.grbChonthoiGian.Controls.Add(this.cbThoiGian);
            this.grbChonthoiGian.Controls.Add(this.btnChonThoiGian);
            this.grbChonthoiGian.Location = new System.Drawing.Point(424, 109);
            this.grbChonthoiGian.Name = "grbChonthoiGian";
            this.grbChonthoiGian.Size = new System.Drawing.Size(514, 74);
            this.grbChonthoiGian.TabIndex = 22;
            this.grbChonthoiGian.TabStop = false;
            this.grbChonthoiGian.Text = "Hãy chọn khoảng thời gian bạn muốn xem";
            // 
            // btnChonThoiGian
            // 
            this.btnChonThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnChonThoiGian.Cursor = System.Windows.Forms.Cursors.Hand;
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
            // btnXemBieuDo
            // 
            this.btnXemBieuDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnXemBieuDo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemBieuDo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBieuDo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXemBieuDo.Location = new System.Drawing.Point(90, 122);
            this.btnXemBieuDo.Name = "btnXemBieuDo";
            this.btnXemBieuDo.Size = new System.Drawing.Size(314, 61);
            this.btnXemBieuDo.TabIndex = 23;
            this.btnXemBieuDo.Text = "Xem biểu đồ so sánh tổng chi phí và doanh thu";
            this.btnXemBieuDo.UseVisualStyleBackColor = false;
            this.btnXemBieuDo.Click += new System.EventHandler(this.btnXemBieuDo_Click);
            // 
            // cbThoiGian
            // 
            this.cbThoiGian.FormattingEnabled = true;
            this.cbThoiGian.Items.AddRange(new object[] {
            "3 tháng",
            "6 tháng",
            "1 năm "});
            this.cbThoiGian.Location = new System.Drawing.Point(67, 34);
            this.cbThoiGian.Name = "cbThoiGian";
            this.cbThoiGian.Size = new System.Drawing.Size(347, 24);
            this.cbThoiGian.TabIndex = 24;
            // 
            // bieuDoHoatDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 603);
            this.Controls.Add(this.btnXemBieuDo);
            this.Controls.Add(this.grbChonthoiGian);
            this.Controls.Add(this.chartSoSanhCPVaDT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartSoSanhCP);
            this.Name = "bieuDoHoatDong";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.bieuDoHoatDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSoSanhCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSoSanhCPVaDT)).EndInit();
            this.grbChonthoiGian.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSoSanhCP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSoSanhCPVaDT;
        private System.Windows.Forms.GroupBox grbChonthoiGian;
        private System.Windows.Forms.Button btnChonThoiGian;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lblDoanhThu;
        private System.Windows.Forms.Button btnXemBieuDo;
        private System.Windows.Forms.ComboBox cbThoiGian;
    }
}