using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH_LinhKienPC.DAL;
using System.Data.SqlClient;

namespace QLBH_LinhKienPC.GUI.THONGKE
{
    public partial class thongke : UserControl
    {
        public thongke()
        {
            InitializeComponent();
        }

        private void bt_tk_Click(object sender, EventArgs e)
        {
            Lopdungchung lopchung = new Lopdungchung();
            lopchung.connection().Open();
            string sql = "SELECT dbo.PHIEU_NHAP.MaPN, dbo.SAN_PHAM.TenSP, dbo.PHIEU_NHAP.NgayNhap, dbo.PHIEU_NHAP.SLN, dbo.PHIEU_NHAP.DONGIA, dbo.NHA_CUNG_CAP.TenNCC, dbo.PHIEU_NHAP.TongTienNhap FROM dbo.NHA_CUNG_CAP INNER JOIN dbo.PHIEU_NHAP ON dbo.NHA_CUNG_CAP.MaNCC = dbo.PHIEU_NHAP.MaNCC INNER JOIN dbo.SAN_PHAM ON dbo.NHA_CUNG_CAP.MaNCC = dbo.SAN_PHAM.MaNCC AND dbo.PHIEU_NHAP.MaSP = dbo.SAN_PHAM.MaSP WHERE 1 =1";
            if ((dt_timetruoc.Text != "") && (dt_timesau.Text != ""))
            {
                sql = sql + " AND NgayNhap >= '" + dt_timetruoc.Text + "' AND NgayNhap <= '" + dt_timesau.Text + "'";
            }
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, lopchung.connection());
            da.Fill(ds);
            lopchung.connection().Close();
            dvt_tknh.DataSource = ds.Tables[0];
            dvt_tknh.Refresh();

        }

        private void bt_tongtien_Click(object sender, EventArgs e)
        {
            int sc = dvt_tknh.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < sc - 1; i++)
                thanhtien += float.Parse(dvt_tknh.Rows[i].Cells["TongTienNhap"].Value.ToString());
            txt_tt.Text = thanhtien.ToString()+".đ";
        }

        private void cr_phieunhap_Click(object sender, EventArgs e)
        {
            frm_baocao_phieunhap pn = new frm_baocao_phieunhap();
            pn.ShowDialog();
        }

        private void bt_cttpn_Click(object sender, EventArgs e)
        {
            cr_tungphieunhap ctpn = new cr_tungphieunhap();
            ctpn.mpn.Text = mpn;
            ctpn.ShowDialog();
        }

        private void dvt_tknh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static string mpn = "";
        private void dvt_tknh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            mpn = dvt_tknh.Rows[numrow].Cells[0].Value.ToString();
        }

        private void thongke_Load(object sender, EventArgs e)
        {
            Lopdungchung lopchung = new Lopdungchung();
            lopchung.connection().Open();
            string sql = "SELECT dbo.PHIEU_NHAP.MaPN, dbo.SAN_PHAM.TenSP, dbo.PHIEU_NHAP.NgayNhap, dbo.PHIEU_NHAP.SLN , dbo.PHIEU_NHAP.DONGIA, dbo.NHA_CUNG_CAP.TenNCC, dbo.PHIEU_NHAP.TongTienNhap FROM dbo.NHA_CUNG_CAP INNER JOIN dbo.PHIEU_NHAP ON dbo.NHA_CUNG_CAP.MaNCC = dbo.PHIEU_NHAP.MaNCC INNER JOIN dbo.SAN_PHAM ON dbo.NHA_CUNG_CAP.MaNCC = dbo.SAN_PHAM.MaNCC AND dbo.PHIEU_NHAP.MaSP = dbo.SAN_PHAM.MaSP ";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, lopchung.connection());
            da.Fill(ds);
            lopchung.connection().Close();
            dvt_tknh.DataSource = ds.Tables[0];
            dvt_tknh.Refresh();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
