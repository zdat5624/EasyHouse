namespace DesignEasyHouse1.formsPhongBan.PhongVeSinh
{
    partial class tablePhanHoiCuDan
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbChonThoiGian = new System.Windows.Forms.GroupBox();
            this.lstChonThoiGian = new System.Windows.Forms.ListBox();
            this.btnChonThoiGian = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBaoCaoChatLuongNVVeSinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grbChonThoiGian.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.residentName,
            this.residentId,
            this.equality});
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(30, 218);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(996, 368);
            this.dataGridView2.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 64;
            // 
            // residentName
            // 
            this.residentName.HeaderText = "Tên cư dân";
            this.residentName.MinimumWidth = 6;
            this.residentName.Name = "residentName";
            // 
            // residentId
            // 
            this.residentId.HeaderText = "Mã cư dân";
            this.residentId.MinimumWidth = 6;
            this.residentId.Name = "residentId";
            // 
            // equality
            // 
            this.equality.HeaderText = "Chất lượng vệ sinh";
            this.equality.MinimumWidth = 6;
            this.equality.Name = "equality";
            // 
            // grbChonThoiGian
            // 
            this.grbChonThoiGian.Controls.Add(this.lstChonThoiGian);
            this.grbChonThoiGian.Controls.Add(this.btnChonThoiGian);
            this.grbChonThoiGian.Controls.Add(this.dateTimePicker1);
            this.grbChonThoiGian.Location = new System.Drawing.Point(286, 121);
            this.grbChonThoiGian.Name = "grbChonThoiGian";
            this.grbChonThoiGian.Size = new System.Drawing.Size(740, 90);
            this.grbChonThoiGian.TabIndex = 9;
            this.grbChonThoiGian.TabStop = false;
            this.grbChonThoiGian.Text = "groupBox1";
            // 
            // lstChonThoiGian
            // 
            this.lstChonThoiGian.FormattingEnabled = true;
            this.lstChonThoiGian.ItemHeight = 16;
            this.lstChonThoiGian.Items.AddRange(new object[] {
            "Xem theo tháng",
            "Xem theo tuần"});
            this.lstChonThoiGian.Location = new System.Drawing.Point(24, 41);
            this.lstChonThoiGian.Name = "lstChonThoiGian";
            this.lstChonThoiGian.Size = new System.Drawing.Size(307, 20);
            this.lstChonThoiGian.TabIndex = 7;
            // 
            // btnChonThoiGian
            // 
            this.btnChonThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnChonThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonThoiGian.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChonThoiGian.Location = new System.Drawing.Point(636, 35);
            this.btnChonThoiGian.Name = "btnChonThoiGian";
            this.btnChonThoiGian.Size = new System.Drawing.Size(75, 32);
            this.btnChonThoiGian.TabIndex = 1;
            this.btnChonThoiGian.Text = "xem";
            this.btnChonThoiGian.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(398, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.lblBaoCaoChatLuongNVVeSinh);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 74);
            this.panel1.TabIndex = 11;
            // 
            // lblBaoCaoChatLuongNVVeSinh
            // 
            this.lblBaoCaoChatLuongNVVeSinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBaoCaoChatLuongNVVeSinh.FlatAppearance.BorderSize = 0;
            this.lblBaoCaoChatLuongNVVeSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBaoCaoChatLuongNVVeSinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoCaoChatLuongNVVeSinh.ForeColor = System.Drawing.Color.Transparent;
            this.lblBaoCaoChatLuongNVVeSinh.Location = new System.Drawing.Point(0, 0);
            this.lblBaoCaoChatLuongNVVeSinh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lblBaoCaoChatLuongNVVeSinh.Name = "lblBaoCaoChatLuongNVVeSinh";
            this.lblBaoCaoChatLuongNVVeSinh.Size = new System.Drawing.Size(405, 74);
            this.lblBaoCaoChatLuongNVVeSinh.TabIndex = 1;
            this.lblBaoCaoChatLuongNVVeSinh.Text = "Báo cáo chất lượng nhân viên vệ sinh";
            this.lblBaoCaoChatLuongNVVeSinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBaoCaoChatLuongNVVeSinh.UseVisualStyleBackColor = true;
            this.lblBaoCaoChatLuongNVVeSinh.Click += new System.EventHandler(this.lblQuanLyVeSinh_Click);
            // 
            // tablePhanHoiCuDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.grbChonThoiGian);
            this.Name = "tablePhanHoiCuDan";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grbChonThoiGian.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox grbChonThoiGian;
        private System.Windows.Forms.ListBox lstChonThoiGian;
        private System.Windows.Forms.Button btnChonThoiGian;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn equality;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lblBaoCaoChatLuongNVVeSinh;
    }
}