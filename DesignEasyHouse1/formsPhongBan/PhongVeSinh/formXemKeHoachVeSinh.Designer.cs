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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTren = new System.Windows.Forms.Panel();
            this.dtgvKeHoachCongViec = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelDuoi = new System.Windows.Forms.Panel();
            this.grbChonThoiGian = new System.Windows.Forms.GroupBox();
            this.btnChonThoiGian = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvKeHoachCongViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvKeHoachCongViec.ColumnHeadersHeight = 30;
            this.dtgvKeHoachCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvKeHoachCongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Details});
            this.dtgvKeHoachCongViec.EnableHeadersVisualStyles = false;
            this.dtgvKeHoachCongViec.Location = new System.Drawing.Point(25, 183);
            this.dtgvKeHoachCongViec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvKeHoachCongViec.Name = "dtgvKeHoachCongViec";
            this.dtgvKeHoachCongViec.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvKeHoachCongViec.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvKeHoachCongViec.RowHeadersVisible = false;
            this.dtgvKeHoachCongViec.RowHeadersWidth = 51;
            this.dtgvKeHoachCongViec.RowTemplate.Height = 24;
            this.dtgvKeHoachCongViec.Size = new System.Drawing.Size(1220, 461);
            this.dtgvKeHoachCongViec.TabIndex = 43;
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
            // Details
            // 
            this.Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Details.HeaderText = "";
            this.Details.Image = global::DesignEasyHouse1.Properties.Resources.analysis;
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            this.Details.Width = 6;
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
            this.grbChonThoiGian.Controls.Add(this.btnChonThoiGian);
            this.grbChonThoiGian.Controls.Add(this.dateTimePicker1);
            this.grbChonThoiGian.Location = new System.Drawing.Point(906, 86);
            this.grbChonThoiGian.Name = "grbChonThoiGian";
            this.grbChonThoiGian.Size = new System.Drawing.Size(339, 90);
            this.grbChonThoiGian.TabIndex = 45;
            this.grbChonThoiGian.TabStop = false;
            this.grbChonThoiGian.Text = "groupBox1";
            // 
            // btnChonThoiGian
            // 
            this.btnChonThoiGian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnChonThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonThoiGian.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChonThoiGian.Location = new System.Drawing.Point(244, 43);
            this.btnChonThoiGian.Name = "btnChonThoiGian";
            this.btnChonThoiGian.Size = new System.Drawing.Size(75, 32);
            this.btnChonThoiGian.TabIndex = 1;
            this.btnChonThoiGian.Text = "xem";
            this.btnChonThoiGian.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 22);
            this.dateTimePicker1.TabIndex = 0;
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
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Details;
        private System.Windows.Forms.Panel panelDuoi;
        private System.Windows.Forms.GroupBox grbChonThoiGian;
        private System.Windows.Forms.Button btnChonThoiGian;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}