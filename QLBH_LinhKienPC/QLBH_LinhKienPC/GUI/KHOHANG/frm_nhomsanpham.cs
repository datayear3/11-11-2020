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
    public partial class frm_nhomsanpham : Form
    {
        BLL.BLL_nhomsanpham bllnsp;
        //internal static object dtv_nhomsanpham;

        public frm_nhomsanpham()
        {
            InitializeComponent();
            bllnsp = new BLL.BLL_nhomsanpham(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bllnsp.loadSP();
        }

        private void bt_themsp_Click(object sender, EventArgs e)
        {
            bllnsp.LuuSP();
            bllnsp.loadSP();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Thông tin sẽ bị thay đổi. Bạn có muốn tiếp tục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllnsp.suaSP();
                bllnsp.loadSP();
            }
        }

        private void dtv_nsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_mn.Text = dtv_nsp.Rows[numrow].Cells[0].Value.ToString();
            txt_tn.Text = dtv_nsp.Rows[numrow].Cells[1].Value.ToString();

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllnsp.xoaSP();
                bllnsp.loadSP();
            }
        }

        private void frm_nhomsanpham_Load(object sender, EventArgs e)
        {

        }
    }
}
