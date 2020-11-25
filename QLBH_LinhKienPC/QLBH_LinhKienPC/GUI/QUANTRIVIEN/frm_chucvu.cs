using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_LinhKienPC.GUI.QUANTRIVIEN
{
    public partial class frm_chucvu : Form
    {
        BLL.BLL_chucvu bllcv;
        public frm_chucvu()
        {
            InitializeComponent();
            bllcv = new BLL.BLL_chucvu(this);
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            bllcv.LuuCV();
            bllcv.loadCV();
        }

        private void frm_chucvu_Load(object sender, EventArgs e)
        {
            bllcv.loadCV();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Thông tin sẽ bị thay đổi. Bạn có muốn tiếp tục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllcv.suaCV();
                bllcv.loadCV();
            }
        }

        private void dtv_chucvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_mcv.Text = dtv_chucvu.Rows[numrow].Cells[0].Value.ToString();
            txt_tencv.Text = dtv_chucvu.Rows[numrow].Cells[1].Value.ToString();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllcv.xoaCV();
                bllcv.loadCV();
            }
        }
    }
}
