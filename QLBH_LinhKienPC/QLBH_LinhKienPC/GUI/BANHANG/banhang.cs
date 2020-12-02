using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLBH_LinhKienPC.GUI.BANHANG
{
    public partial class banhang : UserControl
    {
        public banhang()
        {
            InitializeComponent();
        }

        private void bt_them_khachhang_Click(object sender, EventArgs e)
        {
            frm_khachhang kh = new frm_khachhang();
            kh.ShowDialog();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_hoadonban hdb = new frm_hoadonban();
            hdb.ShowDialog();
        }
    }
}
