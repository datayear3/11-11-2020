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
    public partial class frm_themsanpham : Form
    {
        BLL.BLL_nhomsanpham nsp;
        public frm_themsanpham()
        {
            InitializeComponent();
            nsp = new BLL.BLL_nhomsanpham(this);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            nsp.Luukh();
            
        }
    }
}
