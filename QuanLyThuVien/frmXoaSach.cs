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
    
    public partial class frmXoaSach : MetroFramework.Forms.MetroForm
    {
        DTODauSach _dausach = new DTODauSach();
        BUSCT_PhieuNhap _busCTPhieuNhap = new BUSCT_PhieuNhap();
        BUSCuonSach _busCuonSach = new BUSCuonSach();
        BUSPhieuNhap _busPhieuNhap = new BUSPhieuNhap();
        BUSSach _busSach = new BUSSach();
        DataTable data;

        public delegate void XuLySuKienCapNhat(object sender);
        public event XuLySuKienCapNhat SuKienCapNhat;
       
        public frmXoaSach(object dausach)
        {
            InitializeComponent();
            _dausach = (DTODauSach)dausach;
            KhoiTao();
        }
        void KhoiTao()
        {
            try {
                metroComboBox1.Items.Clear();
              
                int sosachdangmuon = _busCuonSach.DemSoSachMuon(_dausach.Sach.MaSach);
                data = _busCTPhieuNhap.LayDanhSoLuongSach(_dausach.Sach.MaSach);
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    metroComboBox1.Items.Add(data.Rows[i]["MAPHIEUNHAP"].ToString());
                }
                metroComboBox1.SelectedIndex = 0;
            }catch
            {
                metroComboBox1.Enabled = false;
                _btnXoa.Enabled = false;
            }
        }
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                metroComboBox2.Items.Clear();
                int soluong = Int32.Parse(data.Rows[metroComboBox1.SelectedIndex]["SOLUONG"].ToString());
                for (int i = 1; i <= soluong; i++)
                    metroComboBox2.Items.Add(i);
                metroComboBox2.SelectedIndex = 0;
            }catch
            {
                metroComboBox2.Enabled = false;
            }
        }

        private void _btnXoa_Click(object sender, EventArgs e)
        {
            int sosachmuon = _busCuonSach.DemSoSachMuon(_dausach.Sach.MaSach);
            int tongsoluong = _dausach.Sach.SoLuong;
            int sosachbixoa = Int32.Parse(metroComboBox2.Text);
            int sosachcothexoa = tongsoluong - sosachmuon;
            if (sosachbixoa <= sosachcothexoa)
            {
                //xoa cuon sach
                List<string> demo = _busCuonSach.MaCuonSachXoaDuoc(_dausach.Sach.MaSach);
                if (demo.Count == 0)
                {
                    MessageBox.Show("Không Thể Xóa");
                    return;
                }
                if (demo.Count != Int32.Parse(metroComboBox2.Text))
                {
                    MessageBox.Show("Chon Lại Số Sách Cần Xóa Nhỏ Hơn [" + demo.Count.ToString() + "]");
                    return;
                }
                for (int i = 0; i < Int32.Parse(metroComboBox2.Text); i++)
                {
                    _busCuonSach.Xoa(demo[i]);
                }
                //neu trong cuon sach ma sach bi xoa het thi xoa luon sach


                //  MessageBox.Show("Thành Công");
                //xóa luôn chi tiết phiếu nhập
                if (metroComboBox2.SelectedIndex == (metroComboBox2.Items.Count - 1))
                {

                    if (_busCTPhieuNhap.Xoa(metroComboBox1.Text, _dausach.Sach.MaSach))
                    {
                        //
                        if (!_busCTPhieuNhap.KiemTraCTPN(metroComboBox1.Text))
                        {
                            if (_busPhieuNhap.Xoa(metroComboBox1.Text))
                            {
                                MessageBox.Show("Thành Công");

                                this.Close();
                            }
                        }
                        else// cap nhat phieu nhap
                        {

                            double sotienbitru = Double.Parse(metroComboBox2.Text) * _dausach.Sach.TriGia;
                            if (_busPhieuNhap.CapNhatTriGia(sotienbitru, metroComboBox1.Text))
                            {
                                MessageBox.Show("Thành Công");

                                this.Close();
                            }
                        }
                    }
                }
                else
                {
                    if (_busCTPhieuNhap.CapNhatSoLuong(metroComboBox1.Text, Int32.Parse(metroComboBox2.Text), _dausach.Sach.MaSach))
                    {
                        double sotienbitru = Double.Parse(metroComboBox2.Text) * _dausach.Sach.TriGia;
                        if (_busPhieuNhap.CapNhatTriGia(sotienbitru, metroComboBox1.Text))
                        {
                            MessageBox.Show("Thành Công");

                            this.Close();
                        }
                    }
                }
                if (Int32.Parse(metroComboBox2.Text) == _dausach.Sach.SoLuong)
                {
                    _busSach.Xoa(_dausach.Sach.MaSach);
                }
                else
                    _busSach.CapNhatSoLuong(_dausach.Sach.MaSach, (_dausach.Sach.SoLuong - Int32.Parse(metroComboBox2.Text)));
                KhoiTao();
            }
            else if(sosachcothexoa!=0)
            {
                MessageBox.Show("Chon Lại Số Sách Cần Xóa Nhỏ Hơn [" + (sosachcothexoa+1).ToString() + "]");
                return;
            }
            else
            {
                MessageBox.Show("Không Thể Xóa");
                return;
            }
        }

        private void _btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
