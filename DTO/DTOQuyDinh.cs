using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOQuyDinh
    {
        private int _TuoiToiThieu;
        public int TuoiToiThieu
        {
            get { return _TuoiToiThieu; }
            set { _TuoiToiThieu = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Tuổi tối đa
        //----------------------------------------------------------------------
        private int _TuoiToiDa;
        public int TuoiToiDa
        {
            get { return _TuoiToiDa; }
            set { _TuoiToiDa = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Thời hạn thẻ
        //----------------------------------------------------------------------
        private int _ThoiHanThe;
        public int ThoiHanThe
        {
            get { return _ThoiHanThe; }
            set { _ThoiHanThe = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Thời hạn xb
        //----------------------------------------------------------------------
        private int _ThoiHanXB;
        public int ThoiHanXB
        {
            get { return _ThoiHanXB; }
            set { _ThoiHanXB = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Số sách mượn td
        //----------------------------------------------------------------------
        private int _SoSachMuonTD;
        public int SoSachMuonTD
        {
            get { return _SoSachMuonTD; }
            set { _SoSachMuonTD = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Số ngày mượn td
        //----------------------------------------------------------------------
        private int _SoNgayMuonTD;
        public int SoNgayMuonTD
        {
            get { return _SoNgayMuonTD; }
            set { _SoNgayMuonTD = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Tiền phạt mỗi ngày
        //----------------------------------------------------------------------
        private double _TienPhatMoiNgay;
        public double TienPhatMoiNgay
        {
            get { return _TienPhatMoiNgay; }
            set { _TienPhatMoiNgay = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Áp dụng qd số tiền thu
        //----------------------------------------------------------------------
        
       

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTOQuyDinh()
        { }

        //----------------------------------------------------------------------
        //Desc: xóa
        //----------------------------------------------------------------------
        public void Reset()
        { }
    }
}

