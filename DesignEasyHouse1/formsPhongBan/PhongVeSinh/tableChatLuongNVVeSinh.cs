using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignEasyHouse1.formsPhongBan.PhongVeSinh
{
    public partial class tableChatLuongNhanVien : Form
    {
        private DataGridView dataGridView2;
        private GroupBox grbChonThoiGian;
        private ListBox lstChonThoiGian;
        private Button btnChonThoiGian;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn employeeName;
        private DataGridViewTextBoxColumn employeeId;
        private DataGridViewTextBoxColumn performance;
        private Panel panel1;
        private Button button1;
        private DateTimePicker dateTimePicker1;

        public tableChatLuongNhanVien()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.performance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbChonThoiGian = new System.Windows.Forms.GroupBox();
            this.lstChonThoiGian = new System.Windows.Forms.ListBox();
            this.btnChonThoiGian = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
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
            this.employeeName,
            this.employeeId,
            this.performance});
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(36, 204);
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
            this.dataGridView2.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 64;
            // 
            // employeeName
            // 
            this.employeeName.HeaderText = "Tên nhân viên";
            this.employeeName.MinimumWidth = 6;
            this.employeeName.Name = "employeeName";
            // 
            // employeeId
            // 
            this.employeeId.HeaderText = "Mã nhân viên";
            this.employeeId.MinimumWidth = 6;
            this.employeeId.Name = "employeeId";
            // 
            // performance
            // 
            this.performance.HeaderText = "Hiệu suất";
            this.performance.MinimumWidth = 6;
            this.performance.Name = "performance";
            // 
            // grbChonThoiGian
            // 
            this.grbChonThoiGian.Controls.Add(this.lstChonThoiGian);
            this.grbChonThoiGian.Controls.Add(this.btnChonThoiGian);
            this.grbChonThoiGian.Controls.Add(this.dateTimePicker1);
            this.grbChonThoiGian.Location = new System.Drawing.Point(292, 107);
            this.grbChonThoiGian.Name = "grbChonThoiGian";
            this.grbChonThoiGian.Size = new System.Drawing.Size(740, 90);
            this.grbChonThoiGian.TabIndex = 7;
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 72);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Báo cáo  Khu Vực Vệ Sinh";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableChatLuongNhanVien
            // 
            this.ClientSize = new System.Drawing.Size(1065, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.grbChonThoiGian);
            this.Name = "tableChatLuongNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grbChonThoiGian.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
