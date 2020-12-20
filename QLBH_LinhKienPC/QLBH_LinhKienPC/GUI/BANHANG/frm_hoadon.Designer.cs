namespace QLBH_LinhKienPC.GUI.BANHANG
{
    partial class frm_hoadon
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cb_masp = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.btn_tinhtong = new System.Windows.Forms.Button();
            this.txt_tongtienban = new System.Windows.Forms.TextBox();
            this.VNĐ = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_timkiemkh = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.dt_ngayban = new System.Windows.Forms.DateTimePicker();
            this.cb_manv = new System.Windows.Forms.ComboBox();
            this.quanLyCuaHangBanLeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyCuaHangBanLeDataSet = new QLBH_LinhKienPC.QuanLyCuaHangBanLeDataSet();
            this.btn_timkiemnv = new System.Windows.Forms.Button();
            this.cb_makh = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_tennv = new System.Windows.Forms.TextBox();
            this.txt_dienthoai = new System.Windows.Forms.TextBox();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtv_hd = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangBanLeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangBanLeDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_hd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(281, 109);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(108, 35);
            this.btn_delete.TabIndex = 101;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.White;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(725, 109);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(116, 35);
            this.btn_Exit.TabIndex = 100;
            this.btn_Exit.Text = "Đóng";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(497, 109);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(113, 35);
            this.btn_update.TabIndex = 99;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(13, 109);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(110, 35);
            this.btn_add.TabIndex = 98;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // cb_masp
            // 
            this.cb_masp.FormattingEnabled = true;
            this.cb_masp.Location = new System.Drawing.Point(102, 21);
            this.cb_masp.Margin = new System.Windows.Forms.Padding(4);
            this.cb_masp.Name = "cb_masp";
            this.cb_masp.Size = new System.Drawing.Size(140, 21);
            this.cb_masp.TabIndex = 97;
            this.cb_masp.SelectedIndexChanged += new System.EventHandler(this.cb_masp_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(474, 64);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 19);
            this.label13.TabIndex = 95;
            this.label13.Text = "Tổng tiền bán";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 19);
            this.label11.TabIndex = 94;
            this.label11.Text = "Mã sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(399, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 19);
            this.label9.TabIndex = 93;
            this.label9.Text = "Số lượng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(3, 61);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 92;
            this.label8.Text = "Tên sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(650, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 91;
            this.label7.Text = "Đơn giá";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(725, 21);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(184, 20);
            this.txt_dongia.TabIndex = 90;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(470, 21);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(140, 20);
            this.txt_soluong.TabIndex = 89;
            this.txt_soluong.TextChanged += new System.EventHandler(this.txt_soluong_TextChanged_1);
            // 
            // txt_tensp
            // 
            this.txt_tensp.Location = new System.Drawing.Point(102, 62);
            this.txt_tensp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(140, 20);
            this.txt_tensp.TabIndex = 88;
            // 
            // btn_tinhtong
            // 
            this.btn_tinhtong.Location = new System.Drawing.Point(685, 620);
            this.btn_tinhtong.Name = "btn_tinhtong";
            this.btn_tinhtong.Size = new System.Drawing.Size(75, 23);
            this.btn_tinhtong.TabIndex = 73;
            this.btn_tinhtong.Text = "Tính tổng tiền";
            this.btn_tinhtong.UseVisualStyleBackColor = true;
            this.btn_tinhtong.Click += new System.EventHandler(this.btn_tinhtong_Click_1);
            // 
            // txt_tongtienban
            // 
            this.txt_tongtienban.Location = new System.Drawing.Point(573, 63);
            this.txt_tongtienban.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tongtienban.Name = "txt_tongtienban";
            this.txt_tongtienban.Size = new System.Drawing.Size(184, 20);
            this.txt_tongtienban.TabIndex = 96;
            // 
            // VNĐ
            // 
            this.VNĐ.AutoSize = true;
            this.VNĐ.Location = new System.Drawing.Point(918, 624);
            this.VNĐ.Name = "VNĐ";
            this.VNĐ.Size = new System.Drawing.Size(30, 13);
            this.VNĐ.TabIndex = 75;
            this.VNĐ.Text = "VNĐ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_timkiemkh);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dt_ngayban);
            this.groupBox1.Controls.Add(this.cb_manv);
            this.groupBox1.Controls.Add(this.btn_timkiemnv);
            this.groupBox1.Controls.Add(this.cb_makh);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_tenkh);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_tennv);
            this.groupBox1.Controls.Add(this.txt_dienthoai);
            this.groupBox1.Controls.Add(this.txt_mahd);
            this.groupBox1.Location = new System.Drawing.Point(87, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(935, 178);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // btn_timkiemkh
            // 
            this.btn_timkiemkh.BackColor = System.Drawing.Color.White;
            this.btn_timkiemkh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiemkh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_timkiemkh.Location = new System.Drawing.Point(803, 33);
            this.btn_timkiemkh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiemkh.Name = "btn_timkiemkh";
            this.btn_timkiemkh.Size = new System.Drawing.Size(94, 25);
            this.btn_timkiemkh.TabIndex = 90;
            this.btn_timkiemkh.Text = "Tìm kiếm";
            this.btn_timkiemkh.UseVisualStyleBackColor = false;
            this.btn_timkiemkh.Click += new System.EventHandler(this.btn_timkiemkh_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(6, 105);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 19);
            this.label14.TabIndex = 89;
            this.label14.Text = "Mã nhân viên";
            // 
            // dt_ngayban
            // 
            this.dt_ngayban.CustomFormat = "dd/MM/yyyy";
            this.dt_ngayban.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngayban.Location = new System.Drawing.Point(102, 70);
            this.dt_ngayban.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngayban.Name = "dt_ngayban";
            this.dt_ngayban.Size = new System.Drawing.Size(140, 20);
            this.dt_ngayban.TabIndex = 74;
            // 
            // cb_manv
            // 
            this.cb_manv.FormattingEnabled = true;
            this.cb_manv.Location = new System.Drawing.Point(102, 105);
            this.cb_manv.Margin = new System.Windows.Forms.Padding(4);
            this.cb_manv.Name = "cb_manv";
            this.cb_manv.Size = new System.Drawing.Size(140, 21);
            this.cb_manv.TabIndex = 73;
            this.cb_manv.SelectedIndexChanged += new System.EventHandler(this.cb_manv_SelectedIndexChanged_1);
            // 
            // quanLyCuaHangBanLeDataSetBindingSource
            // 
            this.quanLyCuaHangBanLeDataSetBindingSource.DataSource = this.quanLyCuaHangBanLeDataSet;
            this.quanLyCuaHangBanLeDataSetBindingSource.Position = 0;
            // 
            // quanLyCuaHangBanLeDataSet
            // 
            this.quanLyCuaHangBanLeDataSet.DataSetName = "QuanLyCuaHangBanLeDataSet";
            this.quanLyCuaHangBanLeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_timkiemnv
            // 
            this.btn_timkiemnv.BackColor = System.Drawing.Color.White;
            this.btn_timkiemnv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiemnv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_timkiemnv.Location = new System.Drawing.Point(261, 139);
            this.btn_timkiemnv.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiemnv.Name = "btn_timkiemnv";
            this.btn_timkiemnv.Size = new System.Drawing.Size(94, 25);
            this.btn_timkiemnv.TabIndex = 86;
            this.btn_timkiemnv.Text = "Tìm kiếm";
            this.btn_timkiemnv.UseVisualStyleBackColor = false;
            this.btn_timkiemnv.Click += new System.EventHandler(this.btn_timkiemnv_Click_1);
            // 
            // cb_makh
            // 
            this.cb_makh.FormattingEnabled = true;
            this.cb_makh.Location = new System.Drawing.Point(610, 33);
            this.cb_makh.Margin = new System.Windows.Forms.Padding(4);
            this.cb_makh.Name = "cb_makh";
            this.cb_makh.Size = new System.Drawing.Size(162, 21);
            this.cb_makh.TabIndex = 72;
            this.cb_makh.SelectedIndexChanged += new System.EventHandler(this.cb_makh_SelectedIndexChanged_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(481, 145);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 19);
            this.label12.TabIndex = 71;
            this.label12.Text = "Điện thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(479, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 19);
            this.label10.TabIndex = 70;
            this.label10.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(4, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 19);
            this.label6.TabIndex = 69;
            this.label6.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(479, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 67;
            this.label4.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 66;
            this.label3.Text = "Ngày bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(481, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 64;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Location = new System.Drawing.Point(610, 70);
            this.txt_tenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(162, 20);
            this.txt_tenkh.TabIndex = 63;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(610, 106);
            this.txt_diachi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(162, 20);
            this.txt_diachi.TabIndex = 62;
            // 
            // txt_tennv
            // 
            this.txt_tennv.Location = new System.Drawing.Point(102, 141);
            this.txt_tennv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tennv.Name = "txt_tennv";
            this.txt_tennv.Size = new System.Drawing.Size(140, 20);
            this.txt_tennv.TabIndex = 61;
            // 
            // txt_dienthoai
            // 
            this.txt_dienthoai.Location = new System.Drawing.Point(610, 143);
            this.txt_dienthoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_dienthoai.Name = "txt_dienthoai";
            this.txt_dienthoai.Size = new System.Drawing.Size(162, 20);
            this.txt_dienthoai.TabIndex = 60;
            // 
            // txt_mahd
            // 
            this.txt_mahd.Location = new System.Drawing.Point(102, 27);
            this.txt_mahd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(140, 20);
            this.txt_mahd.TabIndex = 58;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtv_hd);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_Exit);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.cb_masp);
            this.groupBox2.Controls.Add(this.txt_tongtienban);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_dongia);
            this.groupBox2.Controls.Add(this.txt_soluong);
            this.groupBox2.Controls.Add(this.txt_tensp);
            this.groupBox2.Location = new System.Drawing.Point(87, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(935, 373);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // dtv_hd
            // 
            this.dtv_hd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv_hd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaNV,
            this.NgayBAN,
            this.MaKH,
            this.MaSp,
            this.SLB,
            this.DGB,
            this.TongTienBan});
            this.dtv_hd.Location = new System.Drawing.Point(13, 184);
            this.dtv_hd.Name = "dtv_hd";
            this.dtv_hd.Size = new System.Drawing.Size(896, 184);
            this.dtv_hd.TabIndex = 103;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(362, 18);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(332, 36);
            this.label17.TabIndex = 72;
            this.label17.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(783, 620);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(129, 20);
            this.txt_tongtien.TabIndex = 74;
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.Name = "MaHD";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            // 
            // NgayBAN
            // 
            this.NgayBAN.DataPropertyName = "NgayBan";
            this.NgayBAN.HeaderText = "Ngày Bán";
            this.NgayBAN.Name = "NgayBAN";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách hàng";
            this.MaKH.Name = "MaKH";
            // 
            // MaSp
            // 
            this.MaSp.DataPropertyName = "MaSP";
            this.MaSp.HeaderText = "Mã Sản Phẩm";
            this.MaSp.Name = "MaSp";
            // 
            // SLB
            // 
            this.SLB.DataPropertyName = "SLB";
            this.SLB.HeaderText = "Số lượng";
            this.SLB.Name = "SLB";
            // 
            // DGB
            // 
            this.DGB.DataPropertyName = "DGB";
            this.DGB.HeaderText = "Đơn giá";
            this.DGB.Name = "DGB";
            // 
            // TongTienBan
            // 
            this.TongTienBan.DataPropertyName = "TongTienBan";
            this.TongTienBan.HeaderText = "Tổng Tiền Bán";
            this.TongTienBan.Name = "TongTienBan";
            this.TongTienBan.Width = 150;
            // 
            // frm_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 661);
            this.Controls.Add(this.btn_tinhtong);
            this.Controls.Add(this.VNĐ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_tongtien);
            this.Name = "frm_hoadon";
            this.Text = "frm_hoadon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangBanLeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyCuaHangBanLeDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtv_hd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.ComboBox cb_masp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_dongia;
        public System.Windows.Forms.TextBox txt_soluong;
        public System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.Button btn_tinhtong;
        public System.Windows.Forms.TextBox txt_tongtienban;
        private System.Windows.Forms.Label VNĐ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_timkiemkh;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.DateTimePicker dt_ngayban;
        public System.Windows.Forms.ComboBox cb_manv;
        private System.Windows.Forms.Button btn_timkiemnv;
        public System.Windows.Forms.ComboBox cb_makh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_tenkh;
        public System.Windows.Forms.TextBox txt_diachi;
        public System.Windows.Forms.TextBox txt_tennv;
        public System.Windows.Forms.TextBox txt_dienthoai;
        public System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dtv_hd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.BindingSource quanLyCuaHangBanLeDataSetBindingSource;
        private QuanLyCuaHangBanLeDataSet quanLyCuaHangBanLeDataSet;
        public System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        public System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        public System.Windows.Forms.DataGridViewTextBoxColumn NgayBAN;
        public System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        public System.Windows.Forms.DataGridViewTextBoxColumn MaSp;
        public System.Windows.Forms.DataGridViewTextBoxColumn SLB;
        public System.Windows.Forms.DataGridViewTextBoxColumn DGB;
        public System.Windows.Forms.DataGridViewTextBoxColumn TongTienBan;
    }
}