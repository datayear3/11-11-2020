namespace QLBH_LinhKienPC.GUI.QUANTRIVIEN
{
    partial class frm_nhanvien
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
            this.rbt_nu = new System.Windows.Forms.RadioButton();
            this.rbt_nam = new System.Windows.Forms.RadioButton();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtv_nhanvien = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_chucvu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.cb_ns = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChiNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // rbt_nu
            // 
            this.rbt_nu.AutoSize = true;
            this.rbt_nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_nu.Location = new System.Drawing.Point(272, 325);
            this.rbt_nu.Name = "rbt_nu";
            this.rbt_nu.Size = new System.Drawing.Size(55, 28);
            this.rbt_nu.TabIndex = 19;
            this.rbt_nu.TabStop = true;
            this.rbt_nu.Text = "Nữ";
            this.rbt_nu.UseVisualStyleBackColor = true;
            this.rbt_nu.CheckedChanged += new System.EventHandler(this.rbt_nu_CheckedChanged);
            // 
            // rbt_nam
            // 
            this.rbt_nam.AutoSize = true;
            this.rbt_nam.Checked = true;
            this.rbt_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_nam.Location = new System.Drawing.Point(195, 325);
            this.rbt_nam.Name = "rbt_nam";
            this.rbt_nam.Size = new System.Drawing.Size(71, 28);
            this.rbt_nam.TabIndex = 20;
            this.rbt_nam.TabStop = true;
            this.rbt_nam.Text = "Nam";
            this.rbt_nam.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(114)))));
            this.bt_sua.FlatAppearance.BorderSize = 0;
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.Color.Azure;
            this.bt_sua.Location = new System.Drawing.Point(446, 382);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(172, 51);
            this.bt_sua.TabIndex = 15;
            this.bt_sua.Text = "SỬA";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(114)))));
            this.bt_thoat.FlatAppearance.BorderSize = 0;
            this.bt_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thoat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.ForeColor = System.Drawing.Color.Azure;
            this.bt_thoat.Location = new System.Drawing.Point(657, 382);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(172, 51);
            this.bt_thoat.TabIndex = 16;
            this.bt_thoat.Text = "THOÁT";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(114)))));
            this.bt_xoa.FlatAppearance.BorderSize = 0;
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.Azure;
            this.bt_xoa.Location = new System.Drawing.Point(240, 382);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(172, 51);
            this.bt_xoa.TabIndex = 17;
            this.bt_xoa.Text = "XÓA";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(4)))), ((int)(((byte)(114)))));
            this.bt_them.FlatAppearance.BorderSize = 0;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.Azure;
            this.bt_them.Location = new System.Drawing.Point(45, 382);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(172, 51);
            this.bt_them.TabIndex = 18;
            this.bt_them.Text = "THÊM";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(195, 266);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(298, 29);
            this.txt_sdt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số Điện Thoại";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachi.Location = new System.Drawing.Point(195, 202);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(298, 29);
            this.txt_diachi.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa Chỉ";
            // 
            // txt_tennv
            // 
            this.txt_tennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tennv.Location = new System.Drawing.Point(195, 141);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(298, 29);
            this.txt_tennv.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // txt_manv
            // 
            this.txt_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_manv.Location = new System.Drawing.Point(195, 85);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(298, 29);
            this.txt_manv.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 69);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(360, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÂN VIÊN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtv_nhanvien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 546);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 340);
            this.panel2.TabIndex = 22;
            // 
            // dtv_nhanvien
            // 
            this.dtv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenCV,
            this.TenNV,
            this.DiaChiNV,
            this.SDTNV,
            this.GioiTinh,
            this.NgaySinh,
            this.MatKhau});
            this.dtv_nhanvien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtv_nhanvien.Location = new System.Drawing.Point(0, 0);
            this.dtv_nhanvien.Name = "dtv_nhanvien";
            this.dtv_nhanvien.Size = new System.Drawing.Size(860, 340);
            this.dtv_nhanvien.TabIndex = 0;
            this.dtv_nhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv_nhanvien_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(533, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Năm Sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(533, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Chức Vụ";
            // 
            // cb_chucvu
            // 
            this.cb_chucvu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_chucvu.FormattingEnabled = true;
            this.cb_chucvu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_chucvu.Location = new System.Drawing.Point(646, 146);
            this.cb_chucvu.Name = "cb_chucvu";
            this.cb_chucvu.Size = new System.Drawing.Size(200, 29);
            this.cb_chucvu.TabIndex = 24;
            this.cb_chucvu.SelectedIndexChanged += new System.EventHandler(this.cb_chucvu_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(533, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mật Khẩu";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_mk
            // 
            this.txt_mk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mk.Location = new System.Drawing.Point(646, 202);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.PasswordChar = '*';
            this.txt_mk.Size = new System.Drawing.Size(200, 29);
            this.txt_mk.TabIndex = 12;
            // 
            // cb_ns
            // 
            this.cb_ns.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ns.FormattingEnabled = true;
            this.cb_ns.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_ns.Location = new System.Drawing.Point(646, 88);
            this.cb_ns.Name = "cb_ns";
            this.cb_ns.Size = new System.Drawing.Size(200, 29);
            this.cb_ns.TabIndex = 24;
            this.cb_ns.SelectedIndexChanged += new System.EventHandler(this.cb_chucvu_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 478);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "TÌM KIẾM";
            // 
            // txt_tk
            // 
            this.txt_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tk.Location = new System.Drawing.Point(176, 478);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.Size = new System.Drawing.Size(298, 29);
            this.txt_tk.TabIndex = 12;
            this.txt_tk.TextChanged += new System.EventHandler(this.txt_tk_TextChanged);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "MÃ NHÂN VIÊN";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 110;
            // 
            // TenCV
            // 
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "TÊN CHỨC VỤ";
            this.TenCV.Name = "TenCV";
            this.TenCV.Width = 130;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "TÊN NHÂN VIÊN";
            this.TenNV.Name = "TenNV";
            // 
            // DiaChiNV
            // 
            this.DiaChiNV.DataPropertyName = "DiaChiNV";
            this.DiaChiNV.HeaderText = "ĐỊA CHỈ NHÂN VIÊN";
            this.DiaChiNV.Name = "DiaChiNV";
            // 
            // SDTNV
            // 
            this.SDTNV.DataPropertyName = "SDTNV";
            this.SDTNV.HeaderText = "SỐ ĐIỆN THOẠI NHÂN VIÊN";
            this.SDTNV.Name = "SDTNV";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "GIỚI TÍNH";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "NGÀY SINH";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "MẬT KHẨU";
            this.MatKhau.Name = "MatKhau";
            // 
            // frm_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(860, 886);
            this.Controls.Add(this.cb_ns);
            this.Controls.Add(this.cb_chucvu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbt_nu);
            this.Controls.Add(this.rbt_nam);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.txt_diachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tennv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_manv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_nhanvien";
            this.Load += new System.EventHandler(this.frm_nhanvien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtv_nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RadioButton rbt_nu;
        public System.Windows.Forms.RadioButton rbt_nam;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_them;
        public System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_tennv;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DataGridView dtv_nhanvien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cb_chucvu;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_mk;
        public System.Windows.Forms.ComboBox cb_ns;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
    }
}