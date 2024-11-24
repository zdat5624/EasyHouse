namespace DesignEasyHouse1.formsPhongBan.PhongCuDan
{
    partial class formTaoPhieuGhi
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
            this.nudDonGiaDien = new System.Windows.Forms.NumericUpDown();
            this.nudDonGiaNuoc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.panelTieuDe = new System.Windows.Forms.Panel();
            this.btnTieuDe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPhiDichVu = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaNuoc)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelTieuDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPhiDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDonGiaDien
            // 
            this.nudDonGiaDien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nudDonGiaDien.Location = new System.Drawing.Point(277, 61);
            this.nudDonGiaDien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudDonGiaDien.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudDonGiaDien.Name = "nudDonGiaDien";
            this.nudDonGiaDien.Size = new System.Drawing.Size(309, 30);
            this.nudDonGiaDien.TabIndex = 51;
            this.nudDonGiaDien.ThousandsSeparator = true;
            // 
            // nudDonGiaNuoc
            // 
            this.nudDonGiaNuoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nudDonGiaNuoc.Location = new System.Drawing.Point(277, 114);
            this.nudDonGiaNuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudDonGiaNuoc.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudDonGiaNuoc.Name = "nudDonGiaNuoc";
            this.nudDonGiaNuoc.Size = new System.Drawing.Size(309, 30);
            this.nudDonGiaNuoc.TabIndex = 52;
            this.nudDonGiaNuoc.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Đơn giá nước";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 23);
            this.label2.TabIndex = 54;
            this.label2.Text = "Đơn giá điện";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHuyBo);
            this.panel2.Controls.Add(this.btnTao);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 224);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 53);
            this.panel2.TabIndex = 133;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuyBo.BackColor = System.Drawing.Color.Silver;
            this.btnHuyBo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuyBo.FlatAppearance.BorderSize = 0;
            this.btnHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyBo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.ForeColor = System.Drawing.Color.White;
            this.btnHuyBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyBo.Location = new System.Drawing.Point(597, 2);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHuyBo.Size = new System.Drawing.Size(105, 43);
            this.btnHuyBo.TabIndex = 32;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnTao
            // 
            this.btnTao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(200)))));
            this.btnTao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTao.FlatAppearance.BorderSize = 0;
            this.btnTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTao.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.ForeColor = System.Drawing.Color.White;
            this.btnTao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTao.Location = new System.Drawing.Point(488, 2);
            this.btnTao.Margin = new System.Windows.Forms.Padding(2);
            this.btnTao.Name = "btnTao";
            this.btnTao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTao.Size = new System.Drawing.Size(105, 43);
            this.btnTao.TabIndex = 31;
            this.btnTao.Text = "Tạo";
            this.btnTao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // panelTieuDe
            // 
            this.panelTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panelTieuDe.Controls.Add(this.btnTieuDe);
            this.panelTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTieuDe.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTieuDe.ForeColor = System.Drawing.Color.White;
            this.panelTieuDe.Location = new System.Drawing.Point(0, 0);
            this.panelTieuDe.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelTieuDe.Name = "panelTieuDe";
            this.panelTieuDe.Size = new System.Drawing.Size(713, 42);
            this.panelTieuDe.TabIndex = 132;
            // 
            // btnTieuDe
            // 
            this.btnTieuDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnTieuDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTieuDe.FlatAppearance.BorderSize = 0;
            this.btnTieuDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTieuDe.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTieuDe.ForeColor = System.Drawing.Color.White;
            this.btnTieuDe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTieuDe.Location = new System.Drawing.Point(0, 0);
            this.btnTieuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTieuDe.Name = "btnTieuDe";
            this.btnTieuDe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTieuDe.Size = new System.Drawing.Size(713, 42);
            this.btnTieuDe.TabIndex = 35;
            this.btnTieuDe.Text = "TẠO PHIẾU GHI";
            this.btnTieuDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTieuDe.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 135;
            this.label3.Text = "Phí dịch vụ";
            // 
            // nudPhiDichVu
            // 
            this.nudPhiDichVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nudPhiDichVu.Location = new System.Drawing.Point(272, 172);
            this.nudPhiDichVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudPhiDichVu.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudPhiDichVu.Name = "nudPhiDichVu";
            this.nudPhiDichVu.Size = new System.Drawing.Size(309, 30);
            this.nudPhiDichVu.TabIndex = 134;
            this.nudPhiDichVu.ThousandsSeparator = true;
            // 
            // formTaoPhieuGhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 277);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudPhiDichVu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTieuDe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDonGiaNuoc);
            this.Controls.Add(this.nudDonGiaDien);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formTaoPhieuGhi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTaoPhieuGhi";
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaNuoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelTieuDe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPhiDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDonGiaDien;
        private System.Windows.Forms.NumericUpDown nudDonGiaNuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Panel panelTieuDe;
        private System.Windows.Forms.Button btnTieuDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPhiDichVu;
    }
}