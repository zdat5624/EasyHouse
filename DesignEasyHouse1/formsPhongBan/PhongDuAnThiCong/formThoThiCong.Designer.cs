namespace DesignEasyHouse1.formsPhongBan.PhongDuAnThiCong
{
    partial class formThoThiCong
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
            this.dtgvDanhSachThoThiCong = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnThemDuAn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachThoThiCong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDanhSachThoThiCong
            // 
            this.dtgvDanhSachThoThiCong.AllowUserToAddRows = false;
            this.dtgvDanhSachThoThiCong.AllowUserToDeleteRows = false;
            this.dtgvDanhSachThoThiCong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDanhSachThoThiCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachThoThiCong.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvDanhSachThoThiCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvDanhSachThoThiCong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachThoThiCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvDanhSachThoThiCong.ColumnHeadersHeight = 30;
            this.dtgvDanhSachThoThiCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvDanhSachThoThiCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Details});
            this.dtgvDanhSachThoThiCong.EnableHeadersVisualStyles = false;
            this.dtgvDanhSachThoThiCong.Location = new System.Drawing.Point(24, 74);
            this.dtgvDanhSachThoThiCong.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtgvDanhSachThoThiCong.Name = "dtgvDanhSachThoThiCong";
            this.dtgvDanhSachThoThiCong.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDanhSachThoThiCong.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDanhSachThoThiCong.RowHeadersVisible = false;
            this.dtgvDanhSachThoThiCong.RowHeadersWidth = 51;
            this.dtgvDanhSachThoThiCong.RowTemplate.Height = 24;
            this.dtgvDanhSachThoThiCong.Size = new System.Drawing.Size(564, 465);
            this.dtgvDanhSachThoThiCong.TabIndex = 40;
            this.dtgvDanhSachThoThiCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDanhSachThoThiCong_CellContentClick);
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
            // btnThemDuAn
            // 
            this.btnThemDuAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemDuAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(200)))));
            this.btnThemDuAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemDuAn.FlatAppearance.BorderSize = 0;
            this.btnThemDuAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDuAn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnThemDuAn.ForeColor = System.Drawing.Color.White;
            this.btnThemDuAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDuAn.Location = new System.Drawing.Point(12, 568);
            this.btnThemDuAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemDuAn.Name = "btnThemDuAn";
            this.btnThemDuAn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemDuAn.Size = new System.Drawing.Size(138, 41);
            this.btnThemDuAn.TabIndex = 41;
            this.btnThemDuAn.Text = "Thêm thợ";
            this.btnThemDuAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemDuAn.UseVisualStyleBackColor = false;
            this.btnThemDuAn.Click += new System.EventHandler(this.btnThemDuAn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 49);
            this.panel1.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(612, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quản Lý Thợ Thi Công";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::DesignEasyHouse1.Properties.Resources.Delete;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::DesignEasyHouse1.Properties.Resources.analysis;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // formThoThiCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 620);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThemDuAn);
            this.Controls.Add(this.dtgvDanhSachThoThiCong);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formThoThiCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thợ thi công";
            this.Load += new System.EventHandler(this.formThoThiCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachThoThiCong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDanhSachThoThiCong;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Details;
        private System.Windows.Forms.Button btnThemDuAn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}