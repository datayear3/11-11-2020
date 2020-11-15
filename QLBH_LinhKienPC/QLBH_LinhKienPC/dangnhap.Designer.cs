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
            this.dn_tk = new System.Windows.Forms.TextBox();
            this.dn_mk = new System.Windows.Forms.TextBox();
            this.bt_dn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dn_tk
            // 
            this.dn_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_tk.Location = new System.Drawing.Point(424, 148);
            this.dn_tk.Multiline = true;
            this.dn_tk.Name = "dn_tk";
            this.dn_tk.Size = new System.Drawing.Size(426, 44);
            this.dn_tk.TabIndex = 1;
            // 
            // dn_mk
            // 
            this.dn_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_mk.Location = new System.Drawing.Point(424, 234);
            this.dn_mk.Multiline = true;
            this.dn_mk.Name = "dn_mk";
            this.dn_mk.PasswordChar = '*';
            this.dn_mk.Size = new System.Drawing.Size(426, 39);
            this.dn_mk.TabIndex = 1;
            // 
            // bt_dn
            // 
            this.bt_dn.BackColor = System.Drawing.Color.AliceBlue;
            this.bt_dn.FlatAppearance.BorderSize = 0;
            this.bt_dn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_dn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_dn.Location = new System.Drawing.Point(340, 325);
            this.bt_dn.Name = "bt_dn";
            this.bt_dn.Size = new System.Drawing.Size(233, 85);
            this.bt_dn.TabIndex = 2;
            this.bt_dn.Text = "ĐĂNG NHẬP";
            this.bt_dn.UseVisualStyleBackColor = false;
            this.bt_dn.Click += new System.EventHandler(this.bt_dn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 468);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLBH_LinhKienPC.Properties.Resources.z2171722687729_32a7bf203d52597a79ab3092bf6d42c3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.AliceBlue;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(679, 325);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(233, 85);
            this.exit.TabIndex = 2;
            this.exit.Text = "THOÁT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = global::QLBH_LinhKienPC.Properties.Resources._512;
            this.pictureBox2.Location = new System.Drawing.Point(304, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.BackgroundImage = global::QLBH_LinhKienPC.Properties.Resources.pngtree_simple_wood_plank_texture_desk_top_view_background_poster_image_260246;
            this.ClientSize = new System.Drawing.Size(963, 468);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.bt_dn);
            this.Controls.Add(this.dn_mk);
            this.Controls.Add(this.dn_tk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dangnhap";
            this.Text = "ĐĂNG NHẬP";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dn_tk;
        private System.Windows.Forms.TextBox dn_mk;
        private System.Windows.Forms.Button bt_dn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

