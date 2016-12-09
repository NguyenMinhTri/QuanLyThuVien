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
    public partial class frmNhapSach : MetroFramework.Forms.MetroForm
    {
        BUSDauSach _busDauSach = new BUSDauSach();
        BUSQuyDinh _busQuyDinh = new BUSQuyDinh();
        BUSPhieuNhap _busPhieuNhap = new BUSPhieuNhap();
        BUSCT_PhieuNhap _busCT_PhieuNhap = new BUSCT_PhieuNhap();
        BUSCuonSach _busCuonSach = new BUSCuonSach();
        BUSSach _busSach = new BUSSach();
        DTOPhieuNhap _PhieuNhap = new DTOPhieuNhap();
        private List<DTODauSach> _DSDauSach;
        public delegate void XuLySuKienCapNhat(object sender);
        public event XuLySuKienCapNhat SuKienCapNhat;

        public frmNhapSach()
        {
            InitializeComponent();
          
            _DSDauSach = _busDauSach.LayDSDauSach();
            _btnAddDS.Enabled = false;
            _btnLapPhieu.Enabled = false;
            if (_DSDauSach != null)
            {
                for (int i = 0; i < _DSDauSach.Count; i++)
                {
                    try
                    {
                        _cbbTenDauSach.Items.Add(_DSDauSach[i].TenDauSach);
                    }
                    catch { }
                }
                try {
                    _cbbTenDauSach.SelectedIndex = 0;
                }
                catch { }
            }
            else
                MessageBox.Show("Không lấy được tên sách để hiển thị");

        }

        private void _cbbTenDauSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string madausach = "";
            try
            {
                madausach = _DSDauSach[_cbbTenDauSach.SelectedIndex].MaDauSach;
            }
            catch
            {
                MessageBox.Show("Không tìm thấy mã đầu sách");
            }
            if (madausach == null || madausach == "")
                return;

            string tentl = _busDauSach.LayTenTheLoai(madausach);
            if (tentl != null)
                _tbTheLoai.Text = tentl;
            else
                _tbTheLoai.Text = "";

            List<string> dstacgia = _busDauSach.LayDSTenTG(madausach);
            if (dstacgia != null)
            {
                string tentg = "";
                if (dstacgia.Count > 0)
                    tentg = dstacgia[0];
                if (dstacgia.Count > 1)
                {
                    for (int i = 1; i < dstacgia.Count; i++)
                        tentg += ", " + dstacgia[i];
                }
                _tbTacGia.Text = tentg;
            }
            else
                _tbTacGia.Text = "";


        }
        private void _tbSoLuong_TextChanged(object sender, EventArgs e)
        {
            long trigia = 0;
            int soluong = 0;
            try
            {
                trigia = long.Parse(_tbTriGia.Text);
                soluong = Int32.Parse(_tbSoLuong.Text);
            }
            catch { }

            _tbThanhTien.Text = (trigia * soluong).ToString();
        }
        private void _tbTriGia_TextChanged(object sender, EventArgs e)
        {
            long trigia = 0;
            int soluong = 0;
            try
            {
                trigia = long.Parse(_tbTriGia.Text);
                soluong = Int32.Parse(_tbSoLuong.Text);
            }
            catch { }

            _tbThanhTien.Text = (trigia * soluong).ToString();
        }

        private void _btnAddDS_Click(object sender, EventArgs e)
        {
            if(_tbTriGia.Text!="" && _tbSoLuong.Text!="" && _tbSoLuong.Text!="" && _cbbTenDauSach.Text!="" )
            {
                DTOCT_PhieuNhap _ctPhieuNhap = new DTOCT_PhieuNhap();
                _ctPhieuNhap.Sach.MaDauSach = _DSDauSach[_cbbTenDauSach.SelectedIndex].MaDauSach;
                _ctPhieuNhap.Sach.NamXB = long.Parse(_tbNamXB.Text);
                _ctPhieuNhap.Sach.NhaXB = _tbNhaXB.Text;
                _ctPhieuNhap.Sach.TriGia = Double.Parse(_tbTriGia.Text);
                _ctPhieuNhap.TriGia = _ctPhieuNhap.Sach.TriGia;
                _ctPhieuNhap.Sach.SoLuong = Int32.Parse(_tbSoLuong.Text);
                _ctPhieuNhap.SoLuong = _ctPhieuNhap.Sach.SoLuong;
                _ctPhieuNhap.Sach.NgayNhap = _dtNgayNhap.Value;
                _ctPhieuNhap.ThanhTien = _ctPhieuNhap.TriGia * _ctPhieuNhap.Sach.SoLuong;
                //Nếu sách đã có trong ds sách thì mới lấy dc ma sách
                _ctPhieuNhap.Sach.MaSach = _busSach.LayMaSach(_ctPhieuNhap.Sach.MaDauSach, _ctPhieuNhap.Sach.NamXB, _ctPhieuNhap.Sach.NhaXB);

                _PhieuNhap.DSCTPhieuNhap.Add(_ctPhieuNhap);
                _PhieuNhap.TongTriGia += _ctPhieuNhap.ThanhTien;
                HienThiLenDataGridView(_cbbTenDauSach.Text, _ctPhieuNhap.Sach.NamXB, _ctPhieuNhap.Sach.NhaXB,
                   _ctPhieuNhap.Sach.TriGia, _ctPhieuNhap.Sach.SoLuong, _ctPhieuNhap.ThanhTien);

               
                _DSDauSach.RemoveAt(_cbbTenDauSach.SelectedIndex);
                _cbbTenDauSach.Items.Clear();
                if (_DSDauSach != null && _DSDauSach.Count != 0)
                {
                    for (int i = 0; i < _DSDauSach.Count; i++)
                    {
                        try
                        {
                            _cbbTenDauSach.Items.Add(_DSDauSach[i].TenDauSach);
                        }
                        catch { }
                    }
                    _cbbTenDauSach.SelectedIndex = 0;
                }
                else
                    _btnAddDS.Enabled = false;
            }
            else
            {
                MessageBox.Show("Chưa Nhập Đầy Đủ Giá Trị");
            }
        }
        public void HienThiLenDataGridView(string tendausach, long namxb, string nhaxb,
            double trigia, int soluong, double thanhtien)
        {
            try
            {
                _tableDSTam.Rows.Add(tendausach, namxb.ToString(), nhaxb,
                    trigia.ToString(), soluong.ToString(), thanhtien.ToString());
            }
            catch { }
        }
        private void _btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (_PhieuNhap.DSCTPhieuNhap.Count <= 0)
            {
                MessageBox.Show("Lập phiếu thất bại");
                return;
            }
            _PhieuNhap.NgayNhap = _dtNgayNhap.Value;
            if(_busPhieuNhap.PhatSinhPhieuNhap(ref _PhieuNhap))
            {
                if(_busPhieuNhap.CapNhat(_PhieuNhap))
                {
                    for(int i=0;i<_PhieuNhap.DSCTPhieuNhap.Count;i++)
                    {
                     
                        if (_PhieuNhap.DSCTPhieuNhap[i].Sach.MaSach == null)
                        {
                            DTOSach sach = new DTOSach(_PhieuNhap.DSCTPhieuNhap[i].Sach);
                            if (_busSach.PhatSinhMaSach(ref sach))
                            {
                                //thêm loại sách vừa nhập vào , vào bảng sách
                                _PhieuNhap.DSCTPhieuNhap[i].Sach.MaSach = sach.MaSach;
                                if (_busSach.CapNhat(_PhieuNhap.DSCTPhieuNhap[i].Sach))
                                {

                                    //thêm số lượng cuốn sách vừa nhập vào , vào cuonsach
                                    for (int j = 0; j < _PhieuNhap.DSCTPhieuNhap[i].SoLuong; j++)
                                    {
                                        DTOCuonSach cuonsach = new DTOCuonSach(_PhieuNhap.DSCTPhieuNhap[i].Sach.MaSach, true);
                                        if (_busCuonSach.PhatSinhMaCuonSach(ref cuonsach))
                                        {
                                            if (_busCuonSach.CapNhat(cuonsach)) {

                                            }

                                        }
                                    }
                                }
                            }
                            //thêm ct phiếu nhập
                            if (_busCT_PhieuNhap.CapNhat(_PhieuNhap.DSCTPhieuNhap[i]))
                            {
                                SuKienCapNhat((object)"CapNhatSach");
                            }
                        }
                        else
                        {
                             int slthem = 0;
                            for (int j = 0; j < _PhieuNhap.DSCTPhieuNhap[i].SoLuong; j++)
                            {
                                DTOCuonSach cuonsach = new DTOCuonSach(_PhieuNhap.DSCTPhieuNhap[i].Sach.MaSach, true);
                                if (_busCuonSach.PhatSinhMaCuonSach(ref cuonsach))
                                {
                                    if (_busCuonSach.CapNhat(cuonsach))
                                    {
                                    
                                        slthem++;
                                    }
                                }
                            }
                            //cập nhật lại số lượng -cuốn sách
                            int soluongcu = _busSach.SoLuongSach(_PhieuNhap.DSCTPhieuNhap[i].Sach.MaSach);
                            if (soluongcu < 0)
                                soluongcu = 0;
                            int soluongmoi = soluongcu + slthem;
                            _busSach.CapNhatSoLuong(_PhieuNhap.DSCTPhieuNhap[i].Sach.MaSach, soluongmoi);

                            //thêm ct phiếu nhập
                            if (_busCT_PhieuNhap.CapNhat(_PhieuNhap.DSCTPhieuNhap[i]))
                            {
                               
                                SuKienCapNhat((object)"CapNhatSach");
                            }
                        }
                    }
                    MessageBox.Show("Thêm thành công ");
                    this.Close();
                }
            }
            
        }

        private void KeyPressNhapSo(object sender, KeyPressEventArgs e)
        {
            int keycode = (int)e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode == 45 || keycode == 46 || keycode == 8)
                e.Handled = false;
            else
            e.Handled = true;
        }

        private void _tbNamXB_Leave(object sender, EventArgs e)
        {
            int thoihanxb = _busQuyDinh.ThoiHanXB();
            if (thoihanxb > 0)
            {
                int nam = _dtNgayNhap.Value.Year;
                try {
                    if (Int32.Parse(_tbNamXB.Text) + thoihanxb < nam)
                    {
                        MessageBox.Show("Chỉ nhận các sách xuất bản trong vòng " + thoihanxb.ToString() + " năm");
                        _btnAddDS.Enabled = false;
                        _tbNamXB.Focus();
                    }
                    else
                        _btnAddDS.Enabled = true;
                }catch
                {
                    
                }
            }
        }

        private void _tbTriGia_Leave(object sender, EventArgs e)
        {
            try {
                if (Int32.Parse(_tbTriGia.Text) <= 0)
                {
                    MessageBox.Show("Trị Giá Lớn Hơn [0]");
                    _btnAddDS.Enabled = false;
                    _tbTriGia.Focus();
                }else
                    _btnAddDS.Enabled = true;
            }
            catch
            {
                _tbTriGia.Focus();
            }
        }

        private void _tbSoLuong_Leave(object sender, EventArgs e)
        {
            try {
                if (Int32.Parse(_tbSoLuong.Text) <= 0)
                {
                    MessageBox.Show("Trị Giá Lớn Hơn [0]");
                    _btnAddDS.Enabled = false;
                    _tbSoLuong.Focus();
                }
                else
                    _btnAddDS.Enabled = true;
            } catch
            {
                _tbSoLuong.Focus();
            }
        }

        private void _btnThoat_Click(object sender, EventArgs e)
        {
            if (_tableDSTam.Rows.Count != 0)
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

        private void _tbTriGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode == 8)
                e.Handled = false;
            else e.Handled = true;

        }

        private void _tbNamXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode == 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void _tbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode == 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void _tableDSTam_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            _btnLapPhieu.Enabled = true;
        }
    }
}
