using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_LinhKienPC.GUI.BANHANG
{
    public partial class frm_khachhang : Form
    {
        BLL.BLL_khachhang bllkh;
        public frm_khachhang()
        {
            InitializeComponent();
            bllkh = new BLL.BLL_khachhang(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_makh_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bllkh.Luukh();
            bllkh.loadkh();

        }

        private void frm_khachhang_Load(object sender, EventArgs e)
        {
            bllkh.loadkh();
            rbt_nam.Checked = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Thông tin sẽ bị thay đổi. Bạn có muốn tiếp tục", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllkh.suakh();
                bllkh.loadkh();
            }
        }

        private void dtv_khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txt_makh.Text = dtv_khachhang.Rows[numrow].Cells[0].Value.ToString();
            txt_tenkh.Text = dtv_khachhang.Rows[numrow].Cells[1].Value.ToString();
            txt_diachi.Text = dtv_khachhang.Rows[numrow].Cells[2].Value.ToString();
            txt_sdt.Text = dtv_khachhang.Rows[numrow].Cells[3].Value.ToString();
            if (dtv_khachhang.Rows[numrow].Cells[4].Value.ToString() == "Nam")
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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show(" Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                bllkh.xoakh();
                bllkh.loadkh();
            }
        }
    }
}
