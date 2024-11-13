namespace DesignEasyHouse1.formsCuDan.moduleGuiDo
{
    partial class formGuiYeuCauGuiDoLayDo
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
            this.cbbLoaiYeuCau = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGui = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbLoaiYeuCau
            // 
            this.cbbLoaiYeuCau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbLoaiYeuCau.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbLoaiYeuCau.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbLoaiYeuCau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbbLoaiYeuCau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiYeuCau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiYeuCau.FormattingEnabled = true;
            this.cbbLoaiYeuCau.Items.AddRange(new object[] {
            "Gửi đồ",
            "Lấy đồ"});
            this.cbbLoaiYeuCau.Location = new System.Drawing.Point(135, 87);
            this.cbbLoaiYeuCau.Name = "cbbLoaiYeuCau";
            this.cbbLoaiYeuCau.Size = new System.Drawing.Size(384, 31);
            this.cbbLoaiYeuCau.TabIndex = 101;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(545, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gửi Yêu Cầu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 96;
            this.label2.Text = "Loại yêu cầu";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(414, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(105, 43);
            this.button2.TabIndex = 32;
            this.button2.Text = "Hủy bỏ";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnGui
            // 
            this.btnGui.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(200)))));
            this.btnGui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGui.FlatAppearance.BorderSize = 0;
            this.btnGui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGui.Location = new System.Drawing.Point(297, 2);
            this.btnGui.Margin = new System.Windows.Forms.Padding(2);
            this.btnGui.Name = "btnGui";
            this.btnGui.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGui.Size = new System.Drawing.Size(105, 43);
            this.btnGui.TabIndex = 31;
            this.btnGui.Text = "Gửi";
            this.btnGui.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGui.UseVisualStyleBackColor = false;
            this.btnGui.Click += new System.EventHandler(this.btnGuiYeuCau_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNoiDung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoiDung.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(135, 130);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(384, 337);
            this.txtNoiDung.TabIndex = 98;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 99;
            this.label6.Text = "Nội dung";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnGui);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 502);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 53);
            this.panel2.TabIndex = 97;
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
            this.panel1.Size = new System.Drawing.Size(545, 44);
            this.panel1.TabIndex = 94;
            // 
            // formGuiYeuCauGuiDoLayDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 555);
            this.Controls.Add(this.cbbLoaiYeuCau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "formGuiYeuCauGuiDoLayDo";
            this.Text = "Gửi yêu cầu gửi đồ lấy đô";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbLoaiYeuCau;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}