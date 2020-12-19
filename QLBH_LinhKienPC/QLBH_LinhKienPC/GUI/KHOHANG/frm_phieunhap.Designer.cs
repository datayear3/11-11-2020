
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
            this.txt_pn = new System.Windows.Forms.TextBox();
            this.txt_mncc = new System.Windows.Forms.TextBox();
            this.txt_nn = new System.Windows.Forms.TextBox();
            this.txt_ttn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dvt_pn = new System.Windows.Forms.DataGridView();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvt_pn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 184);
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
            this.label4.Location = new System.Drawing.Point(587, 127);
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
            this.label5.Location = new System.Drawing.Point(587, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền nhập:";
            // 
            // txt_pn
            // 
            this.txt_pn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pn.Location = new System.Drawing.Point(326, 127);
            this.txt_pn.Name = "txt_pn";
            this.txt_pn.Size = new System.Drawing.Size(156, 26);
            this.txt_pn.TabIndex = 1;
            // 
            // txt_mncc
            // 
            this.txt_mncc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mncc.Location = new System.Drawing.Point(326, 180);
            this.txt_mncc.Name = "txt_mncc";
            this.txt_mncc.Size = new System.Drawing.Size(156, 26);
            this.txt_mncc.TabIndex = 1;
            // 
            // txt_nn
            // 
            this.txt_nn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nn.Location = new System.Drawing.Point(706, 125);
            this.txt_nn.Name = "txt_nn";
            this.txt_nn.Size = new System.Drawing.Size(156, 26);
            this.txt_nn.TabIndex = 1;
            // 
            // txt_ttn
            // 
            this.txt_ttn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ttn.Location = new System.Drawing.Point(706, 184);
            this.txt_ttn.Name = "txt_ttn";
            this.txt_ttn.Size = new System.Drawing.Size(156, 26);
            this.txt_ttn.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(422, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "PHIẾU NHẬP";
            // 
            // dvt_pn
            // 
            this.dvt_pn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvt_pn.Location = new System.Drawing.Point(187, 325);
            this.dvt_pn.Name = "dvt_pn";
            this.dvt_pn.Size = new System.Drawing.Size(689, 166);
            this.dvt_pn.TabIndex = 2;
            this.dvt_pn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(576, 254);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(79, 36);
            this.bt_them.TabIndex = 3;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(774, 254);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(79, 36);
            this.bt_sua.TabIndex = 3;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(676, 254);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(79, 36);
            this.bt_xoa.TabIndex = 3;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            // 
            // frm_phieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 606);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.dvt_pn);
            this.Controls.Add(this.txt_mncc);
            this.Controls.Add(this.txt_ttn);
            this.Controls.Add(this.txt_nn);
            this.Controls.Add(this.txt_pn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "frm_phieunhap";
            this.Text = "frm_phieunhap";
            this.Load += new System.EventHandler(this.frm_phieunhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvt_pn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_pn;
        public System.Windows.Forms.TextBox txt_mncc;
        public System.Windows.Forms.TextBox txt_nn;
        public System.Windows.Forms.TextBox txt_ttn;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dvt_pn;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
    }
}