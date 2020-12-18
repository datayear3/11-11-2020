using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_LinhKienPC.DAL
{
    class DAL_nhomsanpham
    {
        Lopdungchung lopchung = new Lopdungchung();

        public int ThemSP(string man, string tenn)
        {

            string sql = "Insert into NHOM_SAN_PHAM values(N'" + man + "',N'" + tenn + "')";
            return lopchung.ThemSuaXoa(sql);
        }
        public DataTable LoadSP()
        {
            string sql = "Select * from NHOM_SAN_PHAM";
            return lopchung.LoadDuLieu(sql);

        }

        public int SuaSP(string man, string tenn)
        {
            string sql = "Update NHOM_SAN_PHAM set TenNhom =N'" + tenn + "'where MaNhom = '" + man + "'";
            return lopchung.ThemSuaXoa(sql);
        }
        public int XoaSP(string man)
        {
            string sql = "Delete NHOM_SAN_PHAM where MaNHom = N'" + man + "'";
            return lopchung.ThemSuaXoa(sql);

        }
        public DataTable LoadTenNhom()
        {
            string sql = "Select DISTINCT (TenNhom) from NHOM_SAN_PHAM";
            return lopchung.LoadDuLieu(sql);

        }

    }

}
