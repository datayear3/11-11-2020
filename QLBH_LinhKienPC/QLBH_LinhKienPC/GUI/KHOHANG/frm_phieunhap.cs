using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_LinhKienPC.GUI.KHOHANG
{
    public partial class frm_phieunhap : Form
    {
        BLL.BLL_phieunhap bllpn;
        BLL.BLL_sanpham bllsp;
        public frm_phieunhap()
        {
            InitializeComponent();
            bllpn = new BLL.BLL_phieunhap(this);
            bllsp = new BLL.BLL_sanpham(this);
        }

        private void frm_phieunhap_Load(object sender, EventArgs e)
        {
            bllsp.LayDSSP();
            bllpn.loadPN();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        long dg = 0;
        private void cb_tsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAL.Lopdungchung lopchung = new DAL.Lopdungchung();
            
            string select_show = "select GiaNhap from SAN_PHAM where TenSP = '" + cb_tsp.Text.ToString() +"'";
            DataTable gn = lopchung.LoadDuLieu(select_show);
            if (gn != null)
            {
                foreach (DataRow dr in gn.Rows)
                {

                    txt_gn.Text = dr["GiaNhap"].ToString();
                    dg = Convert.ToInt32(dr["GiaNhap"].ToString());
                }
            }
            string select_ncc = "select TenNCC from NHA_CUNG_CAP,SAN_PHAM where SAN_PHAM.MaNCC = NHA_CUNG_CAP.MaNCC and  TenSP = '" + cb_tsp.Text.ToString() + "'";
            DataTable ncc = lopchung.LoadDuLieu(select_ncc);
            if (ncc != null)
            {
                foreach (DataRow dr in ncc.Rows)
                {

                    txt_tncc.Text = dr["TenNCC"].ToString();

                }
            }

            long sl = Convert.ToInt32(num_sln.Value);
           

            float sum = sl * dg;

            txt_ttn.Text = sum + "";

        }

        private void num_sln_ValueChanged(object sender, EventArgs e)
        {
            long sl = Convert.ToInt32(num_sln.Value);

            float sum = sl * dg;
            txt_ttn.Text = sum + "";
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            bllpn.LuuPN();
            bllpn.loadPN();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            bllpn.XoaPN();
            bllpn.loadPN();
        }

        private void dvt_pn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_mpn.Text = dvt_pn.Rows[numrow].Cells[0].Value.ToString();
            txt_tncc.Text = dvt_pn.Rows[numrow].Cells[1].Value.ToString();
            cb_tsp.Text = dvt_pn.Rows[numrow].Cells[2].Value.ToString();
            date_n.Text = dvt_pn.Rows[numrow].Cells[3].Value.ToString();
            num_sln.Value = Convert.ToInt32(dvt_pn.Rows[numrow].Cells[4].Value.ToString());
            txt_gn.Text = dvt_pn.Rows[numrow].Cells[5].Value.ToString();
            txt_ttn.Text = dvt_pn.Rows[numrow].Cells[6].Value.ToString();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            bllpn.SuaPN();
            bllpn.loadPN();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_mpn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_gn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tncc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ttn_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
