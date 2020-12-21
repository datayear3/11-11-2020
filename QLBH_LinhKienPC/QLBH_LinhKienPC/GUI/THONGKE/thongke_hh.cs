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
    public partial class thongke_hh : Form
    {
        public thongke_hh()
        {
            InitializeComponent();
        }

        private void thongke_hh_Load(object sender, EventArgs e)
        {

            Lopdungchung lopchung = new Lopdungchung();
            lopchung.connection().Open();
            string sql = "select MaSP as 'MÃ SP',TenNhom as 'TÊN NHÓM',TenSP AS 'TÊN SẢN PHẨM',DonViTinh AS 'DVT',SLTon AS 'SLT',GiaBan AS 'GIÁ BÁN',GiaNhap AS 'GIÁ NHẬP',TenNCC AS 'NHÀ CUNG CẤP' from SAN_PHAM,NHA_CUNG_CAP,NHOM_SAN_PHAM where SAN_PHAM.MaNhom = NHOM_SAN_PHAM.MaNhom and SAN_PHAM.MaNCC = NHA_CUNG_CAP.MaNCC";

            DataTable dt = lopchung.LoadDuLieu(sql);


            tk_hh RPCC = new tk_hh();
            RPCC.SetDataSource(dt);
            cr_hh.ReportSource = RPCC;


            lopchung.Dong();

        }
    }
}
