namespace DesignEasyHouse1.formsGiamDoc.moduleVeSinh
{
    partial class formBaoCaoChiPhi
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
            this.grbChonthoiGian = new System.Windows.Forms.GroupBox();
            this.lblChonThoiGian = new System.Windows.Forms.Label();
            this.dtpThoiGianKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnChonThoiGian = new System.Windows.Forms.Button();
            this.dtpThoiGianBatDau = new System.Windows.Forms.DateTimePicker();
            this.lblTongChiPhi = new System.Windows.Forms.Label();
            this.dvgBaoCaoChiPhi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblChiPhi = new System.Windows.Forms.Button();
            this.grbChonthoiGian.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBaoCaoChiPhi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbChonthoiGian
            // 
            this.grbChonthoiGian.Controls.Add(this.lblChonThoiGian);
            this.grbChonthoiGian.Controls.Add(this.dtpThoiGianKetThuc);
            this.grbChonthoiGian.Controls.Add(this.btnChonThoiGian);
            this.grbChonthoiGian.Controls.Add(this.dtpThoiGianBatDau);
            this.grbChonthoiGian.Location = new System.Drawing.Point(101, 102);
            this.grbChonthoiGian.Name = "grbChonthoiGian";
            this.grbChonthoiGian.Size = new System.Drawing.Size(915, 74);
            this.grbChonthoiGian.TabIndex = 24;
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
            // dtpThoiGianKetThuc
            // 
            this.dtpThoiGianKetThuc.Location = new System.Drawing.Point(433, 35);
            this.dtpThoiGianKetThuc.Name = "dtpThoiGianKetThuc";
            this.dtpThoiGianKetThuc.Size = new System.Drawing.Size(315, 22);
            this.dtpThoiGianKetThuc.TabIndex = 4;
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
            this.btnChonThoiGian.Click += new System.EventHandler(this.btnChonThoiGian_Click);
            // 
            // dtpThoiGianBatDau
            // 
            this.dtpThoiGianBatDau.Location = new System.Drawing.Point(6, 35);
            this.dtpThoiGianBatDau.Name = "dtpThoiGianBatDau";
            this.dtpThoiGianBatDau.Size = new System.Drawing.Size(315, 22);
            this.dtpThoiGianBatDau.TabIndex = 2;
            // 
            // lblTongChiPhi
            // 
            this.lblTongChiPhi.AutoSize = true;
            this.lblTongChiPhi.ForeColor = System.Drawing.Color.Red;
            this.lblTongChiPhi.Location = new System.Drawing.Point(26, 483);
            this.lblTongChiPhi.Name = "lblTongChiPhi";
            this.lblTongChiPhi.Size = new System.Drawing.Size(80, 16);
            this.lblTongChiPhi.TabIndex = 23;
            this.lblTongChiPhi.Text = "Tổng chi phí";
            // 
            // dvgBaoCaoChiPhi
            // 
            this.dvgBaoCaoChiPhi.AllowUserToAddRows = false;
            this.dvgBaoCaoChiPhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgBaoCaoChiPhi.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dvgBaoCaoChiPhi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgBaoCaoChiPhi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgBaoCaoChiPhi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgBaoCaoChiPhi.ColumnHeadersHeight = 30;
            this.dvgBaoCaoChiPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgBaoCaoChiPhi.EnableHeadersVisualStyles = false;
            this.dvgBaoCaoChiPhi.Location = new System.Drawing.Point(29, 204);
            this.dvgBaoCaoChiPhi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dvgBaoCaoChiPhi.Name = "dvgBaoCaoChiPhi";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgBaoCaoChiPhi.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgBaoCaoChiPhi.RowHeadersVisible = false;
            this.dvgBaoCaoChiPhi.RowHeadersWidth = 51;
            this.dvgBaoCaoChiPhi.RowTemplate.Height = 24;
            this.dvgBaoCaoChiPhi.Size = new System.Drawing.Size(1024, 249);
            this.dvgBaoCaoChiPhi.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.lblChiPhi);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 70);
            this.panel1.TabIndex = 20;
            // 
            // lblChiPhi
            // 
            this.lblChiPhi.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblChiPhi.FlatAppearance.BorderSize = 0;
            this.lblChiPhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblChiPhi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiPhi.ForeColor = System.Drawing.Color.Transparent;
            this.lblChiPhi.Location = new System.Drawing.Point(0, 0);
            this.lblChiPhi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lblChiPhi.Name = "lblChiPhi";
            this.lblChiPhi.Size = new System.Drawing.Size(311, 70);
            this.lblChiPhi.TabIndex = 1;
            this.lblChiPhi.Text = "Báo cáo chi phí";
            this.lblChiPhi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblChiPhi.UseVisualStyleBackColor = true;
            // 
            // formBaoCaoChiPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 580);
            this.Controls.Add(this.grbChonthoiGian);
            this.Controls.Add(this.lblTongChiPhi);
            this.Controls.Add(this.dvgBaoCaoChiPhi);
            this.Controls.Add(this.panel1);
            this.Name = "formBaoCaoChiPhi";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formBaoCaoChiPhi_Load);
            this.grbChonthoiGian.ResumeLayout(false);
            this.grbChonthoiGian.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBaoCaoChiPhi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbChonthoiGian;
        private System.Windows.Forms.Label lblChonThoiGian;
        private System.Windows.Forms.DateTimePicker dtpThoiGianKetThuc;
        private System.Windows.Forms.Button btnChonThoiGian;
        private System.Windows.Forms.DateTimePicker dtpThoiGianBatDau;
        private System.Windows.Forms.Label lblTongChiPhi;
        private System.Windows.Forms.DataGridView dvgBaoCaoChiPhi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lblChiPhi;
    }
}