namespace DesignEasyHouse1.formsPhongBan.PhongDuAnThiCong
{
    partial class formLapKeHoach
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
            this.dtgvGiaiDoanThiCong = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Details = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnGiaiDoan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiaiDoanThiCong)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvGiaiDoanThiCong
            // 
            this.dtgvGiaiDoanThiCong.AllowUserToAddRows = false;
            this.dtgvGiaiDoanThiCong.AllowUserToDeleteRows = false;
            this.dtgvGiaiDoanThiCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvGiaiDoanThiCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvGiaiDoanThiCong.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvGiaiDoanThiCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvGiaiDoanThiCong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvGiaiDoanThiCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvGiaiDoanThiCong.ColumnHeadersHeight = 30;
            this.dtgvGiaiDoanThiCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvGiaiDoanThiCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Details});
            this.dtgvGiaiDoanThiCong.EnableHeadersVisualStyles = false;
            this.dtgvGiaiDoanThiCong.Location = new System.Drawing.Point(12, 55);
            this.dtgvGiaiDoanThiCong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvGiaiDoanThiCong.Name = "dtgvGiaiDoanThiCong";
            this.dtgvGiaiDoanThiCong.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvGiaiDoanThiCong.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvGiaiDoanThiCong.RowHeadersVisible = false;
            this.dtgvGiaiDoanThiCong.RowHeadersWidth = 51;
            this.dtgvGiaiDoanThiCong.RowTemplate.Height = 24;
            this.dtgvGiaiDoanThiCong.Size = new System.Drawing.Size(878, 369);
            this.dtgvGiaiDoanThiCong.TabIndex = 40;
            this.dtgvGiaiDoanThiCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvGiaiDoanThiCong_CellContentClick);
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
            // btnGiaiDoan
            // 
            this.btnGiaiDoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGiaiDoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(200)))));
            this.btnGiaiDoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGiaiDoan.FlatAppearance.BorderSize = 0;
            this.btnGiaiDoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaiDoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGiaiDoan.ForeColor = System.Drawing.Color.White;
            this.btnGiaiDoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaiDoan.Location = new System.Drawing.Point(12, 463);
            this.btnGiaiDoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGiaiDoan.Name = "btnGiaiDoan";
            this.btnGiaiDoan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGiaiDoan.Size = new System.Drawing.Size(147, 40);
            this.btnGiaiDoan.TabIndex = 41;
            this.btnGiaiDoan.Text = "Thêm giai đoạn";
            this.btnGiaiDoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiaiDoan.UseVisualStyleBackColor = false;
            this.btnGiaiDoan.Click += new System.EventHandler(this.btnGiaiDoan_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 44);
            this.panel1.TabIndex = 67;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(902, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lập kế hoạch";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // formLapKeHoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGiaiDoan);
            this.Controls.Add(this.dtgvGiaiDoanThiCong);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formLapKeHoach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập kế hoạch";
            this.Load += new System.EventHandler(this.formLapKeHoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvGiaiDoanThiCong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvGiaiDoanThiCong;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Details;
        private System.Windows.Forms.Button btnGiaiDoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}