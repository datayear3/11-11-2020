﻿namespace QLBH_LinhKienPC.GUI
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
            this.bt_close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bt_khohang = new System.Windows.Forms.Button();
            this.bt_banhang = new System.Windows.Forms.Button();
            this.bt_trangchu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.us_banhang = new QLBH_LinhKienPC.GUI.BANHANG.banhang();
            this.us_trangchu = new QLBH_LinhKienPC.GUI.TRANGCHU.trangchu();
            this.us_khohang = new QLBH_LinhKienPC.GUI.KHOHANG.khohang();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(61)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.bt_close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.bt_khohang);
            this.panel1.Controls.Add(this.bt_banhang);
            this.panel1.Controls.Add(this.bt_trangchu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bt_close
            // 
            this.bt_close.FlatAppearance.BorderSize = 0;
            this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.Image = global::QLBH_LinhKienPC.Properties.Resources.icons8_logout_rounded_down_64;
            this.bt_close.Location = new System.Drawing.Point(109, 705);
            this.bt_close.Margin = new System.Windows.Forms.Padding(4);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(133, 123);
            this.bt_close.TabIndex = 0;
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = global::QLBH_LinhKienPC.Properties.Resources.logo_sell;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = global::QLBH_LinhKienPC.Properties.Resources.icons8_home_page_50;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 591);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(400, 86);
            this.button6.TabIndex = 0;
            this.button6.Text = "TRANG CHỦ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::QLBH_LinhKienPC.Properties.Resources.icons8_home_page_50;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(4, 497);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(392, 86);
            this.button5.TabIndex = 0;
            this.button5.Text = "TRANG CHỦ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::QLBH_LinhKienPC.Properties.Resources.icons8_home_page_50;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 404);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(396, 86);
            this.button4.TabIndex = 0;
            this.button4.Text = "TRANG CHỦ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // bt_khohang
            // 
            this.bt_khohang.FlatAppearance.BorderSize = 0;
            this.bt_khohang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_khohang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_khohang.Image = global::QLBH_LinhKienPC.Properties.Resources.icons8_home_page_50;
            this.bt_khohang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_khohang.Location = new System.Drawing.Point(0, 310);
            this.bt_khohang.Margin = new System.Windows.Forms.Padding(4);
            this.bt_khohang.Name = "bt_khohang";
            this.bt_khohang.Size = new System.Drawing.Size(400, 86);
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
            this.bt_banhang.Location = new System.Drawing.Point(0, 217);
            this.bt_banhang.Margin = new System.Windows.Forms.Padding(4);
            this.bt_banhang.Name = "bt_banhang";
            this.bt_banhang.Size = new System.Drawing.Size(396, 86);
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
            this.bt_trangchu.Location = new System.Drawing.Point(0, 123);
            this.bt_trangchu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_trangchu.Name = "bt_trangchu";
            this.bt_trangchu.Size = new System.Drawing.Size(400, 86);
            this.bt_trangchu.TabIndex = 0;
            this.bt_trangchu.Text = "TRANG CHỦ";
            this.bt_trangchu.UseVisualStyleBackColor = true;
            this.bt_trangchu.Click += new System.EventHandler(this.bt_trangchu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(400, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1540, 123);
            this.panel2.TabIndex = 1;
            // 
            // us_banhang
            // 
            this.us_banhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(165)))), ((int)(((byte)(149)))));
            this.us_banhang.Location = new System.Drawing.Point(400, 123);
            this.us_banhang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.us_banhang.Name = "us_banhang";
            this.us_banhang.Size = new System.Drawing.Size(2160, 1206);
            this.us_banhang.TabIndex = 2;
            // 
            // us_trangchu
            // 
            this.us_trangchu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(240)))), ((int)(((byte)(225)))));
            this.us_trangchu.Location = new System.Drawing.Point(400, 123);
            this.us_trangchu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.us_trangchu.Name = "us_trangchu";
            this.us_trangchu.Size = new System.Drawing.Size(2160, 1206);
            this.us_trangchu.TabIndex = 3;
            // 
            // us_khohang
            // 
            this.us_khohang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.us_khohang.Location = new System.Drawing.Point(400, 123);
            this.us_khohang.Name = "us_khohang";
            this.us_khohang.Size = new System.Drawing.Size(1620, 980);
            this.us_khohang.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.us_khohang);
            this.Controls.Add(this.us_trangchu);
            this.Controls.Add(this.us_banhang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_trangchu;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bt_khohang;
        private System.Windows.Forms.Button bt_banhang;
        private BANHANG.banhang banhang1;
        private TRANGCHU.trangchu trangchu1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BANHANG.banhang us_banhang;
        private TRANGCHU.trangchu us_trangchu;
        private KHOHANG.khohang us_khohang;
    }
}