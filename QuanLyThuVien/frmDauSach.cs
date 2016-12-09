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
    public partial class frmDauSach : MetroFramework.Forms.MetroForm
    {
        private List<DTOTacGia> _DSTacGia = new List<DTOTacGia>();
        private List<DTOTheLoai> _DSTheLoai = new List<DTOTheLoai>();
        private BUSTacGia busTacGia = new BUSTacGia();
        private BUSTheLoai busTheLoai = new BUSTheLoai();
        private BUSDauSach busDauSach = new BUSDauSach();
        private BUSCT_TacGia busCt_tacgia = new BUSCT_TacGia();
        private DTOTacGia tacgia = new DTOTacGia();
        private DTODauSach dausach = new DTODauSach();
        private DTOCT_TacGia ct_tacgia = new DTOCT_TacGia();
        private int numberRemove = -1;

        public delegate void XuLySuKienCapNhat(object sender);
        public event XuLySuKienCapNhat SuKienCapNhat;
        public frmDauSach()
        {
            InitializeComponent();
            KhoiTaoCombobox();
            _btnAdd.Visible = true;
        }

        void KhoiTaoCombobox()
        {

            _DSTacGia = busTacGia.listTacGia();
            for (int i = 0; i < _DSTacGia.Count; i++)
            {
                _cbbTacGia1.Items.Add(_DSTacGia[i].TenTG);
                _cbbTacGia2.Items.Add(_DSTacGia[i].TenTG);
            }
            _DSTheLoai = busTheLoai.ListTheLoai();
            for (int i = 0; i < _DSTheLoai.Count; i++)
            {
                _cbbTheLoai.Items.Add(_DSTheLoai[i].TenTheLoai);
            }




        }
        private void _btnAdd_Click(object sender, EventArgs e)
        {
            dausach = new DTODauSach();
            // MessageBox.Show( _cbbTacGia1.Items.IndexOf("Start").ToString());
            if (_tbTenDauSach.Text != "")
            {
                dausach.TenDauSach = _tbTenDauSach.Text;
                dausach.TheLoai.TenTheLoai = _cbbTheLoai.Text;
                try
                {
                    dausach.TheLoai.MaTheLoai = _DSTheLoai[_cbbTheLoai.SelectedIndex].MaTheLoai;
                }
                catch { return; }
                string tentg, matg;
                tentg = _cbbTacGia1.Text;
                matg = _DSTacGia[_cbbTacGia1.SelectedIndex].MaTG;
                dausach.DSCT_TacGia.Add(new DTOCT_TacGia(new DTOTacGia(matg, tentg)));
                if (_cbbTacGia2.SelectedIndex != -1)
                {


                    tentg = _cbbTacGia2.Text;
                    int index = _cbbTacGia2.SelectedIndex;
                    if (index >= numberRemove)
                        matg = _DSTacGia[index + 1].MaTG;
                    else
                        matg = _DSTacGia[index].MaTG;

                    dausach.DSCT_TacGia.Add(new DTOCT_TacGia(new DTOTacGia(matg, tentg)));
                }
                if (busDauSach.PhatSinhDauSach(ref dausach))
                {
                    if (busDauSach.CapNhat(dausach))
                    {
                        SuKienCapNhat((object)"CapNhatDauSach");
                        MessageBox.Show("Thêm đầu sách thành công");
                        _tbTenDauSach.Text = "";
                        for (int i = 0; i < dausach.DSCT_TacGia.Count; i++)
                        {

                            if (busCt_tacgia.CapNhat(dausach.DSCT_TacGia[i]))
                            {

                            }

                        }
                    }
                }
            }

            else
                MessageBox.Show("Chưa Nhập Tên Đầu Sách");

        }

        private void _cbbTacGia1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _DSTacGia = busTacGia.listTacGia();
            _cbbTacGia2.Items.Clear();
            for (int i = 0; i < _DSTacGia.Count; i++)
            {

                _cbbTacGia2.Items.Add(_DSTacGia[i].TenTG);
            }
            try
            {

                int postion = _cbbTacGia1.SelectedIndex;
                numberRemove = postion;
                _cbbTacGia2.Items.RemoveAt(postion);
            }
            catch { }
        }

        private void _btnThoat_Click(object sender, EventArgs e)
        {

            if (_tbTenDauSach.Text != "")
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
            _tbTenDauSach.Clear();
            try
            {
                _cbbTacGia1.SelectedIndex = 0;
                _cbbTacGia2.SelectedIndex = -1;
                _cbbTheLoai.SelectedIndex = 0;
            }
            catch { }
        }

        private void frmDauSach_Load(object sender, EventArgs e)
        {
            try
            {
                _cbbTheLoai.SelectedIndex = 0;


            }
            catch
            {
                _btnAdd.Enabled = false;
                _btnThemMoi.Enabled = false;
                MessageBox.Show("Vui Lòng Nhập Thông Tin Thể Loại Trước!");
            }
            try
            {
                _cbbTacGia1.SelectedIndex = 0;
            }
            catch
            {
                if (_cbbTacGia1.Items.Count == 0)
                {
                    _btnAdd.Enabled = false;
                    _btnThemMoi.Enabled = false;
                    MessageBox.Show("Vui Lòng Nhập Thông Tin  Tác Giả Trước!");
                }
            }
        }
    }
}
