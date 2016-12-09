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
    public partial class frmDKTacGia   : MetroFramework.Forms.MetroForm
    {
        DTOTacGia tacgia = new DTOTacGia();
        BUSTacGia busTacGia = new BUSTacGia();
        public delegate void XuLySuKienCapNhat(object sender);
        public event XuLySuKienCapNhat SuKienCapNhat;
        public frmDKTacGia()
        {
            InitializeComponent();
            
            _btnAdd.Visible = true;
        }
      
       
        

        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if (_tbTenTG.Text != "")
            {
                tacgia.TenTG = _tbTenTG.Text;
                if(busTacGia.PhatSinhMaTG(ref tacgia))
                {
                    if (busTacGia.CapNhat(tacgia))
                    {
                        MessageBox.Show("Thành Công");
                        _tbTenTG.Text = "";
                        SuKienCapNhat((object)"CapNhatTacGia");
                    }
                }

            }
            else
                MessageBox.Show("Chưa Có Giá Trị");
           
        }

        private void _tbTenTG_KeyPress(object sender, KeyPressEventArgs e)
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
           
            {
                if (_tbTenTG.Text != "")
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
        }

        private void _btnThemMoi_Click(object sender, EventArgs e)
        {
            _tbTenTG.Clear();
        }
    }
}
