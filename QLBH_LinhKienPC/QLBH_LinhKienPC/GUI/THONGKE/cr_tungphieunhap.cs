using QLBH_LinhKienPC.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_LinhKienPC.GUI.THONGKE
{
    public partial class cr_tungphieunhap : Form
    {
        public cr_tungphieunhap()
        {
            InitializeComponent();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cr_cttsp_Load(object sender, EventArgs e)
        {
            
        }

        private void cr_tungphieunhap_Load(object sender, EventArgs e)
        {
            Lopdungchung lopchung = new Lopdungchung();
            lopchung.connection().Open();
            string sql = "SELECT * FROM PHIEU_NHAP where MaPN = '"+ mpn.Text+"'";

            DataTable dt = lopchung.LoadDuLieu(sql);


            cr_tungphieunhaphang RPCC = new cr_tungphieunhaphang();
            RPCC.SetDataSource(dt);
            cr_cttsp.ReportSource = RPCC;


            lopchung.Dong();
        }
    }
}
