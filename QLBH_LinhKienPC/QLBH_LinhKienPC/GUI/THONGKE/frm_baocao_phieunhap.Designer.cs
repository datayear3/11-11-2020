
namespace QLBH_LinhKienPC.GUI.THONGKE
{
    partial class frm_baocao_phieunhap
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
            this.cr_phieunhap = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cr_phieunhap
            // 
            this.cr_phieunhap.ActiveViewIndex = -1;
            this.cr_phieunhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_phieunhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_phieunhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.cr_phieunhap.Location = new System.Drawing.Point(0, 0);
            this.cr_phieunhap.Name = "cr_phieunhap";
            this.cr_phieunhap.Size = new System.Drawing.Size(1285, 961);
            this.cr_phieunhap.TabIndex = 0;
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
            this.bt_thoat.TabIndex = 10;
            this.bt_thoat.Text = "THOÁT";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // frm_baocao_phieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.cr_phieunhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_baocao_phieunhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_baocao_phieunhap";
            this.Load += new System.EventHandler(this.frm_baocao_phieunhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr_phieunhap;
        private System.Windows.Forms.Button bt_thoat;
    }
}