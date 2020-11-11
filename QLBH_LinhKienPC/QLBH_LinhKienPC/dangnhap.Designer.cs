namespace QLBH_LinhKienPC
{
    partial class dangnhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.dn_tk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dn_mk = new System.Windows.Forms.TextBox();
            this.bt_dn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÀI KHOẢNG";
            // 
            // dn_tk
            // 
            this.dn_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_tk.Location = new System.Drawing.Point(300, 67);
            this.dn_tk.Name = "dn_tk";
            this.dn_tk.Size = new System.Drawing.Size(257, 31);
            this.dn_tk.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "MẬT KHẨU";
            // 
            // dn_mk
            // 
            this.dn_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_mk.Location = new System.Drawing.Point(300, 146);
            this.dn_mk.Name = "dn_mk";
            this.dn_mk.Size = new System.Drawing.Size(257, 31);
            this.dn_mk.TabIndex = 1;
            // 
            // bt_dn
            // 
            this.bt_dn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dn.Location = new System.Drawing.Point(250, 266);
            this.bt_dn.Name = "bt_dn";
            this.bt_dn.Size = new System.Drawing.Size(233, 68);
            this.bt_dn.TabIndex = 2;
            this.bt_dn.Text = "ĐĂNG NHẬP";
            this.bt_dn.UseVisualStyleBackColor = true;
            this.bt_dn.Click += new System.EventHandler(this.bt_dn_Click);
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 400);
            this.Controls.Add(this.bt_dn);
            this.Controls.Add(this.dn_mk);
            this.Controls.Add(this.dn_tk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dangnhap";
            this.Text = "ĐĂNG NHẬP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dn_tk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dn_mk;
        private System.Windows.Forms.Button bt_dn;
    }
}

