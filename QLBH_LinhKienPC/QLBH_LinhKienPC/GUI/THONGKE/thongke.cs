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
            string sql = "SELECT * FROM PHIEU_NHAP WHERE 1=1";
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
            string sql = "SELECT * FROM PHIEU_NHAP";

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, lopchung.connection());
            da.Fill(ds);
            lopchung.connection().Close();
            dvt_tknh.DataSource = ds.Tables[0];
            dvt_tknh.Refresh();
        }
    }
}
