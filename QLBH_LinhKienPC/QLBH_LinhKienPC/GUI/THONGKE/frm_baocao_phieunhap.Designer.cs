
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
            this.SuspendLayout();
            // 
            // cr_phieunhap
            // 
            this.cr_phieunhap.ActiveViewIndex = -1;
            this.cr_phieunhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_phieunhap.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_phieunhap.Location = new System.Drawing.Point(121, 36);
            this.cr_phieunhap.Name = "cr_phieunhap";
            this.cr_phieunhap.Size = new System.Drawing.Size(579, 469);
            this.cr_phieunhap.TabIndex = 0;
            // 
            // frm_baocao_phieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 555);
            this.Controls.Add(this.cr_phieunhap);
            this.Name = "frm_baocao_phieunhap";
            this.Text = "frm_baocao_phieunhap";
            this.Load += new System.EventHandler(this.frm_baocao_phieunhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr_phieunhap;
    }
}