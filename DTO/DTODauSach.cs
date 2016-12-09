using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTODauSach
    {
        private string _MaDauSach;
        public string MaDauSach
        {
            get { return _MaDauSach; }
            set { _MaDauSach = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Tên đầu sách
        //----------------------------------------------------------------------
        private string _TenDauSach;
        public string TenDauSach
        {
            get { return _TenDauSach; }
            set { _TenDauSach = value; }
        }
        private DTOSach _Sach;
        public DTOSach Sach
        {
            get { return _Sach; }
            set { _Sach = value; }
        }
        //----------------------------------------------------------------------
        //Desc: Danh sách Sách của Đầu sách
        //----------------------------------------------------------------------
        private List<DTOSach> _DSSach;
        public List<DTOSach> DSSach
        {
            get { return _DSSach; }
            set { _DSSach = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Thể loại
        //----------------------------------------------------------------------
        private DTOTheLoai _TheLoai;
        public DTOTheLoai TheLoai
        {
            get { return _TheLoai; }
            set { _TheLoai = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Danh sách Tác giả của Đầu sách
        //----------------------------------------------------------------------
        private List<DTOCT_TacGia> _DSCT_TacGia;
        public List<DTOCT_TacGia> DSCT_TacGia
        {
            get { return _DSCT_TacGia; }
            set { _DSCT_TacGia = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTODauSach()
        {
            _DSSach = new List<DTOSach>();
            _TheLoai = new DTOTheLoai();
            _DSCT_TacGia = new List<DTOCT_TacGia>();
        }

        //----------------------------------------------------------------------
        //Desc: xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _MaDauSach = "";
            _TenDauSach = "";
            if (_DSSach != null)
                _DSSach.Clear();
            if (_TheLoai != null)
                _TheLoai.Reset();
            if (_DSCT_TacGia != null)
                _DSCT_TacGia.Clear();
        }
    }
}
