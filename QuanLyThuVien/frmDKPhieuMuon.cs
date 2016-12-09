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
    public partial class frmDKPhieuMuon : MetroFramework.Forms.MetroForm
    {
        private BUSPhieuMuon _busPhieuMuon=new BUSPhieuMuon();
        private BUSDocGia _busDocGia=new BUSDocGia();
        private BUSTheLoai _busTheLoai=new BUSTheLoai();
        private BUSTacGia _busTacGia=new BUSTacGia();
        private BUSCuonSach _busCuonSach=new BUSCuonSach();
        private BUSCT_PhieuMuon _busCT_PhieuMuon=new BUSCT_PhieuMuon();
        private BUSQuyDinh _busQuyDinh=new BUSQuyDinh();

        private DTOPhieuMuon _PhieuMuon;


        public frmDKPhieuMuon()
        {
            InitializeComponent();
            _PhieuMuon = new DTOPhieuMuon();
            _dtNgayMuon.Value = DateTime.Today;
        }

        private void _tbMaDG_Leave(object sender, EventArgs e)
        {
            if ((_tbMaDG.Text != _PhieuMuon.DocGia.MaDG || _PhieuMuon.DocGia.MaDG == "") && _tbMaDG.Text != "")
            {
                DTODocGia docgia = _busDocGia.LayThongTinDG(_tbMaDG.Text);
                if (docgia == null)
                {
                    MessageBox.Show("Thất bại");
                    _tbMaDG.Text = _PhieuMuon.DocGia.MaDG;
                }
                else
                {
                    _PhieuMuon.DocGia = docgia;
                    _tbHoTen.Text = docgia.HoTen;
                    if (_PhieuMuon.DSCTPhieuMuon != null)
                        _PhieuMuon.DSCTPhieuMuon.Clear();
                    try
                    {
                        _tableDS.Rows.Clear();
                    }
                    catch { }
                }
            }
            else
                _btnLapPhieu.Enabled = false;
        }

        private void _tbMaSachMuon_Leave(object sender, EventArgs e)
        {

        }
        public bool KiemTraTrungMaSach(string macuonsach)
        {
            for (int i = 0; i < _PhieuMuon.DSCTPhieuMuon.Count; i++)
                if (macuonsach == _PhieuMuon.DSCTPhieuMuon[i].MaCuonSach)
                    return true;
            return false;
        }
        public void HienThiLenDataGridView(string macuonsach, string tensach, List<string> dstentg, string tentl)
        {
            string tentg = dstentg[0];
            if (dstentg.Count > 1)
                for (int i = 1; i < dstentg.Count; i++)
                    tentg += ", " + dstentg[i];
            try
            {
                _tableDS.Rows.Add(macuonsach, tensach, tentg, tentl);
            }
            catch
            { }
        }
        public DTOCT_PhieuMuon LayDuLieuForm()
        {
            if (_tbMaDG.Text == "")
            {
                MessageBox.Show("Chưa nhập mã độc giả");
                return null;
            }

            if (_tbMaSachMuon.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sách");
                return null;
            }
            string macuonsach = _busCuonSach.MaCuonSachMuonDuoc(_tbMaSachMuon.Text);
            if (KiemTraTrungMaSach(macuonsach))
            {
                MessageBox.Show("Mã sách đã tồn tại trong sanh sách");
                return null;
            }
           
           
            if (macuonsach == null)
            {
                MessageBox.Show("Cuốn sách không tồn tại hoặc hết sách mượn");
                return null;
            }

           

            string tensach = _busCuonSach.LayTenDauSach(macuonsach);
            if (tensach == null)
            {
                MessageBox.Show("Không lấy được tên sách");
                tensach = "";
            }

            string matl = _busCuonSach.LayMaTL(macuonsach);
            string tentl = "";
            if (matl == null)
                MessageBox.Show("Không lấy được mã thể loại");
            else
            {
                tentl = _busTheLoai.LayTenTheLoai(matl);
                if (tentl == null)
                {
                    MessageBox.Show("Không lấy được tên thể loại");
                    tentl = "";
                }
            }

            List<DTOTacGia> dstacgia = _busCuonSach.LayDSTacGia(macuonsach);
            List<string> dstentacgia = new List<string>();
            if (dstacgia == null)
                MessageBox.Show("Không lấy được danh sách tác giả");
            else if (dstacgia.Count == 0)
                MessageBox.Show("Sách này chưa có tác giả nào");
            else
            {
                foreach (DTOTacGia tacgia in dstacgia)
                    dstentacgia.Add(tacgia.TenTG);
            }
            HienThiLenDataGridView(_tbMaSachMuon.Text, tensach, dstentacgia, tentl);

            DTOCT_PhieuMuon ctpmu = new DTOCT_PhieuMuon();
            ctpmu.MaCuonSach = macuonsach;

            return ctpmu;
        }

        private void _btnThemDS_Click(object sender, EventArgs e)
        {
            if (_PhieuMuon.DocGia.MaDG != "")
            {
                int sosachmuontd = _busQuyDinh.LaySoSachMuonTD();
                int sosachdangmuon = _busPhieuMuon.DemSoSachDangMuon(_PhieuMuon.DocGia.MaDG);
                if (sosachdangmuon >= sosachmuontd)
                {
                    MessageBox.Show("Độc giả đã mượn " + sosachmuontd.ToString() + " sách, không mượn thêm được nữa");
                    return;
                }
                else

                { 
                    int sosachmuonmuon = _PhieuMuon.DSCTPhieuMuon.Count;
                    if (sosachmuonmuon >= sosachmuontd - sosachdangmuon)
                    {
                        MessageBox.Show("Độc giả đã mượn " + sosachdangmuon
                            + " sách, chỉ có thể mượn thêm " + (sosachmuontd - sosachdangmuon).ToString() + " sách");
                        return;
                    }
                }
            }
            DTOCT_PhieuMuon ctpmu = LayDuLieuForm();
            if (ctpmu != null)
                _PhieuMuon.DSCTPhieuMuon.Add(ctpmu);
        }

        private void _btnLapPhieu_Click(object sender, EventArgs e)
        {
            if (_PhieuMuon.DSCTPhieuMuon.Count == 0)
            {
                MessageBox.Show("Chưa nhập mã sách nào");
                return;
            }

            _PhieuMuon.NgayMuon = _dtNgayMuon.Value;
            if (_PhieuMuon.DocGia.NgayHetHan < _PhieuMuon.NgayMuon)
            {
                MessageBox.Show("Thẻ độc giả đã hết hạn");
                return;
            }

            if (!_busPhieuMuon.KiemTraQD(_PhieuMuon))
                return;

            if (!_busPhieuMuon.TinhNgayHetHan(ref _PhieuMuon))
                return;

            if (!_busPhieuMuon.PhatSinhMaPhieuMuon(ref _PhieuMuon))
            {
                MessageBox.Show("Không tạo được mã phiếu mượn");
                return;
            }
            else
            {
                for (int i = 0; i < _PhieuMuon.DSCTPhieuMuon.Count; i++)
                    _PhieuMuon.DSCTPhieuMuon[i].MaPhieuMuon = _PhieuMuon.MaPhieuMuon;
            }

            if (_busPhieuMuon.CapNhat(_PhieuMuon))
            {
                int dem = 0;
                for (int i = 0; i < _PhieuMuon.DSCTPhieuMuon.Count; i++)
                {
                    if (_busCT_PhieuMuon.CapNhat(_PhieuMuon.DSCTPhieuMuon[i]))
                    {
                        _busCuonSach.CapNhatTinhTrang(_PhieuMuon.DSCTPhieuMuon[i].MaCuonSach, false);
                        dem++;
                    }
                }
                MessageBox.Show("Lập phiếu mượn thành công");
                _tbMaDG.Clear();
                _tbHoTen.Clear();
                _tbMaSachMuon.Clear();
                _tableDS.Rows.Clear();
            }
            else
                MessageBox.Show("Lập phiếu mượn thất bại");
        }

        private void _btnThoat_Click(object sender, EventArgs e)
        {
            if (_tableDS.Rows.Count!= 0)
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
            _tbMaDG.Clear();
            _tbHoTen.Clear();
            _tbMaSachMuon.Clear();
            _tableDS.Rows.Clear();
        }

        private void _tbMaDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode==8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void _tbMaSachMuon_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode == 8)
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
