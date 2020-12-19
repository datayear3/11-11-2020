using QLBH_LinhKienPC;
using QLBH_LinhKienPC.GUI.KHOHANG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_LinhKienPC.BLL
{
    class BLL_phieunhap
    {
        DAL.DAL_phieunhap dal_phieunhap = new DAL.DAL_phieunhap();
        frm_phieunhap frm_pn;
        //frm_sanpham frm_sp;
       // GUI.KHOHANG.frm_phieunhap frm_pn;



        public BLL_phieunhap(frm_phieunhap f)
        {
            frm_pn = f;
        }
        public void loadPN()
        {
            // frm_nhomsanpham.dat = dal_chucvu.LoadCV();
            frm_pn.dvt_pn.DataSource = dal_phieunhap.LoadPN();

        }
        public void LuuPN()
        {
            // [MaPN],[TenNCC],[TenSP],[NgayNhap],[SLN],[DONGIA],[TongTienNhap]
            int ketqua = dal_phieunhap.ThemPN(frm_pn.txt_mpn.Text, frm_pn.txt_tncc.Text, frm_pn.cb_tsp.SelectedValue.ToString(), frm_pn.date_n.Value.ToString(), frm_pn.num_sln.Value.ToString(), frm_pn.txt_gn.Text, frm_pn.txt_ttn.Text);

            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bai");


        }
        public void XoaPN()
        {
            int ketqua = dal_phieunhap.XoaPN(frm_pn.txt_mpn.Text);
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bai");

        }

        public void SuaPN()
        {

            int ketqua = dal_phieunhap.SuaPN(frm_pn.txt_mpn.Text.ToString(),frm_pn.txt_tncc.Text.ToString(),frm_pn.cb_tsp.SelectedValue.ToString(), frm_pn.num_sln.Value.ToString(), frm_pn.txt_gn.Text, frm_pn.txt_ttn.Text);
            if (ketqua >= 1)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bai");
        }



    }
}
