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
    class BLL_nhanvien
    {
        DAL.DAL_nhanvien dal_nv = new DAL.DAL_nhanvien();
        GUI.QUANTRIVIEN.frm_nhanvien frm_nv;
        GUI.QUANTRIVIEN.frm_chucvu frm_cv;
       
        public BLL_nhanvien(GUI.QUANTRIVIEN.frm_nhanvien f)
        {
            frm_nv = f;
        }
        public BLL_nhanvien(GUI.QUANTRIVIEN.frm_chucvu f)
        {
            frm_cv = f;
        }


        public void LuuNV()
        {
            string gt = "";
            if (frm_nv.rbt_nam.Checked == true)
            {
                gt = "Nam";
            }
            if (frm_nv.rbt_nu.Checked == true)
            {
                gt = "Nu";
            }

            try
            {
                

                if (frm_nv.txt_manv.Text.ToString() == "")
                {
                    MessageBox.Show("Mã Nhân viên " + " không được bỏ trống !!! ");
                }
                else if(frm_nv.txt_tennv.Text.ToString() == "")
                {
                    MessageBox.Show("Tên nhân viên " + "không được bỏ trống !!! ");
                }
                else if (frm_nv.txt_diachi.Text.ToString()== "")
                {
                    MessageBox.Show("Địa chỉ " + "không được bỏ trống !!! ");
                }
                else if (frm_nv.txt_mk.Text.ToString()=="")
                {
                    MessageBox.Show("Mật khẩu " + "không được bỏ trống !!! ");
                }
                else if (frm_nv.txt_mk.Text.Length < 6)
                {
                    MessageBox.Show("Mật khẩu " + "phải lớn hơn 6 kí tự !!! ");
                }
                else
                {
                    
                    int ketqua = dal_nv.ThemNV(frm_nv.txt_manv.Text.ToString(), frm_nv.txt_tennv.Text.ToString(), frm_nv.txt_diachi.Text.ToString(), frm_nv.txt_sdt.Text.ToString(), gt, frm_nv.cb_ns.Text, frm_nv.txt_mk.Text.ToString(), frm_nv.cb_chucvu.SelectedValue.ToString());
                    if (ketqua >= 1)
                        MessageBox.Show("Thêm thành công");
                    else
                        MessageBox.Show("Thêm thất bai");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Thêm dữ liệu không thành công !!! " + "Mã nhân viên '" + frm_nv.txt_manv.Text.ToString() + "' đã tồn tại !!! ");
            }

        }
        
        public void suaNV()
        {
            string gt ="";
            if (frm_nv.rbt_nam.Checked == true)
            {
                gt = "Nam";
            }
            if (frm_nv.rbt_nu.Checked == true)
            {
                gt = "Nu";
            }
            
            try
            {


                if (frm_nv.txt_manv.Text.ToString() == "")
                {
                    MessageBox.Show("Mã Nhân viên " + " không được bỏ trống !!! ");
                }
                else if (frm_nv.txt_tennv.Text.ToString() == "")
                {
                    MessageBox.Show("Tên nhân viên " + "không được bỏ trống !!! ");
                }
                else if (frm_nv.txt_diachi.Text.ToString() == "")
                {
                    MessageBox.Show("Địa chỉ " + "không được bỏ trống !!! ");
                }
                else if (frm_nv.txt_mk.Text.ToString() == "")
                {
                    MessageBox.Show("Mật khẩu " + "không được bỏ trống !!! ");
                }
                else if (frm_nv.txt_mk.Text.Length < 6)
                {
                    MessageBox.Show("Mật khẩu " + "phải lớn hơn 6 kí tự !!! ");
                }
                else
                {

                    string tencv = frm_nv.cb_chucvu.Text;
                    int ketqua = dal_nv.SuaNV(frm_nv.txt_manv.Text, frm_nv.txt_tennv.Text, frm_nv.txt_diachi.Text, frm_nv.txt_sdt.Text, gt.ToString(), frm_nv.cb_ns.Text, frm_nv.txt_mk.Text, tencv);
                    if (ketqua >= 1)
                        MessageBox.Show("Sửa thành công");
                    else
                        MessageBox.Show("Sửa thất bai");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Sửa dữ liệu không thành công !!! " + "Mã nhân viên '" + frm_nv.txt_manv.Text.ToString() + "' đã tồn tại !!! ");
            }

        }
        
        public void xoaNV()
        {
            
            try
            {


                if (frm_nv.txt_manv.Text.ToString() == "")
                {
                    MessageBox.Show("Mã Nhân viên " + " không được bỏ trống !!! ");
                }
                else
                {
                    int ketqua = dal_nv.XoaNV(frm_nv.txt_manv.Text);
                    if (ketqua >= 1)
                        MessageBox.Show("Xóa thành công");
                    else
                        MessageBox.Show("Xóa thất bai");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Xóa dữ liệu không thành công !!! " + "Mã nhân viên '" + frm_nv.txt_manv.Text.ToString() + "' không tồn tại !!! ");
            }
        }
        
        public void loadNV()
        {
            frm_nv.dtv_nhanvien.DataSource = dal_nv.LoadNV();

            // load combobox nam sinh
            string t = DateTime.Now.ToString("yyyy");
            frm_nv.cb_ns.Items.Clear();
            for (int i = 1990; i < Convert.ToInt32(t); i++)
            {
                frm_nv.cb_ns.Items.Add(i);
            }
            frm_nv.cb_ns.SelectedIndex = 0;



        }
        public void loadNV_Search()
        {

            string tk = frm_nv.txt_tk.Text;


            frm_nv.dtv_nhanvien.DataSource = dal_nv.LoadNV_Search(tk);

 

        }





    }
}
