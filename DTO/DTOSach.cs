using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOSach
    {
        private string _MaSach;
        public string MaSach
        {
            get { return _MaSach; }
            set { _MaSach = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Mã đầu sách
        //----------------------------------------------------------------------
        private string _MaDauSach;
        public string MaDauSach
        {
            get { return _MaDauSach; }
            set { _MaDauSach = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Danh sách cuốn sách
        //----------------------------------------------------------------------
        private List<DTOCuonSach> _DSCuonSach;
        public List<DTOCuonSach> DSCuonSach
        {
            get { return _DSCuonSach; }
            set { _DSCuonSach = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Năm xb
        //----------------------------------------------------------------------
        private long _NamXB;
        public long NamXB
        {
            get { return _NamXB; }
            set { _NamXB = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Nhà xb
        //----------------------------------------------------------------------
        private string _NhaXB;
        public string NhaXB
        {
            get { return _NhaXB; }
            set { _NhaXB = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Ngày nhập
        //----------------------------------------------------------------------
        private DateTime _NgayNhap;
        public DateTime NgayNhap
        {
            get { return _NgayNhap; }
            set { _NgayNhap = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Trị giá
        //----------------------------------------------------------------------
        private double _TriGia;
        public double TriGia
        {
            get { return _TriGia; }
            set { _TriGia = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Số lượng
        //----------------------------------------------------------------------
        private int _SoLuong;
        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTOSach()
        {
            _DSCuonSach = new List<DTOCuonSach>();
            _NgayNhap = new DateTime();
        }

        //----------------------------------------------------------------------
        //Desc: constructor 1 tham số
        //----------------------------------------------------------------------
        public DTOSach(DTOSach sach)
        {
            _MaSach = sach._MaSach;
            _MaDauSach = sach._MaDauSach;
            _DSCuonSach = sach._DSCuonSach;
            _SoLuong = sach._SoLuong;
            _NamXB = sach._NamXB;
            _NhaXB = sach._NhaXB;
            _TriGia = sach._TriGia;
            _NgayNhap = sach.NgayNhap;
        }

        //----------------------------------------------------------------------
        //Desc: xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _MaSach = "";
            _MaDauSach = "";
            _DSCuonSach.Clear();
            _SoLuong = 0;
            _NhaXB = "";
            _TriGia = 0.0F;
            _DSCuonSach.Clear();
        }
    }
}
