using QLBH_LinhKienPC;
using QLBH_LinhKienPC.GUI.KHOHANG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace QLBH_LinhKienPC.DAL
{
    class DAL_nhacungcap
    {
        Lopdungchung lopchung = new Lopdungchung();
        public int ThemNCC(string mancc, string tenncc, string sdtncc, string dcncc)
        {

            string sql = "Insert into NHA_CUNG_CAP(TenNCC,MaNCC,SDTNCC,DiaChiNCC) values(N'" + mancc + "',N'" + tenncc+ "',N'" + sdtncc + "',N'" + dcncc + "')";
            return lopchung.ThemSuaXoa(sql);
        }
        public DataTable LoadNCC()
        {
            string sql = "Select * from NHA_CUNG_CAP";
            return lopchung.LoadDuLieu(sql);

        }

        public int SuaNCC(string mancc, string tenncc,string sdtncc, string dc)
        {
            string sql = "Update NHA_CUNG_CAP set TenNCC = N'" + tenncc + "', SDTNCC = '" + sdtncc+ "', DiaChiNCC = '" + dc +  "'where MaNCC = '" + mancc + "'";
            return lopchung.ThemSuaXoa(sql);
        }
        public int XoaNCC(string mancc)
        {
            string sql = "Delete NHA_CUNG_CAP where MaNCC = N'" + mancc + "'";
            return lopchung.ThemSuaXoa(sql);

        }
        public DataTable LoadTenNCC()
        {
            string sql = "Select DISTINCT (TenNCC) from NHA_CUNG_CAP";
            return lopchung.LoadDuLieu(sql);

        }

    }
}
