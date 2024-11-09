namespace DesignEasyHouse1.formsCuDan.moduleVeSinh
{
    partial class tableTheoDoiyeuCauVeSinh
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
            this.btnDanhGia = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtgvTheoDoiVeSinh = new System.Windows.Forms.DataGridView();
            this.grbChonthoiGian = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXemYeuCau = new System.Windows.Forms.Button();
            this.dtpTu = new System.Windows.Forms.DateTimePicker();
            this.cbDinhKy = new System.Windows.Forms.ComboBox();
            this.dtpDen = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.lblDinhKy = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheoDoiVeSinh)).BeginInit();
            this.grbChonthoiGian.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDanhGia);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 713);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDanhGia
            // 
            this.btnDanhGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(200)))));
            this.btnDanhGia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDanhGia.FlatAppearance.BorderSize = 0;
            this.btnDanhGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhGia.ForeColor = System.Drawing.Color.White;
            this.btnDanhGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhGia.Location = new System.Drawing.Point(25, 551);
            this.btnDanhGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDanhGia.Name = "btnDanhGia";
            this.btnDanhGia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDanhGia.Size = new System.Drawing.Size(230, 50);
            this.btnDanhGia.TabIndex = 32;
            this.btnDanhGia.Text = "Gửi đánh giá dịch vụ ";
            this.btnDanhGia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhGia.UseVisualStyleBackColor = false;
            this.btnDanhGia.Click += new System.EventHandler(this.btnDanhGia_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dtgvTheoDoiVeSinh, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.grbChonthoiGian, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 434F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1129, 529);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // dtgvTheoDoiVeSinh
            // 
            this.dtgvTheoDoiVeSinh.AllowUserToAddRows = false;
            this.dtgvTheoDoiVeSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTheoDoiVeSinh.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvTheoDoiVeSinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTheoDoiVeSinh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTheoDoiVeSinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTheoDoiVeSinh.ColumnHeadersHeight = 30;
            this.dtgvTheoDoiVeSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvTheoDoiVeSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTheoDoiVeSinh.EnableHeadersVisualStyles = false;
            this.dtgvTheoDoiVeSinh.Location = new System.Drawing.Point(3, 99);
            this.dtgvTheoDoiVeSinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvTheoDoiVeSinh.Name = "dtgvTheoDoiVeSinh";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTheoDoiVeSinh.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTheoDoiVeSinh.RowHeadersVisible = false;
            this.dtgvTheoDoiVeSinh.RowHeadersWidth = 51;
            this.dtgvTheoDoiVeSinh.RowTemplate.Height = 24;
            this.dtgvTheoDoiVeSinh.Size = new System.Drawing.Size(1123, 426);
            this.dtgvTheoDoiVeSinh.TabIndex = 9;
            this.dtgvTheoDoiVeSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTheoDoiVeSinh_CellContentClick);
            this.dtgvTheoDoiVeSinh.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgvTheoDoiVeSinh_CellPainting);
            // 
            // grbChonthoiGian
            // 
            this.grbChonthoiGian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChonthoiGian.Controls.Add(this.tableLayoutPanel2);
            this.grbChonthoiGian.Location = new System.Drawing.Point(3, 3);
            this.grbChonthoiGian.MinimumSize = new System.Drawing.Size(300, 45);
            this.grbChonthoiGian.Name = "grbChonthoiGian";
            this.grbChonthoiGian.Size = new System.Drawing.Size(1123, 89);
            this.grbChonthoiGian.TabIndex = 25;
            this.grbChonthoiGian.TabStop = false;
            this.grbChonthoiGian.Text = "Hãy chọn mốc thời gian bạn muốn xem";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.btnXemYeuCau, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpTu, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbDinhKy, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpDen, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDen, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDinhKy, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.76471F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.23529F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1117, 68);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // btnXemYeuCau
            // 
            this.btnXemYeuCau.AutoSize = true;
            this.btnXemYeuCau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnXemYeuCau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXemYeuCau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXemYeuCau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemYeuCau.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXemYeuCau.Location = new System.Drawing.Point(905, 28);
            this.btnXemYeuCau.MaximumSize = new System.Drawing.Size(200, 45);
            this.btnXemYeuCau.Name = "btnXemYeuCau";
            this.btnXemYeuCau.Size = new System.Drawing.Size(200, 37);
            this.btnXemYeuCau.TabIndex = 10;
            this.btnXemYeuCau.Text = "Xem Yêu Cầu";
            this.btnXemYeuCau.UseVisualStyleBackColor = false;
            this.btnXemYeuCau.Click += new System.EventHandler(this.btnKieuVeSinh_Click);
            // 
            // dtpTu
            // 
            this.dtpTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTu.Location = new System.Drawing.Point(3, 28);
            this.dtpTu.Name = "dtpTu";
            this.dtpTu.Size = new System.Drawing.Size(257, 22);
            this.dtpTu.TabIndex = 1;
            this.dtpTu.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbDinhKy
            // 
            this.cbDinhKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDinhKy.FormattingEnabled = true;
            this.cbDinhKy.Items.AddRange(new object[] {
            "Không định kỳ",
            "Tuần",
            "Tháng"});
            this.cbDinhKy.Location = new System.Drawing.Point(566, 28);
            this.cbDinhKy.Name = "cbDinhKy";
            this.cbDinhKy.Size = new System.Drawing.Size(333, 24);
            this.cbDinhKy.TabIndex = 4;
            // 
            // dtpDen
            // 
            this.dtpDen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDen.Location = new System.Drawing.Point(303, 28);
            this.dtpDen.Name = "dtpDen";
            this.dtpDen.Size = new System.Drawing.Size(257, 22);
            this.dtpDen.TabIndex = 2;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(266, 25);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(31, 16);
            this.lblDen.TabIndex = 0;
            this.lblDen.Text = "Đến";
            // 
            // lblDinhKy
            // 
            this.lblDinhKy.AutoSize = true;
            this.lblDinhKy.Location = new System.Drawing.Point(566, 0);
            this.lblDinhKy.Name = "lblDinhKy";
            this.lblDinhKy.Size = new System.Drawing.Size(79, 16);
            this.lblDinhKy.TabIndex = 3;
            this.lblDinhKy.Text = "Định kỳ theo";
            // 
            // tableTheoDoiyeuCauVeSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1166, 713);
            this.Controls.Add(this.panel1);
            this.Name = "tableTheoDoiyeuCauVeSinh";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.tableTheoDoiyeuCauVeSinh_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheoDoiVeSinh)).EndInit();
            this.grbChonthoiGian.ResumeLayout(false);
            this.grbChonthoiGian.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dtgvTheoDoiVeSinh;
        private System.Windows.Forms.GroupBox grbChonthoiGian;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.Button btnXemYeuCau;
        private System.Windows.Forms.DateTimePicker dtpTu;
        private System.Windows.Forms.ComboBox cbDinhKy;
        private System.Windows.Forms.Label lblDinhKy;
        private System.Windows.Forms.DateTimePicker dtpDen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDanhGia;
    }
}