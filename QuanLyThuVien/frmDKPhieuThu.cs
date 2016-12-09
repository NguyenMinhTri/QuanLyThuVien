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
    public partial class frmDKPhieuThu : MetroFramework.Forms.MetroForm
    {
        private BUSPhieuThu _busPhieuThu = new BUSPhieuThu();
        private BUSDocGia _busDocGia=new BUSDocGia();
        private BUSQuyDinh _busQuyDinh = new BUSQuyDinh();
        private DTOPhieuThu _PhieuThu=new DTOPhieuThu();
        public frmDKPhieuThu()
        {
            InitializeComponent();
            _PhieuThu = new DTOPhieuThu();
            _dtNgayThu.Value = DateTime.Today;
        }

        private void _tbMaDG_Leave(object sender, EventArgs e)
        {
            if ((_tbMaDG.Text != _PhieuThu.DocGia.MaDG || _PhieuThu.DocGia.MaDG == "") && _tbMaDG.Text != "")
            {
                DTODocGia docgia = _busDocGia.LayThongTinDG(_tbMaDG.Text);
                if (docgia == null)
                {
                    MessageBox.Show("Mã độc giả không tồn tại");
                    _tbMaDG.Text = _PhieuThu.DocGia.MaDG;
                }
                else
                {
                    _PhieuThu.DocGia = docgia;
                    _tbTenDG.Text = docgia.HoTen;
                    _tbTongNo.Text = docgia.TongNo.ToString();
                    _tbTienConLai.Text = docgia.TongNo.ToString();
                }
            }
            else
                _btnLapPhieu.Enabled = false;
        }
        public DTOPhieuThu LayDuLieuForm()
        {
            DTOPhieuThu phieuthu = new DTOPhieuThu();
            if (_tbMaDG.Text == "")
            {
                MessageBox.Show("Chưa nhập mã độc giả");
                return null;
            }
            DTODocGia docgia = _busDocGia.LayThongTinDG(_tbMaDG.Text);
            if (docgia == null)
            {
                MessageBox.Show("Độc giả không tồn tại");
                return null;
            }
            phieuthu.DocGia = docgia;
            phieuthu.NgayLap = _dtNgayThu.Value;

            double tienthu;
            if (_tbTienThu.Text == "")
            {
                MessageBox.Show("Chưa nhập số tiền thu");
                return null;
            }
            try
            {
                tienthu = Double.Parse(_tbTienThu.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Nhập sai tiền thu");
                return null;
            }
            if (tienthu < 0)
            {
                MessageBox.Show("Số tiền thu không được nhỏ hơn 0");
                return null;
            }
           
            else
            {
                if ( tienthu > phieuthu.DocGia.TongNo)
                {
                    MessageBox.Show("Số tiền thu không được vượt quá tổng nợ");
                    return null;
                }
            }

            phieuthu.SoTienThu = tienthu;
            phieuthu.ConLai = phieuthu.DocGia.TongNo - tienthu;

            return phieuthu;
        }
        private void _tbTienThu_TextChanged(object sender, EventArgs e)
        {
            double tongno = 0;
            try
            {
                tongno = Double.Parse(_tbTongNo.Text);
            }
            catch { }
            if (tongno == null)
                return;

            double sotienthu = 0;
            try
            {
                sotienthu = Double.Parse(_tbTienThu.Text);
            }
            catch { }
            if (sotienthu == null)
                return;

            _tbTienConLai.Text = (tongno - sotienthu).ToString();
        }

        private void _btnLapPhieu_Click(object sender, EventArgs e)
        {
            DTOPhieuThu phieuthu = LayDuLieuForm();
            if (phieuthu != null)
            {
                if (_busPhieuThu.PhatSinhMaPhieuThu(ref phieuthu))
                {
                    if (_busPhieuThu.CapNhat(phieuthu))
                    {
                        MessageBox.Show("Lập phiếu thu thành công");
                        _tbMaDG.Clear();
                        _tbTenDG.Clear();
                        _tbTienConLai.Clear();
                        _tbTienThu.Clear();
                        _tbTongNo.Clear();

                        if (_busDocGia.CapNhatTongNo(phieuthu.DocGia.MaDG, phieuthu.ConLai))
                            MessageBox.Show("Cập nhật tổng nợ thành công");
                        else
                            MessageBox.Show("Cập nhật tổng nợ thất bại");
                        _PhieuThu = phieuthu;
                       
                    }
                    else
                        MessageBox.Show("Lập phiếu thu thất bại");
                }
                else
                    MessageBox.Show("Không tạo được mã phiếu thu");
            }
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
            _tbMaDG.Clear();
            _tbTenDG.Clear();
            _tbTienConLai.Clear();
            _tbTienThu.Clear();
            _tbTongNo.Clear();
            
        }

        private void _tbMaDG_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode == 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void _tbTienThu_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode == 8)
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
