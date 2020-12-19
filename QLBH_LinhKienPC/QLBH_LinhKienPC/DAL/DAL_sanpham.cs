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

        public int ThemSP(string masp, string tennhom, string tensp, string dvt, string slton, string gianhap, string giaban, string tenncc)
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

        public int SuaSP(string masp, string tennhom, string tensp, string dvt, string slton, string gianhap, string giaban, string tenncc)
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
            string sql = "Update SAN_PHAM set TenSP =N'" + tensp + "',MaNhom =N'" + manhom + "',DonViTinh =N'" + dvt + "',SLTon = N'" + Convert.ToInt32(slton) + "',GIaNhap =N'" + Convert.ToInt32(gianhap) + "',GiaBan =N'" + Convert.ToInt32(giaban) + "'where MaSP = '" + masp + "'";
            return lopchung.ThemSuaXoa(sql);
        }

        public int XoaSP(string masp)
        {
            string sql = "Delete SAN_PHAM where MaSP = N'" + masp + "'";
            return lopchung.ThemSuaXoa(sql);

        }
        public DataTable Loadsp()
        {
            string sql = "Select MaSP,TenNhom,TenSP,DonViTinh,SLTon,GiaNhap,GiaBan,TenNCC from SAN_PHAM,NHOM_SAN_PHAM,NHA_CUNG_CAP where SAN_PHAM.MaNhom = NHOM_SAN_PHAM.MaNhom and SAN_PHAM.MaNCC = NHA_CUNG_CAP.MaNCC";
            return lopchung.LoadDuLieu(sql);

        }
       
    }
}
