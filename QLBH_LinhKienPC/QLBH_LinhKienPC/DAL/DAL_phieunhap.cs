using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLBH_LinhKienPC.DAL
{
    class DAL_phieunhap
    {
        Lopdungchung lopchung = new Lopdungchung();

        /*
        
        
        public int ThemPN(string mapn, string mancc, string manv, string nn, string ttn)
        {

            string sql = "Insert into PHIEU_NHAP values(N'" + mapn + "',N'" + mancc + "',N'" + manv + "',N'" + nn + "',N'" + ttn + "')";
            return lopchung.ThemSuaXoa(sql);
        }
        */
        public DataTable LoadPN()
        {
            string sql = "Select * from PHIEU_NHAP";
            return lopchung.LoadDuLieu(sql);

        }
        /*
        public int SuaPN(string mapn, string mancc, string manv, string nn, string ttn)
        {
            string sql = "Update NHOM_SAN_PHAM set TenNhom =N'" + mapn + "'where MaNhom = '" + man + "'";
            return lopchung.ThemSuaXoa(sql);
        
        }
        */
    }
}
