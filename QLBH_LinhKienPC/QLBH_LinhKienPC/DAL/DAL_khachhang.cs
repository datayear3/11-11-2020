using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_LinhKienPC.DAL
{
    class DAL_khachhang
    {
        Lopdungchung lopchung = new Lopdungchung();

        public int ThemKH(string makh, string tenkh, string diachi, string sdt)
        {

            string sql = "Insert into KHACH_HANG(MaKH,TenKH,DiaChiKH,SDTKH) values(N'" + makh + "',N'" + tenkh + "',N'" + diachi + "',N'" + sdt + "')";
            return lopchung.ThemSuaXoa(sql);
        }
        /*
        public int Suakh(string makh, string hoten, DateTime ngaysinh, string gioitinh, string diachi, string sdt)
        {
            string sql = "Update KHACHHANG set TenKH =N'" + hoten + "',NgaySINH =N'" + ngaysinh.ToString() + "',GioiTINH =N'" + gioitinh + "',DiaCHI =N'" + diachi + "',SDT =N'" + sdt + "'where MaKH = '" + makh + "'";
            return lopchung.ThemSuaXoa(sql);
        }

        internal int ThemKH(object text1, object text2, object text3, object text4)
        {
            throw new NotImplementedException();
        }

        public int Xoakh(string makh)
        {
            string sql = "Delete KHACHHANG where MaKH = N'" + makh + "'";
            return lopchung.ThemSuaXoa(sql);

        }
        */
        public DataTable Loadkh()
        {
            string sql = "Select * from KHACH_HANG";
            return lopchung.LoadDuLieu(sql);

        }
        
    }
}
