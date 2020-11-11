using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_LinhKienPC.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_trangchu_Click(object sender, EventArgs e)
        {
            trangchu1.Visible = true;
            banhang1.Visible = false;
        }

        private void bt_banhang_Click(object sender, EventArgs e)
        {
            trangchu1.Visible = false;
            banhang1.Visible = true;
        }

        
    }
}
