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

        
        
        public int ThemPN(string mapn, string tenncc, string tensp, string nn, string sln, string dg, string tt)
        {


            string mancc = "";
            ///string tncc = tenncc.ToString();
            string select_mancc = "select DISTINCT(MaNCC) from NHA_CUNG_CAP where TenNCC = '" + tenncc + "'";
            DataTable dt_mncc = lopchung.LoadDuLieu(select_mancc);
            if (dt_mncc != null)
            {
                foreach (DataRow dr in dt_mncc.Rows)
                {

                    mancc = dr["MaNCC"].ToString();

                }
            }

            string masp = "";
           // string tncc = tenncc.ToString();
            string select_masp = "select DISTINCT(MaSP) from SAN_PHAM  where TenSP = '" + tensp + "'";
            DataTable dt_mnsp = lopchung.LoadDuLieu(select_masp);
            if (dt_mnsp != null)
            {
                foreach (DataRow dr in dt_mnsp.Rows)
                {

                    masp = dr["MaSP"].ToString();

                }
            }


            string sql = "Insert into PHIEU_NHAP(MaPN,MaNCC,MaSP,NgayNhap,SLN,DONGIA,TongTienNhap) values(N'" + mapn + "',N'" + mancc + "',N'" + masp + "',N'" + nn + "','" + Convert.ToInt32(sln)+ "','" + Convert.ToInt32(dg) + "','" + Convert.ToInt32(tt) + "')";
            return lopchung.ThemSuaXoa(sql);


        }
        public DataTable LoadPN()
        {

            string sql = "Select [MaPN],[TenNCC],[TenSP],[NgayNhap],[SLN],[DONGIA],[TongTienNhap] from PHIEU_NHAP,NHA_CUNG_CAP,SAN_PHAM where PHIEU_NHAP.MaSP = SAN_PHAM.MaSP and  PHIEU_NHAP.MaNCC = NHA_CUNG_CAP.MaNCC ";
            return lopchung.LoadDuLieu(sql);

        }
        
        public int SuaPN(string mapn, string tenncc, string tensp, string sln, string dg, string tt)
        {

            string mancc = "";
            ///string tncc = tenncc.ToString();
            string select_mancc = "select DISTINCT(MaNCC) from NHA_CUNG_CAP where TenNCC = '" + tenncc + "'";
            DataTable dt_mncc = lopchung.LoadDuLieu(select_mancc);
            if (dt_mncc != null)
            {
                foreach (DataRow dr in dt_mncc.Rows)
                {

                    mancc = dr["MaNCC"].ToString();

                }
            }

            string masp = "";
            // string tncc = tenncc.ToString();
            string select_masp = "select DISTINCT(MaSP) from SAN_PHAM  where TenSP = '" + tensp + "'";
            DataTable dt_mnsp = lopchung.LoadDuLieu(select_masp);
            if (dt_mnsp != null)
            {
                foreach (DataRow dr in dt_mnsp.Rows)
                {

                    masp = dr["MaSP"].ToString();

                }
            }
            string sql = "Update PHIEU_NHAP set MaSP = N'" + masp + "', MaNCC = N'" + mancc + "', SLN = '" + Convert.ToInt32(sln) + "', DONGIA = '" + Convert.ToInt32(dg) + "', TongTienNhap = '" + Convert.ToInt32(tt) + "' where MaPN = '" + mapn + "'";
            return lopchung.ThemSuaXoa(sql);
        
        }
        


        public int XoaPN(string mapn)
        {
            string sql = "Delete PHIEU_NHAP where MaPN = N'" + mapn + "'";
            return lopchung.ThemSuaXoa(sql);

        }
    }
}
