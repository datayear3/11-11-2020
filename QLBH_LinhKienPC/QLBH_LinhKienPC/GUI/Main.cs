using QLBH_LinhKienPC.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            us_trangchu.Visible = true;
            us_banhang.Visible = false;
            us_khohang.Visible = false;
            us_quantrivien.Visible = false;
            us_thongke.Visible = false;

        }

        private void bt_banhang_Click(object sender, EventArgs e)
        {
            us_trangchu.Visible = false;
            us_banhang.Visible = true;
            us_khohang.Visible = false;
            us_quantrivien.Visible = false;
            us_thongke.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trangchu1_Load(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_khohang_Click(object sender, EventArgs e)
        {
            us_trangchu.Visible = false;
            us_banhang.Visible = false;
            us_khohang.Visible = true;
            us_quantrivien.Visible = false;
            us_thongke.Visible = false;

        }

        private void bt_quantrivien_Click(object sender, EventArgs e)
        {
            us_trangchu.Visible = false;
            us_banhang.Visible = false;
            us_khohang.Visible = false;
            us_quantrivien.Visible = true;
            us_thongke.Visible = false;

        }

        private void us_quantrivien_Load(object sender, EventArgs e)
        {

        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {
            us_trangchu.Visible = false;
            us_banhang.Visible = false;
            us_khohang.Visible = false;
            us_quantrivien.Visible = false;
            us_thongke.Visible = true;

        }
    }
}
