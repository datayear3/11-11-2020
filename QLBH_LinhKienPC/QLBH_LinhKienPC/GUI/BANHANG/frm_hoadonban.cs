using QLBH_LinhKienPC.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBH_LinhKienPC.GUI.BANHANG
{
    public partial class frm_hoadonban : Form
    {
        BLL.BLL_nhanvien bllnv;
        BLL.BLL_khachhang bllkh;
        BLL.BLL_hoadon bllhd;
        BLL.BLL_sanpham bllsp;
        

        private void frm_hoadonban_Load(object sender, EventArgs e)
        {

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_makhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
