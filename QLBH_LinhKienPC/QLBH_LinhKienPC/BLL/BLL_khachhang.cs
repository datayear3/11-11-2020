using QLBH_LinhKienPC;
using QLBH_LinhKienPC.GUI.BANHANG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_LinhKienPC.BLL
{
    class BLL_khachhang
    {
        DAL.DAL_khachhang dal_khachhang = new DAL.DAL_khachhang();
        frm_khachhang frm_khachhang;
        
        public BLL_khachhang(frm_khachhang f)
        {
            frm_khachhang = f;
        }
        public void Luukh()
        {
            //frm_khachhang
            string gt = "";
            if(frm_khachhang.rbt_nam.Checked == true)
            {
                gt = "Nam";
            }
            if (frm_khachhang.rbt_nu.Checked == true)
            {
                gt = "Nu";
            }
            int ketqua = dal_khachhang.ThemKH(frm_khachhang.txt_makh.Text.ToString(), frm_khachhang.txt_tenkh.Text.ToString(), frm_khachhang.txt_diachi.Text.ToString(), frm_khachhang.txt_sdt.Text.ToString(),gt);
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bai");
        }
        public void suakh()
        {
            string gt = "";
            if (frm_khachhang.rbt_nam.Checked == true)
            {
                gt = "Nam";
            }
            if (frm_khachhang.rbt_nu.Checked == true)
            {
                gt = "Nu";
            }
            int ketqua = dal_khachhang.Suakh(frm_khachhang.txt_makh.Text, frm_khachhang.txt_tenkh.Text,frm_khachhang.txt_diachi.Text, frm_khachhang.txt_sdt.Text,gt);
            if (ketqua >= 1)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bai");
        }
        
        public void xoakh()
        {
            int ketqua = dal_khachhang.Xoakh(frm_khachhang.txt_makh.Text);
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bai");
        }
        
        public void loadkh()
        {
            //frm_khachhang.dtv_khachhang.DataSource = dal_khachhang.Loadkh();
        }

        /*
        public void LayDSNCC()
        {
            frm_hoadon.cb_makh.DataSource = dal_khachhang.Loadkh();
            frm_hoadon.cb_makh.DisplayMember = "MaKH";
            frm_hoadon.cb_makh.ValueMember = "MaKH";
        }
        
        */
    }
}
