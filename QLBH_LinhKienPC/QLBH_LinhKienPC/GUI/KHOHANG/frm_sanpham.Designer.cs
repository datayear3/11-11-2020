
namespace QLBH_LinhKienPC.GUI.KHOHANG
{
    partial class frm_sanpham
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
            this.l = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.txt_msp = new System.Windows.Forms.TextBox();
            this.txt_mn = new System.Windows.Forms.TextBox();
            this.txt_tsp = new System.Windows.Forms.TextBox();
            this.txt_gb = new System.Windows.Forms.TextBox();
            this.txt_mncc = new System.Windows.Forms.TextBox();
            this.txt_gn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_slt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_dvt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            //this.dtv_sanpham = new System.Windows.Forms.DataGridView();
           // ((System.ComponentModel.ISupportInitialize)(this.dtv_sanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(103, 89);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(118, 19);
            this.l.TabIndex = 0;
            this.l.Text = "Mã sản phẩm(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhóm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sản phẩm(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(588, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(360, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(401, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "THÔNG TIN HÀNG TRONG KHO";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(588, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá nhập";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(105, 211);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(123, 19);
            this.lb5.TabIndex = 0;
            this.lb5.Text = "Mã nhà cung cấp";
            // 
            // txt_msp
            // 
            this.txt_msp.Location = new System.Drawing.Point(252, 90);
            this.txt_msp.Name = "txt_msp";
            this.txt_msp.Size = new System.Drawing.Size(142, 20);
            this.txt_msp.TabIndex = 1;
            // 
            // txt_mn
            // 
            this.txt_mn.Location = new System.Drawing.Point(252, 248);
            this.txt_mn.Name = "txt_mn";
            this.txt_mn.Size = new System.Drawing.Size(142, 20);
            this.txt_mn.TabIndex = 1;
            this.txt_mn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_tsp
            // 
            this.txt_tsp.Location = new System.Drawing.Point(252, 127);
            this.txt_tsp.Name = "txt_tsp";
            this.txt_tsp.Size = new System.Drawing.Size(142, 20);
            this.txt_tsp.TabIndex = 1;
            this.txt_tsp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_gb
            // 
            this.txt_gb.Location = new System.Drawing.Point(740, 131);
            this.txt_gb.Name = "txt_gb";
            this.txt_gb.Size = new System.Drawing.Size(174, 20);
            this.txt_gb.TabIndex = 1;
            // 
            // txt_mncc
            // 
            this.txt_mncc.Location = new System.Drawing.Point(252, 212);
            this.txt_mncc.Name = "txt_mncc";
            this.txt_mncc.Size = new System.Drawing.Size(142, 20);
            this.txt_mncc.TabIndex = 1;
            this.txt_mncc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_gn
            // 
            this.txt_gn.Location = new System.Drawing.Point(740, 92);
            this.txt_gn.Name = "txt_gn";
            this.txt_gn.Size = new System.Drawing.Size(174, 20);
            this.txt_gn.TabIndex = 1;
            this.txt_gn.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(588, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng tồn";
            // 
            // txt_slt
            // 
            this.txt_slt.Location = new System.Drawing.Point(740, 181);
            this.txt_slt.Name = "txt_slt";
            this.txt_slt.Size = new System.Drawing.Size(174, 20);
            this.txt_slt.TabIndex = 1;
            this.txt_slt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(103, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Đơn vị tính";
            // 
            // txt_dvt
            // 
            this.txt_dvt.Location = new System.Drawing.Point(252, 166);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.Size = new System.Drawing.Size(142, 20);
            this.txt_dvt.TabIndex = 1;
            this.txt_dvt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 304);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Hình ảnh";
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(592, 232);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.TabIndex = 2;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(716, 232);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 2;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(839, 232);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.TabIndex = 2;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            // 
            // dtv_ttsanpham
            
            // 
            // frm_sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1128, 645);
           
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.txt_mncc);
            this.Controls.Add(this.txt_slt);
            this.Controls.Add(this.txt_tsp);
            this.Controls.Add(this.txt_gb);
            this.Controls.Add(this.txt_gn);
            this.Controls.Add(this.txt_dvt);
            this.Controls.Add(this.txt_mn);
            this.Controls.Add(this.txt_msp);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.l);
            this.Name = "frm_sanpham";
            this.Text = "`";
            this.Load += new System.EventHandler(this.frm_sanpham_Load);
           // ((System.ComponentModel.ISupportInitialize)(this.dtv_sanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.TextBox txt_msp;
        private System.Windows.Forms.TextBox txt_mn;
        private System.Windows.Forms.TextBox txt_tsp;
        private System.Windows.Forms.TextBox txt_gb;
        private System.Windows.Forms.TextBox txt_mncc;
        private System.Windows.Forms.TextBox txt_gn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_slt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_dvt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
       
    }
}