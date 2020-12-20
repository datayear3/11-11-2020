namespace QLBH_LinhKienPC.GUI
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_thongke = new System.Windows.Forms.Button();
            this.bt_quantrivien = new System.Windows.Forms.Button();
            this.bt_khohang = new System.Windows.Forms.Button();
            this.bt_banhang = new System.Windows.Forms.Button();
            this.bt_trangchu = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.us_thongke = new QLBH_LinhKienPC.GUI.THONGKE.thongke();
            this.us_khohang = new QLBH_LinhKienPC.GUI.KHOHANG.khohang();
            this.us_banhang = new QLBH_LinhKienPC.GUI.BANHANG.banhang();
            this.us_quantrivien = new QLBH_LinhKienPC.GUI.QUANTRIVIEN.quantrivien();
            this.us_trangchu = new QLBH_LinhKienPC.GUI.TRANGCHU.trangchu();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bt_thongke);
            this.panel1.Controls.Add(this.bt_quantrivien);
            this.panel1.Controls.Add(this.bt_khohang);
            this.panel1.Controls.Add(this.bt_banhang);
            this.panel1.Controls.Add(this.bt_trangchu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 894);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = global::QLBH_LinhKienPC.Properties.Resources.logo_sell;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // bt_thongke
            // 
            this.bt_thongke.FlatAppearance.BorderSize = 0;
            this.bt_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thongke.Image = global::QLBH_LinhKienPC.Properties.Resources.icons8_system_report_50;
            this.bt_thongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_thongke.Location = new System.Drawing.Point(6, 328);
            this.bt_thongke.Name = "bt_thongke";
            this.bt_thongke.Size = new System.Drawing.Size(294, 70);
            this.bt_thongke.TabIndex = 0;
            this.bt_thongke.Text = "THỐNG KÊ";
            this.bt_thongke.UseVisualStyleBackColor = true;
            this.bt_thongke.Click += new System.EventHandler(this.bt_thongke_Click);
            // 
            // bt_quantrivien
            // 
            this.bt_quantrivien.FlatAppearance.BorderSize = 0;
            this.bt_quantrivien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_quantrivien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quantrivien.Image = global::QLBH_LinhKienPC.Properties.Resources.icons8_admin_settings_male_50;
            this.bt_quantrivien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_quantrivien.Location = new System.Drawing.Point(3, 404);
            this.bt_quantrivien.Name = "bt_quantrivien";
            this.bt_quantrivien.Size = new System.Drawing.Size(297, 70);
            this.bt_quantrivien.TabIndex = 0;
            this.bt_quantrivien.Text = "QUẢN TRỊ VIÊN";
            this.bt_quantrivien.UseVisualStyleBackColor = true;
            this.bt_quantrivien.Click += new System.EventHandler(this.bt_quantrivien_Click);
            // 
            // bt_khohang
            // 
            this.bt_khohang.FlatAppearance.BorderSize = 0;
            this.bt_khohang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_khohang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_khohang.Image = global::QLBH_LinhKienPC.Properties.Resources.icons8_data_provider_50;
            this.bt_khohang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_khohang.Location = new System.Drawing.Point(0, 252);
            this.bt_khohang.Name = "bt_khohang";
            this.bt_khohang.Size = new System.Drawing.Size(300, 70);
            this.bt_khohang.TabIndex = 0;
            this.bt_khohang.Text = "KHO HÀNG";
            this.bt_khohang.UseVisualStyleBackColor = true;
            this.bt_khohang.Click += new System.EventHandler(this.bt_khohang_Click);
            // 
            // bt_banhang
            // 
            this.bt_banhang.FlatAppearance.BorderSize = 0;
            this.bt_banhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_banhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_banhang.Image = global::QLBH_LinhKienPC.Properties.Resources.icons8_sell_stock_50;
            this.bt_banhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_banhang.Location = new System.Drawing.Point(0, 176);
            this.bt_banhang.Name = "bt_banhang";
            this.bt_banhang.Size = new System.Drawing.Size(297, 70);
            this.bt_banhang.TabIndex = 0;
            this.bt_banhang.Text = "BÁN HÀNG";
            this.bt_banhang.UseVisualStyleBackColor = true;
            this.bt_banhang.Click += new System.EventHandler(this.bt_banhang_Click);
            // 
            // bt_trangchu
            // 
            this.bt_trangchu.FlatAppearance.BorderSize = 0;
            this.bt_trangchu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_trangchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_trangchu.Image = global::QLBH_LinhKienPC.Properties.Resources.icons8_home_page_50;
            this.bt_trangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_trangchu.Location = new System.Drawing.Point(0, 100);
            this.bt_trangchu.Name = "bt_trangchu";
            this.bt_trangchu.Size = new System.Drawing.Size(300, 70);
            this.bt_trangchu.TabIndex = 0;
            this.bt_trangchu.Text = "TRANG CHỦ";
            this.bt_trangchu.UseVisualStyleBackColor = true;
            this.bt_trangchu.Click += new System.EventHandler(this.bt_trangchu_Click);
            // 
            // bt_close
            // 
            this.bt_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(60)))), ((int)(((byte)(146)))));
            this.bt_close.FlatAppearance.BorderSize = 0;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.Image = global::QLBH_LinhKienPC.Properties.Resources.icons8_logout_rounded_down_64;
            this.bt_close.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_close.Location = new System.Drawing.Point(0, 0);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(233, 100);
            this.bt_close.TabIndex = 0;
            this.bt_close.Text = "THOÁT";
            this.bt_close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_close.UseVisualStyleBackColor = false;
            this.bt_close.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.bt_close);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(336, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1088, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ BÁN LINH KIỆN MÁY TÍNH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // us_thongke
            // 
            this.us_thongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.us_thongke.Location = new System.Drawing.Point(300, 100);
            this.us_thongke.Name = "us_thongke";
            this.us_thongke.Size = new System.Drawing.Size(1620, 980);
            this.us_thongke.TabIndex = 6;
            // 
            // us_khohang
            // 
            this.us_khohang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.us_khohang.Location = new System.Drawing.Point(300, 100);
            this.us_khohang.Margin = new System.Windows.Forms.Padding(2);
            this.us_khohang.Name = "us_khohang";
            this.us_khohang.Size = new System.Drawing.Size(1620, 980);
            this.us_khohang.TabIndex = 4;
            // 
            // us_banhang
            // 
            this.us_banhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(165)))), ((int)(((byte)(149)))));
            this.us_banhang.Location = new System.Drawing.Point(300, 100);
            this.us_banhang.Name = "us_banhang";
            this.us_banhang.Size = new System.Drawing.Size(1620, 980);
            this.us_banhang.TabIndex = 2;
            // 
            // us_quantrivien
            // 
            this.us_quantrivien.BackColor = System.Drawing.SystemColors.ControlDark;
            this.us_quantrivien.Location = new System.Drawing.Point(300, 100);
            this.us_quantrivien.Name = "us_quantrivien";
            this.us_quantrivien.Size = new System.Drawing.Size(1620, 980);
            this.us_quantrivien.TabIndex = 7;
            // 
            // us_trangchu
            // 
            this.us_trangchu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(225)))));
            this.us_trangchu.Location = new System.Drawing.Point(300, 100);
            this.us_trangchu.Name = "us_trangchu";
            this.us_trangchu.Size = new System.Drawing.Size(1620, 980);
            this.us_trangchu.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 894);
            this.Controls.Add(this.us_trangchu);
            this.Controls.Add(this.us_quantrivien);
            this.Controls.Add(this.us_thongke);
            this.Controls.Add(this.us_khohang);
            this.Controls.Add(this.us_banhang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_trangchu;
        public System.Windows.Forms.Button bt_close;
        public System.Windows.Forms.Button bt_thongke;
        public System.Windows.Forms.Button bt_quantrivien;
        public System.Windows.Forms.Button bt_khohang;
        public System.Windows.Forms.Button bt_banhang;
        //private BANHANG.banhang banhang1;
        //private TRANGCHU.trangchu trangchu1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public BANHANG.banhang us_banhang;
        private KHOHANG.khohang us_khohang;
        private System.Windows.Forms.Label label1;
        private THONGKE.thongke us_thongke;
        private QUANTRIVIEN.quantrivien us_quantrivien;
        private TRANGCHU.trangchu us_trangchu;
    }
}