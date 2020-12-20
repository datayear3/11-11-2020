
namespace QLBH_LinhKienPC.GUI.KHOHANG
{
    partial class frm_phieunhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mpn = new System.Windows.Forms.TextBox();
            this.txt_tncc = new System.Windows.Forms.TextBox();
            this.txt_ttn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dvt_pn = new System.Windows.Forms.DataGridView();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_gn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.num_sln = new System.Windows.Forms.NumericUpDown();
            this.date_n = new System.Windows.Forms.DateTimePicker();
            this.cb_tsp = new System.Windows.Forms.ComboBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvt_pn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sln)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu Nhập:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhà Cung Cấp:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(573, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Nhập:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(573, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền nhập:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_mpn
            // 
            this.txt_mpn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mpn.Location = new System.Drawing.Point(212, 54);
            this.txt_mpn.Name = "txt_mpn";
            this.txt_mpn.Size = new System.Drawing.Size(248, 26);
            this.txt_mpn.TabIndex = 1;
            this.txt_mpn.TextChanged += new System.EventHandler(this.txt_mpn_TextChanged);
            // 
            // txt_tncc
            // 
            this.txt_tncc.Enabled = false;
            this.txt_tncc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tncc.Location = new System.Drawing.Point(212, 238);
            this.txt_tncc.Name = "txt_tncc";
            this.txt_tncc.Size = new System.Drawing.Size(248, 26);
            this.txt_tncc.TabIndex = 1;
            this.txt_tncc.TextChanged += new System.EventHandler(this.txt_tncc_TextChanged);
            // 
            // txt_ttn
            // 
            this.txt_ttn.Enabled = false;
            this.txt_ttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ttn.Location = new System.Drawing.Point(692, 139);
            this.txt_ttn.Name = "txt_ttn";
            this.txt_ttn.Size = new System.Drawing.Size(156, 26);
            this.txt_ttn.TabIndex = 1;
            this.txt_ttn.TextChanged += new System.EventHandler(this.txt_ttn_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(360, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(326, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "QUẢN LÝ NHẬP HÀNG";
            // 
            // dvt_pn
            // 
            this.dvt_pn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvt_pn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.TenSP,
            this.SLN,
            this.DONGIA,
            this.TenNCC,
            this.NgayNhap,
            this.TongTienNhap});
            this.dvt_pn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvt_pn.Location = new System.Drawing.Point(0, 384);
            this.dvt_pn.Name = "dvt_pn";
            this.dvt_pn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dvt_pn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvt_pn.Size = new System.Drawing.Size(1016, 222);
            this.dvt_pn.TabIndex = 2;
            this.dvt_pn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvt_pn_CellClick);
            this.dvt_pn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvt_pn_CellContentClick);
            // 
            // MaPN
            // 
            this.MaPN.DataPropertyName = "MaPN";
            this.MaPN.HeaderText = "MÃ PHIẾU NHẬP";
            this.MaPN.Name = "MaPN";
            this.MaPN.ReadOnly = true;
            this.MaPN.Width = 130;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "TÊN SẢN PHẨM";
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 150;
            // 
            // SLN
            // 
            this.SLN.DataPropertyName = "SLN";
            this.SLN.HeaderText = "SỐ LƯỢNG NHẬP";
            this.SLN.Name = "SLN";
            this.SLN.ReadOnly = true;
            this.SLN.Width = 130;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "ĐƠN GIÁ";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.ReadOnly = true;
            this.DONGIA.Width = 130;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "TÊN NHÀ CUNG CẤP";
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.ReadOnly = true;
            this.TenNCC.Width = 150;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "NGÀY NHẬP";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            this.NgayNhap.Width = 150;
            // 
            // TongTienNhap
            // 
            this.TongTienNhap.DataPropertyName = "TongTienNhap";
            this.TongTienNhap.HeaderText = "TỔNG TIỀN NHẬP";
            this.TongTienNhap.Name = "TongTienNhap";
            this.TongTienNhap.ReadOnly = true;
            this.TongTienNhap.Width = 130;
            // 
            // bt_them
            // 
            this.bt_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.Location = new System.Drawing.Point(495, 209);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(132, 55);
            this.bt_them.TabIndex = 3;
            this.bt_them.Text = "THÊM";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.Location = new System.Drawing.Point(633, 209);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(129, 55);
            this.bt_sua.TabIndex = 3;
            this.bt_sua.Text = "SỬA";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.Location = new System.Drawing.Point(768, 209);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(126, 55);
            this.bt_xoa.TabIndex = 3;
            this.bt_xoa.Text = "HỦY";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng nhập";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá nhập";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_gn
            // 
            this.txt_gn.Enabled = false;
            this.txt_gn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gn.Location = new System.Drawing.Point(212, 194);
            this.txt_gn.Name = "txt_gn";
            this.txt_gn.Size = new System.Drawing.Size(248, 26);
            this.txt_gn.TabIndex = 1;
            this.txt_gn.TextChanged += new System.EventHandler(this.txt_gn_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên sản phẩm";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // num_sln
            // 
            this.num_sln.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_sln.Location = new System.Drawing.Point(212, 152);
            this.num_sln.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_sln.Name = "num_sln";
            this.num_sln.Size = new System.Drawing.Size(248, 26);
            this.num_sln.TabIndex = 4;
            this.num_sln.ValueChanged += new System.EventHandler(this.num_sln_ValueChanged);
            // 
            // date_n
            // 
            this.date_n.Enabled = false;
            this.date_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_n.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_n.Location = new System.Drawing.Point(692, 80);
            this.date_n.Name = "date_n";
            this.date_n.Size = new System.Drawing.Size(156, 26);
            this.date_n.TabIndex = 5;
            // 
            // cb_tsp
            // 
            this.cb_tsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tsp.FormattingEnabled = true;
            this.cb_tsp.Location = new System.Drawing.Point(212, 101);
            this.cb_tsp.Name = "cb_tsp";
            this.cb_tsp.Size = new System.Drawing.Size(248, 28);
            this.cb_tsp.TabIndex = 6;
            this.cb_tsp.SelectedIndexChanged += new System.EventHandler(this.cb_tsp_SelectedIndexChanged);
            // 
            // bt_thoat
            // 
            this.bt_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bt_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoat.Location = new System.Drawing.Point(636, 287);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(126, 55);
            this.bt_thoat.TabIndex = 3;
            this.bt_thoat.Text = "THOÁT";
            this.bt_thoat.UseVisualStyleBackColor = false;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // frm_phieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1016, 606);
            this.Controls.Add(this.cb_tsp);
            this.Controls.Add(this.date_n);
            this.Controls.Add(this.num_sln);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.dvt_pn);
            this.Controls.Add(this.txt_gn);
            this.Controls.Add(this.txt_tncc);
            this.Controls.Add(this.txt_ttn);
            this.Controls.Add(this.txt_mpn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_phieunhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_phieunhap";
            this.Load += new System.EventHandler(this.frm_phieunhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvt_pn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sln)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_mpn;
        public System.Windows.Forms.TextBox txt_tncc;
        public System.Windows.Forms.TextBox txt_ttn;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dvt_pn;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_gn;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.NumericUpDown num_sln;
        public System.Windows.Forms.DateTimePicker date_n;
        public System.Windows.Forms.ComboBox cb_tsp;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienNhap;
    }
}