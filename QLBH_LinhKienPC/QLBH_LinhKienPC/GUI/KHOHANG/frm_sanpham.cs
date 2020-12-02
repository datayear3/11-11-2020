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
    public partial class frm_sanpham : Form
    {
        BLL.BLL_sanpham bllsp;
        internal static object dtv_sanpham;

        public frm_sanpham()
        {
            InitializeComponent();
            bllsp = new BLL.BLL_sanpham(this);
        }
      
        private void frm_sanpham_Load(object sender, EventArgs e)
        {
            //bllsp.loadSP();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
