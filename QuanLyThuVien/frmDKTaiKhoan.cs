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
    public partial class frmDKTaiKhoan : MetroFramework.Forms.MetroForm
    {
        BUSNguoiDung _busNguoiDung = new BUSNguoiDung();
        BUSDocGia _busDocGia = new BUSDocGia();
        DTONguoiDung nguoidung;
        public frmDKTaiKhoan()
        {
            InitializeComponent();
            if (UserManager.User.LoaiNguoiDung == LOAI_NGUOI_DUNG.ThuThu)
            {
                _rbTT.Visible = false;
                _rbDG.Checked = true;
            }
        }

        public DTONguoiDung LayDuLieu()
        {
            DTONguoiDung nguoidungtemp = new DTONguoiDung();
            if(_tbMK.Text!=_tbNhapLai.Text)
            {
                MessageBox.Show("Mật Khẩu Không Trùng Khớp !");
                return null;
            }
            if (_tbTK.Text.Length < 4 || _tbTK.Text.Length > 16)
            {
                MessageBox.Show("Độ dài tài khoản từ 4 đến 16 ký tự");
                return null;
            }
            else
            {
                

                if (_rbTT.Checked)
                {
                    nguoidungtemp.LoaiNguoiDung = LOAI_NGUOI_DUNG.ThuThu;
          
                }
                else
                    nguoidungtemp.LoaiNguoiDung = LOAI_NGUOI_DUNG.DocGia;

                nguoidungtemp.TaiKhoan = _tbTK.Text;
            }

            if (_tbMK.Text.Length < 4 || _tbMK.Text.Length > 36)
            {
                MessageBox.Show("Độ dài mật khẩu từ 4 đến 36 ký tự");
                return null;
            }
            else
            {

                nguoidungtemp.MatKhau = _tbMK.Text;
            }

            return nguoidungtemp;
        }

        private void _btnDK_Click(object sender, EventArgs e)
        {
            if(_tbMK.Text!="" && _tbNhapLai.Text!="" && _tbTK.Text!="")
            {
                 nguoidung = LayDuLieu();
                if (nguoidung != null)
                {
                    int demtk = _busNguoiDung.DemMaTaiKhoan(nguoidung.TaiKhoan);
                    if (demtk > 0)
                        MessageBox.Show("Tài khoản đã tồn tại");
                    else
                    {
                        if (nguoidung.LoaiNguoiDung == LOAI_NGUOI_DUNG.DocGia)
                        {
                            if (!_busDocGia.KiemTraTonTaiMaDocGia(nguoidung.TaiKhoan))
                                MessageBox.Show("Tài khoản phải trùng với mã độc giả");
                            else
                            {
                                nguoidung.MaDG = nguoidung.TaiKhoan;
                                nguoidung.MaNhom = "NH03";
                                if (_busNguoiDung.CapNhat(nguoidung))
                                {
                                    MessageBox.Show("Tạo thành công");
                                    _tbTK.Text = "";
                                    _tbMK.Text = _tbNhapLai.Text = "";
                                }
                                else
                                    MessageBox.Show("Tạo thất bại");
                            }
                        }
                        else
                        {
                            nguoidung.MaNhom = "NH02";
                            if (_busNguoiDung.CapNhat(nguoidung))
                            {
                                MessageBox.Show("Tạo thành công");
                                _tbTK.Text = "";
                                _tbMK.Text = _tbNhapLai.Text = "";
                            }
                            else
                                MessageBox.Show("Tạo thất bại");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa Nhập Đầy Đủ Thông Tin");
            }
        }

        private void _btnThoat_Click(object sender, EventArgs e)
        {
          
            {
                if (_tbTK.Text != "")
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
    }
}
