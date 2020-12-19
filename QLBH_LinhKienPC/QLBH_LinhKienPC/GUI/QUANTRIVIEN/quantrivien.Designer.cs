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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_chucvu
            // 
            this.bt_chucvu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(38)))), ((int)(((byte)(99)))));
            this.bt_chucvu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chucvu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_chucvu.Location = new System.Drawing.Point(27, 128);
            this.bt_chucvu.Name = "bt_chucvu";
            this.bt_chucvu.Size = new System.Drawing.Size(236, 82);
            this.bt_chucvu.TabIndex = 0;
            this.bt_chucvu.Text = "QUẢN LÝ CHỨC VỤ";
            this.bt_chucvu.UseVisualStyleBackColor = false;
            this.bt_chucvu.Click += new System.EventHandler(this.bt_chucvu_Click);
            // 
            // bt_nhanvien
            // 
            this.bt_nhanvien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(38)))), ((int)(((byte)(99)))));
            this.bt_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bt_nhanvien.Location = new System.Drawing.Point(296, 128);
            this.bt_nhanvien.Name = "bt_nhanvien";
            this.bt_nhanvien.Size = new System.Drawing.Size(236, 82);
            this.bt_nhanvien.TabIndex = 0;
            this.bt_nhanvien.Text = "QUẢN LÝ NHÂN VIÊN";
            this.bt_nhanvien.UseVisualStyleBackColor = false;
            this.bt_nhanvien.Click += new System.EventHandler(this.bt_nhanvien_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1620, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN TRỊ VIÊN";
            // 
            // quantrivien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_nhanvien);
            this.Controls.Add(this.bt_chucvu);
            this.Name = "quantrivien";
            this.Size = new System.Drawing.Size(1620, 980);
            this.Load += new System.EventHandler(this.quantrivien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_chucvu;
        private System.Windows.Forms.Button bt_nhanvien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
