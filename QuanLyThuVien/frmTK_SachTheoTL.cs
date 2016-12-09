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
    public partial class frmTK_SachTheoTL : MetroFramework.Forms.MetroForm
    {
        private BUSTK_MuonSach _busTK_MuonSach=new BUSTK_MuonSach();
        private BUSCTTK_MuonSach _busCTTK_MuonSach=new BUSCTTK_MuonSach();
        private BUSPhieuMuon _busPhieuMuon=new BUSPhieuMuon();
        private BUSTheLoai _busTheLoai=new BUSTheLoai();
        private BUSQuyDinh _busQuyDinh=new BUSQuyDinh();

        private DTOTK_MuonSach _TKMuonSach=new DTOTK_MuonSach();
        private List<DTOCuonSach> _DSCuonSachMuon=new List<DTOCuonSach>();
        public frmTK_SachTheoTL()
        {
            InitializeComponent();
            ThemTheLoai();

        }
        public void ThemTheLoai()
        {
            List<DTOTheLoai> dstheloai = new List<DTOTheLoai>();
            dstheloai = _busTheLoai.ListTheLoai();
            if (dstheloai != null)
            {
                for (int i = 0; i < dstheloai.Count; i++)
                {
                    DTOCTTK_MuonSach cttk = new DTOCTTK_MuonSach();
                    cttk.TheLoai = dstheloai[i];
                    _TKMuonSach.DSCTTKMuonSach.Add(cttk);
                }
            }
        }
        public void HienThiThongTinTK()
        {
            for (int i = 0; i < _TKMuonSach.DSCTTKMuonSach.Count; i++)
                _tableThongKe.Rows.Add(_TKMuonSach.DSCTTKMuonSach[i].TheLoai.TenTheLoai, _TKMuonSach.DSCTTKMuonSach[i].SoLuotMuon, _TKMuonSach.DSCTTKMuonSach[i].TiLe);
            _tbTong.Text = _TKMuonSach.TongSoLuotMuon.ToString();
        }
        private void _btnTK_Click(object sender, EventArgs e)
        {
            //
            _TKMuonSach.TongSoLuotMuon = 0;
            for (int i = 0; i < _TKMuonSach.DSCTTKMuonSach.Count; i++)
            {
                _TKMuonSach.DSCTTKMuonSach[i].SoLuotMuon = 0;
                _TKMuonSach.DSCTTKMuonSach[i].TiLe = 0;
            }
            _tableThongKe.Rows.Clear();
            //
            _TKMuonSach.NamTK = _dtNgayTK.Value.Year;
            _TKMuonSach.ThangTK = _dtNgayTK.Value.Month;
            for (int i = 0; i < _TKMuonSach.DSCTTKMuonSach.Count; i++)
            {
                _TKMuonSach.DSCTTKMuonSach[i].NamTK = _TKMuonSach.NamTK;
                _TKMuonSach.DSCTTKMuonSach[i].ThangTK = _TKMuonSach.ThangTK;
            }
            //
            int kiemtra = _busTK_MuonSach.KiemTraTonTai(_TKMuonSach);
            if (kiemtra < 0)
                MessageBox.Show("Không lấy được dữ liệu");
            else if (kiemtra > 0)
            {
                if (_busTK_MuonSach.LayDuLieuTK(ref _TKMuonSach))
                {

                    List<DTOCTTK_MuonSach> dscttkMuonSach = _busCTTK_MuonSach.LayCTTKMuonSach(_TKMuonSach.ThangTK, _TKMuonSach.NamTK);
                    if (dscttkMuonSach == null)
                        MessageBox.Show("");
                    else
                    {
                        for (int i = 0; i < _TKMuonSach.DSCTTKMuonSach.Count; i++)
                        {
                            for (int j = 0; j < dscttkMuonSach.Count; j++)
                            {
                                if (_TKMuonSach.DSCTTKMuonSach[i].TheLoai.MaTheLoai == dscttkMuonSach[j].TheLoai.MaTheLoai)
                                {
                                    _TKMuonSach.DSCTTKMuonSach[i].SoLuotMuon = dscttkMuonSach[j].SoLuotMuon;
                                    _TKMuonSach.DSCTTKMuonSach[i].TiLe = dscttkMuonSach[j].TiLe;
                                    break;
                                }
                            }
                        }
                    }

                    HienThiThongTinTK();
                }
                else
                    MessageBox.Show("Không lấy được dữ liệu thống kê");
            }
            else
            {
                //lấy dữ liệu thống kê
                _DSCuonSachMuon.Clear();
                _DSCuonSachMuon = _busPhieuMuon.LaySachMuonTrongThang(_TKMuonSach.ThangTK, _TKMuonSach.NamTK);
                if (_DSCuonSachMuon == null)
                {
                    MessageBox.Show("Không lấy được danh sách sách mượn trong tháng");
                    return;
                }

                _busTK_MuonSach.TinhLuotMuon_TiLe(ref _TKMuonSach, _DSCuonSachMuon);
                HienThiThongTinTK();
                //khác tháng thì mới lưu lại, cùng thì ko lưu vì thay đổi muon tra lien tuc
                if (_TKMuonSach.NamTK != DateTime.Today.Year || _TKMuonSach.ThangTK != DateTime.Today.Month)
                {
                    //lưu lại dữ liệu thống kê
                    if (_busTK_MuonSach.CapNhat(_TKMuonSach))
                    {
                        for (int i = 0; i < _TKMuonSach.DSCTTKMuonSach.Count; i++)
                        {
                            if (_TKMuonSach.DSCTTKMuonSach[i].SoLuotMuon > 0)
                                _busCTTK_MuonSach.CapNhat(_TKMuonSach.DSCTTKMuonSach[i]);
                        }
                    }
                    else
                        MessageBox.Show("Lưu dữ liệu thống kê thất bại");
                }

            }
        }

        private void _btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
