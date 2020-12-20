namespace QLBH_LinhKienPC.GUI.THONGKE
{
    partial class thongke
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
            this.bt_cttpn = new System.Windows.Forms.Button();
            this.cr_phieunhap = new System.Windows.Forms.Button();
            this.txt_tt = new System.Windows.Forms.TextBox();
            this.dvt_tknh = new System.Windows.Forms.DataGridView();
            this.bt_tongtien = new System.Windows.Forms.Button();
            this.bt_tk = new System.Windows.Forms.Button();
            this.dt_timesau = new System.Windows.Forms.DateTimePicker();
            this.dt_timetruoc = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_tt = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvt_tknh)).BeginInit();
            this.panel6.SuspendLayout();
            this.bt_tt.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.bt_cttpn);
            this.panel1.Controls.Add(this.cr_phieunhap);
            this.panel1.Controls.Add(this.txt_tt);
            this.panel1.Controls.Add(this.dvt_tknh);
            this.panel1.Controls.Add(this.bt_tongtien);
            this.panel1.Controls.Add(this.bt_tk);
            this.panel1.Controls.Add(this.dt_timesau);
            this.panel1.Controls.Add(this.dt_timetruoc);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1620, 326);
            this.panel1.TabIndex = 0;
            // 
            // bt_cttpn
            // 
            this.bt_cttpn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_cttpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cttpn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_cttpn.Location = new System.Drawing.Point(228, 68);
            this.bt_cttpn.Name = "bt_cttpn";
            this.bt_cttpn.Size = new System.Drawing.Size(304, 53);
            this.bt_cttpn.TabIndex = 5;
            this.bt_cttpn.Text = "CHI TIẾT TỪNG PHIẾU NHẬP";
            this.bt_cttpn.UseVisualStyleBackColor = false;
            this.bt_cttpn.Click += new System.EventHandler(this.bt_cttpn_Click);
            // 
            // cr_phieunhap
            // 
            this.cr_phieunhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cr_phieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cr_phieunhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cr_phieunhap.Location = new System.Drawing.Point(228, 152);
            this.cr_phieunhap.Name = "cr_phieunhap";
            this.cr_phieunhap.Size = new System.Drawing.Size(304, 53);
            this.cr_phieunhap.TabIndex = 5;
            this.cr_phieunhap.Text = "CHI TIẾT PHIẾU NHẬP";
            this.cr_phieunhap.UseVisualStyleBackColor = false;
            this.cr_phieunhap.Click += new System.EventHandler(this.cr_phieunhap_Click);
            // 
            // txt_tt
            // 
            this.txt_tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tt.Location = new System.Drawing.Point(228, 242);
            this.txt_tt.Name = "txt_tt";
            this.txt_tt.Size = new System.Drawing.Size(175, 44);
            this.txt_tt.TabIndex = 4;
            // 
            // dvt_tknh
            // 
            this.dvt_tknh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvt_tknh.Dock = System.Windows.Forms.DockStyle.Right;
            this.dvt_tknh.Location = new System.Drawing.Point(623, 53);
            this.dvt_tknh.Name = "dvt_tknh";
            this.dvt_tknh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvt_tknh.Size = new System.Drawing.Size(997, 273);
            this.dvt_tknh.TabIndex = 3;
            this.dvt_tknh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvt_tknh_CellClick);
            this.dvt_tknh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvt_tknh_CellContentClick);
            // 
            // bt_tongtien
            // 
            this.bt_tongtien.BackColor = System.Drawing.Color.Silver;
            this.bt_tongtien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tongtien.ForeColor = System.Drawing.Color.Blue;
            this.bt_tongtien.Location = new System.Drawing.Point(25, 233);
            this.bt_tongtien.Name = "bt_tongtien";
            this.bt_tongtien.Size = new System.Drawing.Size(173, 53);
            this.bt_tongtien.TabIndex = 2;
            this.bt_tongtien.Text = "TỔNG TIỀN";
            this.bt_tongtien.UseVisualStyleBackColor = false;
            this.bt_tongtien.Click += new System.EventHandler(this.bt_tongtien_Click);
            // 
            // bt_tk
            // 
            this.bt_tk.BackColor = System.Drawing.Color.Silver;
            this.bt_tk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_tk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tk.ForeColor = System.Drawing.Color.Blue;
            this.bt_tk.Location = new System.Drawing.Point(25, 152);
            this.bt_tk.Name = "bt_tk";
            this.bt_tk.Size = new System.Drawing.Size(173, 53);
            this.bt_tk.TabIndex = 2;
            this.bt_tk.Text = "TÌM KIẾM";
            this.bt_tk.UseVisualStyleBackColor = false;
            this.bt_tk.Click += new System.EventHandler(this.bt_tk_Click);
            // 
            // dt_timesau
            // 
            this.dt_timesau.CustomFormat = "dd/mm/yyyy";
            this.dt_timesau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_timesau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_timesau.Location = new System.Drawing.Point(25, 103);
            this.dt_timesau.Name = "dt_timesau";
            this.dt_timesau.Size = new System.Drawing.Size(173, 29);
            this.dt_timesau.TabIndex = 1;
            // 
            // dt_timetruoc
            // 
            this.dt_timetruoc.CustomFormat = "dd/MM/yyyy";
            this.dt_timetruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_timetruoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_timetruoc.Location = new System.Drawing.Point(25, 68);
            this.dt_timetruoc.Name = "dt_timetruoc";
            this.dt_timetruoc.Size = new System.Drawing.Size(173, 29);
            this.dt_timetruoc.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel6.Controls.Add(this.label3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1620, 53);
            this.panel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(591, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "THỐNG KÊ NHẬP HÀNG";
            // 
            // bt_tt
            // 
            this.bt_tt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bt_tt.Controls.Add(this.panel4);
            this.bt_tt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_tt.Location = new System.Drawing.Point(0, 326);
            this.bt_tt.Name = "bt_tt";
            this.bt_tt.Size = new System.Drawing.Size(1620, 654);
            this.bt_tt.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1620, 50);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(581, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ BÁN HÀNG";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 662);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1620, 318);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1620, 46);
            this.panel5.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(507, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "THỐNG KÊ HÀNG HÓA TRONG KHO";
            // 
            // thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bt_tt);
            this.Controls.Add(this.panel1);
            this.Name = "thongke";
            this.Size = new System.Drawing.Size(1620, 980);
            this.Load += new System.EventHandler(this.thongke_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvt_tknh)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.bt_tt.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel bt_tt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_timesau;
        private System.Windows.Forms.DateTimePicker dt_timetruoc;
        private System.Windows.Forms.DataGridView dvt_tknh;
        private System.Windows.Forms.Button bt_tk;
        private System.Windows.Forms.TextBox txt_tt;
        private System.Windows.Forms.Button bt_tongtien;
        private System.Windows.Forms.Button cr_phieunhap;
        private System.Windows.Forms.Button bt_cttpn;
    }
}
