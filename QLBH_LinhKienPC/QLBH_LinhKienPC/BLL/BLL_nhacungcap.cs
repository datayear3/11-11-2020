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
    class BLL_nhacungcap
    {
        DAL.DAL_nhacungcap dal_nhacungcap = new DAL.DAL_nhacungcap();
        frm_nhacungcap frm_ncc;
        public BLL_nhacungcap(frm_nhacungcap f)
        {
            frm_ncc = f;
        }
        public void LuuNCC()
        {

           /* int ketqua = dal_nhacungcap.ThemNCC(frm_ncc.txt_mncc.Text, frm_ncc.txt_tncc.Text);
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bai");
           */
        }
        
        public void loadNCC()
        {
            // frm_nhomsanpham.dat = dal_chucvu.LoadCV();
            frm_ncc.dvt_ncc.DataSource = dal_nhacungcap.LoadNCC();

        }
        public void suaNCC()
        {

            int ketqua = dal_nhacungcap.SuaNCC(frm_ncc.txt_mncc.Text.ToString(), frm_ncc.txt_tncc.Text.ToString());
            if (ketqua >= 1)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bai");
        }

        public void xoaNCC()
        {
            int ketqua = dal_nhacungcap.XoaNCC(frm_ncc.txt_mncc.Text.ToString());
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bai");
        }
    }
}
