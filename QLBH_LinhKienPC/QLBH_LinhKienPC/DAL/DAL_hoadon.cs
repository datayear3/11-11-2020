using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_LinhKienPC.DAL
{
    class DAL_hoadon
    {
        Lopdungchung lopchung = new Lopdungchung();

        public int ThemHD(string mahd,string manv, string makh , string ngayban , string tongtienban )
        {

            string sql = "Insert into HOA_DON_BAN(MaHD,MaNV,MaKH,NgayBan,TongTienBan) values(N'" + mahd + "',N'" + manv + "',N'" + makh + "','" + ngayban + "','" + tongtienban + "')";
            return lopchung.ThemSuaXoa(sql);
        }

        public int SuaHD(string mahd, string manv, string makh, string ngayban, string tongtienban)
        {
            string sql = "Update HOA_DON_BAN set MaHD =N'" + mahd + "',MaNV =N'" + manv + "',MaKH =N'" + makh + "',N'" + ngayban + "',N'" + tongtienban + "'where MaHD = '" + mahd + "'";
            return lopchung.ThemSuaXoa(sql);
        }

        public int XoaHD(string mahd)
        {
            string sql = "Delete HOA_DON_BAN where MaHD = N'" + mahd + "'";
            return lopchung.ThemSuaXoa(sql);

        }

        public DataTable LoadHD()
        {
            string sql = "Select * from HOA_DON_BAN";
            return lopchung.LoadDuLieu(sql);

        }
    }
}
