namespace DesignEasyHouse1.formsCuDan.moduleVeSinh
{
    partial class formYeuCauVeSinh
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
            this.grbMuaVatTu = new System.Windows.Forms.GroupBox();
            this.cbKhuVucVeSinh = new System.Windows.Forms.ComboBox();
            this.cbLoaiVeSinh = new System.Windows.Forms.ComboBox();
            this.lblKhuVucCuThe = new System.Windows.Forms.Label();
            this.txtKhuVucCuThe = new System.Windows.Forms.TextBox();
            this.dtpThoiGianVeSinh = new System.Windows.Forms.DateTimePicker();
            this.lblKhuVucVeSinh = new System.Windows.Forms.Label();
            this.btnGuiYeuCau = new System.Windows.Forms.Button();
            this.lblChonThoiGian = new System.Windows.Forms.Label();
            this.lblLoaiVeSinh = new System.Windows.Forms.Label();
            this.radVeSinhDinhKyTuan = new System.Windows.Forms.RadioButton();
            this.radVeSinhThuong = new System.Windows.Forms.RadioButton();
            this.lblChonKieuVeSinh = new System.Windows.Forms.Label();
            this.radVeSinhDinhKyThang = new System.Windows.Forms.RadioButton();
            this.grbMuaVatTu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbMuaVatTu
            // 
            this.grbMuaVatTu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grbMuaVatTu.Controls.Add(this.radVeSinhDinhKyThang);
            this.grbMuaVatTu.Controls.Add(this.lblChonKieuVeSinh);
            this.grbMuaVatTu.Controls.Add(this.radVeSinhThuong);
            this.grbMuaVatTu.Controls.Add(this.radVeSinhDinhKyTuan);
            this.grbMuaVatTu.Controls.Add(this.cbKhuVucVeSinh);
            this.grbMuaVatTu.Controls.Add(this.cbLoaiVeSinh);
            this.grbMuaVatTu.Controls.Add(this.lblKhuVucCuThe);
            this.grbMuaVatTu.Controls.Add(this.txtKhuVucCuThe);
            this.grbMuaVatTu.Controls.Add(this.dtpThoiGianVeSinh);
            this.grbMuaVatTu.Controls.Add(this.lblKhuVucVeSinh);
            this.grbMuaVatTu.Controls.Add(this.btnGuiYeuCau);
            this.grbMuaVatTu.Controls.Add(this.lblChonThoiGian);
            this.grbMuaVatTu.Controls.Add(this.lblLoaiVeSinh);
            this.grbMuaVatTu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMuaVatTu.Location = new System.Drawing.Point(65, 43);
            this.grbMuaVatTu.Name = "grbMuaVatTu";
            this.grbMuaVatTu.Size = new System.Drawing.Size(941, 643);
            this.grbMuaVatTu.TabIndex = 5;
            this.grbMuaVatTu.TabStop = false;
            this.grbMuaVatTu.Text = "Thông tin yêu cầu vệ sinh";
            // 
            // cbKhuVucVeSinh
            // 
            this.cbKhuVucVeSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKhuVucVeSinh.FormattingEnabled = true;
            this.cbKhuVucVeSinh.Items.AddRange(new object[] {
            "phòng khách",
            "phòng ngủ",
            "nhà bếp"});
            this.cbKhuVucVeSinh.Location = new System.Drawing.Point(228, 236);
            this.cbKhuVucVeSinh.Name = "cbKhuVucVeSinh";
            this.cbKhuVucVeSinh.Size = new System.Drawing.Size(503, 36);
            this.cbKhuVucVeSinh.TabIndex = 16;
            // 
            // cbLoaiVeSinh
            // 
            this.cbLoaiVeSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLoaiVeSinh.FormattingEnabled = true;
            this.cbLoaiVeSinh.Items.AddRange(new object[] {
            "Căn hộ riêng",
            "Khu vực chung"});
            this.cbLoaiVeSinh.Location = new System.Drawing.Point(231, 175);
            this.cbLoaiVeSinh.Name = "cbLoaiVeSinh";
            this.cbLoaiVeSinh.Size = new System.Drawing.Size(503, 36);
            this.cbLoaiVeSinh.TabIndex = 15;
            // 
            // lblKhuVucCuThe
            // 
            this.lblKhuVucCuThe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKhuVucCuThe.AutoSize = true;
            this.lblKhuVucCuThe.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhuVucCuThe.Location = new System.Drawing.Point(230, 274);
            this.lblKhuVucCuThe.Name = "lblKhuVucCuThe";
            this.lblKhuVucCuThe.Size = new System.Drawing.Size(206, 23);
            this.lblKhuVucCuThe.TabIndex = 14;
            this.lblKhuVucCuThe.Text = "Khu vực cụ thể (tùy chọn)";
            // 
            // txtKhuVucCuThe
            // 
            this.txtKhuVucCuThe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKhuVucCuThe.Location = new System.Drawing.Point(231, 300);
            this.txtKhuVucCuThe.Name = "txtKhuVucCuThe";
            this.txtKhuVucCuThe.Size = new System.Drawing.Size(503, 34);
            this.txtKhuVucCuThe.TabIndex = 13;
            // 
            // dtpThoiGianVeSinh
            // 
            this.dtpThoiGianVeSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpThoiGianVeSinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThoiGianVeSinh.Location = new System.Drawing.Point(232, 374);
            this.dtpThoiGianVeSinh.Name = "dtpThoiGianVeSinh";
            this.dtpThoiGianVeSinh.Size = new System.Drawing.Size(503, 30);
            this.dtpThoiGianVeSinh.TabIndex = 12;
            // 
            // lblKhuVucVeSinh
            // 
            this.lblKhuVucVeSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKhuVucVeSinh.AutoSize = true;
            this.lblKhuVucVeSinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhuVucVeSinh.Location = new System.Drawing.Point(230, 210);
            this.lblKhuVucVeSinh.Name = "lblKhuVucVeSinh";
            this.lblKhuVucVeSinh.Size = new System.Drawing.Size(173, 23);
            this.lblKhuVucVeSinh.TabIndex = 10;
            this.lblKhuVucVeSinh.Text = "Chọn khu vực vệ sinh";
            // 
            // btnGuiYeuCau
            // 
            this.btnGuiYeuCau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuiYeuCau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnGuiYeuCau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiYeuCau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuiYeuCau.Location = new System.Drawing.Point(397, 558);
            this.btnGuiYeuCau.Name = "btnGuiYeuCau";
            this.btnGuiYeuCau.Size = new System.Drawing.Size(158, 62);
            this.btnGuiYeuCau.TabIndex = 8;
            this.btnGuiYeuCau.Text = "Gửi yêu cầu";
            this.btnGuiYeuCau.UseVisualStyleBackColor = false;
            this.btnGuiYeuCau.Click += new System.EventHandler(this.btnGuiYeuCau_Click);
            // 
            // lblChonThoiGian
            // 
            this.lblChonThoiGian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChonThoiGian.AutoSize = true;
            this.lblChonThoiGian.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonThoiGian.Location = new System.Drawing.Point(231, 348);
            this.lblChonThoiGian.Name = "lblChonThoiGian";
            this.lblChonThoiGian.Size = new System.Drawing.Size(174, 23);
            this.lblChonThoiGian.TabIndex = 6;
            this.lblChonThoiGian.Text = "chọn khung thời gian";
            // 
            // lblLoaiVeSinh
            // 
            this.lblLoaiVeSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoaiVeSinh.AutoSize = true;
            this.lblLoaiVeSinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiVeSinh.Location = new System.Drawing.Point(228, 149);
            this.lblLoaiVeSinh.Name = "lblLoaiVeSinh";
            this.lblLoaiVeSinh.Size = new System.Drawing.Size(141, 23);
            this.lblLoaiVeSinh.TabIndex = 2;
            this.lblLoaiVeSinh.Text = "Chọn loại vệ sinh";
            // 
            // radVeSinhDinhKyTuan
            // 
            this.radVeSinhDinhKyTuan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radVeSinhDinhKyTuan.AutoSize = true;
            this.radVeSinhDinhKyTuan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVeSinhDinhKyTuan.Location = new System.Drawing.Point(346, 456);
            this.radVeSinhDinhKyTuan.Name = "radVeSinhDinhKyTuan";
            this.radVeSinhDinhKyTuan.Size = new System.Drawing.Size(128, 27);
            this.radVeSinhDinhKyTuan.TabIndex = 17;
            this.radVeSinhDinhKyTuan.TabStop = true;
            this.radVeSinhDinhKyTuan.Text = "Định kỳ tuần";
            this.radVeSinhDinhKyTuan.UseVisualStyleBackColor = true;
            // 
            // radVeSinhThuong
            // 
            this.radVeSinhThuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radVeSinhThuong.AutoSize = true;
            this.radVeSinhThuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVeSinhThuong.Location = new System.Drawing.Point(346, 423);
            this.radVeSinhThuong.Name = "radVeSinhThuong";
            this.radVeSinhThuong.Size = new System.Drawing.Size(90, 27);
            this.radVeSinhThuong.TabIndex = 18;
            this.radVeSinhThuong.TabStop = true;
            this.radVeSinhThuong.Text = "Thường";
            this.radVeSinhThuong.UseVisualStyleBackColor = true;
            // 
            // lblChonKieuVeSinh
            // 
            this.lblChonKieuVeSinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChonKieuVeSinh.AutoSize = true;
            this.lblChonKieuVeSinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonKieuVeSinh.Location = new System.Drawing.Point(227, 423);
            this.lblChonKieuVeSinh.Name = "lblChonKieuVeSinh";
            this.lblChonKieuVeSinh.Size = new System.Drawing.Size(106, 23);
            this.lblChonKieuVeSinh.TabIndex = 19;
            this.lblChonKieuVeSinh.Text = "Kiểu vệ sinh ";
            // 
            // radVeSinhDinhKyThang
            // 
            this.radVeSinhDinhKyThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radVeSinhDinhKyThang.AutoSize = true;
            this.radVeSinhDinhKyThang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVeSinhDinhKyThang.Location = new System.Drawing.Point(346, 489);
            this.radVeSinhDinhKyThang.Name = "radVeSinhDinhKyThang";
            this.radVeSinhDinhKyThang.Size = new System.Drawing.Size(138, 27);
            this.radVeSinhDinhKyThang.TabIndex = 20;
            this.radVeSinhDinhKyThang.TabStop = true;
            this.radVeSinhDinhKyThang.Text = "Định kỳ tháng";
            this.radVeSinhDinhKyThang.UseVisualStyleBackColor = true;
            // 
            // formYeuCauVeSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 698);
            this.Controls.Add(this.grbMuaVatTu);
            this.Name = "formYeuCauVeSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grbMuaVatTu.ResumeLayout(false);
            this.grbMuaVatTu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbMuaVatTu;
        private System.Windows.Forms.Button btnGuiYeuCau;
        private System.Windows.Forms.Label lblChonThoiGian;
        private System.Windows.Forms.Label lblLoaiVeSinh;
        private System.Windows.Forms.Label lblKhuVucVeSinh;
        private System.Windows.Forms.DateTimePicker dtpThoiGianVeSinh;
        private System.Windows.Forms.Label lblKhuVucCuThe;
        private System.Windows.Forms.TextBox txtKhuVucCuThe;
        private System.Windows.Forms.ComboBox cbLoaiVeSinh;
        private System.Windows.Forms.ComboBox cbKhuVucVeSinh;
        private System.Windows.Forms.Label lblChonKieuVeSinh;
        private System.Windows.Forms.RadioButton radVeSinhThuong;
        private System.Windows.Forms.RadioButton radVeSinhDinhKyTuan;
        private System.Windows.Forms.RadioButton radVeSinhDinhKyThang;
    }
}