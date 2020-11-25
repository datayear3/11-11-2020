using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_LinhKienPC.GUI.QUANTRIVIEN
{
    public partial class quantrivien : UserControl
    {
        public quantrivien()
        {
            InitializeComponent();
        }

        private void bt_chucvu_Click(object sender, EventArgs e)
        {
            frm_chucvu chucvu = new frm_chucvu();
            chucvu.ShowDialog();
        }

        private void bt_nhanvien_Click(object sender, EventArgs e)
        {
            frm_nhanvien nhanvien = new frm_nhanvien();
            nhanvien.ShowDialog();
        }
    }
}
