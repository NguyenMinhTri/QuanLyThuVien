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
    public partial class frmDKLoaiDG : MetroFramework.Forms.MetroForm
    {
        DTOLoaiDG loaiDG = new DTOLoaiDG();
        BUSLoaiDocGia busLoaiDG = new BUSLoaiDocGia();
        public delegate void XuLySuKienCapNhat(object sender);
        public event XuLySuKienCapNhat SuKienCapNhat;
        public frmDKLoaiDG()
        {
            InitializeComponent();
            _btnAdd.Visible = true;

        }                     
        private void _btnAdd_Click(object sender, EventArgs e)
        {
            if(_tbTenDG.Text=="")
            {
                MessageBox.Show("Không được để trống loại độc giả");
                return;
            }
            loaiDG = new DTOLoaiDG();
            loaiDG.TenLoaiDG = _tbTenDG.Text;
            if(busLoaiDG.PhatSinhMaLoaiDG(ref loaiDG)) 
            if (loaiDG != null)
                if (!busLoaiDG.KiemTra(loaiDG.MaLoaiDG))
                {
                    if (busLoaiDG.CapNhat(loaiDG))
                    {
                        MessageBox.Show("Thành công");
                            _tbTenDG.Text = "";
                        SuKienCapNhat((object)"CapNhatLoaiDG");
                     }
                }
                else
                    MessageBox.Show("Mã độc giả đã tồn tại");
        }

        private void _btnThoat_Click(object sender, EventArgs e)
        {
           
                if (_tbTenDG.Text != "")
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
            _tbTenDG.Clear();
        }
    }
}
