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
            string sql = "SELECT dbo.PHIEU_NHAP.MaPN AS 'MÃ PHIẾU NHẬP', dbo.SAN_PHAM.TenSP AS 'TÊN SẢN PHẨM', dbo.PHIEU_NHAP.NgayNhap AS 'NGÀY NHẬP', dbo.PHIEU_NHAP.SLN AS 'SỐ LƯỢNG NHẬP', dbo.PHIEU_NHAP.DONGIA AS 'ĐƠN GIÁ NHẬP', dbo.NHA_CUNG_CAP.TenNCC AS 'TÊN NHÀ CUNG CẤP', dbo.PHIEU_NHAP.TongTienNhap AS 'TỔNG TIỀN NHẬP' FROM dbo.NHA_CUNG_CAP INNER JOIN dbo.PHIEU_NHAP ON dbo.NHA_CUNG_CAP.MaNCC = dbo.PHIEU_NHAP.MaNCC INNER JOIN dbo.SAN_PHAM ON dbo.NHA_CUNG_CAP.MaNCC = dbo.SAN_PHAM.MaNCC AND dbo.PHIEU_NHAP.MaSP = dbo.SAN_PHAM.MaSP where MaPN = '"+ mpn.Text+"'";

            DataTable dt = lopchung.LoadDuLieu(sql);


            cr_tungphieunhaphang RPCC = new cr_tungphieunhaphang();
            RPCC.SetDataSource(dt);
            cr_cttsp.ReportSource = RPCC;


            lopchung.Dong();
        }
    }
}
