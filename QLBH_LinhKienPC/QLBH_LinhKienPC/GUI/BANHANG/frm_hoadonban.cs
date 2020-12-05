using QLBH_LinhKienPC.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBH_LinhKienPC.GUI.BANHANG
{
    public partial class frm_hoadonban : Form
    {
        private BLL_sanpham bllsp;
        private BLL_nhanvien bllnv;
        private BLL_khachhang bllkh;

        public frm_hoadonban()
        {
            InitializeComponent();
            bllnv = new BLL.BLL_nhanvien(this);
            bllkh = new BLL.BLL_khachhang(this);
            bllsp = new BLL.BLL_sanpham(this);
        }
        string chuoiketnoi = @"Data Source=mc;Initial Catalog=QuanLyCuaHangBanLe;Integrated Security=True";
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
        string sql;
        private object dtv_hoadon;

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void frm_hoadonban_Load(object sender, EventArgs e)
        { 
               
                bllnv.loadNV();
        }

        private void cb_mahoadon_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void dtv_banhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_makhachhang.Items.Clear();
            cb_manhanvien.Items.Clear();
            cb_masanpham.Items.Clear();
            ketnoi.Open();
            sql = @"select KHACH_HANG.MaKH , NHAN_VIEN.MaNV , SAN_PHAM.MaSP
               FROM HOA_DON Inner Join KHACH_HANG, HOA_DON Inner Join NHAN_VIEN
               ON HOA_DON.MaKH = KHACH_HANG.MaKH , HOA_DON.MaNV = NHAN_VIEN.MaNV
               WHERE (HOA_DON.MaKH = N' " + cb_makhachhang.Text + @" ')";
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            i = 0;
            while (docdulieu.Read())
            {
                cb_manhanvien.Items.Add(docdulieu[1].ToString());
                i++;
            }
            ketnoi.Close();
        }
    }
}
