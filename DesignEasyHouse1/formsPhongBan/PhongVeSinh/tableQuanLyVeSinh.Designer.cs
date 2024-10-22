namespace DesignEasyHouse1.formsPhongBan.PhongVeSinh
{
    partial class tableQuanLyVeSinh
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
            this.lblQuanLyVeSinh = new System.Windows.Forms.Button();
            this.grbChonThoiGian = new System.Windows.Forms.GroupBox();
            this.btnChonThoiGian = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleanArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grbChonThoiGian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.lblQuanLyVeSinh);
            this.panel1.Location = new System.Drawing.Point(2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 74);
            this.panel1.TabIndex = 2;
            // 
            // lblQuanLyVeSinh
            // 
            this.lblQuanLyVeSinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblQuanLyVeSinh.FlatAppearance.BorderSize = 0;
            this.lblQuanLyVeSinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuanLyVeSinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyVeSinh.ForeColor = System.Drawing.Color.Transparent;
            this.lblQuanLyVeSinh.Location = new System.Drawing.Point(0, 0);
            this.lblQuanLyVeSinh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lblQuanLyVeSinh.Name = "lblQuanLyVeSinh";
            this.lblQuanLyVeSinh.Size = new System.Drawing.Size(311, 74);
            this.lblQuanLyVeSinh.TabIndex = 1;
            this.lblQuanLyVeSinh.Text = "Quản lý vệ sinh";
            this.lblQuanLyVeSinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuanLyVeSinh.UseVisualStyleBackColor = true;
            // 
            // grbChonThoiGian
            // 
            this.grbChonThoiGian.Controls.Add(this.btnChonThoiGian);
            this.grbChonThoiGian.Controls.Add(this.dateTimePicker1);
            this.grbChonThoiGian.Location = new System.Drawing.Point(514, 77);
            this.grbChonThoiGian.Name = "grbChonThoiGian";
            this.grbChonThoiGian.Size = new System.Drawing.Size(542, 63);
            this.grbChonThoiGian.TabIndex = 3;
            this.grbChonThoiGian.TabStop = false;
            this.grbChonThoiGian.Text = "Chọn thời gian";
            // 
            // btnChonThoiGian
            // 
            this.btnChonThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnChonThoiGian.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChonThoiGian.Location = new System.Drawing.Point(406, 16);
            this.btnChonThoiGian.Name = "btnChonThoiGian";
            this.btnChonThoiGian.Size = new System.Drawing.Size(118, 36);
            this.btnChonThoiGian.TabIndex = 1;
            this.btnChonThoiGian.Text = "Xem";
            this.btnChonThoiGian.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(379, 22);
            this.dateTimePicker1.TabIndex = 0;
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
            this.cleanArea,
            this.employeeId,
            this.progress,
            this.time});
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(42, 177);
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
            this.dataGridView2.Size = new System.Drawing.Size(968, 368);
            this.dataGridView2.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 64;
            // 
            // cleanArea
            // 
            this.cleanArea.HeaderText = "Khu vực vệ sinh";
            this.cleanArea.MinimumWidth = 6;
            this.cleanArea.Name = "cleanArea";
            // 
            // employeeId
            // 
            this.employeeId.HeaderText = "Mã nhân viên phụ trách";
            this.employeeId.MinimumWidth = 6;
            this.employeeId.Name = "employeeId";
            // 
            // progress
            // 
            this.progress.HeaderText = "Tiến độ ";
            this.progress.MinimumWidth = 6;
            this.progress.Name = "progress";
            // 
            // time
            // 
            this.time.HeaderText = "Thời gian vệ sinh";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnTroLai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTroLai.Location = new System.Drawing.Point(42, 80);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 33);
            this.btnTroLai.TabIndex = 13;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
            // 
            // tableQuanLyVeSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 547);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.grbChonThoiGian);
            this.Controls.Add(this.panel1);
            this.Name = "tableQuanLyVeSinh";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.grbChonThoiGian.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lblQuanLyVeSinh;
        private System.Windows.Forms.GroupBox grbChonThoiGian;
        private System.Windows.Forms.Button btnChonThoiGian;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleanArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.Button btnTroLai;
    }
}