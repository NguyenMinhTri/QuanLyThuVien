using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTODocGia
    {
        private string _MaDG;
        public string MaDG
        {
            get { return _MaDG; }
            set { _MaDG = value; }
        }
        private string _MaLoaiDG;
        public string MaLoaiDG
        {
            get
            {
                return _MaLoaiDG;
            }

            set
            {
                _MaLoaiDG = value;
            }
        }

        //----------------------------------------------------------------------
        //Desc: Họ tên
        //----------------------------------------------------------------------
        private string _HoTen;
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Địa chỉ
        //----------------------------------------------------------------------
        private string _DiaChi;
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Email
        //----------------------------------------------------------------------
        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Loại độc giả
        //----------------------------------------------------------------------
        private DTOLoaiDG _LoaiDG;
        public DTOLoaiDG LoaiDG
        {
            get { return _LoaiDG; }
            set { _LoaiDG = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Ngày sinh
        //----------------------------------------------------------------------
        private DateTime _NgaySinh;
        public DateTime NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Ngày lập thẻ
        //----------------------------------------------------------------------
        private DateTime _NgayLapThe;
        public DateTime NgayLapThe
        {
            get { return _NgayLapThe; }
            set { _NgayLapThe = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Tổng nợ
        //----------------------------------------------------------------------
        private double _TongNo;
        public double TongNo
        {
            get { return _TongNo; }
            set { _TongNo = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Ngày hết hạn
        //----------------------------------------------------------------------
        private DateTime _NgayHetHan;
        public DateTime NgayHetHan
        {
            get { return _NgayHetHan; }
            set { _NgayHetHan = value; }
        }

      



        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTODocGia()
        {
            _LoaiDG = new DTOLoaiDG();
            _NgaySinh = new DateTime();
            _NgayLapThe = new DateTime();
            _NgayHetHan = new DateTime();
        }

        //----------------------------------------------------------------------
        //Desc: constructor 1 tham số
        //----------------------------------------------------------------------
        public DTODocGia(DTODocGia docgia)
        {
            _MaDG = docgia._MaDG;
            _HoTen = docgia._HoTen;
            _DiaChi = docgia._DiaChi;
            _Email = docgia._Email;
            _LoaiDG = docgia._LoaiDG;
            _NgaySinh = docgia._NgaySinh;
            _NgayLapThe = docgia._NgayLapThe;
            _TongNo = docgia._TongNo;
            _NgayHetHan = docgia._NgayHetHan;
        }

        //----------------------------------------------------------------------
        //Desc: xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _MaDG = "";
            _HoTen = "";
            _DiaChi = "";
            _Email = "";
            if (_LoaiDG != null)
                _LoaiDG.Reset();
            //_NgaySinh = new DateTime();
            //_NgayLapThe = new DateTime();
            //_NgayHetHan = new DateTime();
        }
    }
}
