using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_LinhKienPC.DAL
{
    class DAL_sanpham
    {
        Lopdungchung lopchung = new Lopdungchung();

        public int ThemSP(string masp, string manhom, string tensp, string dvt, String slton, String giaban, String gianhap, String mancc)
        {

            string sql = "Insert into SAN_PHAM(MaSP,MaNhom,TenSP,DonViTinh,SLTon,GiaNhap,GiaBan,MaNCC) values(N'" + masp + "',N'" + tensp + "',N'" + manhom + "',N'" + dvt + "',N'" + slton + "',N'" + giaban + "',N'" + gianhap + "',N'" + mancc + "')";
            return lopchung.ThemSuaXoa(sql);
        }

        public int SuaSP(string masp, string manhom, string tensp, string dvt, String slton, String giaban, String gianhap, String mancc)
        {
            string sql = "Update SAN_PHAM set TenSP =N'" + tensp + "',MaNhom =N'" + manhom + "',DonViTinh =N'" + dvt + "',SLTon =N'" + slton + "',GIaNhap =N'" + gianhap + "',GiaBan =N'" + giaban + "'where MaSP = '" + masp + "'";
            return lopchung.ThemSuaXoa(sql);
        }

        public int XoaSP(string masp)
        {
            string sql = "Delete MA_SAN_PHAM where MaSP = N'" + masp + "'";
            return lopchung.ThemSuaXoa(sql);

        }
        public DataTable Loadsp()
        {
            string sql = "Select * from SAN_PHAM";
            return lopchung.LoadDuLieu(sql);

        }
       
    }
}
