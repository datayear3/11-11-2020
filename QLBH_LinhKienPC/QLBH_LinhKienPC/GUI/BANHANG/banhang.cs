using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLBH_LinhKienPC.GUI.BANHANG
{
    public partial class banhang : UserControl
    {
        public banhang()
        {
            InitializeComponent();
        }

        private void bt_them_khachhang_Click(object sender, EventArgs e)
        {
            frm_khachhang kh = new frm_khachhang();

            kh.ShowDialog();
           
        }

        private void banhang_Load(object sender, EventArgs e)
        {
            DAL.Lopdungchung conn = new DAL.Lopdungchung();

            // load data gitview
            string show_data = "select MaHD,TenNV,TenKH,TenSP,NgayBan,DGB,SLB,TongTienBan from HOA_DON_BAN,NHAN_VIEN,KHACH_HANG,SAN_PHAM where NHAN_VIEN.MaNV = HOA_DON_BAN.MaNV and HOA_DON_BAN.MaKH = KHACH_HANG.MaKH and HOA_DON_BAN.MaSP = SAN_PHAM.MaSP";
            DataTable dt = conn.LoadDuLieu(show_data);
            dvt_doanhthu.DataSource = dt;

        }

        private void bt_hoadon_Click(object sender, EventArgs e)
        {
           
        }
    }
}
