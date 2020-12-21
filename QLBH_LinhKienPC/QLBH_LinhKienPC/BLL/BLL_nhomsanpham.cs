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
        frm_sanpham frm_sp;

        public BLL_nhomsanpham(frm_nhomsanpham f)
        {
            frm_nsp = f;
        }
        public BLL_nhomsanpham(frm_sanpham f)
        {
            frm_sp = f;
        }
        public void LuuSP()
        {
            
            

            try
            {

                int ketqua = dal_nhomsanpham.ThemSP(frm_nsp.txt_mn.Text, frm_nsp.txt_tn.Text);
                if (ketqua >= 1)
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bai");

            }
            catch (Exception)
            {

                MessageBox.Show("Thêm dữ liệu không thành công !!!");
            }
        }

        public void loadSP()
        {
            // frm_nhomsanpham.dat = dal_chucvu.LoadCV();
            frm_nsp.dtv_nsp.DataSource = dal_nhomsanpham.LoadSP();

        }
        public void suaSP()
        {

            int ketqua = dal_nhomsanpham.SuaSP(frm_nsp.txt_mn.Text.ToString(), frm_nsp.txt_tn.Text.ToString());
            if (ketqua >= 1)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bai");
        }

        public void xoaSP()
        {
            int ketqua = dal_nhomsanpham.XoaSP(frm_nsp.txt_mn.Text.ToString());
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bai");
        }


        public void LayDSNhomSP()
        {
            frm_sp.cb_tn.DataSource = dal_nhomsanpham.LoadTenNhom();
            frm_sp.cb_tn.DisplayMember = "TenNhom";
            frm_sp.cb_tn.ValueMember = "TenNhom";
        }

    }
}
