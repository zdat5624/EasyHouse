namespace DesignEasyHouse1.formsCuDan.moduleVeSinh
{
    partial class tableVeSinhDinhKy
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
            this.lblDangKyVeSinhDinhKy = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleanArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTroLai
            // 
            this.btnTroLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnTroLai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroLai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTroLai.Location = new System.Drawing.Point(12, 76);
            this.btnTroLai.Name = "btnTroLai";
            this.btnTroLai.Size = new System.Drawing.Size(75, 33);
            this.btnTroLai.TabIndex = 16;
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
            this.cleanArea,
            this.registerId,
            this.employeeId,
            this.residentId,
            this.time,
            this.frequency});
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(12, 145);
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
            this.dataGridView2.Size = new System.Drawing.Size(1028, 381);
            this.dataGridView2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.lblDangKyVeSinhDinhKy);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 70);
            this.panel1.TabIndex = 17;
            // 
            // lblDangKyVeSinhDinhKy
            // 
            this.lblDangKyVeSinhDinhKy.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDangKyVeSinhDinhKy.FlatAppearance.BorderSize = 0;
            this.lblDangKyVeSinhDinhKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDangKyVeSinhDinhKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangKyVeSinhDinhKy.ForeColor = System.Drawing.Color.Transparent;
            this.lblDangKyVeSinhDinhKy.Location = new System.Drawing.Point(0, 0);
            this.lblDangKyVeSinhDinhKy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.lblDangKyVeSinhDinhKy.Name = "lblDangKyVeSinhDinhKy";
            this.lblDangKyVeSinhDinhKy.Size = new System.Drawing.Size(311, 70);
            this.lblDangKyVeSinhDinhKy.TabIndex = 1;
            this.lblDangKyVeSinhDinhKy.Text = "Lịch vệ sinh định kỳ";
            this.lblDangKyVeSinhDinhKy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDangKyVeSinhDinhKy.UseVisualStyleBackColor = true;
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
            this.cleanArea.HeaderText = "Khu vực";
            this.cleanArea.MinimumWidth = 6;
            this.cleanArea.Name = "cleanArea";
            // 
            // registerId
            // 
            this.registerId.HeaderText = "Mã đăng ký";
            this.registerId.MinimumWidth = 6;
            this.registerId.Name = "registerId";
            // 
            // employeeId
            // 
            this.employeeId.HeaderText = "Mã nhân viên";
            this.employeeId.MinimumWidth = 6;
            this.employeeId.Name = "employeeId";
            // 
            // residentId
            // 
            this.residentId.HeaderText = "Mã cư dân";
            this.residentId.MinimumWidth = 6;
            this.residentId.Name = "residentId";
            // 
            // time
            // 
            this.time.HeaderText = "Thời gian vệ sinh";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            // 
            // frequency
            // 
            this.frequency.HeaderText = "Tần suất";
            this.frequency.MinimumWidth = 6;
            this.frequency.Name = "frequency";
            // 
            // tableVeSinhDinhKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTroLai);
            this.Controls.Add(this.dataGridView2);
            this.Name = "tableVeSinhDinhKy";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTroLai;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleanArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn registerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequency;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lblDangKyVeSinhDinhKy;
    }
}