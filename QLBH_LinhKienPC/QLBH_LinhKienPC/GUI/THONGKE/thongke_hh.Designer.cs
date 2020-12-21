
namespace QLBH_LinhKienPC.GUI.THONGKE
{
    partial class thongke_hh
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
            this.cr_hh = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cr_hh
            // 
            this.cr_hh.ActiveViewIndex = -1;
            this.cr_hh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_hh.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_hh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cr_hh.Location = new System.Drawing.Point(0, 0);
            this.cr_hh.Name = "cr_hh";
            this.cr_hh.Size = new System.Drawing.Size(1484, 961);
            this.cr_hh.TabIndex = 0;
            // 
            // thongke_hh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 961);
            this.Controls.Add(this.cr_hh);
            this.Name = "thongke_hh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "thongke_hh";
            this.Load += new System.EventHandler(this.thongke_hh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr_hh;
    }
}