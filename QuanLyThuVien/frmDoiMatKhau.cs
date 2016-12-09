using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace UI
{
    public partial class frmDoiMatKhau : MetroFramework.Forms.MetroForm
    {
        BUSNguoiDung _busNguoiDung = new BUSNguoiDung();
        public frmDoiMatKhau()
        {
            InitializeComponent();
            if (UserManager.User != null)
                _tbTK.Text = UserManager.User.TaiKhoan;
        }

        private void _btnDoiMK_Click(object sender, EventArgs e)
        {
          
           

            if (_tbMKCu.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu cũ");
                return;
            }

            if (_tbMKMoi.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu mới");
                return;
            }

           

            DTONguoiDung nguoidung = _busNguoiDung.LayThongTinNguoiDung(_tbTK.Text, _tbMKCu.Text);

            if (nguoidung != null)
            {
                nguoidung.MatKhau = (_tbMKMoi.Text);
                if (_busNguoiDung.CapNhat(nguoidung))
                    MessageBox.Show("Cập nhật thành công");
                else
                    MessageBox.Show("Cập nhật thất bại");
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
        }

        private void _btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
