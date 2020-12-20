using QLBH_LinhKienPC.GUI;
using QLBH_LinhKienPC.GUI.BANHANG;
using QLBH_LinhKienPC.GUI.KHOHANG;
using QLBH_LinhKienPC.GUI.QUANTRIVIEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLBH_LinhKienPC.BLL
{
    class BLL_hoadon
    {
        DAL.DAL_hoadon dal_hoadon = new DAL.DAL_hoadon();
        frm_khachhang frm_kh;
       // frm_nhavien frm_nv;
        frm_hoadon frm_hoadon;
        frm_nhomsanpham frm_nsp;
        private GUI.BANHANG.frm_hoadon frm_hoadon1;

        public BLL_hoadon(frm_khachhang f)
        {
            frm_kh = f;
        }
        public BLL_hoadon(frm_nhomsanpham f)
        {
            frm_nsp = f;
        }
        public BLL_hoadon(frm_nhanvien f)
        {
           // frm_nv = f;
        }

        public BLL_hoadon(GUI.BANHANG.frm_hoadon frm_hoadon1)
        {
            this.frm_hoadon1 = frm_hoadon1;
        }
        public void themhd()
        {
            int ketqua = dal_hoadon.ThemHD(frm_hoadon.txt_mahd.ToString(), frm_hoadon.cb_manv.ToString(), frm_hoadon.cb_makh.ToString(), frm_hoadon.dt_ngayban.ToString(), frm_hoadon.txt_tongtienban.ToString(), frm_hoadon.txt_dongia.ToString(), frm_hoadon.cb_masp.ToString(), frm_hoadon.txt_soluong.ToString());
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bai");

        }
        /*public void loadhd()
        {
            frm_hoadon.dtv_hd.DataSource = dal_hoadon.Loadhd();
        }
        */
    }
}
