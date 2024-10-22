namespace DesignEasyHouse1.formsPhongBan.PhongVeSinh
{
    partial class tableTheoDoiHieuSuat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTheoDoiHieuSuat = new System.Windows.Forms.Label();
            //this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtpChonThoiGian = new System.Windows.Forms.DateTimePicker();
            this.grbChonthoiGian = new System.Windows.Forms.GroupBox();
            this.lblChonThoiGian = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnChonThoiGian = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleanArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responseFromResident = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTroLai = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grbChonthoiGian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.lblTheoDoiHieuSuat);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 70);
            this.panel1.TabIndex = 0;
            // 
            // lblTheoDoiHieuSuat
            // 
            this.lblTheoDoiHieuSuat.AutoSize = true;
            this.lblTheoDoiHieuSuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheoDoiHieuSuat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTheoDoiHieuSuat.Location = new System.Drawing.Point(11, 19);
            this.lblTheoDoiHieuSuat.Name = "lblTheoDoiHieuSuat";
            this.lblTheoDoiHieuSuat.Size = new System.Drawing.Size(194, 28);
            this.lblTheoDoiHieuSuat.TabIndex = 0;
            this.lblTheoDoiHieuSuat.Text = "Theo dõi hiệu suất ";
            // 
            // metroLabel1
            // 
            //this.metroLabel1.AutoSize = true;
            //this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            //this.metroLabel1.Name = "metroLabel1";
            //this.metroLabel1.Size = new System.Drawing.Size(100, 23);
            //this.metroLabel1.TabIndex = 0;
            // 
            // dtpChonThoiGian
            // 
            this.dtpChonThoiGian.Location = new System.Drawing.Point(6, 35);
            this.dtpChonThoiGian.Name = "dtpChonThoiGian";
            this.dtpChonThoiGian.Size = new System.Drawing.Size(315, 22);
            this.dtpChonThoiGian.TabIndex = 2;
            // 
            // grbChonthoiGian
            // 
            this.grbChonthoiGian.Controls.Add(this.lblChonThoiGian);
            this.grbChonthoiGian.Controls.Add(this.dateTimePicker1);
            this.grbChonthoiGian.Controls.Add(this.btnChonThoiGian);
            this.grbChonthoiGian.Controls.Add(this.dtpChonThoiGian);
            this.grbChonthoiGian.Location = new System.Drawing.Point(163, 76);
            this.grbChonthoiGian.Name = "grbChonthoiGian";
            this.grbChonthoiGian.Size = new System.Drawing.Size(887, 74);
            this.grbChonthoiGian.TabIndex = 3;
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
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnChonThoiGian
            // 
            this.btnChonThoiGian.Location = new System.Drawing.Point(771, 34);
            this.btnChonThoiGian.Name = "btnChonThoiGian";
            this.btnChonThoiGian.Size = new System.Drawing.Size(75, 23);
            this.btnChonThoiGian.TabIndex = 3;
            this.btnChonThoiGian.Text = "xem";
            this.btnChonThoiGian.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.employeeName,
            this.employeeId,
            this.cleanArea,
            this.responseFromResident});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(17, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 405);
            this.dataGridView1.TabIndex = 4;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // employeeName
            // 
            this.employeeName.HeaderText = "Tên nhân viên";
            this.employeeName.MinimumWidth = 6;
            this.employeeName.Name = "employeeName";
            this.employeeName.ReadOnly = true;
            // 
            // employeeId
            // 
            this.employeeId.HeaderText = "Mã nhân viên";
            this.employeeId.MinimumWidth = 6;
            this.employeeId.Name = "employeeId";
            this.employeeId.ReadOnly = true;
            // 
            // cleanArea
            // 
            this.cleanArea.HeaderText = "Khu vực vệ sinh";
            this.cleanArea.MinimumWidth = 6;
            this.cleanArea.Name = "cleanArea";
            this.cleanArea.ReadOnly = true;
            // 
            // responseFromResident
            // 
            this.responseFromResident.HeaderText = "Phản hồi từ cư dân";
            this.responseFromResident.MinimumWidth = 6;
            this.responseFromResident.Name = "responseFromResident";
            this.responseFromResident.ReadOnly = true;
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnTroLai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTroLai.Location = new System.Drawing.Point(17, 76);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 33);
            this.btnTroLai.TabIndex = 13;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
            // 
            // tableTheoDoiHieuSuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 593);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbChonthoiGian);
            this.Controls.Add(this.panel1);
            this.Name = "tableTheoDoiHieuSuat";
            this.Text = "Theo Dõi  Hiệu  Suất";
            this.Load += new System.EventHandler(this.formTheoDoiHieuSuat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbChonthoiGian.ResumeLayout(false);
            this.grbChonthoiGian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTheoDoiHieuSuat;
        //private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker dtpChonThoiGian;
        private System.Windows.Forms.GroupBox grbChonthoiGian;
        private System.Windows.Forms.Button btnChonThoiGian;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleanArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn responseFromResident;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblChonThoiGian;
        private System.Windows.Forms.Button btnTroLai;
    }
}