using QLBH_LinhKienPC.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBH_LinhKienPC.GUI.BANHANG
{
    public partial class frm_hoadonban : Form
    {
        private void dtv_banhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dt_ngayban.Value = Convert.ToDateTime(dtv_banhang.CurrentRow.Cells["NgayBan"].Value);
        }

        private void frm_hoadonban_Load(object sender, EventArgs e)
        {

        }
    }
}
