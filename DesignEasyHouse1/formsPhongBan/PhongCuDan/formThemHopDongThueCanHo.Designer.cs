namespace DesignEasyHouse1.formsPhongBan
{
    partial class formThemHopDongThueCanHo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnThemHopDong = new System.Windows.Forms.Button();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.btnThemCuDan = new System.Windows.Forms.Button();
            this.lbSoDienThoai = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtDieuKhoan = new System.Windows.Forms.TextBox();
            this.lbCCCD = new System.Windows.Forms.Label();
            this.btnTieuDe = new System.Windows.Forms.Button();
            this.nudTienThue = new System.Windows.Forms.NumericUpDown();
            this.cbbMaCanHo = new System.Windows.Forms.ComboBox();
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvCuDanThue = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbVaiTro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCuDanID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienThue)).BeginInit();
            this.panelTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCuDanThue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuyBo);
            this.panel1.Controls.Add(this.btnThemHopDong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 566);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 50);
            this.panel1.TabIndex = 48;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyBo.BackColor = System.Drawing.Color.Silver;
            this.btnHuyBo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuyBo.FlatAppearance.BorderSize = 0;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnHuyBo.ForeColor = System.Drawing.Color.White;
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(883, 2);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHuyBo.Size = new System.Drawing.Size(120, 40);
            this.btnHuyBo.TabIndex = 32;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnThemHopDong
            // 
            this.btnThemHopDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(200)))));
            this.btnThemHopDong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemHopDong.FlatAppearance.BorderSize = 0;
            this.btnThemHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHopDong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnThemHopDong.ForeColor = System.Drawing.Color.White;
            this.btnThemHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHopDong.Location = new System.Drawing.Point(757, 2);
            this.btnThemHopDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemHopDong.Name = "btnThemHopDong";
            this.btnThemHopDong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemHopDong.Size = new System.Drawing.Size(120, 40);
            this.btnThemHopDong.TabIndex = 31;
            this.btnThemHopDong.Text = "Thêm";
            this.btnThemHopDong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemHopDong.UseVisualStyleBackColor = false;
            this.btnThemHopDong.Click += new System.EventHandler(this.btnThemHopDong_Click);
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(56, 74);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(91, 23);
            this.lbHoTen.TabIndex = 7;
            this.lbHoTen.Text = "Mã căn hộ";
            // 
            // btnThemCuDan
            // 
            this.btnThemCuDan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemCuDan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThemCuDan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemCuDan.FlatAppearance.BorderSize = 0;
            this.btnThemCuDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCuDan.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnThemCuDan.ForeColor = System.Drawing.Color.Black;
            this.btnThemCuDan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCuDan.Location = new System.Drawing.Point(562, 150);
            this.btnThemCuDan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemCuDan.Name = "btnThemCuDan";
            this.btnThemCuDan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemCuDan.Size = new System.Drawing.Size(143, 31);
            this.btnThemCuDan.TabIndex = 33;
            this.btnThemCuDan.Text = "Thêm cư dân";
            this.btnThemCuDan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemCuDan.UseVisualStyleBackColor = false;
            this.btnThemCuDan.Click += new System.EventHandler(this.btnThemCuDan_Click);
            // 
            // lbSoDienThoai
            // 
            this.lbSoDienThoai.AutoSize = true;
            this.lbSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDienThoai.Location = new System.Drawing.Point(56, 112);
            this.lbSoDienThoai.Name = "lbSoDienThoai";
            this.lbSoDienThoai.Size = new System.Drawing.Size(69, 23);
            this.lbSoDienThoai.TabIndex = 5;
            this.lbSoDienThoai.Text = "Bắt đầu";
            // 
            // lbEmail
            // 
            this.lbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(558, 224);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(159, 23);
            this.lbEmail.TabIndex = 35;
            this.lbEmail.Text = "Ghi chú điều khoản";
            // 
            // txtDieuKhoan
            // 
            this.txtDieuKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDieuKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDieuKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDieuKhoan.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtDieuKhoan.Location = new System.Drawing.Point(562, 251);
            this.txtDieuKhoan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDieuKhoan.Multiline = true;
            this.txtDieuKhoan.Name = "txtDieuKhoan";
            this.txtDieuKhoan.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDieuKhoan.Size = new System.Drawing.Size(420, 260);
            this.txtDieuKhoan.TabIndex = 0;
            // 
            // lbCCCD
            // 
            this.lbCCCD.AutoSize = true;
            this.lbCCCD.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCCCD.Location = new System.Drawing.Point(56, 190);
            this.lbCCCD.Name = "lbCCCD";
            this.lbCCCD.Size = new System.Drawing.Size(82, 23);
            this.lbCCCD.TabIndex = 37;
            this.lbCCCD.Text = "Tiền thuê";
            // 
            // btnTieuDe
            // 
            this.btnTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(200)))));
            this.btnTieuDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTieuDe.FlatAppearance.BorderSize = 0;
            this.btnTieuDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTieuDe.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTieuDe.ForeColor = System.Drawing.Color.White;
            this.btnTieuDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTieuDe.Location = new System.Drawing.Point(0, 0);
            this.btnTieuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTieuDe.Name = "btnTieuDe";
            this.btnTieuDe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTieuDe.Size = new System.Drawing.Size(1015, 50);
            this.btnTieuDe.TabIndex = 33;
            this.btnTieuDe.Text = "THÊM HỢP ĐỒNG";
            this.btnTieuDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTieuDe.UseVisualStyleBackColor = false;
            // 
            // nudTienThue
            // 
            this.nudTienThue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nudTienThue.Location = new System.Drawing.Point(197, 186);
            this.nudTienThue.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudTienThue.Name = "nudTienThue";
            this.nudTienThue.Size = new System.Drawing.Size(283, 30);
            this.nudTienThue.TabIndex = 48;
            this.nudTienThue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbbMaCanHo
            // 
            this.cbbMaCanHo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMaCanHo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMaCanHo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbbMaCanHo.FormattingEnabled = true;
            this.cbbMaCanHo.Location = new System.Drawing.Point(197, 74);
            this.cbbMaCanHo.Name = "cbbMaCanHo";
            this.cbbMaCanHo.Size = new System.Drawing.Size(283, 31);
            this.cbbMaCanHo.TabIndex = 47;
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panelTieuDe.Controls.Add(this.btnTieuDe);
            this.panelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieuDe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTieuDe.ForeColor = System.Drawing.Color.White;
            this.panelTieuDe.Location = new System.Drawing.Point(0, 0);
            this.panelTieuDe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(1015, 50);
            this.panelTieuDe.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "Danh sách cư dân thuê";
            // 
            // dtgvCuDanThue
            // 
            this.dtgvCuDanThue.AllowUserToAddRows = false;
            this.dtgvCuDanThue.AllowUserToDeleteRows = false;
            this.dtgvCuDanThue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgvCuDanThue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCuDanThue.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvCuDanThue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvCuDanThue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCuDanThue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvCuDanThue.ColumnHeadersHeight = 30;
            this.dtgvCuDanThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvCuDanThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dtgvCuDanThue.EnableHeadersVisualStyles = false;
            this.dtgvCuDanThue.Location = new System.Drawing.Point(60, 259);
            this.dtgvCuDanThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvCuDanThue.Name = "dtgvCuDanThue";
            this.dtgvCuDanThue.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCuDanThue.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvCuDanThue.RowHeadersVisible = false;
            this.dtgvCuDanThue.RowHeadersWidth = 51;
            this.dtgvCuDanThue.RowTemplate.Height = 24;
            this.dtgvCuDanThue.Size = new System.Drawing.Size(416, 252);
            this.dtgvCuDanThue.TabIndex = 53;
            this.dtgvCuDanThue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCuDanThue_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::DesignEasyHouse1.Properties.Resources.Delete;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Width = 6;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(197, 112);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(283, 30);
            this.dtpNgayBatDau.TabIndex = 54;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(197, 150);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(283, 30);
            this.dtpNgayKetThuc.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 55;
            this.label2.Text = "Kết thúc";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 57;
            this.label3.Text = "ID cư dân";
            // 
            // tbVaiTro
            // 
            this.tbVaiTro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVaiTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbVaiTro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVaiTro.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tbVaiTro.Location = new System.Drawing.Point(650, 111);
            this.tbVaiTro.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbVaiTro.Name = "tbVaiTro";
            this.tbVaiTro.Size = new System.Drawing.Size(332, 31);
            this.tbVaiTro.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(558, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 60;
            this.label4.Text = "Vai trò";
            // 
            // tbCuDanID
            // 
            this.tbCuDanID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCuDanID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbCuDanID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCuDanID.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.tbCuDanID.Location = new System.Drawing.Point(650, 70);
            this.tbCuDanID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbCuDanID.Name = "tbCuDanID";
            this.tbCuDanID.Size = new System.Drawing.Size(332, 31);
            this.tbCuDanID.TabIndex = 61;
            // 
            // formThemHopDongThueCanHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1015, 616);
            this.Controls.Add(this.tbCuDanID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVaiTro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.dtgvCuDanThue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudTienThue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbbMaCanHo);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.btnThemCuDan);
            this.Controls.Add(this.panelTieuDe);
            this.Controls.Add(this.lbSoDienThoai);
            this.Controls.Add(this.lbCCCD);
            this.Controls.Add(this.txtDieuKhoan);
            this.Controls.Add(this.lbEmail);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MinimumSize = new System.Drawing.Size(1033, 663);
            this.Name = "formThemHopDongThueCanHo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formThemHopDongThueCanHo_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTienThue)).EndInit();
            this.panelTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCuDanThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnThemHopDong;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Button btnThemCuDan;
        private System.Windows.Forms.Label lbSoDienThoai;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtDieuKhoan;
        private System.Windows.Forms.Label lbCCCD;
        private System.Windows.Forms.Button btnTieuDe;
        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.ComboBox cbbMaCanHo;
        private System.Windows.Forms.NumericUpDown nudTienThue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvCuDanThue;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbVaiTro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCuDanID;
    }
}