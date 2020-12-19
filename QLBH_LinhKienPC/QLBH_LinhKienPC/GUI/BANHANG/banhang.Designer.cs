namespace QLBH_LinhKienPC.GUI.BANHANG
{
    partial class banhang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvt_doanhthu = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_them_khachhang = new System.Windows.Forms.Button();
            this.bt_hoadon = new System.Windows.Forms.Button();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvt_doanhthu)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dvt_doanhthu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(498, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 980);
            this.panel1.TabIndex = 0;
            // 
            // dvt_doanhthu
            // 
            this.dvt_doanhthu.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dvt_doanhthu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvt_doanhthu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dvt_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvt_doanhthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.TenNV,
            this.TenKH,
            this.NgayBan,
            this.DGB,
            this.SLB,
            this.TenSP,
            this.TongTienBan});
            this.dvt_doanhthu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvt_doanhthu.Location = new System.Drawing.Point(0, 80);
            this.dvt_doanhthu.Name = "dvt_doanhthu";
            this.dvt_doanhthu.Size = new System.Drawing.Size(1122, 900);
            this.dvt_doanhthu.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(198)))), ((int)(((byte)(108)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 80);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(492, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOANH THU";
            // 
            // bt_them_khachhang
            // 
            this.bt_them_khachhang.BackColor = System.Drawing.Color.Green;
            this.bt_them_khachhang.FlatAppearance.BorderSize = 0;
            this.bt_them_khachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them_khachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them_khachhang.Location = new System.Drawing.Point(0, 0);
            this.bt_them_khachhang.Name = "bt_them_khachhang";
            this.bt_them_khachhang.Size = new System.Drawing.Size(243, 78);
            this.bt_them_khachhang.TabIndex = 1;
            this.bt_them_khachhang.Text = "THÊM KHÁCH HÀNG";
            this.bt_them_khachhang.UseVisualStyleBackColor = false;
            this.bt_them_khachhang.Click += new System.EventHandler(this.bt_them_khachhang_Click);
            // 
            // bt_hoadon
            // 
            this.bt_hoadon.BackColor = System.Drawing.Color.Green;
            this.bt_hoadon.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_hoadon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_hoadon.Location = new System.Drawing.Point(249, 0);
            this.bt_hoadon.Name = "bt_hoadon";
            this.bt_hoadon.Size = new System.Drawing.Size(243, 80);
            this.bt_hoadon.TabIndex = 2;
            this.bt_hoadon.Text = "HÓA ĐƠN";
            this.bt_hoadon.UseVisualStyleBackColor = false;
            this.bt_hoadon.Click += new System.EventHandler(this.bt_hoadon_Click);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "MÃ HÓA ĐƠN";
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 130;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "TÊN NHÂN VIÊN";
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 150;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "TÊN KHÁCH HÀNG";
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 150;
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "NGÀY BÁN";
            this.NgayBan.Name = "NgayBan";
            // 
            // DGB
            // 
            this.DGB.DataPropertyName = "DGB";
            this.DGB.HeaderText = "ĐƠN GIÁ BÁN";
            this.DGB.Name = "DGB";
            this.DGB.Width = 150;
            // 
            // SLB
            // 
            this.SLB.DataPropertyName = "SLB";
            this.SLB.HeaderText = "SỐ LƯỢNG BÁN";
            this.SLB.Name = "SLB";
            this.SLB.Width = 150;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "TÊN SẢN PHẨM";
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 150;
            // 
            // TongTienBan
            // 
            this.TongTienBan.DataPropertyName = "TongTienBan";
            this.TongTienBan.HeaderText = "TỔNG TIỀN";
            this.TongTienBan.Name = "TongTienBan";
            // 
            // banhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(165)))), ((int)(((byte)(149)))));
            this.Controls.Add(this.bt_hoadon);
            this.Controls.Add(this.bt_them_khachhang);
            this.Controls.Add(this.panel1);
            this.Name = "banhang";
            this.Size = new System.Drawing.Size(1620, 980);
            this.Load += new System.EventHandler(this.banhang_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvt_doanhthu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dvt_doanhthu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button bt_them_khachhang;
        public System.Windows.Forms.Button bt_hoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienBan;
    }
}
