using QLBH_LinhKienPC.GUI.BANHANG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using QLBH_LinhKienPC.GUI.QUANTRIVIEN;

namespace QLBH_LinhKienPC.BLL
{
    class BLL_hoadon
    {
        DAL.DAL_hoadon dal_hoadon = new DAL.DAL_hoadon();
        GUI.BANHANG.frm_khachhang frm_khachhang;
        GUI.QUANTRIVIEN.frm_nhanvien frm_nv;
        GUI.KHOHANG.frm_sanpham frm_sanpham;
        private frm_hoadonban frm_hoadonban;
        public BLL_hoadon(GUI.QUANTRIVIEN.frm_nhanvien f)
        {
            frm_nv = f;
        }
        public BLL_hoadon(GUI.BANHANG.frm_khachhang f)
        {
            frm_khachhang = f;
        }
        public BLL_hoadon(GUI.KHOHANG.frm_sanpham f)
        {
            frm_sanpham = f;
        }

        public BLL_hoadon(frm_hoadonban frm_hoadonban)
        {
            this.frm_hoadonban = frm_hoadonban;
        }

        public void xoaNV()
        {
           /*
            int ketqua = dal_hoadon.XoaNV(frm_hoadon.txt_mahd.Text);
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bai");

            */
        }
    }
}
