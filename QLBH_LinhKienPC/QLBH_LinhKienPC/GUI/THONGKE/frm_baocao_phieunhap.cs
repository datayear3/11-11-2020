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
            string sql = "SELECT dbo.PHIEU_NHAP.MaPN AS 'MÃ PHIẾU', dbo.SAN_PHAM.TenSP AS 'SẢN PHẨM', dbo.PHIEU_NHAP.NgayNhap AS 'NGÀY NHẬP', dbo.PHIEU_NHAP.SLN AS 'SỐ LƯỢNG', dbo.PHIEU_NHAP.DONGIA AS 'ĐƠN GIÁ', dbo.NHA_CUNG_CAP.TenNCC AS 'NHÀ CUNG CẤP', dbo.PHIEU_NHAP.TongTienNhap AS 'TIỀN NHẬP' FROM dbo.NHA_CUNG_CAP INNER JOIN dbo.PHIEU_NHAP ON dbo.NHA_CUNG_CAP.MaNCC = dbo.PHIEU_NHAP.MaNCC INNER JOIN dbo.SAN_PHAM ON dbo.NHA_CUNG_CAP.MaNCC = dbo.SAN_PHAM.MaNCC AND dbo.PHIEU_NHAP.MaSP = dbo.SAN_PHAM.MaSP ";

            DataTable dt = lopchung.LoadDuLieu(sql);


            cr_phieunhap RPCC = new cr_phieunhap();
            RPCC.SetDataSource(dt);
            cr_phieunhap.ReportSource = RPCC;


            lopchung.Dong();




           
           
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
