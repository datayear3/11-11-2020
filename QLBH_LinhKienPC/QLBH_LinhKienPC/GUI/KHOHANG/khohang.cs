﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_LinhKienPC.GUI.KHOHANG
{
    public partial class khohang : UserControl
    {
        public khohang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_nhomsanpham nsp = new frm_nhomsanpham();
            nsp.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_sanpham sp = new frm_sanpham();
            sp.ShowDialog();
        }

        private void khohang_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_nhacungcap sp = new frm_nhacungcap();
            sp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_phieunhap sp = new frm_phieunhap();
            sp.ShowDialog();
        }
    }
}
