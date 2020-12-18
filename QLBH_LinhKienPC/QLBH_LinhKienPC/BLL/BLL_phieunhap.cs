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
       // GUI.KHOHANG.frm_phieunhap frm_pn;



        public BLL_phieunhap(frm_phieunhap f)
        {
            frm_pn = f;
        }
        public void loadPN()
        {
            // frm_nhomsanpham.dat = dal_chucvu.LoadCV();
            //frm_pn.dvt.pn.DataSource = dal_phieunhap.LoadPN();

        }
    }
}
