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
    public partial class frmDKTheLoai :MetroFramework.Forms.MetroForm
    {
        DTOTheLoai theloai = new DTOTheLoai();
        BUSTheLoai busTheLoai = new BUSTheLoai();
        //Tạo sự kiện them or cập nhat load lai table
        public delegate void XuLySuKienCapNhat(object sender);
        public event XuLySuKienCapNhat SuKienCapNhat;
        //
      

        public frmDKTheLoai()
        {
            InitializeComponent();
         
            _btnAdd.Visible = true;
        }
        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if (_tbTenTL.Text != "")
            {
                theloai.TenTheLoai = _tbTenTL.Text;
                if (busTheLoai.PhatSinhMaTheLoai(ref theloai))
                {
                    if (busTheLoai.CapNhat(theloai))
                    {
                        MessageBox.Show("Thành Công");
                        //Gọi sự kiện
                        SuKienCapNhat((object) "CapNhatTheLoai");
                        _tbTenTL.Text = "";
                    }
                }

            }
            else
                MessageBox.Show("Chưa Có Giá Trị");

        }

        private void _tbTenTL_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 33 && keycode <= 47) || (keycode >= 58 && keycode <= 64)
                || (keycode >= 91 && keycode <= 96) || (keycode >= 123 && keycode <= 126))
                e.Handled = true;
            else
                e.Handled = false;
        }

        private void _btnThoat_Click(object sender, EventArgs e)
        {
            if (_tbTenTL.Text != "")
            {
                DialogResult result = MessageBox.Show("Chưa Lưu Lại Dữ Liệu ! Bạn Có Muốn Thoát", "THÔNG BÁO", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
                else
                {

                }
            }
            else
                this.Close();
        }

        private void _btnThemMoi_Click(object sender, EventArgs e)
        {
            _tbTenTL.Clear();
        }
    }
}
