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
            // SampleChildForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 654);
            this.Controls.Add(this.button30);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "SampleChildForm1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button30;
    }
}