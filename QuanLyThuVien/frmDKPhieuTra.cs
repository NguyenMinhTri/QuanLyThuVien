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
    public partial class frmDKPhieuTra : MetroFramework.Forms.MetroForm
    {
        private BUSDocGia _busDocGia = new BUSDocGia();
        private BUSCuonSach _busCuonSach=new BUSCuonSach();
        private BUSPhieuMuon _busPhieuMuon = new BUSPhieuMuon();
        private BUSPhieuTra _busPhieuTra = new BUSPhieuTra();
        private BUSCT_PhieuTra _busCT_PhieuTra = new BUSCT_PhieuTra();
        private BUSQuyDinh _busQuyDinh = new BUSQuyDinh();

        private DTOPhieuTra _PhieuTra=new DTOPhieuTra();
        private List<DTOCT_PhieuMuon> _DSSachDangMuon;
        private double _tienphat = 0;
        public frmDKPhieuTra()
        {
            InitializeComponent();
            _dtNgayTra.Value = DateTime.Today;
            _PhieuTra.NgayTra = DateTime.Today;
        }

        private void _tbMaDG_Leave(object sender, EventArgs e)
        {
            if ((_tbMaDG.Text != _PhieuTra.DocGia.MaDG || _PhieuTra.DocGia.MaDG == "") && _tbMaDG.Text != "")
            {
                DTODocGia docgia = _busDocGia.LayThongTinDG(_tbMaDG.Text);
                if (docgia == null)
                {
                    MessageBox.Show("Mã độc giả không tồn tại");
                    _tbMaDG.Text = _PhieuTra.DocGia.MaDG;
                }
                else
                {
                    _tienphat = 0;
                    _PhieuTra.DocGia = docgia;
                    _tbHoTen.Text = docgia.HoTen;
                    _DSSachDangMuon = _busPhieuMuon.LayDSSachDangMuon(docgia.MaDG);
                    if (_PhieuTra.DSCTPhieuTra != null)
                        _PhieuTra.DSCTPhieuTra.Clear();
                    try
                    {
                        _tableSach.Rows.Clear();
                    }
                    catch { }
                }
            }
            else
                _btnLapPhieu.Enabled = false;
        }
        public bool KiemTraSachMuonChuaTra(string macuonsach)
        {
            for (int i = 0; i < _DSSachDangMuon.Count; i++)
                if (macuonsach == _DSSachDangMuon[i].MaCuonSach)
                    return true;
            return false;
        }
        public bool KiemTraTrungMaSach(string macuonsach)
        {
            for (int i = 0; i < _PhieuTra.DSCTPhieuTra.Count; i++)
                if (macuonsach == _PhieuTra.DSCTPhieuTra[i].CTPhieuMuon.MaCuonSach)
                    return true;
            return false;
        }
        public DTOCT_PhieuTra LayDuLieuForm()
        {
            if (_tbMaDG.Text == "")
            {
                MessageBox.Show("Chưa nhập mã độc giả");
                return null;
            }


            if (_tbMaSach.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sách");
                return null;
            }


            if (KiemTraTrungMaSach(_tbMaSach.Text))
            {
                MessageBox.Show("Mã sách đã tồn tại trong danh sách");
                return null;
            }


            DTOCuonSach cuonsach = _busCuonSach.LayThongTinCuonSach(_tbMaSach.Text);
            if (cuonsach == null)
            {
                MessageBox.Show("Mã sách không tồn tại");
                return null;
            }


          


            if (!KiemTraSachMuonChuaTra(cuonsach.MaCuonSach))
            {
                MessageBox.Show("Độc giả không mượn sách này");
                return null;
            }


            string maphieumuon = "";
            for (int i = 0; i < _DSSachDangMuon.Count; i++)
            {
                if (cuonsach.MaCuonSach == _DSSachDangMuon[i].MaCuonSach)
                {
                    maphieumuon = _DSSachDangMuon[i].MaPhieuMuon;
                    break;
                }
            }


            DateTime ngaymuon = new DateTime();
            object obj = _busPhieuMuon.LayNgayMuon(maphieumuon);
            if (obj == null)
            {
                MessageBox.Show("Không lấy được ngày mượn");
                return null;
            }
            else
            {
                try
                {
                    ngaymuon = (DateTime)obj;
                }
                catch
                {
                    MessageBox.Show("Sai dữ liệu ngày mượn");
                    return null;
                }

                TimeSpan timespan;
                try
                {
                    timespan = _PhieuTra.NgayTra.Subtract(ngaymuon);
                }
                catch
                {
                    MessageBox.Show("Không tính được số ngày mượn");
                    return null;
                }

                int songaymuon = (int)timespan.TotalDays;
                double tienphatmoingay = _busQuyDinh.LayTienPhatMoiNgay();
                if (tienphatmoingay < 0)
                {
                    MessageBox.Show("Không lấy được quy định số tiền phạt mỗi ngày");
                    return null;
                }

                int songaymuontd = _busQuyDinh.LaySoNgayMuonTD();
                if (songaymuontd < 0)
                {
                    MessageBox.Show("Không lấy được số ngày mượn tối đa");
                    return null;
                }

                double tienphat;
                if (songaymuon < songaymuontd)
                    tienphat = 0.0F;
                else
                    tienphat = (songaymuon - songaymuontd) * tienphatmoingay;

                DTOCT_PhieuTra ctptr = new DTOCT_PhieuTra();
                ctptr.CTPhieuMuon = new DTOCT_PhieuMuon(maphieumuon, cuonsach.MaCuonSach);
                ctptr.SoNgayMuon = songaymuon;
                ctptr.TienPhat = tienphat;
               
                 
                try
                {
                    _tableSach.Rows.Add(cuonsach.MaCuonSach, ngaymuon.ToString("dd/MM/yyyy"), songaymuon.ToString(), tienphat.ToString());
                }
                catch
                {
                    MessageBox.Show("Không hiển thị lên data grid view được");
                    return null;
                }

                return ctptr;
            }
        }
        private void _btnThemSach_Click(object sender, EventArgs e)
        {
            DTOCT_PhieuTra ctptr = LayDuLieuForm();
            if (ctptr != null)
            {
                _PhieuTra.DSCTPhieuTra.Add(ctptr);
                _PhieuTra.TongTienPhat += ctptr.TienPhat;
                _tbTienPhat.Text = _PhieuTra.TongTienPhat.ToString();
                _tbTongNo.Text = (_PhieuTra.DocGia.TongNo + _PhieuTra.TongTienPhat).ToString();
            }
        }

        private void _btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (_PhieuTra.DSCTPhieuTra.Count == 0)
                MessageBox.Show("Chưa nhập mã sách nào");
            else
            {
                double tienthukynay;
                try
                {
                    tienthukynay = 0;
                }
                catch
                {
                    MessageBox.Show("Nhập sai tiền thu");
                    return;
                }

                if (tienthukynay < 0.0F || tienthukynay > _PhieuTra.TongTienPhat)
                {
                    MessageBox.Show("Tiền thu không được nhỏ hơn 0 hoặc lớn hơn tổng tiền phạt");
                    return;
                }

             
                _PhieuTra.ConLai = _PhieuTra.TongTienPhat + _PhieuTra.DocGia.TongNo;
                if (_busPhieuTra.PhatSinhMaPhieuTra(ref _PhieuTra))
                {
                    if (_busPhieuTra.CapNhat(_PhieuTra))
                    {
                        int dem = 0;
                        for (int i = 0; i < _PhieuTra.DSCTPhieuTra.Count; i++)
                        {
                            if (_busCT_PhieuTra.CapNhat(_PhieuTra.DSCTPhieuTra[i]))
                            {
                                _busCuonSach.CapNhatTinhTrang(_PhieuTra.DSCTPhieuTra[i].CTPhieuMuon.MaCuonSach, true);
                                dem++;
                            }
                        }
                        if (_busDocGia.CapNhatTongNo(_PhieuTra.DocGia.MaDG, _PhieuTra.DocGia.TongNo + _PhieuTra.TongTienPhat))
                            _PhieuTra.DocGia.TongNo = _PhieuTra.DocGia.TongNo + _PhieuTra.ConLai;

                        MessageBox.Show("Lập phiếu trả sách thành công");
                        Reset();
                            

                    }
                    else
                        MessageBox.Show("Lập phiếu trả thất bại");
                }
                else
                    MessageBox.Show("Không tạo được mã phiếu trả");
            }
        }
        void Reset()
        {
            _tbHoTen.Text = "";
            _tbMaDG.Text = "";
            _tbTienPhat.Text = "";
            _tbTongNo.Text = "";
            _tienphat = 0;
            _tableSach.Rows.Clear();
        }

        private void _btnThoat_Click(object sender, EventArgs e)
        {
            if (_tableSach.Rows.Count != 0)
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
            Reset();
        }

        private void _tbMaDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode == 8)
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
