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
        /*
        public void Luuhd()
        {

            //int ketqua = dal_hoadon.ThemHD(frm_khachhang.cb_makhachhang.Text.ToString(), frm_nhanvien.cb_manhanvien.Text.ToString(),frm_sanpham.cb_masanpham.Text.ToString());
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bai");

        }

        public void suahd()
        {
            //int ketqua = dal_hoadon.SuaHD(frm_khachhang.cb_makhachhang.Text.ToString(), frm_nhanvien.cb_manhanvien.Text.ToString(),frm_sanpham.cb_masanpham.Text.ToString());
            if (ketqua >= 1)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bai");
        }

        public void xoahd()
        {
            int ketqua = dal_hoadon.SuaHD(frm_khachhang.cb_makhachhang.Text.ToString(), frm_nhanvien.cb_manhanvien.Text.ToString(),frm_sanpham.cb_masanpham.Text.ToString());
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bai");
        }
        public void loadHD()
        {
            frm_hoadonban.dtv_banhang.DataSource = dal_hoadon.LoadHD();
        }
        */
    }
}
