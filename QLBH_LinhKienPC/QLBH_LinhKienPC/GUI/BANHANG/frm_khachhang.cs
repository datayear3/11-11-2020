using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_LinhKienPC.GUI.BANHANG
{
    public partial class frm_khachhang : Form
    {
        BLL.BLL_khachhang bllkh;
        public frm_khachhang()
        {
            InitializeComponent();
            bllkh = new BLL.BLL_khachhang(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_makh_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bllkh.Luukh();
            bllkh.loadkh();

        }

        private void frm_khachhang_Load(object sender, EventArgs e)
        {
            bllkh.loadkh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
