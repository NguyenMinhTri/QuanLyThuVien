using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOPhieuNhap
    {
        private string _MaPhieuNhap;
        public string MaPhieuNhap
        {
            get { return _MaPhieuNhap; }
            set { _MaPhieuNhap = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Danh sách CT_Phiếu Nhập
        //----------------------------------------------------------------------
        private List<DTOCT_PhieuNhap> _DSCTPhieuNhap;
        public List<DTOCT_PhieuNhap> DSCTPhieuNhap
        {
            get { return _DSCTPhieuNhap; }
            set { _DSCTPhieuNhap = value; }
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
        //Desc: Tổng trị giá
        //----------------------------------------------------------------------
        private double _TongTriGia;
        public double TongTriGia
        {
            get { return _TongTriGia; }
            set { _TongTriGia = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTOPhieuNhap()
        {
            _DSCTPhieuNhap = new List<DTOCT_PhieuNhap>();
        }

        //----------------------------------------------------------------------
        //Desc: xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _MaPhieuNhap = "";
            _DSCTPhieuNhap.Clear();
            _TongTriGia = 0.0F;
        }
    }
}
