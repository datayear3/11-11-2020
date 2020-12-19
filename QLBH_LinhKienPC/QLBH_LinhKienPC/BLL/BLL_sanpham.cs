using QLBH_LinhKienPC;
using QLBH_LinhKienPC.GUI.KHOHANG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

using QLBH_LinhKienPC.GUI.BANHANG;


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



            // SAN PHAM ( MASP,MANHOM,TENSP,DVT,SLTON,GB,GN,MANCC,...,....)
            int ketqua = dal_sanpham.ThemSP(frm_sp.txt_msp.Text, frm_sp.cb_tn.SelectedValue.ToString(), frm_sp.txt_tsp.Text.ToString(), frm_sp.cb_dvt.Text, frm_sp.txt_slt.Text, frm_sp.txt_gb.Text,frm_sp.txt_gn.Text,frm_sp.cb_tncc.SelectedValue.ToString());

            if (ketqua >= 1)
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bai");

            
         }
        
        public void SuaSP()
        {

                int ketqua = dal_sanpham.SuaSP(frm_sp.txt_msp.Text, frm_sp.cb_tn.SelectedValue.ToString(), frm_sp.txt_tsp.Text.ToString(), frm_sp.cb_dvt.Text, frm_sp.txt_slt.Text, frm_sp.txt_gb.Text, frm_sp.txt_gn.Text, frm_sp.cb_tncc.SelectedValue.ToString());
                if (ketqua >= 1)
                    MessageBox.Show("Sửa thành công");
                else
                    MessageBox.Show("Sửa thất bai");
         }


         
        
        public void loadsp()
        {
            frm_sp.dtv_sp.DataSource = dal_sanpham.Loadsp();
            
            
            frm_sp.cb_dvt.Items.Clear();
            frm_sp.cb_dvt.Items.Add("Cái");
            frm_sp.cb_dvt.Items.Add("Con");


            frm_sp.cb_dvt.SelectedIndex = 0;
            

        }
        public void XoaSP()
        {
            int ketqua = dal_sanpham.XoaSP(frm_sp.txt_msp.Text);
            if (ketqua >= 1)
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bai");
           
        }

    }
}
