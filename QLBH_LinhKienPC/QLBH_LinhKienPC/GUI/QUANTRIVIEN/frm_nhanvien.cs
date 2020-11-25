using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_LinhKienPC.GUI.QUANTRIVIEN
{
    public partial class frm_nhanvien : Form
    {
        BLL.BLL_nhanvien bllnv;
        BLL.BLL_chucvu bllcv;
        public frm_nhanvien()
        {
            InitializeComponent();
            bllnv = new BLL.BLL_nhanvien(this);
            bllcv = new BLL.BLL_chucvu(this);
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            bllcv.LayDSCV();
            bllnv.loadNV();
        }

        private void rbt_nu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            bllnv.LuuNV();
            bllnv.loadNV();
        }
    }
}
