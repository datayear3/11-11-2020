using QLBH_LinhKienPC.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_LinhKienPC.GUI.BANHANG
{
    public partial class frm_hoadon : Form
    {
        Lopdungchung lopchung = new Lopdungchung();
        DataTable dthd;
        SqlConnection con;
        SqlCommand comm;

        BLL.BLL_khachhang bllkh;
        BLL.BLL_nhanvien bllnv;
        BLL.BLL_sanpham bllsp;
        BLL.BLL_hoadon bllhd;

        public frm_hoadon()
        {
            InitializeComponent();
            bllkh = new BLL.BLL_khachhang(this);
            bllnv = new BLL.BLL_nhanvien(this);
            bllsp = new BLL.BLL_sanpham(this);
            bllhd = new BLL.BLL_hoadon(this);
        }

        /*private void frm_hoadon_Load(object sender, EventArgs e)
        {
            bllkh.loadkh();
            bllnv.loadNV();
            bllsp.loadsp();
            bllhd.loadhd();
        }

        private void btn_hienthihd_Click(object sender, EventArgs e)
        {
            bllhd.loadhd();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bllhd.themhd();
            bllhd.loadhd();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            bllhd.suahd();
            bllhd.loadhd();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllhd.xoahd();
                bllhd.loadhd();
            }
        }
        */
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_manv_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = lopchung.connection();
            con.Open();
            comm = new SqlCommand("select * from NHAN_VIEN where MaNV = '" + cb_manv.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tennv.Text = reader.GetString(1).ToString();
            }
        }

        private void cb_makh_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = lopchung.connection();
            con.Open();
            comm = new SqlCommand("select * from KHACH_HANG where MaKH = '" + cb_makh.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tenkh.Text = reader.GetString(1).ToString();
                txt_diachi.Text = reader.GetString(4).ToString();
                txt_dienthoai.Text = reader.GetString(5).ToString();
            }
        }

        private void cb_mahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = lopchung.connection();
            con.Open();
            comm = new SqlCommand("select * from SAN_PHAM where MaSP = '" + cb_masp.SelectedValue.ToString() + "'", con);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txt_tensp.Text = reader.GetString(2).ToString();
                txt_dongia.Text = reader.GetInt32(5).ToString();
            }
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            double sl, gn, tt;
            if (txt_dongia.Text == "")
                gn = 0;
            else
                gn = Convert.ToDouble(txt_dongia.Text);
            if (txt_soluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txt_soluong.Text);
            tt = gn * sl;
         //   txt_tongtienban.Text = tt.ToString();
        }

        /*private void dtv_hd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahd.Text = dtv_hd.CurrentRow.Cells["MaHD"].Value.ToString();
            cb_manv.Text = dtv_hd.CurrentRow.Cells["MaNV"].Value.ToString();
            dt_ngayban.Value = Convert.ToDateTime(dtv_hd.CurrentRow.Cells["NgayBan"].Value);
            cb_makh.Text = dtv_hd.CurrentRow.Cells["MaKH"].Value.ToString();
            cb_masp.Text = dtv_hd.CurrentRow.Cells["MaSP"].Value.ToString();
            txt_soluong.Text = dtv_hd.CurrentRow.Cells["SLB"].Value.ToString();
            txt_dongia.Text = dtv_hd.CurrentRow.Cells["DGB"].Value.ToString();
            txt_tongtienban.Text = dtv_hd.CurrentRow.Cells["TongTienBan"].Value.ToString();
        }
        */
        private void btn_timkiemnv_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cb_manv.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from HOA_DON_BAN WHERE 1=1";

            if (cb_manv.Text != "")
                sql += " AND MaNV LIKE N'%" + cb_manv.SelectedValue + "%'";
            dthd = lopchung.LoadDuLieu(sql);
            if (dthd.Rows.Count == 0)
                MessageBox.Show("Không có nhân viên thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dthd.Rows.Count + " nhân viên thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtv_hd.DataSource = dthd;
        }

        private void btn_timkiemkh_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cb_makh.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from HOA_DON_BANS WHERE 1=1";

            if (cb_makh.Text != "")
                sql += " AND MaKH LIKE N'%" + cb_makh.SelectedValue + "%'";
            dthd = lopchung.LoadDuLieu(sql);
            if (dthd.Rows.Count == 0)
                MessageBox.Show("Không có khách hàng thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + dthd.Rows.Count + " khách thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtv_hd.DataSource = dthd;
        }

        private void btn_tinhtong_Click(object sender, EventArgs e)
        {
            int sc = dtv_hd.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dtv_hd.Rows[i].Cells["TongTienBan"].Value.ToString());
            txt_tongtien.Text = thanhtien.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dt_ngayban_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_tenkh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tennv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_dienthoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mahd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtv_hd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_thanhtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_dongia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tenhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void VNĐ_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void dtv_hd_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_mahd.Text = dtv_hd.Rows[numrow].Cells[0].Value.ToString();
            cb_manv.Text = dtv_hd.CurrentRow.Cells["MaNV"].Value.ToString();
            dt_ngayban.Value = Convert.ToDateTime(dtv_hd.CurrentRow.Cells["NgayBan"].Value);
            cb_makh.Text = dtv_hd.CurrentRow.Cells["MaKH"].Value.ToString();
            cb_masp.Text = dtv_hd.CurrentRow.Cells["MaSP"].Value.ToString();
            txt_soluong.Text = dtv_hd.CurrentRow.Cells["SLB"].Value.ToString();
            txt_dongia.Text = dtv_hd.CurrentRow.Cells["DGB"].Value.ToString();
            txt_tongtienban.Text = dtv_hd.CurrentRow.Cells["TongTienBan"].Value.ToString();
        }
    }
}
