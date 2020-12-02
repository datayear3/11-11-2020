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
    class BLL_nhomsanpham
    {
        DAL.DAL_nhomsanpham dal_nhomsanpham = new DAL.DAL_nhomsanpham();
        frm_nhomsanpham frm_nsp;
        public BLL_nhomsanpham(frm_nhomsanpham f)
        {
            frm_nsp = f;
        }
        public void LuuSP()
        {
            
            int ketqua = dal_nhomsanpham.ThemSP(frm_nsp.txt_mn.Text,frm_nsp.txt_tn.Text);
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bai");
        }

        public void loadSP()
        {
           // frm_nhomsanpham.dtv_nhomsanpham.DataSource = dal_nhomsanpham.LoadSP();
        }



    }
}
