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


namespace QLBH_LinhKienPC.GUI.KHOHANG
{
    public partial class frm_sanpham : Form
    {
       // internal static object txt_tenkh;
       // internal object dtv_banhang;
       // internal object cb_masanpham;
        BLL.BLL_sanpham bllsp;
        BLL.BLL_nhomsanpham bllnsp;
        BLL.BLL_nhacungcap bllncc;
       // internal static object dtv_sanpham;

        public frm_sanpham()
        {
            InitializeComponent();
            bllnsp = new BLL.BLL_nhomsanpham(this);
            bllsp = new BLL.BLL_sanpham(this);
            bllncc = new BLL.BLL_nhacungcap(this);

        }

        private void frm_sanpham_Load(object sender, EventArgs e)
        {
            bllnsp.LayDSNhomSP();
            bllncc.LayDSNCC();
            bllsp.loadsp();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_msp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_dvt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            bllsp.LuuSP();
            bllsp.loadsp();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Thông tin sẽ bị thay đổi. Bạn có muốn tiếp tục ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllsp.SuaSP();
                bllsp.loadsp();
            }
        }

        private void dtv_sp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllsp.XoaSP();
                bllsp.loadsp();
            }
        }

        private void dtv_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_msp.Text = dtv_sp.Rows[numrow].Cells[0].Value.ToString();
            cb_tn.Text = dtv_sp.Rows[numrow].Cells[1].Value.ToString();
            txt_tsp.Text = dtv_sp.Rows[numrow].Cells[2].Value.ToString();
            cb_dvt.Text = dtv_sp.Rows[numrow].Cells[3].Value.ToString();
            txt_slt.Text = dtv_sp.Rows[numrow].Cells[4].Value.ToString();
            txt_gb.Text = dtv_sp.Rows[numrow].Cells[5].Value.ToString();
            txt_gn.Text = dtv_sp.Rows[numrow].Cells[6].Value.ToString();
            cb_tncc.Text = dtv_sp.Rows[numrow].Cells[7].Value.ToString();
        }
    }
}
