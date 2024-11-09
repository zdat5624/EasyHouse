namespace DesignEasyHouse1.formsCuDan
{
    partial class formThongBaoCuaCuDan
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grbChonXemThongBao = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXemThongBao = new System.Windows.Forms.Button();
            this.cbLoaiThongBao = new System.Windows.Forms.ComboBox();
            this.dtgvThongBao = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbChonXemThongBao.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dtgvThongBao, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grbChonXemThongBao, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.77551F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.22449F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 490);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // grbChonXemThongBao
            // 
            this.grbChonXemThongBao.Controls.Add(this.tableLayoutPanel2);
            this.grbChonXemThongBao.Location = new System.Drawing.Point(3, 3);
            this.grbChonXemThongBao.Name = "grbChonXemThongBao";
            this.grbChonXemThongBao.Size = new System.Drawing.Size(623, 86);
            this.grbChonXemThongBao.TabIndex = 0;
            this.grbChonXemThongBao.TabStop = false;
            this.grbChonXemThongBao.Text = "Phân loại thông báo";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.40504F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.59496F));
            this.tableLayoutPanel2.Controls.Add(this.btnXemThongBao, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbLoaiThongBao, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(617, 65);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnXemThongBao
            // 
            this.btnXemThongBao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnXemThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemThongBao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXemThongBao.Location = new System.Drawing.Point(492, 3);
            this.btnXemThongBao.Name = "btnXemThongBao";
            this.btnXemThongBao.Size = new System.Drawing.Size(75, 38);
            this.btnXemThongBao.TabIndex = 0;
            this.btnXemThongBao.Text = "Xem";
            this.btnXemThongBao.UseVisualStyleBackColor = false;
            // 
            // cbLoaiThongBao
            // 
            this.cbLoaiThongBao.FormattingEnabled = true;
            this.cbLoaiThongBao.Items.AddRange(new object[] {
            "Yêu cầu vệ sinh",
            "Tất cả"});
            this.cbLoaiThongBao.Location = new System.Drawing.Point(3, 3);
            this.cbLoaiThongBao.Name = "cbLoaiThongBao";
            this.cbLoaiThongBao.Size = new System.Drawing.Size(483, 24);
            this.cbLoaiThongBao.TabIndex = 1;
            this.cbLoaiThongBao.Text = "Tất cả";
            // 
            // dtgvThongBao
            // 
            this.dtgvThongBao.AllowUserToAddRows = false;
            this.dtgvThongBao.AllowUserToDeleteRows = false;
            this.dtgvThongBao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvThongBao.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvThongBao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvThongBao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvThongBao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvThongBao.ColumnHeadersHeight = 30;
            this.dtgvThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvThongBao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvThongBao.EnableHeadersVisualStyles = false;
            this.dtgvThongBao.Location = new System.Drawing.Point(3, 96);
            this.dtgvThongBao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvThongBao.Name = "dtgvThongBao";
            this.dtgvThongBao.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvThongBao.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvThongBao.RowHeadersVisible = false;
            this.dtgvThongBao.RowHeadersWidth = 51;
            this.dtgvThongBao.RowTemplate.Height = 24;
            this.dtgvThongBao.Size = new System.Drawing.Size(874, 390);
            this.dtgvThongBao.TabIndex = 2;
            // 
            // formThongBaoCuaCuDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formThongBaoCuaCuDan";
            this.Text = "Thông Báo";
            this.Load += new System.EventHandler(this.formThongBaoCuaCuDan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grbChonXemThongBao.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grbChonXemThongBao;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnXemThongBao;
        private System.Windows.Forms.ComboBox cbLoaiThongBao;
        private System.Windows.Forms.DataGridView dtgvThongBao;
    }
}