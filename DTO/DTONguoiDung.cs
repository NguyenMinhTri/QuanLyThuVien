using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public enum LOAI_NGUOI_DUNG
    {
        NguoiQuanTri,
        ThuThu,
        DocGia
    }

    public class DTONguoiDung
    {
        private string _TaiKhoan;
        public string TaiKhoan
        {
            get { return _TaiKhoan; }
            set { _TaiKhoan = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Mật khẩu
        //----------------------------------------------------------------------
        private string _MatKhau;
        public string MatKhau
        {
            get { return _MatKhau; }
            set { _MatKhau = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Mã nhóm
        //----------------------------------------------------------------------
        private string _MaNhom;
        public string MaNhom
        {
            get { return _MaNhom; }
            set { _MaNhom = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Mã độc giả
        //----------------------------------------------------------------------
        private string _MaDG;
        public string MaDG
        {
            get { return _MaDG; }
            set { _MaDG = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Loại người dùng
        //----------------------------------------------------------------------
        private LOAI_NGUOI_DUNG _LoaiNguoiDung;
        public LOAI_NGUOI_DUNG LoaiNguoiDung
        {
            get { return _LoaiNguoiDung; }
            set { _LoaiNguoiDung = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTONguoiDung()
        { }

        //----------------------------------------------------------------------
        //Desc: constructor 2 tham số
        //----------------------------------------------------------------------
        public DTONguoiDung(string taikhoan, string matkhau)
        {
            _TaiKhoan = taikhoan;
            _MatKhau = matkhau;
        }

        //----------------------------------------------------------------------
        //Desc: xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _TaiKhoan = "";
            _MatKhau = "";
            _MaNhom = "";
            _MaDG = "";
        }
    }
}
