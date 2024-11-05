namespace DesignEasyHouse1.formsGiamDoc.QuanLyNhanVien
{
    partial class DanhSachNhanVien
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
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelDuoi = new System.Windows.Forms.Panel();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.panelTren = new System.Windows.Forms.Panel();
            this.dtgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.ptbHideMenu = new System.Windows.Forms.PictureBox();
            this.panelDuoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachNhanVien)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHideMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::DesignEasyHouse1.Properties.Resources.Delete;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 6;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::DesignEasyHouse1.Properties.Resources.analysis;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 6;
            // 
            // panelDuoi
            // 
            this.panelDuoi.Controls.Add(this.btnThemNhanVien);
            this.panelDuoi.Location = new System.Drawing.Point(3, 582);
            this.panelDuoi.Name = "panelDuoi";
            this.panelDuoi.Size = new System.Drawing.Size(1127, 161);
            this.panelDuoi.TabIndex = 46;
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemNhanVien.AutoSize = true;
            this.btnThemNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(200)))));
            this.btnThemNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemNhanVien.FlatAppearance.BorderSize = 0;
            this.btnThemNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnThemNhanVien.Image = global::DesignEasyHouse1.Properties.Resources.Add;
            this.btnThemNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNhanVien.Location = new System.Drawing.Point(40, 110);
            this.btnThemNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnThemNhanVien.Size = new System.Drawing.Size(163, 40);
            this.btnThemNhanVien.TabIndex = 31;
            this.btnThemNhanVien.Text = "Thêm nhân viên";
            this.btnThemNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNhanVien.UseVisualStyleBackColor = false;
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemHopDong_Click);
            // 
            // panelTren
            // 
            this.panelTren.Location = new System.Drawing.Point(3, 72);
            this.panelTren.Name = "panelTren";
            this.panelTren.Size = new System.Drawing.Size(1127, 63);
            this.panelTren.TabIndex = 48;
            this.panelTren.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTren_Paint);
            // 
            // dtgvDanhSachNhanVien
            // 
            this.dtgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDanhSachNhanVien.Location = new System.Drawing.Point(3, 141);
            this.dtgvDanhSachNhanVien.Name = "dtgvDanhSachNhanVien";
            this.dtgvDanhSachNhanVien.RowHeadersWidth = 51;
            this.dtgvDanhSachNhanVien.RowTemplate.Height = 24;
            this.dtgvDanhSachNhanVien.Size = new System.Drawing.Size(1127, 435);
            this.dtgvDanhSachNhanVien.TabIndex = 49;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelTieuDe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelDuoi, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtgvDanhSachNhanVien, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelTren, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51351F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.48649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1133, 746);
            this.tableLayoutPanel1.TabIndex = 50;
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panelTieuDe.Controls.Add(this.labelTieuDe);
            this.panelTieuDe.Controls.Add(this.ptbHideMenu);
            this.panelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieuDe.Location = new System.Drawing.Point(3, 2);
            this.panelTieuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(1127, 65);
            this.panelTieuDe.TabIndex = 50;
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelTieuDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTieuDe.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.ForeColor = System.Drawing.Color.White;
            this.labelTieuDe.Location = new System.Drawing.Point(66, 16);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(221, 28);
            this.labelTieuDe.TabIndex = 1;
            this.labelTieuDe.Text = "Danh Sách Nhân Viên";
            // 
            // ptbHideMenu
            // 
            this.ptbHideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbHideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbHideMenu.Image = global::DesignEasyHouse1.Properties.Resources.iconlessthan_2;
            this.ptbHideMenu.Location = new System.Drawing.Point(0, 0);
            this.ptbHideMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbHideMenu.Name = "ptbHideMenu";
            this.ptbHideMenu.Size = new System.Drawing.Size(60, 65);
            this.ptbHideMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbHideMenu.TabIndex = 0;
            this.ptbHideMenu.TabStop = false;
            // 
            // DanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 746);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DanhSachNhanVien";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DanhSachNhanVien_Load);
            this.Resize += new System.EventHandler(this.DanhSachNhanVien_Resize);
            this.panelDuoi.ResumeLayout(false);
            this.panelDuoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachNhanVien)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelTieuDe.ResumeLayout(false);
            this.panelTieuDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHideMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panelDuoi;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Panel panelTren;
        private System.Windows.Forms.DataGridView dtgvDanhSachNhanVien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.PictureBox ptbHideMenu;
    }
}