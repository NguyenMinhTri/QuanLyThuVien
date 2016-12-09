using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOPhieuThu
    {
        private string _MaPhieuThu;
        public string MaPhieuThu
        {
            get { return _MaPhieuThu; }
            set { _MaPhieuThu = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Ngày lập
        //----------------------------------------------------------------------
        private DateTime _NgayLap;
        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
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
        //Desc: Số tiền thu
        //----------------------------------------------------------------------
        private double _SoTienThu;
        public double SoTienThu
        {
            get { return _SoTienThu; }
            set { _SoTienThu = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Còn lại
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
        public DTOPhieuThu()
        {
            _DocGia = new DTODocGia();
        }

        //----------------------------------------------------------------------
        //Desc: xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _MaPhieuThu = "";
            _DocGia.Reset();
            _SoTienThu = 0.0F;
            _ConLai = 0.0F;
        }
    }
}
