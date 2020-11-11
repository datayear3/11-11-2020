using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_LinhKienPC
{
    public partial class dangnhap : Form
    {
        int dem = 0;
        DAL.Lopdungchung lopchung = new DAL.Lopdungchung();
        public dangnhap()
        {
            InitializeComponent();
        }

        private void bt_dn_Click(object sender, EventArgs e)
        {
            string sql = "select count(*) from NHAN_VIEN where MaNV = '" + dn_tk.Text.ToUpper() + "'and MatKhau = '" + dn_mk.Text.ToUpper() + "'";
            int kq = (int)lopchung.ExcuteScalar(sql);
            if (kq >= 1)
            {
                GUI.Main main = new GUI.Main();
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
    }
}
