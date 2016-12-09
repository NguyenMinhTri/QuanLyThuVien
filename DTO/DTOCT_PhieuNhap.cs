using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOCT_PhieuNhap
    {
        //----------------------------------------------------------------------
        private string _MaPhieuNhap;
        public string MaPhieuNhap
        {
            get { return _MaPhieuNhap; }
            set { _MaPhieuNhap = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Sách
        //----------------------------------------------------------------------
        private DTOSach _Sach;
        public DTOSach Sach
        {
            get { return _Sach; }
            set { _Sach = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Số Lượng
        //----------------------------------------------------------------------
        private int _SoLuong;
        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Trị Giá
        //----------------------------------------------------------------------
        private double _TriGia;
        public double TriGia
        {
            get { return _TriGia; }
            set { _TriGia = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Thành Tiền
        //----------------------------------------------------------------------
        private double _ThanhTien;
        public double ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTOCT_PhieuNhap()
        {
            _Sach = new DTOSach();
        }

        //----------------------------------------------------------------------
        //Desc: Xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _MaPhieuNhap = "";
            Sach.Reset();
            _SoLuong = 0;
            _TriGia = 0.0F;
            _ThanhTien = 0.0F;
        }
    }
}
