namespace DesignEasyHouse1.formsCuDan
{
    partial class formsThanhToan
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
            this.lblQR = new System.Windows.Forms.Label();
            this.btnXacNhanChuyenKhoan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQR
            // 
            this.lblQR.AutoSize = true;
            this.lblQR.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQR.Location = new System.Drawing.Point(53, 9);
            this.lblQR.Name = "lblQR";
            this.lblQR.Size = new System.Drawing.Size(104, 23);
            this.lblQR.TabIndex = 50;
            this.lblQR.Text = "Mã RQ code";
            // 
            // btnXacNhanChuyenKhoan
            // 
            this.btnXacNhanChuyenKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(200)))));
            this.btnXacNhanChuyenKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXacNhanChuyenKhoan.FlatAppearance.BorderSize = 0;
            this.btnXacNhanChuyenKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhanChuyenKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanChuyenKhoan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanChuyenKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhanChuyenKhoan.Location = new System.Drawing.Point(195, -1);
            this.btnXacNhanChuyenKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXacNhanChuyenKhoan.Name = "btnXacNhanChuyenKhoan";
            this.btnXacNhanChuyenKhoan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnXacNhanChuyenKhoan.Size = new System.Drawing.Size(267, 40);
            this.btnXacNhanChuyenKhoan.TabIndex = 31;
            this.btnXacNhanChuyenKhoan.Text = "Xác nhận chuyển khoản";
            this.btnXacNhanChuyenKhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXacNhanChuyenKhoan.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Silver;
            this.btnHuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(468, -1);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHuy.Size = new System.Drawing.Size(120, 40);
            this.btnHuy.TabIndex = 32;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXacNhanChuyenKhoan);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 597);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 50);
            this.panel2.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 421);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // formsThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 647);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQR);
            this.Controls.Add(this.panel2);
            this.Name = "formsThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formsThanhToan";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQR;
        private System.Windows.Forms.Button btnXacNhanChuyenKhoan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}