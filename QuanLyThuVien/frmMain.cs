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
    public partial class frmMain : Form
    {
        BUSDocGia _busDocGia;
        BUSLoaiDocGia _busLoaiDG;
        BUSPhieuNhap _busPhieuNhap;
        BUSPhieuMuon _busPhieuMuon;
        BUSDauSach _busDauSach;
        BUSTheLoai _busTheLoai;
        BUSCuonSach _busCuonSach;
        BUSTacGia _busTacGia;
        BUSQuyDinh _busQuyDinh;
        BUSSach _busSach;
        BUSCT_TacGia _busCT_TacGia;
        BUSCT_PhieuNhap _busCT_PhieuNhap;
        BUSPhieuThu _busPhieuThu;
        BUSPhieuTra _busPhieuTra;
        List<string> _dsTenTacGiaTheoSach;
        List<string> _dsTenTacGia;
        List<DTOTacGia> _dsTacGia;
        List<DTOTheLoai> _dsTheLoai;
        public frmMain()
        {
            InitializeComponent();
            _busDocGia = new BUSDocGia();
            _busLoaiDG = new BUSLoaiDocGia();
            _busPhieuNhap = new BUSPhieuNhap();
            _busDauSach = new BUSDauSach();
            _busTheLoai = new BUSTheLoai();
            _busTacGia = new BUSTacGia();
            _busQuyDinh = new BUSQuyDinh();
            _busCT_PhieuNhap = new BUSCT_PhieuNhap();
            _busCuonSach = new BUSCuonSach();
            _busSach = new BUSSach();
            _busCT_TacGia = new BUSCT_TacGia();
            _dsTheLoai = new List<DTOTheLoai>();
            _busPhieuTra = new BUSPhieuTra();
            _busPhieuMuon = new BUSPhieuMuon();
            _busPhieuThu = new BUSPhieuThu();
            //

            PhanQuyen();


        }
        //Các hàm load du lieu vao data gridview
        void DSSach()
        {
            DataTable data = _busSach.LayThongTinSach();
            if (data != null)
            {
                _tableSach.DataSource = data;
                if (data.Rows.Count != 0)
                    _btnCapNhatSach.Enabled = _btnXoaSach.Enabled = true;
                else
                {
                    _tbSach_MaSach.Text = "";
                    _tbSach_NamXB.Text = "";
                    _tbSach_NhaXB.Text = "";
                    _tbSach_SoLuong.Text = "";
                    _tbSach_SoMuon.Text = "";
                    _tbSach_TacGia.Text = "";
                    _tbSach_TenDauSach.Text = "";
                    _tbSach_TheLoai.Text = "";
                    _tbSach_TriGia.Text = "";
                    _dtSach_NgayNhap.Text = "";
                    _btnCapNhatSach.Enabled = _btnXoaSach.Enabled = false;
                }
            }
            else
                MessageBox.Show("Thất bại");
        }
        void DSDG()
        {
            DataTable data = _busDocGia.DanhSachDocGia();
            if (data == null)
                MessageBox.Show("Không lấy được danh sách độc giả");
            else
            {
                _tableDocGia.DataSource = _busDocGia.DanhSachDocGia();
                if (data.Rows.Count != 0)
                    _btnCapNhatDocGia.Enabled = _btnXoaDocGia.Enabled = true;
                else
                {
                    resetChiTietDG();
                    _btnCapNhatDocGia.Enabled = _btnXoaDocGia.Enabled = false;
                }
            }
        }
        void DSLoaiDG()
        {
            DataTable data = _busLoaiDG.LayDataDG();
            if (data == null)
                MessageBox.Show("Không lấy được danh sách độc giả");
            else
            {
                _tableLoaiDG.DataSource = data;
                if (data.Rows.Count != 0)
                    _btnCapNhatLoaiDocGia.Enabled = _btnXoaLoaiDocGia.Enabled = true;
                else
                    _btnCapNhatLoaiDocGia.Enabled = _btnXoaLoaiDocGia.Enabled = false;
            }
        }
        void DSPN()
        {
            DataTable data = _busPhieuNhap.DanhSachPhieuNhap();
            if (data != null)
            {
                _tablePhieuNhap.DataSource = data;

            }
            else
            {
                MessageBox.Show("Không lấy được danh sách phiếu nhập");
            }
        }
        void DSDauSach()
        {
            DataTable data = _busDauSach.LayDuLieuBangDauSach();
            if (data != null)
            {
                _tableDauSach.DataSource = data;
                if (data.Rows.Count != 0)
                    _btnCapNhatDauSach.Enabled = _btnXoaDauSach.Enabled = true;
                else
                    _btnCapNhatDauSach.Enabled = _btnXoaDauSach.Enabled = false;

            }
            else
            {
                MessageBox.Show("Không lấy được danh sách đầu sách");
            }
        }
        void DSTL()
        {
            DataTable data = _busTheLoai.LayDanhSachTheLoai();
            if (data != null)
            {
                _tableTheLoai.DataSource = data;
                if (data.Rows.Count != 0)
                    _btnCapNhatTheLoai.Enabled = _btnXoaTheLoai.Enabled = true;
                else
                    _btnCapNhatTheLoai.Enabled = _btnXoaTheLoai.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không lấy dược danh sách thể loại");
            }
        }
        void DSTG()
        {
            DataTable data = _busTacGia.DanhSachTacGia();
            if (data != null)
            {
                _tableTacGia.DataSource = data;
                if (data.Rows.Count != 0)
                    _btnCapNhatTacGia.Enabled = _btnXoaTacGia.Enabled = true;
                else
                    _btnCapNhatTacGia.Enabled = _btnXoaTacGia.Enabled = false;
            }
            else
            {
                MessageBox.Show("Không lấy được danh sách tác giả");
            }
        }
        //Load dữ liệu đỗ vào datagridview Sach

        private void _tileDSSach_Click(object sender, EventArgs e)
        {
            DSSach();
            KhoiTaoTimSach();



            if (_tabControl.Controls.IndexOf(_mTabDSSach) == -1)
            {
                _tabControl.Controls.Add(_mTabDSSach);
                _tabControl.SelectedTab = _mTabDSSach;
            }
            else
                _tabControl.SelectedTab = _mTabDSSach;
        }
        private void _tileDSDG_Click(object sender, EventArgs e)
        {
            _lbTenBangDocGia.Text = "Danh Sách Độc Giả";
            DSDG();


            if (_tabControl.Controls.IndexOf(_mtabDSDocGia) == -1)
            {
                _tabControl.Controls.Add(_mtabDSDocGia);
                _tabControl.SelectedTab = _mtabDSDocGia;
            }
            else
                _tabControl.SelectedTab = _mtabDSDocGia;
        }

        private void _tileDSLoaiDG_Click(object sender, EventArgs e)
        {
            DSLoaiDG();

            if (_tabControl.Controls.IndexOf(_mTabDSLoaiDG) == -1)
            {
                _tabControl.Controls.Add(_mTabDSLoaiDG);
                _tabControl.SelectedTab = _mTabDSLoaiDG;
            }
            else
                _tabControl.SelectedTab = _mTabDSLoaiDG;
        }

        private void _tileDSPN_Click(object sender, EventArgs e)
        {

            DSPN();

            if (_tabControl.Controls.IndexOf(_mTabDSCTPN) == -1)
            {
                _tabControl.Controls.Add(_mTabDSCTPN);
                _tabControl.SelectedTab = _mTabDSCTPN;
            }
            else
                _tabControl.SelectedTab = _mTabDSCTPN;
        }

        private void _tileDSDauSach_Click(object sender, EventArgs e)
        {
            DSDauSach();

            if (_tabControl.Controls.IndexOf(_mTabDSDauSach) == -1)
            {
                _tabControl.Controls.Add(_mTabDSDauSach);
                _tabControl.SelectedTab = _mTabDSDauSach;
            }
            else
                _tabControl.SelectedTab = _mTabDSDauSach;


        }

        private void _tileDSTL_Click(object sender, EventArgs e)
        {
            DSTL();

            if (_tabControl.Controls.IndexOf(_mTabDSTheLoai) == -1)
            {
                _tabControl.Controls.Add(_mTabDSTheLoai);
                _tabControl.SelectedTab = _mTabDSTheLoai;
            }
            else
                _tabControl.SelectedTab = _mTabDSTheLoai;
        }

        private void _tileDSTG_Click(object sender, EventArgs e)
        {
            DSTG();
            if (_tabControl.Controls.IndexOf(_mTabDSTacGia) == -1)
            {
                _tabControl.Controls.Add(_mTabDSTacGia);
                _tabControl.SelectedTab = _mTabDSTacGia;
            }
            else
                _tabControl.SelectedTab = _mTabDSTacGia;
        }

        private void _tableLoaiDG_SelectionChanged(object sender, EventArgs e)
        {
            var oBject = (MetroFramework.Controls.MetroGrid)sender;
            if (oBject.CurrentRow != null)
            {
                DTOLoaiDG loaiDG = new DTOLoaiDG();
                _tbLDG_MaLoaiDG.Text = (string)oBject.Rows[oBject.CurrentRow.Index].Cells[0].Value;
                _tbLDG_TenLoaiDG.Text = (string)oBject.Rows[oBject.CurrentRow.Index].Cells[1].Value;
            }
        }

        private void _tableDocGia_SelectionChanged(object sender, EventArgs e)
        {
            DTODocGia docgia = new DTODocGia();
            var oBject = (MetroFramework.Controls.MetroGrid)sender;
            if (oBject.CurrentRow != null)
            {
                //khởi tạo độc giả
                docgia.MaDG = (string)oBject.Rows[oBject.CurrentRow.Index].Cells[0].Value;
                docgia.MaLoaiDG = (string)oBject.Rows[oBject.CurrentRow.Index].Cells[1].Value;
                docgia.HoTen = (string)oBject.Rows[oBject.CurrentRow.Index].Cells[2].Value;
                docgia.NgaySinh = (DateTime)oBject.Rows[oBject.CurrentRow.Index].Cells[3].Value;
                docgia.DiaChi = (string)oBject.Rows[oBject.CurrentRow.Index].Cells[4].Value;
                docgia.Email = (string)oBject.Rows[oBject.CurrentRow.Index].Cells[5].Value;
                docgia.NgayLapThe = (DateTime)oBject.Rows[oBject.CurrentRow.Index].Cells[6].Value;
                docgia.NgayHetHan = (DateTime)oBject.Rows[oBject.CurrentRow.Index].Cells[7].Value;
                docgia.TongNo = Convert.ToDouble(oBject.Rows[oBject.CurrentRow.Index].Cells[8].Value);
                //Khởi tạo danh sách tên loại độc giả
                List<DTOLoaiDG> _DSLoaiDG = new List<DTOLoaiDG>();
                _DSLoaiDG = _busLoaiDG.LayDSLoaiDG();
                if (_DSLoaiDG == null)
                {
                    MessageBox.Show("Không lấy được danh sách loại độc giả");
                    return;
                }
                else
                {
                    _cbbDG_LoaiDG.Items.Clear();
                    for (int i = 0; i < _DSLoaiDG.Count; i++)
                    {
                        try
                        {
                            _cbbDG_LoaiDG.Items.Add(_DSLoaiDG[i].TenLoaiDG);
                        }
                        catch
                        { }
                    }
                    _cbbDG_LoaiDG.SelectedIndex = 0;
                }
                //
                _dtDG_NgayLT.ButtonDropDown.Visible = false;
                _dtDG_NgayLT.IsInputReadOnly = true;
                //
                for (int i = 0; i < _DSLoaiDG.Count; i++)
                {

                    if (_DSLoaiDG[i].MaLoaiDG == docgia.MaLoaiDG)
                        _cbbDG_LoaiDG.SelectedIndex = i;
                }
                //
                _tbDG_HoTen.Text = docgia.HoTen;
                _tbDG_DiaChi.Text = docgia.DiaChi;
                _tbDG_Email.Text = docgia.Email;
                _tbDG_TongNo.Text = docgia.TongNo.ToString();
                _dtDG_NgayLT.Value = docgia.NgayLapThe;
                _dtDG_NgayHH.Value = docgia.NgayHetHan;
                _dtDG_NgaySinh.Value = docgia.NgaySinh;
                _tbDG_MaDG.Text = docgia.MaDG;

            }
        }

        private void _tableSach_SelectionChanged(object sender, EventArgs e)
        {
            var oBject = (MetroFramework.Controls.MetroGrid)sender;

            if (oBject.CurrentRow != null)
            {
                DTODauSach dausach;
                DTOSach sach;
                string masach;
                try {
                    _panelTimSach.Expanded = false;
                    masach = (string)oBject.Rows[oBject.CurrentRow.Index].Cells["_dgw_txtMaSach"].Value;
                    BUSSach busSach = new BUSSach();
                    sach = busSach.LaySach(masach);
                    string madausach = sach.MaDauSach;
                    BUSDauSach busDauSach = new BUSDauSach();
                    dausach = busDauSach.DauSach(madausach);
                } catch
                {
                    return;
                }
                //
                _tbSach_TenDauSach.Text = dausach.TenDauSach;
                _tbSach_TheLoai.Text = dausach.TheLoai.TenTheLoai;
                _tbSach_TacGia.Text = "";
                for (int i = 0; i < dausach.DSCT_TacGia.Count; i++)
                {
                    _tbSach_TacGia.Text += dausach.DSCT_TacGia[0].TacGia.TenTG + ", ";
                }
                _tbSach_MaSach.Text = masach;
                _tbSach_NamXB.Text = sach.NamXB.ToString();
                _tbSach_NhaXB.Text = sach.NhaXB;
                _dtSach_NgayNhap.Value = sach.NgayNhap;
                _tbSach_TriGia.Text = sach.TriGia.ToString();
                _tbSach_SoLuong.Text = sach.SoLuong.ToString();
                int sosachdangmuon = _busCuonSach.DemSoSachMuon(sach.MaSach);
                if (sosachdangmuon < 0)
                    sosachdangmuon = 0;
                _tbSach_SoMuon.Text = sosachdangmuon.ToString();

            }
        }

        private void _tableDauSach_SelectionChanged(object sender, EventArgs e)
        {
            _dsTenTacGia = new List<string>();
            var oBject = (MetroFramework.Controls.MetroGrid)sender;
            if (oBject.CurrentRow != null)
            {
                DTODauSach dausach = new DTODauSach();
                try {
                    dausach.MaDauSach = oBject.Rows[oBject.CurrentRow.Index].Cells["_dgw_txtMaDS"].Value.ToString();
                    dausach.TenDauSach = oBject.Rows[oBject.CurrentRow.Index].Cells["_dgw_txtTenDS"].Value.ToString();
                    dausach.TheLoai.MaTheLoai = oBject.Rows[oBject.CurrentRow.Index].Cells[3].Value.ToString();
                    dausach.TheLoai.TenTheLoai = oBject.Rows[oBject.CurrentRow.Index].Cells["_dgw_txtTenTheLoai"].Value.ToString();
                }
                catch { return; }
                //Khoi tao cac commbobox
                _cbbDS_TG1.SelectedIndex = _cbbDS_TG2.SelectedIndex = _cbbDS_TheLoai.SelectedIndex = -1;
                _dsTacGia = _busTacGia.listTacGia();
                _dsTenTacGiaTheoSach = _busDauSach.LayDSTenTG(dausach.MaDauSach);
                _cbbDS_TG1.Items.Clear();
                _cbbDS_TG2.Items.Clear();
                for (int i = 0; i < _dsTacGia.Count; i++)
                {
                    _cbbDS_TG1.Items.Add(_dsTacGia[i].TenTG);
                    _cbbDS_TG2.Items.Add(_dsTacGia[i].TenTG);
                    _dsTenTacGia.Add(_dsTacGia[i].TenTG);
                }
                _dsTheLoai = _busTheLoai.ListTheLoai();
                _cbbDS_TheLoai.Items.Clear();
                for (int i = 0; i < _dsTheLoai.Count; i++)
                {
                    _cbbDS_TheLoai.Items.Add(_dsTheLoai[i].TenTheLoai);
                }
                try
                {
                    _cbbDS_TheLoai.SelectedIndex = _cbbDS_TheLoai.Items.IndexOf(dausach.TheLoai.TenTheLoai);

                    _cbbDS_TG1.SelectedIndex = _cbbDS_TG1.Items.IndexOf(_dsTenTacGiaTheoSach[0]);
                    if (_dsTenTacGiaTheoSach.Count > 1)
                        _cbbDS_TG2.SelectedIndex = _cbbDS_TG2.Items.IndexOf(_dsTenTacGiaTheoSach[1]);
                }
                catch { }
                //
                _tbDS_TenDauSach.Text = dausach.TenDauSach;
                _tbDS_MaDauSach.Text = dausach.MaDauSach;


            }
        }

        private void _tableTheLoai_SelectionChanged(object sender, EventArgs e)
        {
            var oBject = (MetroFramework.Controls.MetroGrid)sender;
            if (oBject.CurrentRow != null)
            {

                _tbTL_MaTL.Text = (string)oBject.Rows[oBject.CurrentRow.Index].Cells[0].Value;
                _tbTL_TenTL.Text = (string)oBject.Rows[oBject.CurrentRow.Index].Cells[1].Value;
            }
        }

        private void _tableTacGia_SelectionChanged(object sender, EventArgs e)
        {
            var oBject = (MetroFramework.Controls.MetroGrid)sender;
            if (oBject.CurrentRow != null)
            {

                _tbTG_MaTG.Text = (string)oBject.Rows[oBject.CurrentRow.Index].Cells[0].Value;
                _tbTG_TenTG.Text = (string)oBject.Rows[oBject.CurrentRow.Index].Cells[1].Value;
            }
        }

        private void _btnCapNhatLoaiDocGia_Click(object sender, EventArgs e)
        {
            DTOLoaiDG loaiDG = new DTOLoaiDG();
            if (_tbLDG_MaLoaiDG.Text != "" && _tbLDG_TenLoaiDG.Text != "")
            {
                loaiDG.MaLoaiDG = _tbLDG_MaLoaiDG.Text;
                loaiDG.TenLoaiDG = _tbLDG_TenLoaiDG.Text;
                if (_busLoaiDG.CapNhat(loaiDG))
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                    DSLoaiDG();

                }
                else
                {
                    MessageBox.Show("Cập Nhật Thất Bại");
                }
            }
            else
            {
                MessageBox.Show("Cập Nhật Thất Bại");
            }
        }

        private void _btnCapNhatTacGia_Click(object sender, EventArgs e)
        {
            DTOTacGia tacgia = new DTOTacGia();
            if (_tbTG_MaTG.Text != "" && _tbTG_TenTG.Text != "")
            {
                tacgia.TenTG = _tbTG_TenTG.Text;
                tacgia.MaTG = _tbTG_MaTG.Text;
                if (_busTacGia.CapNhat(tacgia))
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                    DSTG();
                }
                else
                    MessageBox.Show("Cập Nhật Thất Bại");

            }
            else
                MessageBox.Show("Cập Nhật Thất Bại");
        }

        private void _btnCapNhatTheLoai_Click(object sender, EventArgs e)
        {
            DTOTheLoai theloai = new DTOTheLoai();
            if (_tbTL_MaTL.Text != "" && _tbTL_TenTL.Text != "")
            {
                theloai.MaTheLoai = _tbTL_MaTL.Text;
                theloai.TenTheLoai = _tbTL_TenTL.Text;
                if (_busTheLoai.CapNhat(theloai))
                {
                    MessageBox.Show("Cập Nhật Thành Công");
                    DSTL();
                }
                else
                    MessageBox.Show("Cập Nhật Thất Bại");

            }
            else
                MessageBox.Show("Cập Nhật Thất Bại");
        }

        private void _btnCapNhatDauSach_Click(object sender, EventArgs e)
        {

            if (_tbDS_TenDauSach.Text != "" && _cbbDS_TG1.Text != "" && _cbbDS_TheLoai.Text != "" && _tbDS_MaDauSach.Text != "")
            {
                DTODauSach dausach = new DTODauSach();
                string tentg, matg;
                dausach.MaDauSach = _tbDS_MaDauSach.Text;
                dausach.TenDauSach = _tbDS_TenDauSach.Text;
                dausach.TheLoai.MaTheLoai = _dsTheLoai[_cbbDS_TheLoai.SelectedIndex].MaTheLoai;
                tentg = _cbbDS_TG1.Text;
                matg = _dsTacGia[_cbbDS_TG1.SelectedIndex].MaTG;
                dausach.DSCT_TacGia.Add(new DTOCT_TacGia(new DTOTacGia(matg, tentg)));
                if (_cbbDS_TG2.SelectedIndex != -1)
                {
                    tentg = _cbbDS_TG2.Text;
                    int index = _dsTenTacGia.IndexOf(_cbbDS_TG2.Text);
                    matg = _dsTacGia[index].MaTG;
                    dausach.DSCT_TacGia.Add(new DTOCT_TacGia(new DTOTacGia(matg, tentg)));
                }
                _busCT_TacGia.Xoa(dausach.MaDauSach);
                if (_busDauSach.CapNhat(dausach))
                    for (int i = 0; i < dausach.DSCT_TacGia.Count; i++)
                    {
                        dausach.DSCT_TacGia[i].MaDauSach = dausach.MaDauSach;
                        if (_busCT_TacGia.CapNhat(dausach.DSCT_TacGia[i]))
                        {

                            DSDauSach();
                        }
                        else
                        {
                            MessageBox.Show("Cập Nhật Thất Bại");
                        }


                    }
                else
                    MessageBox.Show("Cập Nhật Thất Bại");
                MessageBox.Show("Cập Nhật Thành Công");
            }
            else
                MessageBox.Show("Cập Nhật Thất Bại");
        }

        private void _cbbDS_TG1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cbbDS_TG2.SelectedIndex = -1;
            try {
                _cbbDS_TG2.Items.Clear();
                for (int i = 0; i < _dsTacGia.Count; i++)
                    _cbbDS_TG2.Items.Add(_dsTacGia[i].TenTG);

                if (_cbbDS_TG1.Items.Count > 0)
                {
                    int indexRemove = _cbbDS_TG1.Items.IndexOf(_cbbDS_TG1.Text);
                    _cbbDS_TG2.Items.RemoveAt(indexRemove);

                }

            }
            catch { }
        }

        private void _btnCapNhatSach_Click(object sender, EventArgs e)
        {
            if (_tbSach_MaSach.Text != "" && _tbSach_TenDauSach.Text != "" && _tbSach_TheLoai.Text != "" && _tbSach_TacGia.Text != "" && _tbSach_NamXB.Text != "" && _tbSach_NhaXB.Text != "" && _tbSach_SoLuong.Text != "" && _tbSach_SoMuon.Text != "" && _dtSach_NgayNhap.Text != "")
            {
                DTOSach upSach = new DTOSach();
                DTOSach sach = _busSach.LaySach(_tbSach_MaSach.Text);
                DTODauSach dausach = _busDauSach.DauSach(sach.MaDauSach);
                upSach.MaDauSach = sach.MaDauSach;
                upSach.MaSach = _tbSach_MaSach.Text;
                upSach.MaSach = sach.MaSach;
                upSach.DSCuonSach = sach.DSCuonSach;
                upSach.NamXB = long.Parse(_tbSach_NamXB.Text);
                upSach.NhaXB = _tbSach_NhaXB.Text;
                upSach.NgayNhap = sach.NgayNhap;
                upSach.SoLuong = sach.SoLuong;
                upSach.TriGia = Double.Parse(_tbSach_TriGia.Text);
                int thoihanxb = _busQuyDinh.ThoiHanXB();
                if (thoihanxb > 0)
                {
                    if (upSach.NamXB + thoihanxb < DateTime.Today.Year)
                    {
                        MessageBox.Show("Chỉ nhận sách xuất bản trong trong vòng " + thoihanxb.ToString() + " năm");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Không lấy được quy định thời hạn xuất bản");
                    return;
                }
                //
                if (upSach.NamXB == upSach.NamXB && upSach.NhaXB == sach.NhaXB && upSach.TriGia == sach.TriGia)
                    MessageBox.Show("Chưa chọn thông tin thay đổi");
                else
                {
                    int dem = _busSach.DemLanXuatBan(upSach.MaDauSach, upSach.NamXB, upSach.NhaXB, upSach.TriGia);
                    if (dem < 0)
                        MessageBox.Show("Không kiểm tra được lần xuất bản");
                    else if (dem > 0)
                        MessageBox.Show("Lần xuất bản này đã tồn tại");
                    else
                    {
                        //update here
                        if (_busSach.CapNhat(upSach))
                        {

                            if (_busCT_PhieuNhap.CapNhatTriGia(upSach.MaSach, upSach.TriGia))
                            {
                                DataTable data = _busCT_PhieuNhap.LayDanhSoLuongSach(upSach.MaSach);

                                for (int i = 0; i < data.Rows.Count; i++)
                                {
                                    double tongtien = _busCT_PhieuNhap.TongTien(data.Rows[i]["MAPHIEUNHAP"].ToString());
                                    _busPhieuNhap.CapNhatTongTriGia(data.Rows[i]["MAPHIEUNHAP"].ToString(), tongtien);
                                }
                                MessageBox.Show("Cập nhật thành công");
                                DSSach();
                            }
                        }
                        else
                            MessageBox.Show("Cập nhật thất bại");
                    }
                }

            }
            else
                MessageBox.Show("Cập nhật thất bại");
        }
        List<DTOTacGia> listTacGia;
        List<DTOTheLoai> listTheLoai;
        void KhoiTaoTimSach()
        {
            _cbbTSach_TriGia.Items.Clear();
            _cbbTSach_TheLoai.Items.Clear();
            _cbbTSach_TacGia.Items.Clear();
            listTacGia = _busTacGia.listTacGia();
            listTheLoai = _busTheLoai.ListTheLoai();
            if (listTheLoai != null)
            {
                for (int i = 0; i < listTheLoai.Count; i++)
                {
                    _cbbTSach_TheLoai.Items.Add(listTheLoai[i].TenTheLoai);
                }
            }
            if (listTacGia != null)
            {
                for (int i = 0; i < listTacGia.Count; i++)
                {
                    _cbbTSach_TacGia.Items.Add(listTacGia[i].TenTG);
                }
            }
            //
            _cbbTSach_TriGia.Items.Add("0 -- 50000");
            _cbbTSach_TriGia.Items.Add("50000 -- 100000");
            _cbbTSach_TriGia.Items.Add("100000 -- 200000");
            _cbbTSach_TriGia.Items.Add("200000 --");
            //

        }

        private void _btnTimSach_Click(object sender, EventArgs e)
        {
            if (_cbTSach_MaSach.Checked == false && _cbTSach_TenSach.Checked == false && _cbTSach_NamXB.Checked == false && _cbTSach_NgayNhap.Checked == false && _cbTSach_NhaXB.Checked == false && _cbTSach_TacGia.Checked == false && _cbTSach_TheLoai.Checked == false && _cbTSach_TriGia.Checked == false)
            {
                MessageBox.Show("Chưa Chọn Thông Tin Tra Cứu");
            }
            else
            {
                string masach;
                if (_cbTSach_MaSach.Checked && _tbTSach_MaSach.Text != "")
                    masach = _tbTSach_MaSach.Text;
                else
                    masach = null;

                string tensach;
                if (_cbTSach_TenSach.Checked && _tbTSach_TenSach.Text != "")
                    tensach = _tbTSach_TenSach.Text;
                else
                    tensach = null;

                string matl;
                if (_cbTSach_TheLoai.Checked && _cbbTSach_TheLoai.Text != "")
                    matl = listTheLoai[_cbbTSach_TheLoai.SelectedIndex].MaTheLoai;
                else
                    matl = null;

                string matg;
                if (_cbTSach_TacGia.Checked && _cbbTSach_TacGia.Text != "")
                    matg = listTacGia[_cbbTSach_TacGia.SelectedIndex].MaTG;
                else
                    matg = null;

                long namxb;
                if (_cbTSach_NamXB.Checked && _tbTSach_NamXB.Text != "")
                    namxb = long.Parse(_tbTSach_NamXB.Text);
                else
                    namxb = -1;

                string nhaxb;
                if (_cbTSach_NhaXB.Checked && _tbTSach_NhaXB.Text != "")
                    nhaxb = _tbTSach_NhaXB.Text;
                else
                    nhaxb = null;

                DateTime ngaynhap;
                object objNgayNhap;
                if (_cbTSach_NgayNhap.Checked && _dtTSach_NgayNhap.Text != "")
                {
                    ngaynhap = _dtTSach_NgayNhap.Value;
                    objNgayNhap = (object)ngaynhap;
                }
                else
                    objNgayNhap = null;

                double trigiamin, trigiamax;
                if (_cbTSach_TriGia.Checked && _cbbTSach_TriGia.Text != "")
                {
                    int index = -1;
                    index = _cbbTSach_TriGia.SelectedIndex;
                    switch (index)
                    {
                        case 0:
                            trigiamin = 0;
                            trigiamax = 50000;
                            break;
                        case 1:
                            trigiamin = 50000;
                            trigiamax = 100000;
                            break;
                        case 2:
                            trigiamin = 100000;
                            trigiamax = 200000;
                            break;
                        case 3:
                            trigiamin = 200000;
                            trigiamax = -1;
                            break;
                        default:
                            trigiamin = 0;
                            trigiamax = -1;
                            break;
                    }
                }
                else
                {
                    trigiamin = 0;
                    trigiamax = -1;
                }

                DataTable data = _busSach.TraCuuSach(masach, tensach, matl, matg, namxb, nhaxb, objNgayNhap, trigiamin, trigiamax);
                if (masach == null && matg == null && tensach == null && matl == null && namxb == -1 && nhaxb == null && objNgayNhap == null && trigiamin == 0 && trigiamax == -1)
                {
                    MessageBox.Show("Chưa Nhập Dữ Liệu Tìm Kiếm");
                    return;
                }
                if (data == null)
                    MessageBox.Show("Tra Cứu Thất Bại");
                else
                {
                    _tableSach.DataSource = data;
                    if (data.Rows.Count != 0)
                        _btnCapNhatSach.Enabled = _btnXoaSach.Enabled = true;
                    else
                    {
                        _tbSach_MaSach.Text = "";
                        _tbSach_NamXB.Text = "";
                        _tbSach_NhaXB.Text = "";
                        _tbSach_SoLuong.Text = "";
                        _tbSach_SoMuon.Text = "";
                        _tbSach_TacGia.Text = "";
                        _tbSach_TenDauSach.Text = "";
                        _tbSach_TheLoai.Text = "";
                        _tbSach_TriGia.Text = "";
                        _dtSach_NgayNhap.Text = "";
                        _btnCapNhatSach.Enabled = _btnXoaSach.Enabled = false;
                    }
                }
            }

        }



        private void _btnThoatTimSach_Click(object sender, EventArgs e)
        {
            _panelTimSach.Expanded = false;
        }
        private void FormIsClosed(object sender, FormClosedEventArgs e)
        {

            DSSach();

        }
        private void _btnXoaSach_Click(object sender, EventArgs e)
        {
            DTOSach sach = _busSach.LaySach(_tbSach_MaSach.Text);
            DTODauSach dausach = _busDauSach.DauSach(sach.MaDauSach);
            dausach.Sach = sach;
            frmXoaSach frmXoaSach = new frmXoaSach(dausach);
            frmXoaSach.FormClosed += FormIsClosed;
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmXoaSach.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmXoaSach.Height / 2;
            frmXoaSach.StartPosition = FormStartPosition.Manual;
            frmXoaSach.Location = pos;
            frmXoaSach.ShowDialog();
        }

        private void _tileNhapSach_Click(object sender, EventArgs e)
        {

            frmNhapSach frmAddSach = new frmNhapSach();
            frmAddSach.SuKienCapNhat += new frmNhapSach.XuLySuKienCapNhat(UpdateDataGridView);
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmAddSach.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmAddSach.Height / 2;
            frmAddSach.StartPosition = FormStartPosition.Manual;
            frmAddSach.Location = pos;
            frmAddSach.ShowDialog();
        }
        public void UpdateDataGridView(object obj)
        {
            if (obj.ToString() == "CapNhatSach")
                DSSach();
            else if (obj.ToString() == "CapNhatDauSach")
                DSDauSach();
            else if (obj.ToString() == "CapNhatTheLoai")
                DSTL();
            else if (obj.ToString() == "CapNhatTacGia")
                DSTG();
            else if (obj.ToString() == "CapNhatDocGia")
                DSDG();
            else if (obj.ToString() == "CapNhatLoaiDG")
                DSLoaiDG();
          


        }

        private void _tileNhapDS_Click(object sender, EventArgs e)
        {
            frmDauSach frmDauSach = new frmDauSach();
            frmDauSach.SuKienCapNhat += new frmDauSach.XuLySuKienCapNhat(UpdateDataGridView);
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmDauSach.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmDauSach.Height / 2;
            frmDauSach.StartPosition = FormStartPosition.Manual;
            frmDauSach.Location = pos;
            frmDauSach.ShowDialog();
        }

        private void _tileThemTL_Click(object sender, EventArgs e)
        {
            frmDKTheLoai frmDKTheLoai = new frmDKTheLoai();
            frmDKTheLoai.SuKienCapNhat += new frmDKTheLoai.XuLySuKienCapNhat(UpdateDataGridView);
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmDKTheLoai.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmDKTheLoai.Height / 2;
            frmDKTheLoai.StartPosition = FormStartPosition.Manual;
            frmDKTheLoai.Location = pos;
            frmDKTheLoai.ShowDialog();
        }

        private void _tileThemTacGia_Click(object sender, EventArgs e)
        {

            frmDKTacGia frmDKTacGia = new frmDKTacGia();
            frmDKTacGia.SuKienCapNhat += new frmDKTacGia.XuLySuKienCapNhat(UpdateDataGridView);
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmDKTacGia.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmDKTacGia.Height / 2;
            frmDKTacGia.StartPosition = FormStartPosition.Manual;
            frmDKTacGia.Location = pos;
            frmDKTacGia.ShowDialog();
        }

        private void _tileLapTheDG_Click(object sender, EventArgs e)
        {
            frmDocGia frmDocGia = new frmDocGia();
            frmDocGia.SuKienCapNhat += new frmDocGia.XuLySuKienCapNhat(UpdateDataGridView);
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmDocGia.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmDocGia.Height / 2;
            frmDocGia.StartPosition = FormStartPosition.Manual;
            frmDocGia.Location = pos;
            frmDocGia.ShowDialog();
        }

        private void _tileThemLoaiDG_Click(object sender, EventArgs e)
        {
            frmDKLoaiDG frmDKLoaiDG = new frmDKLoaiDG();
            frmDKLoaiDG.SuKienCapNhat += new frmDKLoaiDG.XuLySuKienCapNhat(UpdateDataGridView);
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmDKLoaiDG.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmDKLoaiDG.Height / 2;
            frmDKLoaiDG.StartPosition = FormStartPosition.Manual;
            frmDKLoaiDG.Location = pos;
            frmDKLoaiDG.ShowDialog();
        }

        private void _btnCapNhatDocGia_Click(object sender, EventArgs e)
        {
            if (_tbDG_DiaChi.Text != "" && _tbDG_Email.Text != "" && _tbDG_HoTen.Text != "" && _tbDG_MaDG.Text != "" && _tbDG_TongNo.Text != "" && _dtDG_NgayHH.Text != "" && _dtDG_NgayLT.Text != "" && _dtDG_NgaySinh.Text != "")
            {
                //
                List<DTOLoaiDG> dsLoaiDG = _busLoaiDG.LayDSLoaiDG();
                DTODocGia docgia = new DTODocGia();
                //Quy định về tuổi
                int tuoitoithieu = _busQuyDinh.getMinAge();
                int tuoitoida = _busQuyDinh.getMaxAge();
                if (tuoitoithieu < 0 || tuoitoida < 0)
                {
                    MessageBox.Show("Không lấy được quy định về tuổi");
                    return;
                }
                else
                {
                    int tuoi = DateTime.Today.Year - _dtDG_NgaySinh.Value.Year;
                    if (tuoi < tuoitoithieu || tuoi > tuoitoida)
                    {
                        MessageBox.Show("Tuổi độc giả phải lớn hơn " + tuoitoithieu.ToString() + " và nhỏ hơn " + tuoitoida.ToString());
                        return;
                    }
                    else
                        docgia.NgaySinh = _dtDG_NgaySinh.Value;
                    //Tạo Ngày hết hạn
                    _dtDG_NgayHH.Value = _dtDG_NgayLT.Value;
                    _dtDG_NgayHH.Value = _dtDG_NgayHH.Value.AddMonths(_busQuyDinh.getGetMonthEx());
                    docgia.NgayHetHan = _dtDG_NgayHH.Value;

                    docgia.NgayLapThe = _dtDG_NgayLT.Value;

                    if (docgia.NgayLapThe <= docgia.NgaySinh || docgia.NgayHetHan <= docgia.NgaySinh)
                    {
                        MessageBox.Show("Ngày sinh phải nhỏ hơn ngày lập thẻ, ngày hết hạn");
                        return;
                    }

                    docgia.MaDG = _tbDG_MaDG.Text;
                    docgia.HoTen = _tbDG_HoTen.Text;
                    docgia.DiaChi = _tbDG_DiaChi.Text;
                    docgia.Email = _tbDG_Email.Text;
                    docgia.LoaiDG.TenLoaiDG = _cbbDG_LoaiDG.Text;
                    docgia.LoaiDG.MaLoaiDG = dsLoaiDG[_cbbDG_LoaiDG.SelectedIndex].MaLoaiDG;
                    docgia.TongNo = long.Parse(_tbDG_TongNo.Text);
                    docgia.MaLoaiDG = dsLoaiDG[_cbbDG_LoaiDG.SelectedIndex].MaLoaiDG;
                    DTODocGia oldDocgia = new DTODocGia();


                    oldDocgia.MaLoaiDG = (string)_tableDocGia.Rows[_tableDocGia.CurrentRow.Index].Cells[1].Value;
                    oldDocgia.HoTen = (string)_tableDocGia.Rows[_tableDocGia.CurrentRow.Index].Cells[2].Value;
                    oldDocgia.NgaySinh = (DateTime)_tableDocGia.Rows[_tableDocGia.CurrentRow.Index].Cells[3].Value;
                    oldDocgia.DiaChi = (string)_tableDocGia.Rows[_tableDocGia.CurrentRow.Index].Cells[4].Value;
                    oldDocgia.Email = (string)_tableDocGia.Rows[_tableDocGia.CurrentRow.Index].Cells[5].Value;


                    if (oldDocgia.DiaChi == docgia.DiaChi && oldDocgia.HoTen == docgia.HoTen && oldDocgia.Email == docgia.Email && docgia.LoaiDG.MaLoaiDG == oldDocgia.MaLoaiDG && docgia.NgaySinh == oldDocgia.NgaySinh)
                    {
                        MessageBox.Show("Chưa nhập thông tin mới cho độc giả");

                    }
                    else
                    {
                        if (_busDocGia.ThemDocGia(docgia))
                        {
                            MessageBox.Show("Cập nhật thành công");
                            DSDG();

                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại");

                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin");
            }
        }

        private void _tileDSDGHetHan_Click(object sender, EventArgs e)
        {

            DataTable data = _busDocGia.DanhSachDocGiaHetHan();
            if (data == null)
                MessageBox.Show("Không lấy được danh sách độc giả");
            else
            {
                _tableDocGia.DataSource = data;
                _lbTenBangDocGia.Text = "Danh Sách Độc Giả Hết Hạn";

                if (_tabControl.Controls.IndexOf(_mtabDSDocGia) == -1)
                {
                    _tabControl.Controls.Add(_mtabDSDocGia);
                    _tabControl.SelectedTab = _mtabDSDocGia;
                }
                else
                    _tabControl.SelectedTab = _mtabDSDocGia;
                if (data.Rows.Count <= 0)
                {
                    resetChiTietDG();
                }

            }
        }
        void resetChiTietDG()
        {
            _tbDG_DiaChi.Text = "";
            _tbDG_Email.Text = "";
            _tbDG_HoTen.Text = "";
            _tbDG_MaDG.Text = "";
            _tbDG_TongNo.Text = "";
            _dtDG_NgayHH.Text = "";
            _dtDG_NgayLT.Text = "";
            _dtDG_NgaySinh.Text = "";
            _cbbDG_LoaiDG.Text = "";
        }

        private void _tileLapPhieuMuon_Click(object sender, EventArgs e)
        {

            frmDKPhieuMuon frmDKPhieuMuon = new frmDKPhieuMuon();
            // frmDocGia.SuKienCapNhat += new frmDocGia.XuLySuKienCapNhat(UpdateDataGridView);
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmDKPhieuMuon.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmDKPhieuMuon.Height / 2;
            frmDKPhieuMuon.StartPosition = FormStartPosition.Manual;
            frmDKPhieuMuon.Location = pos;
            frmDKPhieuMuon.ShowDialog();
        }

        private void _tileDSPhieuMuon_Click(object sender, EventArgs e)
        {
            if (_tabControl.Controls.IndexOf(_mTabPhieuMuon) == -1)
            {
                _tabControl.Controls.Add(_mTabPhieuMuon);
                _tabControl.SelectedTab = _mTabPhieuMuon;
            }
            else
                _tabControl.SelectedTab = _mTabPhieuMuon;
            //
            DataTable data;
            data = _busPhieuMuon.LayDanhSachPhieuMuon();
            if (data == null)
                MessageBox.Show("Không lấy được danh sách phiếu mượn");
            else
            {
                _tablePhieuMuon.DataSource = data;
            }
        }

        private void _tablePhieuMuon_SelectionChanged(object sender, EventArgs e)
        {
            var oBject = (MetroFramework.Controls.MetroGrid)sender;
            if (oBject.CurrentRow != null)
            {

                _tbPM_MaPM.Text = (string)oBject.Rows[oBject.CurrentRow.Index].Cells[0].Value;
                if (_tbPM_MaPM.Text != "")
                {
                    DTOPhieuMuon phieumuon = _busPhieuMuon.LayPhieuMuon(_tbPM_MaPM.Text);
                    if (phieumuon == null)
                        MessageBox.Show("Không lấy được thông tin phiếu mượn");
                    else
                    {
                        _tbPM_MaDG.Text = phieumuon.DocGia.MaDG;
                        _tbPM_TenDG.Text = phieumuon.DocGia.HoTen;
                        _dtPM_NgayMuon.Value = phieumuon.NgayMuon;
                        _tableCTSachMuon.Rows.Clear();

                        for (int i = 0; i < phieumuon.DSCTPhieuMuon.Count; i++)
                        {
                            string macuonsach = phieumuon.DSCTPhieuMuon[i].MaCuonSach;
                            string tensach = _busCuonSach.LayTenDauSach(macuonsach);
                            List<DTOTacGia> dstg = _busCuonSach.LayDSTacGia(macuonsach);
                            List<string> dstentg = new List<string>();
                            for (int j = 0; j < dstg.Count; j++)
                                dstentg.Add(dstg[j].TenTG);
                            string tentl = _busCuonSach.LayTenTL(macuonsach);

                            //hiện thi chi tiet sach mượn
                            string tentg = dstentg[0];
                            if (dstentg.Count > 1)
                                for (int j = 1; i < dstentg.Count; j++)
                                    tentg += ", " + dstentg[j];
                            try
                            {
                                _tableCTSachMuon.Rows.Add(macuonsach, tensach, tentg, tentl);
                            }
                            catch
                            { }
                        }
                    }
                }
            }
        }

        private void _tablePhieuNhap_SelectionChanged(object sender, EventArgs e)
        {
            var oBject = (MetroFramework.Controls.MetroGrid)sender;
            if (oBject.CurrentRow != null)
            {

                _tbPN_MaPN.Text = (string)oBject.Rows[oBject.CurrentRow.Index].Cells[0].Value;
                if (_tbPN_MaPN.Text != "")
                {
                    _tablePNChiTietSach.Rows.Clear();
                    DTOPhieuNhap phieunhap = _busPhieuNhap.LayPhieuNhap(_tbPN_MaPN.Text);
                    if (phieunhap == null)
                        MessageBox.Show("Không lấy được thông tin phiếu nhập");
                    else
                    {
                        for (int i = 0; i < phieunhap.DSCTPhieuNhap.Count; i++)
                        {
                            string tendausach = _busDauSach.LayDauSach(phieunhap.DSCTPhieuNhap[i].Sach.MaDauSach).TenDauSach;

                            _tablePNChiTietSach.Rows.Add(tendausach, phieunhap.DSCTPhieuNhap[i].Sach.NamXB, phieunhap.DSCTPhieuNhap[i].Sach.NhaXB,
                                                        phieunhap.DSCTPhieuNhap[i].Sach.TriGia.ToString(), phieunhap.DSCTPhieuNhap[i].Sach.SoLuong.ToString(), phieunhap.DSCTPhieuNhap[i].ThanhTien.ToString());
                        }
                        _tbPN_Tong.Text = phieunhap.TongTriGia.ToString();
                    }
                }
            }
        }

        private void _tileLapPhieuTra_Click(object sender, EventArgs e)
        {
            frmDKPhieuTra frmDKPhieuTra = new frmDKPhieuTra();
            // frmDocGia.SuKienCapNhat += new frmDocGia.XuLySuKienCapNhat(UpdateDataGridView);
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmDKPhieuTra.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmDKPhieuTra.Height / 2;
            frmDKPhieuTra.StartPosition = FormStartPosition.Manual;
            frmDKPhieuTra.Location = pos;
            frmDKPhieuTra.ShowDialog();
        }

        private void _tileDSPhieuTra_Click(object sender, EventArgs e)
        {
            if (_tabControl.Controls.IndexOf(_mTabPhieuTra) == -1)
            {
                _tabControl.Controls.Add(_mTabPhieuTra);
                _tabControl.SelectedTab = _mTabPhieuTra;
            }
            else
                _tabControl.SelectedTab = _mTabPhieuTra;
            //
            DataTable data;
            data = _busPhieuTra.LayDanhSachPhieuTra();
            if (data == null)
                MessageBox.Show("Không lấy được danh sách phiếu mượn");
            else
            {
                _tablePhieuTra.DataSource = data;
            }
        }

        private void _tablePhieuTra_SelectionChanged(object sender, EventArgs e)
        {
            var oBject = (MetroFramework.Controls.MetroGrid)sender;
            if (oBject.CurrentRow != null)
            {

                _tbPT_MaPT.Text = (string)oBject.Rows[oBject.CurrentRow.Index].Cells[0].Value;
                if (_tbPT_MaPT.Text != "")
                {
                    _tablePTChiTietSach.Rows.Clear();
                    DTOPhieuTra phieutra = _busPhieuTra.LayPhieuTra(_tbPT_MaPT.Text);
                    if (phieutra == null)
                        MessageBox.Show("Không lấy được thông tin phiếu trả");
                    else
                    {
                        _tbPT_MaDG.Text = phieutra.DocGia.MaDG;
                       
                        _tbPT_TenDG.Text = phieutra.DocGia.HoTen;
                        _dtPT_NgayTra.Value = phieutra.NgayTra;
                        _tbPT_TienPhat.Text = phieutra.TongTienPhat.ToString();
                        _tbPT_TongNo.Text = phieutra.ConLai.ToString();
                        foreach (DTOCT_PhieuTra ctptr in phieutra.DSCTPhieuTra)
                        {
                            try
                            {
                                _tablePTChiTietSach.Rows.Add(ctptr.CTPhieuMuon.MaCuonSach, phieutra.NgayTra.AddDays(-ctptr.SoNgayMuon).ToString(),
                                    ctptr.SoNgayMuon.ToString(), ctptr.TienPhat);
                            }
                            catch { }
                        }
                    }
                }
            }
        }

        private void _tileLapPhieuThu_Click(object sender, EventArgs e)
        {
            frmDKPhieuThu frmDKPhieuThu = new frmDKPhieuThu();
            // frmDocGia.SuKienCapNhat += new frmDocGia.XuLySuKienCapNhat(UpdateDataGridView);
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmDKPhieuThu.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmDKPhieuThu.Height / 2;
            frmDKPhieuThu.StartPosition = FormStartPosition.Manual;
            frmDKPhieuThu.Location = pos;
            frmDKPhieuThu.ShowDialog();
        }

        private void _tileDSPhieuThu_Click(object sender, EventArgs e)
        {
            if (_tabControl.Controls.IndexOf(_mTabPhieuThu) == -1)
            {
                _tabControl.Controls.Add(_mTabPhieuThu);
                _tabControl.SelectedTab = _mTabPhieuThu;
            }
            else
                _tabControl.SelectedTab = _mTabPhieuThu;
            //
            DataTable data;
            data = _busPhieuThu.LayDanhSachPhieuThu();
            if (data == null)
                MessageBox.Show("Không lấy được danh sách phiếu mượn");
            else
            {
                _tablePhieuThu.DataSource = data;
            }
        }



        private void _tablePhieuThu_SelectionChanged(object sender, EventArgs e)
        {
            var oBject = (MetroFramework.Controls.MetroGrid)sender;
            if (oBject.CurrentRow != null)
            {
                _tbPThu_MaPT.Text = (string)oBject.Rows[oBject.CurrentRow.Index].Cells[0].Value;
                if (_tbPThu_MaPT.Text != "")
                {

                    DTOPhieuThu phieuthu = _busPhieuThu.LayPhieuThu(_tbPThu_MaPT.Text);
                    if (phieuthu == null)
                        MessageBox.Show("Không lấy được thông tin phiếu thu");
                    else
                    {
                        _tbPThu_MaDG.Text = phieuthu.DocGia.MaDG;
                        _tbPThu_TenDG.Text = phieuthu.DocGia.HoTen;
                        _dtPThu_NgayThu.Value = phieuthu.NgayLap;
                        _tbPThu_TongNo.Text = (phieuthu.SoTienThu + phieuthu.ConLai).ToString();
                        _tbPThu_SoTienThu.Text = phieuthu.SoTienThu.ToString();
                        _tbPThu_TienConLai.Text = phieuthu.ConLai.ToString();
                    }
                }
            }
        }



        private void _tileTimSach_Click(object sender, EventArgs e)
        {
            _tileDSSach_Click(null, null);
            _panelTimSach.Expanded = true;

        }

        private void _tileTKSachTL_Click(object sender, EventArgs e)
        {

            frmTK_SachTheoTL frmTK_SachTheoTL = new frmTK_SachTheoTL();
            // frmDocGia.SuKienCapNhat += new frmDocGia.XuLySuKienCapNhat(UpdateDataGridView);
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmTK_SachTheoTL.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmTK_SachTheoTL.Height / 2;
            frmTK_SachTheoTL.StartPosition = FormStartPosition.Manual;
            frmTK_SachTheoTL.Location = pos;
            frmTK_SachTheoTL.ShowDialog();
        }

        private void _tileTKSachTre_Click(object sender, EventArgs e)
        {
            frmTK_TraSachTre frmTK_TraSachTre = new frmTK_TraSachTre();
            // frmDocGia.SuKienCapNhat += new frmDocGia.XuLySuKienCapNhat(UpdateDataGridView);
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmTK_TraSachTre.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmTK_TraSachTre.Height / 2;
            frmTK_TraSachTre.StartPosition = FormStartPosition.Manual;
            frmTK_TraSachTre.Location = pos;
            frmTK_TraSachTre.ShowDialog();
        }

        private void _tileQuyDinh_Click(object sender, EventArgs e)
        {

            frmQuyDinh frmQuyDinh = new frmQuyDinh();
            // frmDocGia.SuKienCapNhat += new frmDocGia.XuLySuKienCapNhat(UpdateDataGridView);
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmQuyDinh.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmQuyDinh.Height / 2;
            frmQuyDinh.StartPosition = FormStartPosition.Manual;
            frmQuyDinh.Location = pos;
            frmQuyDinh.ShowDialog();
        }

        private void _tileDangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.FormClosed += frmDangNhap_FormClosed;
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmDangNhap.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmDangNhap.Height / 2;
            frmDangNhap.StartPosition = FormStartPosition.Manual;
            frmDangNhap.Location = pos;
            frmDangNhap.ShowDialog();
        }
        void frmQuyDinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_busQuyDinh.LayQuyDinh() == null)
            {
                this.Close();
            }

        }
        void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            PhanQuyen();
        }
        public void PhanQuyen()
        {
            if (UserManager.User != null)
            {
                switch (UserManager.User.LoaiNguoiDung)
                {
                    case LOAI_NGUOI_DUNG.NguoiQuanTri:
                        this.Text = "Quản Lý Thư Viện - Người Quản Trị";
                        if(_busQuyDinh.LayQuyDinh()==null)
                        {
                            frmQuyDinh frmQuyDinh = new frmQuyDinh();
                            // frmDocGia.SuKienCapNhat += new frmDocGia.XuLySuKienCapNhat(UpdateDataGridView);
                            frmQuyDinh.FormClosed += frmQuyDinh_FormClosed;
                            Point pos = this.Location;
                            pos.X = pos.X + this.Size.Width / 2 - frmQuyDinh.Width / 2;
                            pos.Y = pos.Y + this.Size.Height / 2 - frmQuyDinh.Height / 2;
                            frmQuyDinh.StartPosition = FormStartPosition.Manual;
                            frmQuyDinh.Location = pos;
                            frmQuyDinh.ShowDialog();
                        }
                        _tileDangXuat.Visible = true;
                        _tileDangNhap.Visible = false;
                        _tabDocGia.PageVisible = true;
                        _tabMuonTra.PageVisible = true;
                        _tabTK_QD.PageVisible = true;
                        _btnCapNhatSach.Visible = true;
                        _btnXoaSach.Visible = true;
                        //
                        _groupCaiDatTK.Visible = true;
                        _groupQuanliSach.Visible = true;
                        _groupQuanLiTacGia.Visible = true;
                        _groupQuanLiTheLoai.Visible = true;
                        _groupXuLyDuLieu.Visible = true;
                        break;
                    case LOAI_NGUOI_DUNG.ThuThu:
                        this.Text = "Quản Lý Thư Viện - Thủ Thư";
                        if (_busQuyDinh.LayQuyDinh() == null)
                        {
                            frmQuyDinh frmQuyDinh = new frmQuyDinh();
                            // frmDocGia.SuKienCapNhat += new frmDocGia.XuLySuKienCapNhat(UpdateDataGridView);
                            frmQuyDinh.FormClosed += frmQuyDinh_FormClosed;
                            Point pos = this.Location;
                            pos.X = pos.X + this.Size.Width / 2 - frmQuyDinh.Width / 2;
                            pos.Y = pos.Y + this.Size.Height / 2 - frmQuyDinh.Height / 2;
                            frmQuyDinh.StartPosition = FormStartPosition.Manual;
                            frmQuyDinh.Location = pos;
                            frmQuyDinh.ShowDialog();
                        }
                        _tileDangXuat.Visible = true;
                        _tileDangNhap.Visible = false;
                        _tabDocGia.PageVisible = true;
                        _tabMuonTra.PageVisible = true;
                        _tabTK_QD.PageVisible = true;
                        _btnCapNhatSach.Enabled = true;
                        _btnXoaSach.Enabled = true;
                        //
                        _groupCaiDatTK.Visible = true;
                        _groupQuanliSach.Visible = true;
                        _groupQuanLiTacGia.Visible = true;
                        _groupQuanLiTheLoai.Visible = true;
                        _groupXuLyDuLieu.Visible = true;
                        break;
                    case LOAI_NGUOI_DUNG.DocGia:
                        this.Text = "Quản Lý Thư Viện - Độc Giả";
                        _tileDangNhap.Visible = false;
                        _tileDangXuat.Visible = true;
                        break;


                }
            }
            else
            {
                //Tab chính điều khiển
                _tileDangNhap.Visible = true;
                _tileDangXuat.Visible = false;
                _tabDocGia.PageVisible = false;
                _tabMuonTra.PageVisible = false;
                _tabTK_QD.PageVisible = false;
                //
                _groupCaiDatTK.Visible = false;
                _groupQuanliSach.Visible = false;
                _groupQuanLiTacGia.Visible = false;
                _groupQuanLiTheLoai.Visible = false;
                _groupXuLyDuLieu.Visible = false;
                //control cap nhat, xoa

                _btnCapNhatSach.Visible = false;
           
                _btnXoaSach.Visible = false;

                _tabControl.Controls.Remove(_mTabPhieuThu);
                _tabControl.Controls.Remove(_mTabPhieuTra);
                _tabControl.Controls.Remove(_mTabPhieuMuon);
                _tabControl.Controls.Remove(_mTabDSCTPN);
                _tabControl.Controls.Remove(_mTabDSTacGia);
                _tabControl.Controls.Remove(_mTabDSLoaiDG);
                _tabControl.Controls.Remove(_mtabDSDocGia);
                _tabControl.Controls.Remove(_mTabDSSach);
                _tabControl.Controls.Remove(_mTabDSDauSach);
                _tabControl.Controls.Remove(_mTabDSTheLoai);

            }
        }

        private void _closeTabPhieuThu_Click(object sender, EventArgs e)
        {
            _tabControl.Controls.Remove(_mTabPhieuThu);
        }

        private void _closeTabPhieuTra_Click(object sender, EventArgs e)
        {
            _tabControl.Controls.Remove(_mTabPhieuTra);
        }

        private void _closeTabPhieuMuon_Click(object sender, EventArgs e)
        {
            _tabControl.Controls.Remove(_mTabPhieuMuon);
        }

        private void _closeTabPhieuNhap_Click(object sender, EventArgs e)
        {
            _tabControl.Controls.Remove(_mTabDSCTPN);
        }

        private void _closeTabTacGia_Click(object sender, EventArgs e)
        {
            _tabControl.Controls.Remove(_mTabDSTacGia);
        }

        private void _closeTabTheLoai_Click(object sender, EventArgs e)
        {
            _tabControl.Controls.Remove(_mTabDSTheLoai);
        }

        private void _closeTabDauSach_Click(object sender, EventArgs e)
        {
            _tabControl.Controls.Remove(_mTabDSDauSach);
        }

        private void _closeTabSach_Click(object sender, EventArgs e)
        {
            _tabControl.Controls.Remove(_mTabDSSach);
        }

        private void _closeTabDG_Click(object sender, EventArgs e)
        {
            _tabControl.Controls.Remove(_mtabDSDocGia);
        }

        private void _closeTabLoaiDG_Click(object sender, EventArgs e)
        {
            _tabControl.Controls.Remove(_mTabDSLoaiDG);
        }

        private void _tileDKTK_Click(object sender, EventArgs e)
        {
            frmDKTaiKhoan frmDKTaiKhoan = new frmDKTaiKhoan();
           // frmDKTaiKhoan.FormClosed += frmDangNhap_FormClosed;
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmDKTaiKhoan.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmDKTaiKhoan.Height / 2;
            frmDKTaiKhoan.StartPosition = FormStartPosition.Manual;
            frmDKTaiKhoan.Location = pos;
            frmDKTaiKhoan.ShowDialog();
        }

        private void _tileDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frmDoiMatKhau = new frmDoiMatKhau();
            // frmDKTaiKhoan.FormClosed += frmDangNhap_FormClosed;
            Point pos = this.Location;
            pos.X = pos.X + this.Size.Width / 2 - frmDoiMatKhau.Width / 2;
            pos.Y = pos.Y + this.Size.Height / 2 - frmDoiMatKhau.Height / 2;
            frmDoiMatKhau.StartPosition = FormStartPosition.Manual;
            frmDoiMatKhau.Location = pos;
            frmDoiMatKhau.ShowDialog();
        }

        private void _tileDangXuat_Click(object sender, EventArgs e)
        {
            if (UserManager.User == null)
                MessageBox.Show("Bạn chưa đăng nhập");
            else
            {
                DialogResult result = MessageBox.Show("Thoát tài khoản?", "THÔNG BÁO", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    UserManager.User = null;
                    PhanQuyen();
                }
            }
        }

        private void _btnXoaLoaiDocGia_Click(object sender, EventArgs e)
        {
         
            if (!_busDocGia.KiemTranTonTaiMaLoaiDG(_tbLDG_MaLoaiDG.Text))
            {
                DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Xóa Mã Loại Độc Giả: " + _tbLDG_MaLoaiDG.Text
                      , "CẢNH BÁO", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    if (_busLoaiDG.Xoa(_tbLDG_MaLoaiDG.Text))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        DSLoaiDG();
                    }

                    else
                        MessageBox.Show("Xóa Thất Bại");
                }
            }
            else
            {
                MessageBox.Show("Không Thể Xóa");
            }
        }

        private void _btnXoaDocGia_Click(object sender, EventArgs e)
        {
            string madg = "";
            try
            {
                madg = _tbDG_MaDG.Text;
            }
            catch { }
            if (madg != "")
            {
               
                DTODocGia docgia = _busDocGia.LayThongTinDG(madg);
                if (docgia != null)
                {
                    if (_busDocGia.KiemTraTonTaiPhieuMuon(docgia.MaDG))
                        MessageBox.Show("Độc giả có thông tin trong phiếu mượn, không được xóa");
                    else
                    {
                        DialogResult result = MessageBox.Show("Nếu tiếp tục, sẽ xóa vĩnh viễn độc giả "
                            + docgia.MaDG, "CẢNH BÁO", MessageBoxButtons.OKCancel);
                        if (result == System.Windows.Forms.DialogResult.OK)
                        {
                            if (_busDocGia.Xoa(docgia))
                            {
                                MessageBox.Show("Xoá thành công");
                                try
                                {
                                    DSDG();
                                }
                                catch { }
                            }
                            else
                                MessageBox.Show("Xóa thất bại");
                        }
                    }
                }
                else
                    MessageBox.Show("Độc giả không tồn tại");
            }
        }

        private void _tileSaoluu_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak";
            dlg.FilterIndex = 0;
            dlg.FileName = "QUANLYTHUVIEN";
            if (dlg.ShowDialog() == DialogResult.OK && dlg.FileName != "")
            {
                BUSDuLieu _busDulieu = new BUSDuLieu();
                if (_busDulieu.SaoLuuDuLieu(dlg.FileName, "QUANLYTHUVIEN")) 
                {
                    MessageBox.Show("Sao Lưu Thành Công");
                }
            }
        }

        private void _tilePhucHoi_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK && dlg.FileName != "")
            {
                BUSDuLieu _busDulieu = new BUSDuLieu();
                if (_busDulieu.PhucHoiDuLieu(dlg.FileName, "QUANLYTHUVIEN"))
                {
                    MessageBox.Show("Phục Hồi Thành Công");
                }
                else
                    MessageBox.Show("Phục Hồi Thất Bại");
            }
        }

        private void _btnXoaDauSach_Click(object sender, EventArgs e)
        {

            if (!_busSach.KiemTraTonTaiDauSach(_tbDS_MaDauSach.Text))
            {

                DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Xóa Mã Đầu Sách: "+ _tbDS_MaDauSach.Text
                       , "CẢNH BÁO", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    _busCT_TacGia.Xoa(_tbDS_MaDauSach.Text);
                    _busDauSach.Xoa(_tbDS_MaDauSach.Text);
                    MessageBox.Show("Xóa Thành Công");
                    DSDauSach();
                }
               
            }
            else
            {
                MessageBox.Show("Không Thể Xóa");
            }


        }

        private void _btnXoaTheLoai_Click(object sender, EventArgs e)
        {
            if (!_busDauSach.KiemTraTonMaTheLoai(_tbTL_MaTL.Text))
            {
                DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Xóa Mã Thể Loại: " + _tbTL_MaTL.Text
                      , "CẢNH BÁO", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    if (_busTheLoai.Xoa(_tbTL_MaTL.Text))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        DSTL();
                    }

                    else
                        MessageBox.Show("Xóa Thất Bại");
                }
            }
            else
            {
                MessageBox.Show("Không Thể Xóa");
            }
        }

        private void _btnXoaTacGia_Click(object sender, EventArgs e)
        {
            if (!_busCT_TacGia.DieuKienXoaTacGia(_tbTG_MaTG.Text))
            {
                DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Xóa Mã Tác Giả: " + _tbTG_MaTG.Text
                      , "CẢNH BÁO", MessageBoxButtons.OKCancel);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    if (_busTacGia.Xoa(_tbTG_MaTG.Text))
                    {
                        MessageBox.Show("Xóa Thành Công");
                        DSTG();
                    }

                    else
                        MessageBox.Show("Xóa Thất Bại");
                }
            }
            else
            {
                MessageBox.Show("Không Thể Xóa");
            }
        }

        private void _tileThoatUngDung_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn Thoát Ứng Dụng " 
                    , "Thông Báo", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
