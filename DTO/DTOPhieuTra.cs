using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOPhieuTra
    {
        private string _MaPhieuTra;
        public string MaPhieuTra
        {
            get { return _MaPhieuTra; }
            set { _MaPhieuTra = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Danh sách CT_PHIEUTRA
        //----------------------------------------------------------------------
        private List<DTOCT_PhieuTra> _DSCTPhieuTra;
        public List<DTOCT_PhieuTra> DSCTPhieuTra
        {
            get { return _DSCTPhieuTra; }
            set { _DSCTPhieuTra = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Độc giả
        //----------------------------------------------------------------------
        private DTODocGia _DocGia;
        public DTODocGia DocGia
        {
            get { return _DocGia; }
            set { _DocGia = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Ngày trả
        //----------------------------------------------------------------------
        private DateTime _NgayTra;
        public DateTime NgayTra
        {
            get { return _NgayTra; }
            set { _NgayTra = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Tổng tiền phạt
        //----------------------------------------------------------------------
        private double _TongTienPhat;
        public double TongTienPhat
        {
            get { return _TongTienPhat; }
            set { _TongTienPhat = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Tiền phạt kỳ này
        //----------------------------------------------------------------------
        private double _TienThuKyNay;
       

        //----------------------------------------------------------------------
        //Desc: Nợ kỳ này
        //----------------------------------------------------------------------
        private double _ConLai;
        public double ConLai
        {
            get { return _ConLai; }
            set { _ConLai = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTOPhieuTra()
        {
            _DSCTPhieuTra = new List<DTOCT_PhieuTra>();
            _DocGia = new DTODocGia();
            _NgayTra = new DateTime();
        }

        //----------------------------------------------------------------------
        //Desc: xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _MaPhieuTra = "";
            _DocGia.Reset();
            _DSCTPhieuTra.Clear();
            _TongTienPhat = 0.0F;
            _TienThuKyNay = 0.0F;
            _ConLai = 0.0F;
        }
    }
}
