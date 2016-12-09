using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace UI
{
    public partial class frmDangNhap : MetroFramework.Forms.MetroForm
    {
        BUSNguoiDung _busNguoiDung = new BUSNguoiDung();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void _btnDangNhap_Click(object sender, EventArgs e)
        {

            if (_tbTK.Text == "")
            {
                MessageBox.Show("Chưa nhập tài khoản");
                _tbTK.Focus();
                return;
            }

            if (_tbMK.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                _tbMK.Focus();
                return;
            }

            DTONguoiDung lastUser = null;
            if (UserManager.User != null && UserManager.User.TaiKhoan != "" && UserManager.User.MatKhau != "")
                lastUser = UserManager.User;

            DTONguoiDung newUser = _busNguoiDung.LayThongTinNguoiDung(_tbTK.Text, _tbMK.Text);
            if (newUser != null)
            {
                MessageBox.Show("Đăng nhập thành công");
                UserManager.User = newUser;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
                if (lastUser != null)
                    UserManager.User = lastUser;
            }
        }

        private void _btnThoat_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void _tbMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                _btnDangNhap_Click(null, null);
            }
        }
    }
}
