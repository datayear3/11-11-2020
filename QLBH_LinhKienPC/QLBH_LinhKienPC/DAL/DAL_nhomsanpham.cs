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
    }
}
