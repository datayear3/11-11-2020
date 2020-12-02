using QLBH_LinhKienPC;
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

namespace QLBH_LinhKienPC.BLL
{
    class BLL_chucvu
    {
        DAL.DAL_chucvu dal_chucvu = new DAL.DAL_chucvu();
        GUI.QUANTRIVIEN.frm_chucvu frm_chucvu;
        GUI.QUANTRIVIEN.frm_nhanvien frm_nv;

        
        public BLL_chucvu(GUI.QUANTRIVIEN.frm_chucvu f)
        {
            frm_chucvu = f;
        }
        public BLL_chucvu(GUI.QUANTRIVIEN.frm_nhanvien f)
        {
            frm_nv = f;
        }
        public void LuuCV()
        {
            string q = "";
            int tamp = frm_chucvu.cb_cv.SelectedIndex;
            if(tamp == 0)
            {
                q = "ADMIN";
            }
            else if(tamp == 1)
            {
                q = "KHO";
            }
            else
            {
                q = "NV";
            }
            int ketqua = dal_chucvu.ThemCV(frm_chucvu.txt_mcv.Text.ToString(), frm_chucvu.txt_tencv.Text.ToString(),q);
            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bai");
        }
        
        public void suaCV()
        {
            string q = "";
            int tamp = frm_chucvu.cb_cv.SelectedIndex;
            if (tamp == 0)
            {
                q = "ADMIN";
            }
            else if (tamp == 1)
            {
                q = "KHO";
            }
            else
            {
                q = "NV";
            }

            int ketqua = dal_chucvu.SuaCV(frm_chucvu.txt_mcv.Text.ToString(), frm_chucvu.txt_tencv.Text.ToString(), q);
            if (ketqua >= 1)
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bai");
        }

        public void xoaCV()
        {
            int ketqua = dal_chucvu.XoaCV(frm_chucvu.txt_mcv.Text.ToString());
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bai");
        }
    
        public void loadCV()
        {
            frm_chucvu.dtv_chucvu.DataSource = dal_chucvu.LoadCV();
            DataTable cb_quyen = dal_chucvu.LoadCV_cb();
            frm_chucvu.cb_cv.Items.Clear();
            if (cb_quyen != null)
            {
                foreach (DataRow dr in cb_quyen.Rows)
                {
                    
                    frm_chucvu.cb_cv.Items.Add(dr["Quyen"].ToString());

                }
            }
            frm_chucvu.cb_cv.SelectedIndex = 0;
        }

        
        public void LayDSCV()
        {
            frm_nv.cb_chucvu.DataSource = dal_chucvu.LoadCV();
            frm_nv.cb_chucvu.DisplayMember = "MaCV";
            frm_nv.cb_chucvu.ValueMember = "MaCV";
        }
        
        
    }
}
