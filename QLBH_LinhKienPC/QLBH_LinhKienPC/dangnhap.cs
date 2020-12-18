using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QLBH_LinhKienPC
{
    public partial class dangnhap : Form
    {
        int dem = 0;
        public string data_macv="";
        public string ten_nv = "";
        public string loai_quyen = "";
        DAL.Lopdungchung lopchung = new DAL.Lopdungchung();
        public dangnhap()
        {
            InitializeComponent();
        }

        private void bt_dn_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from NHAN_VIEN where MaNV = '" + dn_tk.Text.ToUpper() + "'and MatKhau = '" + dn_mk.Text.ToUpper() + "'";
            string mcv = "select * from NHAN_VIEN where MaNV = '" + dn_tk.Text.ToUpper() + "'";
            

            DataTable data_tb_nv = lopchung.LoadDuLieu(mcv);
            if (data_tb_nv != null)
            {
                foreach (DataRow dr in data_tb_nv.Rows)
                {
                    data_macv = dr["MaCV"].ToString();
                    ten_nv = dr["TenNV"].ToString();

                }
            }
            
            string quyen = "select * from CHUC_VU where MaCV = '" + data_macv +"'";
            DataTable data_tb_cv = lopchung.LoadDuLieu(quyen);
            if (data_tb_cv != null)
            {
                foreach (DataRow dr in data_tb_cv.Rows)
                {
                    loai_quyen = dr["Quyen"].ToString();
                }
            }
            
            int kq = (int)lopchung.ExcuteScalar(sql);
            if (kq >= 1)
            {
                GUI.Main main = new GUI.Main();
                main.bt_close.Text = "Xin chao, " + ten_nv;
                if (loai_quyen != "admin")
                {
                    main.bt_quantrivien.Visible = false;
                }
                this.Hide();
                main.ShowDialog();
                this.Show();
            }
            else
            {
                dem++;
                MessageBox.Show("Đăng nhập thất bại,mời bạn nhập lại");
                if (dem == 3)
                {
                    MessageBox.Show("Bạn đã nhập sai 3 lần");
                    Application.Exit();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
