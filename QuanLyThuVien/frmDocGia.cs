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
    public partial class frmDocGia : MetroFramework.Forms.MetroForm
    {
        List<DTOLoaiDG> _DSLoaiDG = new List<DTOLoaiDG>();
        BUSLoaiDocGia _busLoaiDG = new BUSLoaiDocGia();
        BUSQuyDinh busQuyDinh = new BUSQuyDinh();
        BUSDocGia busDocGia = new BUSDocGia();
        DTODocGia _docgia;
        public delegate void XuLySuKienCapNhat(object sender);
        public event XuLySuKienCapNhat SuKienCapNhat;
        public frmDocGia()
        {
            InitializeComponent();
         

        }

        public void init()
        {
            //khởi tạo giá trị số tuổi đúng quy định

            DateTime minDate = new DateTime((DateTime.Today.Year - busQuyDinh.getMaxAge()), DateTime.Today.Month, DateTime.Today.Day);
            DateTime maxDate = new DateTime((DateTime.Today.Year - busQuyDinh.getMinAge()), DateTime.Today.Month, DateTime.Today.Day);
            _dtNgaySinh.MinDate = minDate;
            _dtNgaySinh.MaxDate = maxDate;
            //khởi tạo ngày hết hạn

            _dtNgayHetHan.Value = _dtNgayLapThe.Value;
            _dtNgayHetHan.Value = _dtNgayHetHan.Value.AddMonths(busQuyDinh.getGetMonthEx());

        }
        public DTODocGia initDocGia()
        {
            DTODocGia docgia = new DTODocGia();
            DateTime macdinh = new DateTime(0001, 1, 1);
            if (_tbHoTen.Text != "" && _tbDiaChi.Text != "" && _tbMail.Text != "" && _dtNgaySinh.Value != macdinh)
            {
                docgia.MaDG = busDocGia.PhatSinhMaDG(_dtNgayLapThe.Value.Year);
                docgia.HoTen = _tbHoTen.Text;
                docgia.NgayHetHan = _dtNgayHetHan.Value;
                docgia.NgayLapThe = _dtNgayLapThe.Value;
                docgia.NgaySinh = _dtNgaySinh.Value;
                docgia.Email = _tbMail.Text;
                docgia.DiaChi = _tbDiaChi.Text;
                docgia.TongNo = 0.0F;
                docgia.MaLoaiDG = _DSLoaiDG[_cbbLoaiDocGia.SelectedIndex].MaLoaiDG;
            }
            else
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin");
                return null;
            }

            return docgia;
        }
        public bool HienThiDSLoaiDG()
        {
            _DSLoaiDG = _busLoaiDG.LayDSLoaiDG();
            if (_DSLoaiDG == null)
            {
                MessageBox.Show("Không lấy được danh sách loại độc giả");
                return false;
            }
            else
            {
                for (int i = 0; i < _DSLoaiDG.Count; i++)
                {
                    try
                    {
                        _cbbLoaiDocGia.Items.Add(_DSLoaiDG[i].TenLoaiDG);
                    }
                    catch
                    { }
                }
                try
                {
                    _cbbLoaiDocGia.SelectedIndex = 0;
                    return true;
                }
                catch
                {
                    MessageBox.Show("Chưa Có Thông Tin Loại Độc Giả !");
                    return false;
                }


            }
        }



        private void _btnDangKi_Click(object sender, EventArgs e)
        {
             _docgia = initDocGia();
            if (_docgia != null)
            {
                if (busDocGia.ThemDocGia(_docgia))
                {
                    MessageBox.Show("Thêm thành công");
                    _tbDiaChi.Text = "";
                    _tbHoTen.Text = "";
                    _tbMail.Text = "";
                    _dtNgaySinh.Text = "";
                    SuKienCapNhat((object)"CapNhatDocGia");
                }
                else
                    MessageBox.Show("Thêm thất bại");
            }
        }

        private void _dtNgayLapThe_ValueChanged(object sender, EventArgs e)
        {
            _dtNgayHetHan.Value = _dtNgayLapThe.Value;
            _dtNgayHetHan.Value = _dtNgayHetHan.Value.AddMonths(busQuyDinh.getGetMonthEx());
        }

        private void _btnThoat_Click(object sender, EventArgs e)
        {
           
            {
                if (_tbHoTen.Text != "" || _tbDiaChi.Text != "" || _tbMail.Text != "")
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
            _tbDiaChi.Text = "";
            _tbHoTen.Text = "";
            _tbMail.Text = "";
            _dtNgaySinh.Text = "";

        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            _dtNgayLapThe.Value = DateTime.Today;
            if (HienThiDSLoaiDG())
            {

            }
            else
                this.Close();
            init();
        }
    }
}
