namespace DesignEasyHouse1.formsGiamDoc.moduleVeSinh
{
    partial class tableDoanhThu
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
            this.btnTroLai = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Button();
            //this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbChonthoiGian = new System.Windows.Forms.GroupBox();
            this.lblChonThoiGian = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnChonThoiGian = new System.Windows.Forms.Button();
            this.dtpChonThoiGian = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.grbChonthoiGian.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnTroLai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTroLai.Location = new System.Drawing.Point(29, 79);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 33);
            this.btnTroLai.TabIndex = 17;
            this.btnTroLai.Text = "Trở lại";
            this.btnTroLai.UseVisualStyleBackColor = false;
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
            this.total,
            this.time});
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(29, 206);
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
            this.dataGridView2.Size = new System.Drawing.Size(1024, 249);
            this.dataGridView2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.lblDoanhThu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 70);
            this.panel1.TabIndex = 14;
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
            // metroLabel1
            // 
            //this.metroLabel1.AutoSize = true;
            //this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            //this.metroLabel1.Name = "metroLabel1";
            //this.metroLabel1.Size = new System.Drawing.Size(100, 23);
            //this.metroLabel1.TabIndex = 0;
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.lblTongDoanhThu.Location = new System.Drawing.Point(26, 485);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(100, 16);
            this.lblTongDoanhThu.TabIndex = 18;
            this.lblTongDoanhThu.Text = "Tổng doanh thu";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 64;
            // 
            // total
            // 
            this.total.HeaderText = "Doanh thu";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            // 
            // time
            // 
            this.time.HeaderText = "Thời gian";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            // 
            // grbChonthoiGian
            // 
            this.grbChonthoiGian.Controls.Add(this.lblChonThoiGian);
            this.grbChonthoiGian.Controls.Add(this.dateTimePicker1);
            this.grbChonthoiGian.Controls.Add(this.btnChonThoiGian);
            this.grbChonthoiGian.Controls.Add(this.dtpChonThoiGian);
            this.grbChonthoiGian.Location = new System.Drawing.Point(138, 108);
            this.grbChonthoiGian.Name = "grbChonthoiGian";
            this.grbChonthoiGian.Size = new System.Drawing.Size(915, 74);
            this.grbChonthoiGian.TabIndex = 19;
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
            // tableDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 614);
            this.Controls.Add(this.grbChonthoiGian);
            this.Controls.Add(this.lblTongDoanhThu);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Name = "tableDoanhThu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grbChonthoiGian.ResumeLayout(false);
            this.grbChonthoiGian.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lblDoanhThu;
        //private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.GroupBox grbChonthoiGian;
        private System.Windows.Forms.Label lblChonThoiGian;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnChonThoiGian;
        private System.Windows.Forms.DateTimePicker dtpChonThoiGian;
    }
}