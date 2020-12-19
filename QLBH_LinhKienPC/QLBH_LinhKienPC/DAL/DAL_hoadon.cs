using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_LinhKienPC.DAL
{
    class DAL_hoadon
    {
        Lopdungchung lopchung = new Lopdungchung();

        public int ThemHD(string mahd, string manv, string makh, DateTime ngayban, string thanhtien, string masp, string dongia, string soluong)
        {

            string sql = "Insert into HOA_DON_BAN(MaHD,MaNV,MaKH,NgayBan,TongTienBan,DGB,MaSP,SLB) values(N'" + mahd + "',N'" + manv + "',N'" + makh + "',N'" + ngayban.ToString() + "',N'" + thanhtien + "',N'" + masp + "',N'" + dongia + "',N'" + soluong + "')";
            return lopchung.ThemSuaXoa(sql);
        }



        public int SuaHD(string mahd, string manv, string makh, DateTime ngayban, string thanhtien, string masp, string dongia, string soluong)
        {
            string sql = "Update HOA_DON_BAN set MaNV =N'" + manv + "',NgayBan = N'" + ngayban.ToString() + "',MaKH = N'" + makh + "',MaH = N'" + masp + "',SLB = N'" + soluong + "',DGB = N'" + dongia + "',TongTienBan = N'" + thanhtien + "' where MaHD = N'" + mahd + "'";
            return lopchung.ThemSuaXoa(sql);
        }

        internal int ThemHD(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8)
        {
            throw new NotImplementedException();
        }

        public int XoaHD(string mahd)
        {
            string sql = "Delete HOA_DON_BAN where MaHD = N'" + mahd + "'";
            return lopchung.ThemSuaXoa(sql);

        }

        internal object Loadhd()
        {
            throw new NotImplementedException();
        }

        public DataTable LoadHD()
        {
            string sql = "Select * from HOA_DON_BAN";
            return lopchung.LoadDuLieu(sql);

        }


    }
}
