using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_LinhKienPC.DAL
{
    class DAL_sanpham
    {
        Lopdungchung lopchung = new Lopdungchung();

        public int ThemSP(string masp, string tennhom, string tensp, string dvt, String slton, String gianhap, String giaban, String tenncc)
        {
            string manhom = "";
            ///string tncc = tenncc.ToString();
            string select_mancc = "select DISTINCT(MaNhom) from NHOM_SAN_PHAM where TenNhom = '" + tennhom + "'";
            DataTable dt_mncc = lopchung.LoadDuLieu(select_mancc);
            if (dt_mncc != null)
            {
                foreach (DataRow dr in dt_mncc.Rows)
                {

                    manhom = dr["MaNhom"].ToString();

                }
            }
            
            string mancc = "";
            string tncc = tenncc.ToString();
            string select_manccc = "select DISTINCT(MaNCC) from NHA_CUNG_CAP where TenNCC = '" + tncc + "'";
            DataTable dt_mnccc = lopchung.LoadDuLieu(select_manccc);
            if (dt_mnccc != null)
            {
                foreach (DataRow dr in dt_mnccc.Rows)
                {

                    mancc = dr["MaNCC"].ToString();

                }
            }
            


            string sql = "Insert into SAN_PHAM(MaSP,MaNhom,TenSP,DonViTinh,SLTon,GiaNhap,GiaBan,MaNCC) values(N'" + masp  + "',N'" + manhom + "',N'" + tensp + "',N'" + dvt + "',N'" +Convert.ToInt32(slton) + "',N'" +Convert.ToInt32(giaban) + "',N'" +Convert.ToInt32(gianhap) + "','" + mancc + "')";
            return lopchung.ThemSuaXoa(sql);
        }

        public int SuaSP(string masp, string manhom, string tensp, string dvt, String slton, String giaban, String gianhap, String mancc)
        {
            string sql = "Update SAN_PHAM set TenSP =N'" + tensp + "',MaNhom =N'" + manhom + "',DonViTinh =N'" + dvt + "',SLTon =N'" + slton + "',GIaNhap =N'" + gianhap + "',GiaBan =N'" + giaban + "'where MaSP = '" + masp + "'";
            return lopchung.ThemSuaXoa(sql);
        }

        public int XoaSP(string masp)
        {
            string sql = "Delete SAN_PHAM where MaSP = N'" + masp + "'";
            return lopchung.ThemSuaXoa(sql);

        }
        public DataTable Loadsp()
        {
            string sql = "Select * from SAN_PHAM";
            return lopchung.LoadDuLieu(sql);

        }
       
    }
}
