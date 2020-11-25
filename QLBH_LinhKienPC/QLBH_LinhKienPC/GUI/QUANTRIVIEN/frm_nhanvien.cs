using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLBH_LinhKienPC.GUI.QUANTRIVIEN
{
    public partial class frm_nhanvien : Form
    {
        BLL.BLL_nhanvien bllnv;
        BLL.BLL_chucvu bllcv;
        public frm_nhanvien()
        {
            InitializeComponent();
            bllnv = new BLL.BLL_nhanvien(this);
            bllcv = new BLL.BLL_chucvu(this);
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_nhanvien_Load(object sender, EventArgs e)
        {
            bllcv.LayDSCV();
            bllnv.loadNV();
        }

        private void rbt_nu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            bllnv.LuuNV();
            bllnv.loadNV();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {

        }

        private void dtv_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                int numrow;
                numrow = e.RowIndex;
                txt_manv.Text = dtv_nhanvien.Rows[numrow].Cells[0].Value.ToString();
                txt_tennv.Text = dtv_nhanvien.Rows[numrow].Cells[2].Value.ToString();
                txt_diachi.Text = dtv_nhanvien.Rows[numrow].Cells[3].Value.ToString();
                txt_sdt.Text = dtv_nhanvien.Rows[numrow].Cells[4].Value.ToString();
                cb_chucvu.Text = dtv_nhanvien.CurrentRow.Cells["MaCV"].Value.ToString();
                txt_mk.Text = dtv_nhanvien.CurrentRow.Cells["MatKhau"].Value.ToString();
                dt_ns.Value = Convert.ToDateTime(dtv_nhanvien.CurrentRow.Cells["NgaySinh"].Value);
                if (dtv_nhanvien.Rows[numrow].Cells[5].Value.ToString() == "Nam")
                {
                    rbt_nam.Checked = true;
                    rbt_nu.Checked = false;
                }
                else
                {
                    rbt_nam.Checked = false;
                    rbt_nu.Checked = true;
                }
            
            


        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            bllnv.xoaNV();
            bllnv.loadNV();
        }
    }
}
