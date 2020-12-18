using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_LinhKienPC.DAL
{
    class DAL_nhanvien
    {
        Lopdungchung lopchung = new Lopdungchung();

        public int ThemNV(string manv, string tennv, string diachi, string sdt, String gt, string ns,String mk, String mcv)
        {

            string sql = "Insert into NHAN_VIEN(MaNV,TenNV,DiaChiNV,SDTNV,GioiTinh,NgaySinh,MatKhau,MaCV) values(N'" + manv + "',N'" + tennv + "',N'" + diachi + "',N'" + sdt + "',N'" + gt +"', N'" + ns.ToString() + "', N'" + mk + "',N'" + mcv + "')";
            return lopchung.ThemSuaXoa(sql);
        }

        public int SuaNV(string manv, string tennv, string diachi, string sdt, String gt, String ns, String mk, String mcv)
        {
            string sql = "Update NHAN_VIEN set TenNV =N'" + tennv + "',DiaChiKH =N'" + diachi + "',SDTKH =N'" + sdt + "',GioiTinh =N'" + gt + "',N'" + ns + "', N'" + mk + "'where MaNV = '" + manv + "'";
            return lopchung.ThemSuaXoa(sql);
        }

        public int XoaNV(string manv)
        {
            string sql = "Delete NHAN_VIEN where MaNV = N'" + manv + "'";
            return lopchung.ThemSuaXoa(sql);

        }

        public DataTable LoadNV()
        {
            string sql = "Select * from NHAN_VIEN";
            return lopchung.LoadDuLieu(sql);

        }
        
    }
}
