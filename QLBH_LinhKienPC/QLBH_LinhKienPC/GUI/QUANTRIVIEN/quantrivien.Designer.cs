namespace QLBH_LinhKienPC.GUI.QUANTRIVIEN
{
    partial class quantrivien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_chucvu = new System.Windows.Forms.Button();
            this.bt_nhanvien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_chucvu
            // 
            this.bt_chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chucvu.Location = new System.Drawing.Point(38, 31);
            this.bt_chucvu.Name = "bt_chucvu";
            this.bt_chucvu.Size = new System.Drawing.Size(236, 82);
            this.bt_chucvu.TabIndex = 0;
            this.bt_chucvu.Text = "QUẢN LÝ CHỨC VỤ";
            this.bt_chucvu.UseVisualStyleBackColor = true;
            this.bt_chucvu.Click += new System.EventHandler(this.bt_chucvu_Click);
            // 
            // bt_nhanvien
            // 
            this.bt_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nhanvien.Location = new System.Drawing.Point(38, 156);
            this.bt_nhanvien.Name = "bt_nhanvien";
            this.bt_nhanvien.Size = new System.Drawing.Size(236, 82);
            this.bt_nhanvien.TabIndex = 0;
            this.bt_nhanvien.Text = "QUẢN LÝ NHÂN VIÊN";
            this.bt_nhanvien.UseVisualStyleBackColor = true;
            this.bt_nhanvien.Click += new System.EventHandler(this.bt_nhanvien_Click);
            // 
            // quantrivien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.bt_nhanvien);
            this.Controls.Add(this.bt_chucvu);
            this.Name = "quantrivien";
            this.Size = new System.Drawing.Size(1620, 980);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_chucvu;
        private System.Windows.Forms.Button bt_nhanvien;
    }
}
