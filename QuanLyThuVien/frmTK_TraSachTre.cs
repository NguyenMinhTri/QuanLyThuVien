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
    public partial class frmTK_TraSachTre : MetroFramework.Forms.MetroForm
    {
        private BUSTK_TraSachTre _busTKTraSachTre=new BUSTK_TraSachTre();
        private BUSPhieuMuon _busPhieuMuon = new BUSPhieuMuon();
        private BUSCuonSach _busCuonSach=new BUSCuonSach();
        private BUSQuyDinh _busQuyDinh=new BUSQuyDinh();

        private List<DTOTK_TraSachTre> _DSTKTraSachTre=new List<DTOTK_TraSachTre>();
        private List<DTOCT_PhieuMuon> _DSPhieuMuonTraTre=new List<DTOCT_PhieuMuon>() ;
        
        public frmTK_TraSachTre()
        {
            InitializeComponent();
        }
        public void HienThiLenDataGridView()
        {
            _tableThongKe.Rows.Clear();
            if (_DSTKTraSachTre.Count == 0)
                MessageBox.Show("Không có sách trả trễ");
            else
            {
                for (int i = 0; i < _DSTKTraSachTre.Count; i++)
                {
                    string tensach = _busCuonSach.LayTenDauSach(_DSTKTraSachTre[i].MaCuonSach);
                    if (tensach == null)
                        tensach = "";
                    _tableThongKe.Rows.Add(tensach, _DSTKTraSachTre[i].NgayMuon.ToString(),
                        _DSTKTraSachTre[i].SoNgayTraTre.ToString());
                }
            }
        }
        private void _btnThongKe_Click(object sender, EventArgs e)
        {
            _DSTKTraSachTre = new List<DTOTK_TraSachTre>();
            int kiemtra = _busTKTraSachTre.KiemTraTonTai(_dtNgayTK.Value);
            if (kiemtra < 0)
                MessageBox.Show("Không lấy được dữ liệu thống kê");
            else if (kiemtra > 0)
            {
                //lấy dữ liệu thống kê
                _DSTKTraSachTre = _busTKTraSachTre.LayDuLieuThongKe(_dtNgayTK.Value);
                if (_DSTKTraSachTre == null)
                    MessageBox.Show("Không lấy được dữ liệu thống kê");
                else
                    HienThiLenDataGridView();
            }
            else
            {
                //thống kê
                _DSPhieuMuonTraTre = _busPhieuMuon.LayDSSachTraTre(_dtNgayTK.Value);
                for (int i = 0; i < _DSPhieuMuonTraTre.Count; i++)
                {
                    DTOTK_TraSachTre tksachtratre = _busTKTraSachTre.LayTTSachTraTre(_DSPhieuMuonTraTre[i], _dtNgayTK.Value);
                    if (tksachtratre != null)
                        _DSTKTraSachTre.Add(tksachtratre);
                }

                HienThiLenDataGridView();
                //lưu lại
                int count = _busTKTraSachTre.InsertList(_DSTKTraSachTre);
            }

        }

        private void _btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
