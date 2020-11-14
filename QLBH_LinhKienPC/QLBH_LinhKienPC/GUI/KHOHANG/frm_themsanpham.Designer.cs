namespace QLBH_LinhKienPC.GUI.KHOHANG
{
    partial class frm_themsanpham
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
            this.txt_mn = new System.Windows.Forms.TextBox();
            this.txt_tn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_mn
            // 
            this.txt_mn.Location = new System.Drawing.Point(273, 75);
            this.txt_mn.Name = "txt_mn";
            this.txt_mn.Size = new System.Drawing.Size(100, 20);
            this.txt_mn.TabIndex = 0;
            // 
            // txt_tn
            // 
            this.txt_tn.Location = new System.Drawing.Point(273, 167);
            this.txt_tn.Name = "txt_tn";
            this.txt_tn.Size = new System.Drawing.Size(100, 20);
            this.txt_tn.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_themsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_tn);
            this.Controls.Add(this.txt_mn);
            this.Name = "frm_themsanpham";
            this.Text = "frm_themsanpham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txt_mn;
        public System.Windows.Forms.TextBox txt_tn;
        private System.Windows.Forms.Button button1;
    }
}