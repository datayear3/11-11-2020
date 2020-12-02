using System;
using System.Collections.Generic;
using QLBH_LinhKienPC.GUI.KHOHANG;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_LinhKienPC.BLL
{
    class BLL_sanpham
    {

        DAL.DAL_sanpham dal_sanpham = new DAL.DAL_sanpham();
        frm_sanpham frm_sp;
        public BLL_sanpham(frm_sanpham f)
        {
            frm_sp = f;
        }
        public void LuuSP()
        {
            /*
            int ketqua = dal_sanpham.ThemSP(frm_sanpham.txt_masp.Text.ToString(), frm_sanpham.txt_tenkh.Text.ToString(), frm_khachhang.txt_diachi.Text.ToString(), frm_khachhang.txt_sdt.Text.ToString(), gt);
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bai");

            */
        }

    }
}
