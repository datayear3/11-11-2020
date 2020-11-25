using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_LinhKienPC.DAL
{
    class DAL_chucvu
    {
        Lopdungchung lopchung = new Lopdungchung();

        public int ThemCV(string macv, string tencv)
        {

            string sql = "Insert into CHUC_VU(MaCV,TenCV) values(N'" + macv + "',N'" + tencv + "')";
            return lopchung.ThemSuaXoa(sql);
        }

        public int SuaCV(string macv, string tencv)
        {
            string sql = "Update CHUC_VU set TenCV =N'" + tencv +  "'where MaCV = '" + macv + "'";
            return lopchung.ThemSuaXoa(sql);
        }

        public int XoaCV(string macv)
        {
            string sql = "Delete CHUC_VU where MaCV = N'" + macv + "'";
            return lopchung.ThemSuaXoa(sql);

        }

        public DataTable LoadCV()
        {
            string sql = "Select * from CHUC_VU";
            return lopchung.LoadDuLieu(sql);

        }
    }
}
