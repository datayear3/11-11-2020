
namespace QLBH_LinhKienPC.GUI.THONGKE
{
    partial class cr_tungphieunhap
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
            this.cr_cttsp = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.mpn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cr_cttsp
            // 
            this.cr_cttsp.ActiveViewIndex = -1;
            this.cr_cttsp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_cttsp.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_cttsp.Dock = System.Windows.Forms.DockStyle.Left;
            this.cr_cttsp.Location = new System.Drawing.Point(0, 0);
            this.cr_cttsp.Name = "cr_cttsp";
            this.cr_cttsp.Size = new System.Drawing.Size(1268, 961);
            this.cr_cttsp.TabIndex = 0;
            this.cr_cttsp.Load += new System.EventHandler(this.cr_cttsp_Load);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(114)))));
            this.bt_thoat.FlatAppearance.BorderSize = 0;
            this.bt_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.ForeColor = System.Drawing.Color.Azure;
            this.bt_thoat.Location = new System.Drawing.Point(1300, 12);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(172, 51);
            this.bt_thoat.TabIndex = 9;
            this.bt_thoat.Text = "THOÁT";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // mpn
            // 
            this.mpn.AutoSize = true;
            this.mpn.Location = new System.Drawing.Point(1297, 120);
            this.mpn.Name = "mpn";
            this.mpn.Size = new System.Drawing.Size(35, 13);
            this.mpn.TabIndex = 10;
            this.mpn.Text = "label1";
            this.mpn.Visible = false;
            // 
            // cr_tungphieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.mpn);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.cr_cttsp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cr_tungphieunhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cr_tungphieunhap";
            this.Load += new System.EventHandler(this.cr_tungphieunhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr_cttsp;
        private System.Windows.Forms.Button bt_thoat;
        public System.Windows.Forms.Label mpn;
    }
}