﻿
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
            ((System.ComponentModel.ISupportInitialize)(this.dvt_pn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_sln)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 324);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhà Cung Cấp:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(764, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Nhập:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(764, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền nhập:";
            // 
            // txt_mpn
            // 
            this.txt_mpn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mpn.Location = new System.Drawing.Point(423, 97);
            this.txt_mpn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mpn.Name = "txt_mpn";
            this.txt_mpn.Size = new System.Drawing.Size(207, 30);
            this.txt_mpn.TabIndex = 1;
            // 
            // txt_tncc
            // 
            this.txt_tncc.Enabled = false;
            this.txt_tncc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tncc.Location = new System.Drawing.Point(423, 324);
            this.txt_tncc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tncc.Name = "txt_tncc";
            this.txt_tncc.Size = new System.Drawing.Size(207, 30);
            this.txt_tncc.TabIndex = 1;
            // 
            // txt_ttn
            // 
            this.txt_ttn.Enabled = false;
            this.txt_ttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ttn.Location = new System.Drawing.Point(923, 171);
            this.txt_ttn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ttn.Name = "txt_ttn";
            this.txt_ttn.Size = new System.Drawing.Size(207, 30);
            this.txt_ttn.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(563, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 42);
            this.label6.TabIndex = 0;
            this.label6.Text = "PHIẾU NHẬP";
            // 
            // dvt_pn
            // 
            this.dvt_pn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvt_pn.Location = new System.Drawing.Point(96, 425);
            this.dvt_pn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvt_pn.Name = "dvt_pn";
            this.dvt_pn.RowHeadersWidth = 51;
            this.dvt_pn.Size = new System.Drawing.Size(1224, 273);
            this.dvt_pn.TabIndex = 2;
            this.dvt_pn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvt_pn_CellContentClick);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(749, 257);
            this.bt_them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(105, 44);
            this.bt_them.TabIndex = 3;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(1025, 257);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(105, 44);
            this.bt_sua.TabIndex = 3;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(892, 257);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(105, 44);
            this.bt_xoa.TabIndex = 3;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng nhập";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 274);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá nhập";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_gn
            // 
            this.txt_gn.Enabled = false;
            this.txt_gn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gn.Location = new System.Drawing.Point(423, 270);
            this.txt_gn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_gn.Name = "txt_gn";
            this.txt_gn.Size = new System.Drawing.Size(207, 30);
            this.txt_gn.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(213, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên sản phẩm";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // num_sln
            // 
            this.num_sln.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_sln.Location = new System.Drawing.Point(423, 218);
            this.num_sln.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.num_sln.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_sln.Name = "num_sln";
            this.num_sln.Size = new System.Drawing.Size(208, 30);
            this.num_sln.TabIndex = 4;
            this.num_sln.ValueChanged += new System.EventHandler(this.num_sln_ValueChanged);
            // 
            // date_n
            // 
            this.date_n.Enabled = false;
            this.date_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_n.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_n.Location = new System.Drawing.Point(923, 98);
            this.date_n.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_n.Name = "date_n";
            this.date_n.Size = new System.Drawing.Size(207, 30);
            this.date_n.TabIndex = 5;
            // 
            // cb_tsp
            // 
            this.cb_tsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tsp.FormattingEnabled = true;
            this.cb_tsp.Location = new System.Drawing.Point(423, 155);
            this.cb_tsp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_tsp.Name = "cb_tsp";
            this.cb_tsp.Size = new System.Drawing.Size(207, 33);
            this.cb_tsp.TabIndex = 6;
            this.cb_tsp.SelectedIndexChanged += new System.EventHandler(this.cb_tsp_SelectedIndexChanged);
            // 
            // frm_phieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 746);
            this.Controls.Add(this.cb_tsp);
            this.Controls.Add(this.date_n);
            this.Controls.Add(this.num_sln);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_phieunhap";
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
    }
}