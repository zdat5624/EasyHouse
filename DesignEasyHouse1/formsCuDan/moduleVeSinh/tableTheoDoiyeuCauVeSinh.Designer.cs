namespace DesignEasyHouse1.formsCuDan.moduleVeSinh
{
    partial class tableTheoDoiyeuCauVeSinh
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
            this.dtgvTheoDoiVeSinh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheoDoiVeSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTheoDoiVeSinh
            // 
            this.dtgvTheoDoiVeSinh.AllowUserToAddRows = false;
            this.dtgvTheoDoiVeSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTheoDoiVeSinh.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dtgvTheoDoiVeSinh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTheoDoiVeSinh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTheoDoiVeSinh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTheoDoiVeSinh.ColumnHeadersHeight = 30;
            this.dtgvTheoDoiVeSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvTheoDoiVeSinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgvTheoDoiVeSinh.EnableHeadersVisualStyles = false;
            this.dtgvTheoDoiVeSinh.Location = new System.Drawing.Point(0, 0);
            this.dtgvTheoDoiVeSinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgvTheoDoiVeSinh.Name = "dtgvTheoDoiVeSinh";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTheoDoiVeSinh.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTheoDoiVeSinh.RowHeadersVisible = false;
            this.dtgvTheoDoiVeSinh.RowHeadersWidth = 51;
            this.dtgvTheoDoiVeSinh.RowTemplate.Height = 24;
            this.dtgvTheoDoiVeSinh.Size = new System.Drawing.Size(1022, 404);
            this.dtgvTheoDoiVeSinh.TabIndex = 9;
            this.dtgvTheoDoiVeSinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTheoDoiVeSinh_CellContentClick);
            this.dtgvTheoDoiVeSinh.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgvTheoDoiVeSinh_CellPainting);
            // 
            // tableTheoDoiyeuCauVeSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 565);
            this.Controls.Add(this.dtgvTheoDoiVeSinh);
            this.Name = "tableTheoDoiyeuCauVeSinh";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.tableTheoDoiyeuCauVeSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTheoDoiVeSinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTheoDoiVeSinh;
    }
}