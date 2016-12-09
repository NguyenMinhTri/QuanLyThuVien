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
    public partial class frmQuyDinh : MetroFramework.Forms.MetroForm
    {
        BUSQuyDinh _busQuyDinh = new BUSQuyDinh();
        DTOQuyDinh _quyDinh = new DTOQuyDinh();
        DTOQuyDinh quydinhmoi;
        public frmQuyDinh()
        {
            InitializeComponent();
            _quyDinh = _busQuyDinh.LayQuyDinh();
            if (_quyDinh == null)
            {
                _btnThemQuyDinh.Visible = true;
                _btnThayDoi.Visible = false;
                _btnThoat.Visible = false;

            }
            else
            { 
                HienThiQuyDinh();
            }

        }
        public void HienThiQuyDinh()
        {
            _tbTuoiToiThieu.Text = _quyDinh.TuoiToiThieu.ToString();
            _tbTuoiToiDa.Text = _quyDinh.TuoiToiDa.ToString();
            _tbThoiHan.Text = _quyDinh.ThoiHanThe.ToString();
            _tbSSTD.Text = _quyDinh.SoSachMuonTD.ToString();
            _tbSNTD.Text = _quyDinh.SoNgayMuonTD.ToString();
            _tbThoiHanXB.Text = _quyDinh.ThoiHanXB.ToString();
            _tbTienPhat.Text = _quyDinh.TienPhatMoiNgay.ToString();
        }
        public DTOQuyDinh LayDuLieu()
        {
            DTOQuyDinh quydinhmoitemp = new DTOQuyDinh();
            try
            {
                quydinhmoitemp.TuoiToiThieu = Int32.Parse(_tbTuoiToiThieu.Text);
            }
            catch
            {
                MessageBox.Show("Sai tuổi tối thiểu");
                return null;
            }
            if (quydinhmoitemp.TuoiToiThieu < 10)
            {
                MessageBox.Show("Tuổi tối thiểu quá nhỏ");
                return null;
            }
            else if (quydinhmoitemp.TuoiToiThieu > 60)
            {
                MessageBox.Show("Tuổi tối thiểu quá lớn");
                return null;
            }


            try
            {
                quydinhmoitemp.TuoiToiDa = Int32.Parse(_tbTuoiToiDa.Text);
            }
            catch
            {
                MessageBox.Show("Sai tuổi tối đa");
                return null;
            }
            if (quydinhmoitemp.TuoiToiDa <= quydinhmoitemp.TuoiToiThieu)
            {
                MessageBox.Show("Tuổi tối đa phải lớn hơn tuổi tối thiểu");
                return null;
            }
            else if (quydinhmoitemp.TuoiToiDa > 70)
            {
                MessageBox.Show("Tuổi tối đa quá lớn");
                return null;
            }



            try
            {
                quydinhmoitemp.ThoiHanThe = Int32.Parse(_tbThoiHan.Text);
            }
            catch
            {
                MessageBox.Show("Sai thời hạn thẻ");
                return null;
            }
            if (quydinhmoitemp.ThoiHanThe <= 0)
            {
                MessageBox.Show("Thời hạn thẻ phải lớn hơn 0");
                return null;
            }



            try
            {
                quydinhmoitemp.SoSachMuonTD = Int32.Parse(_tbSSTD.Text);
            }
            catch
            {
                MessageBox.Show("Sai số sách mượn tối đa");
                return null;
            }
            if (quydinhmoitemp.SoSachMuonTD <= 0)
            {
                MessageBox.Show("Số sách mượn tối đa phải lớn hơn 0");
                return null;
            }



            try
            {
                quydinhmoitemp.SoNgayMuonTD = Int32.Parse(_tbSNTD.Text);
            }
            catch
            {
                MessageBox.Show("Sai số ngày mượn tối đa");
                return null;
            }
            if (quydinhmoitemp.SoNgayMuonTD <= 0)
            {
                MessageBox.Show("Số ngày mượn tối đa phải lớn hơn 0");
                return null;
            }



            try
            {
                quydinhmoitemp.ThoiHanXB = Int32.Parse(_tbThoiHanXB.Text);
            }
            catch
            {
                MessageBox.Show("Sai thời hạn xuất bản");
                return null;
            }
            if (quydinhmoitemp.ThoiHanXB <= 0)
            {
                MessageBox.Show("Thời hạn xuất bản phải lớn hơn 0");
                return null;
            }



            try
            {
                quydinhmoitemp.TienPhatMoiNgay = float.Parse(_tbTienPhat.Text);
            }
            catch
            {
                MessageBox.Show("Sai tiền phạt");
                return null;
            }
            if (quydinhmoitemp.TienPhatMoiNgay < 1000 || quydinhmoitemp.TienPhatMoiNgay % 1000 != 0)
            {
                MessageBox.Show("Tiền phạt từ 1000 trở lên và chia hết cho 1000");
                return null;
            }





        
           


            return quydinhmoitemp;
        }

        private void _btnThayDoi_Click(object sender, EventArgs e)
        {
            quydinhmoi = LayDuLieu();
            if (quydinhmoi == null)
                HienThiQuyDinh();
            else
            {
                if (quydinhmoi.TuoiToiThieu != _quyDinh.TuoiToiThieu
                    || quydinhmoi.TuoiToiDa != _quyDinh.TuoiToiDa
                    || quydinhmoi.ThoiHanThe != _quyDinh.ThoiHanThe
                    || quydinhmoi.SoSachMuonTD != _quyDinh.SoSachMuonTD
                    || quydinhmoi.SoNgayMuonTD != _quyDinh.SoNgayMuonTD
                    || quydinhmoi.ThoiHanXB != _quyDinh.ThoiHanXB
                    || quydinhmoi.TienPhatMoiNgay != _quyDinh.TienPhatMoiNgay
                   )
                {
                    if (_busQuyDinh.CapNhat(quydinhmoi))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        _quyDinh = quydinhmoi;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                        HienThiQuyDinh();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn thông tin thay đổi");
                    HienThiQuyDinh();
                }
            }
        }

        private void _btnThoat_Click(object sender, EventArgs e)
        {
            quydinhmoi = LayDuLieu();
            if (quydinhmoi != null)
            {
                if (quydinhmoi.TuoiToiThieu != _quyDinh.TuoiToiThieu
                    || quydinhmoi.TuoiToiDa != _quyDinh.TuoiToiDa
                    || quydinhmoi.ThoiHanThe != _quyDinh.ThoiHanThe
                    || quydinhmoi.SoSachMuonTD != _quyDinh.SoSachMuonTD
                    || quydinhmoi.SoNgayMuonTD != _quyDinh.SoNgayMuonTD
                    || quydinhmoi.ThoiHanXB != _quyDinh.ThoiHanXB
                    || quydinhmoi.TienPhatMoiNgay != _quyDinh.TienPhatMoiNgay
                   )
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
                {
                    this.Close();
                }
            }
            else
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
               
        }

        private void _btnThemQuyDinh_Click(object sender, EventArgs e)
        {
            quydinhmoi = LayDuLieu();
            if(quydinhmoi!=null)
              if (_busQuyDinh.ThemQuyDinh(quydinhmoi))
                {
                        MessageBox.Show("Cập nhật thành công");
                        _quyDinh = quydinhmoi;
                    this.Close();
                }
                else
                 {
                       MessageBox.Show("Cập nhật thất bại");
                        HienThiQuyDinh();
                  }
        }

        private void _tbTuoiToiThieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode == 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void _tbTuoiToiDa_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode == 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void _tbThoiHan_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode == 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void _tbSSTD_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode == 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void _tbSNTD_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode == 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void _tbThoiHanXB_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode == 8)
                e.Handled = false;
            else e.Handled = true;
        }

        private void _tbTienPhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keycode = e.KeyChar;
            if ((keycode >= 48 && keycode <= 57) || keycode == 8)
                e.Handled = false;
            else e.Handled = true;
        }
    }
}
