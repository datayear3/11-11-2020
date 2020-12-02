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
        internal static object dtv_nhomsanpham;

        public frm_nhomsanpham()
        {
            InitializeComponent();
            bllnsp = new BLL.BLL_nhomsanpham(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_themsp_Click(object sender, EventArgs e)
        {
            bllnsp.LuuSP();
            bllnsp.loadSP();

        }
    }
}
