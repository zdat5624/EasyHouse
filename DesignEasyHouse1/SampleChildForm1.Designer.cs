namespace DesignEasyHouse1
{
    partial class SampleChildForm1
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
            this.button30 = new System.Windows.Forms.Button();
            this.btnChonFileAnh = new System.Windows.Forms.Button();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.nudTienThue = new System.Windows.Forms.NumericUpDown();
            this.cbbMaCanHo = new System.Windows.Forms.ComboBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTienThue)).BeginInit();
            this.SuspendLayout();
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(200)))));
            this.button30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button30.FlatAppearance.BorderSize = 0;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.button30.ForeColor = System.Drawing.Color.White;
            this.button30.Image = global::DesignEasyHouse1.Properties.Resources.Add;
            this.button30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button30.Location = new System.Drawing.Point(39, 582);
            this.button30.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button30.Name = "button30";
            this.button30.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button30.Size = new System.Drawing.Size(180, 47);
            this.button30.TabIndex = 31;
            this.button30.Text = "Thêm cư dân";
            this.button30.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button30.UseVisualStyleBackColor = false;
            // 
            // btnChonFileAnh
            // 
            this.btnChonFileAnh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnChonFileAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChonFileAnh.FlatAppearance.BorderSize = 0;
            this.btnChonFileAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonFileAnh.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.btnChonFileAnh.ForeColor = System.Drawing.Color.Black;
            this.btnChonFileAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonFileAnh.Location = new System.Drawing.Point(104, 152);
            this.btnChonFileAnh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChonFileAnh.Name = "btnChonFileAnh";
            this.btnChonFileAnh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnChonFileAnh.Size = new System.Drawing.Size(143, 31);
            this.btnChonFileAnh.TabIndex = 47;
            this.btnChonFileAnh.Text = "Chọn file ảnh";
            this.btnChonFileAnh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChonFileAnh.UseVisualStyleBackColor = false;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(104, 252);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(275, 30);
            this.dtpNgaySinh.TabIndex = 48;
            // 
            // nudTienThue
            // 
            this.nudTienThue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nudTienThue.Location = new System.Drawing.Point(104, 384);
            this.nudTienThue.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudTienThue.Name = "nudTienThue";
            this.nudTienThue.Size = new System.Drawing.Size(275, 30);
            this.nudTienThue.TabIndex = 50;
            this.nudTienThue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbbMaCanHo
            // 
            this.cbbMaCanHo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMaCanHo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMaCanHo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbbMaCanHo.FormattingEnabled = true;
            this.cbbMaCanHo.Location = new System.Drawing.Point(104, 320);
            this.cbbMaCanHo.Name = "cbbMaCanHo";
            this.cbbMaCanHo.Size = new System.Drawing.Size(275, 31);
            this.cbbMaCanHo.TabIndex = 49;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txtHoTen.Location = new System.Drawing.Point(104, 459);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(275, 31);
            this.txtHoTen.TabIndex = 51;
            // 
            // SampleChildForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 654);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.nudTienThue);
            this.Controls.Add(this.cbbMaCanHo);
            this.Controls.Add(this.btnChonFileAnh);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.button30);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "SampleChildForm1";
            ((System.ComponentModel.ISupportInitialize)(this.nudTienThue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button btnChonFileAnh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.NumericUpDown nudTienThue;
        private System.Windows.Forms.ComboBox cbbMaCanHo;
        private System.Windows.Forms.TextBox txtHoTen;
    }
}