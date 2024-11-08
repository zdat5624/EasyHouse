namespace DesignEasyHouse1.formsPhongBan.PhongVeSinh
{
    partial class formXemKeHoachVeSinh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formXemKeHoachVeSinh));
            this.panelTren = new System.Windows.Forms.Panel();
            this.dtgvKeHoachCongViec = new System.Windows.Forms.DataGridView();
            this.panelDuoi = new System.Windows.Forms.Panel();
            this.grbChonThoiGian = new System.Windows.Forms.GroupBox();
            this.btnChonThoiGian = new System.Windows.Forms.Button();
            this.dtpXemTheoThoiGian = new System.Windows.Forms.DateTimePicker();
            this.HoanThanh = new System.Windows.Forms.DataGridViewImageColumn();
            this.cbTrangThaiCongViec = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKeHoachCongViec)).BeginInit();
            this.grbChonThoiGian.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTren
            // 
            this.panelTren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panelTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTren.Location = new System.Drawing.Point(0, 0);
            this.panelTren.Name = "panelTren";
            this.panelTren.Size = new System.Drawing.Size(1316, 80);
            this.panelTren.TabIndex = 42;
            // 
            // dtgvKeHoachCongViec
            // 
            this.dtgvKeHoachCongViec.AllowUserToAddRows = false;
            this.dtgvKeHoachCongViec.AllowUserToDeleteRows = false;
            this.dtgvKeHoachCongViec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKeHoachCongViec.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvKeHoachCongViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvKeHoachCongViec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvKeHoachCongViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvKeHoachCongViec.ColumnHeadersHeight = 30;
            this.dtgvKeHoachCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvKeHoachCongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoanThanh});
            this.dtgvKeHoachCongViec.EnableHeadersVisualStyles = false;
            this.dtgvKeHoachCongViec.Location = new System.Drawing.Point(49, 183);
            this.dtgvKeHoachCongViec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvKeHoachCongViec.Name = "dtgvKeHoachCongViec";
            this.dtgvKeHoachCongViec.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvKeHoachCongViec.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgvKeHoachCongViec.RowHeadersVisible = false;
            this.dtgvKeHoachCongViec.RowHeadersWidth = 51;
            this.dtgvKeHoachCongViec.RowTemplate.Height = 24;
            this.dtgvKeHoachCongViec.Size = new System.Drawing.Size(1220, 461);
            this.dtgvKeHoachCongViec.TabIndex = 43;
            this.dtgvKeHoachCongViec.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKeHoachCongViec_CellContentClick);
            // 
            // panelDuoi
            // 
            this.panelDuoi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDuoi.Location = new System.Drawing.Point(0, 651);
            this.panelDuoi.Name = "panelDuoi";
            this.panelDuoi.Size = new System.Drawing.Size(1316, 40);
            this.panelDuoi.TabIndex = 44;
            // 
            // grbChonThoiGian
            // 
            this.grbChonThoiGian.Controls.Add(this.cbTrangThaiCongViec);
            this.grbChonThoiGian.Controls.Add(this.btnChonThoiGian);
            this.grbChonThoiGian.Controls.Add(this.dtpXemTheoThoiGian);
            this.grbChonThoiGian.Location = new System.Drawing.Point(687, 86);
            this.grbChonThoiGian.Name = "grbChonThoiGian";
            this.grbChonThoiGian.Size = new System.Drawing.Size(582, 90);
            this.grbChonThoiGian.TabIndex = 45;
            this.grbChonThoiGian.TabStop = false;
            this.grbChonThoiGian.Text = "Chọn thời gian và trạng thái công việc";
            // 
            // btnChonThoiGian
            // 
            this.btnChonThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnChonThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonThoiGian.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChonThoiGian.Location = new System.Drawing.Point(507, 37);
            this.btnChonThoiGian.Name = "btnChonThoiGian";
            this.btnChonThoiGian.Size = new System.Drawing.Size(75, 32);
            this.btnChonThoiGian.TabIndex = 1;
            this.btnChonThoiGian.Text = "xem";
            this.btnChonThoiGian.UseVisualStyleBackColor = false;
            this.btnChonThoiGian.Click += new System.EventHandler(this.btnChonThoiGian_Click);
            // 
            // dtpXemTheoThoiGian
            // 
            this.dtpXemTheoThoiGian.Location = new System.Drawing.Point(6, 41);
            this.dtpXemTheoThoiGian.Name = "dtpXemTheoThoiGian";
            this.dtpXemTheoThoiGian.Size = new System.Drawing.Size(290, 22);
            this.dtpXemTheoThoiGian.TabIndex = 0;
            this.dtpXemTheoThoiGian.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // HoanThanh
            // 
            this.HoanThanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HoanThanh.HeaderText = "Hoàn thành";
            this.HoanThanh.Image = ((System.Drawing.Image)(resources.GetObject("HoanThanh.Image")));
            this.HoanThanh.MinimumWidth = 6;
            this.HoanThanh.Name = "HoanThanh";
            this.HoanThanh.ReadOnly = true;
            this.HoanThanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HoanThanh.Width = 105;
            // 
            // cbTrangThaiCongViec
            // 
            this.cbTrangThaiCongViec.FormattingEnabled = true;
            this.cbTrangThaiCongViec.Items.AddRange(new object[] {
            "Chưa hoàn thành",
            "Đã hoàn thành",
            "Tất cả"});
            this.cbTrangThaiCongViec.Location = new System.Drawing.Point(302, 43);
            this.cbTrangThaiCongViec.Name = "cbTrangThaiCongViec";
            this.cbTrangThaiCongViec.Size = new System.Drawing.Size(199, 24);
            this.cbTrangThaiCongViec.TabIndex = 2;
            this.cbTrangThaiCongViec.Text = "Trạng thái các công việc";
            // 
            // formXemKeHoachVeSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 691);
            this.Controls.Add(this.grbChonThoiGian);
            this.Controls.Add(this.panelDuoi);
            this.Controls.Add(this.dtgvKeHoachCongViec);
            this.Controls.Add(this.panelTren);
            this.Name = "formXemKeHoachVeSinh";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formXemKeHoachVeSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKeHoachCongViec)).EndInit();
            this.grbChonThoiGian.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTren;
        private System.Windows.Forms.DataGridView dtgvKeHoachCongViec;
        private System.Windows.Forms.Panel panelDuoi;
        private System.Windows.Forms.GroupBox grbChonThoiGian;
        private System.Windows.Forms.Button btnChonThoiGian;
        private System.Windows.Forms.DateTimePicker dtpXemTheoThoiGian;
        private System.Windows.Forms.DataGridViewImageColumn HoanThanh;
        private System.Windows.Forms.ComboBox cbTrangThaiCongViec;
    }
}