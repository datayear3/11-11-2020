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
    public partial class frm_nhacungcap : Form
    {
        BLL.BLL_nhacungcap bllncc;
        public frm_nhacungcap()
        {
            InitializeComponent();
            bllncc = new BLL.BLL_nhacungcap(this);
        }

        private void frm_nhacungcap_Load(object sender, EventArgs e)
        {
            bllncc.loadNCC();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            bllncc.LuuNCC();
            bllncc.loadNCC();

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Thông tin sẽ bị thay đổi. Bạn có muốn tiếp tục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllncc.suaNCC();
                bllncc.loadNCC();
            }
        }

        private void dvt_ncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_mncc.Text = dvt_ncc.Rows[numrow].Cells[0].Value.ToString();
            txt_tncc.Text = dvt_ncc.Rows[numrow].Cells[1].Value.ToString();
            txt_sdt.Text = dvt_ncc.Rows[numrow].Cells[2].Value.ToString();
            txt_dc.Text = dvt_ncc.Rows[numrow].Cells[3].Value.ToString();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllncc.xoaNCC();
                bllncc.loadNCC();
            }
        }
    }
}
