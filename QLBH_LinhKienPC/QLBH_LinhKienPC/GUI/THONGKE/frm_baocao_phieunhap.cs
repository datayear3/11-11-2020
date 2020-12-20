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
    public partial class frm_baocao_phieunhap : Form
    {
        public frm_baocao_phieunhap()
        {
            InitializeComponent();
        }

        private void frm_baocao_phieunhap_Load(object sender, EventArgs e)
        {
            Lopdungchung lopchung = new Lopdungchung();
            lopchung.connection().Open();
            string sql = "SELECT * FROM PHIEU_NHAP";

            DataTable dt = lopchung.LoadDuLieu(sql);


            cr_phieunhap RPCC = new cr_phieunhap();
            RPCC.SetDataSource(dt);
            cr_phieunhap.ReportSource = RPCC;


            lopchung.Dong();




           
           
        }
    }
}
