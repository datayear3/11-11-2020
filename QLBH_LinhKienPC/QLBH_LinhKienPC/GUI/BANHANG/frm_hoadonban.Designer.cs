namespace QLBH_LinhKienPC.GUI.BANHANG
{
    partial class frm_hoadonban
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
            this.components = new System.ComponentModel.Container();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.dtv_banhang = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_makhachhang = new System.Windows.Forms.ComboBox();
            this.cb_manhanvien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_ngayban = new System.Windows.Forms.ComboBox();
            this.quanLyCuaHangBanLeDataSet = new QLBH_LinhKienPC.QuanLyCuaHangBanLeDataSet();
            this.quanLyCuaHangBanLeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyCuaHangBanLeDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_mhd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_banhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangBanLeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangBanLeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangBanLeDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(114)))));
            this.bt_thoat.FlatAppearance.BorderSize = 0;
            this.bt_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.ForeColor = System.Drawing.Color.Azure;
            this.bt_thoat.Location = new System.Drawing.Point(311, 382);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(172, 51);
            this.bt_thoat.TabIndex = 5;
            this.bt_thoat.Text = "THOÁT";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(114)))));
            this.bt_sua.FlatAppearance.BorderSize = 0;
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.Color.Azure;
            this.bt_sua.Location = new System.Drawing.Point(311, 308);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(172, 51);
            this.bt_sua.TabIndex = 6;
            this.bt_sua.Text = "SỬA";
            this.bt_sua.UseVisualStyleBackColor = false;
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(114)))));
            this.bt_xoa.FlatAppearance.BorderSize = 0;
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.Azure;
            this.bt_xoa.Location = new System.Drawing.Point(28, 382);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(172, 51);
            this.bt_xoa.TabIndex = 7;
            this.bt_xoa.Text = "XÓA";
            this.bt_xoa.UseVisualStyleBackColor = false;
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(114)))));
            this.bt_them.FlatAppearance.BorderSize = 0;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.Azure;
            this.bt_them.Location = new System.Drawing.Point(28, 308);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(172, 51);
            this.bt_them.TabIndex = 8;
            this.bt_them.Text = "THÊM";
            this.bt_them.UseVisualStyleBackColor = false;
            // 
            // dtv_banhang
            // 
            this.dtv_banhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_banhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.TenKH,
            this.TenNV,
            this.NgayBan,
            this.TenSP,
            this.TongTienBan});
            this.dtv_banhang.Location = new System.Drawing.Point(569, 12);
            this.dtv_banhang.Name = "dtv_banhang";
            this.dtv_banhang.Size = new System.Drawing.Size(648, 439);
            this.dtv_banhang.TabIndex = 9;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.Name = "MaHD";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên Khách Hàng";
            this.TenKH.Name = "TenKH";
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày Bán";
            this.NgayBan.Name = "NgayBan";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // TongTienBan
            // 
            this.TongTienBan.DataPropertyName = "TongTienBan";
            this.TongTienBan.HeaderText = "Tổng Tiền Bán";
            this.TongTienBan.Name = "TongTienBan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // cb_makhachhang
            // 
            this.cb_makhachhang.FormattingEnabled = true;
            this.cb_makhachhang.Location = new System.Drawing.Point(129, 110);
            this.cb_makhachhang.Name = "cb_makhachhang";
            this.cb_makhachhang.Size = new System.Drawing.Size(121, 21);
            this.cb_makhachhang.TabIndex = 13;
            this.cb_makhachhang.SelectedIndexChanged += new System.EventHandler(this.cb_makhachhang_SelectedIndexChanged);
            // 
            // cb_manhanvien
            // 
            this.cb_manhanvien.FormattingEnabled = true;
            this.cb_manhanvien.Location = new System.Drawing.Point(129, 192);
            this.cb_manhanvien.Name = "cb_manhanvien";
            this.cb_manhanvien.Size = new System.Drawing.Size(121, 21);
            this.cb_manhanvien.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ngày Bán";
            // 
            // dt_ngayban
            // 
            this.dt_ngayban.FormattingEnabled = true;
            this.dt_ngayban.Location = new System.Drawing.Point(395, 106);
            this.dt_ngayban.Name = "dt_ngayban";
            this.dt_ngayban.Size = new System.Drawing.Size(136, 21);
            this.dt_ngayban.TabIndex = 17;
            // 
            // quanLyCuaHangBanLeDataSet
            // 
            this.quanLyCuaHangBanLeDataSet.DataSetName = "QuanLyCuaHangBanLeDataSet";
            this.quanLyCuaHangBanLeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyCuaHangBanLeDataSetBindingSource
            // 
            this.quanLyCuaHangBanLeDataSetBindingSource.DataSource = this.quanLyCuaHangBanLeDataSet;
            this.quanLyCuaHangBanLeDataSetBindingSource.Position = 0;
            // 
            // quanLyCuaHangBanLeDataSetBindingSource1
            // 
            this.quanLyCuaHangBanLeDataSetBindingSource1.DataSource = this.quanLyCuaHangBanLeDataSet;
            this.quanLyCuaHangBanLeDataSetBindingSource1.Position = 0;
            // 
            // txt_mhd
            // 
            this.txt_mhd.Location = new System.Drawing.Point(395, 183);
            this.txt_mhd.Multiline = true;
            this.txt_mhd.Name = "txt_mhd";
            this.txt_mhd.Size = new System.Drawing.Size(134, 30);
            this.txt_mhd.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mã Hóa Đơn";
            // 
            // frm_hoadonban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 466);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_mhd);
            this.Controls.Add(this.dt_ngayban);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_manhanvien);
            this.Controls.Add(this.cb_makhachhang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtv_banhang);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.bt_thoat);
            this.Name = "frm_hoadonban";
            this.Text = "frm_hoadonban";
            this.Load += new System.EventHandler(this.frm_hoadonban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_banhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangBanLeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangBanLeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangBanLeDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.DataGridView dtv_banhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_makhachhang;
        private System.Windows.Forms.ComboBox cb_manhanvien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dt_ngayban;
        private QuanLyCuaHangBanLeDataSet quanLyCuaHangBanLeDataSet;
        private System.Windows.Forms.BindingSource quanLyCuaHangBanLeDataSetBindingSource;
        private System.Windows.Forms.BindingSource quanLyCuaHangBanLeDataSetBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienBan;
        public System.Windows.Forms.TextBox txt_mhd;
        private System.Windows.Forms.Label label6;
    }
}