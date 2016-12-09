using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOCT_PhieuTra
    {
        //----------------------------------------------------------------------
        private string _MaPhieuTra;
        public string MaPhieuTra
        {
            get { return _MaPhieuTra; }
            set { _MaPhieuTra = value; }
        }

        //----------------------------------------------------------------------
        //Desc: CT_Phiếu Mượn
        //----------------------------------------------------------------------
        private DTOCT_PhieuMuon _CTPhieuMuon;
        public DTOCT_PhieuMuon CTPhieuMuon
        {
            get { return _CTPhieuMuon; }
            set { _CTPhieuMuon = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Số ngày mượn
        //----------------------------------------------------------------------
        private int _SoNgayMuon;
        public int SoNgayMuon
        {
            get { return _SoNgayMuon; }
            set { _SoNgayMuon = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Tiền phạt
        //----------------------------------------------------------------------
        private double _TienPhat;
        public double TienPhat
        {
            get { return _TienPhat; }
            set { _TienPhat = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTOCT_PhieuTra()
        {
            _CTPhieuMuon = new DTOCT_PhieuMuon();
        }

        //----------------------------------------------------------------------
        //Desc: Xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _MaPhieuTra = "";
            _CTPhieuMuon.Reset();
            _TienPhat = 0.0F;
            _SoNgayMuon = 0;
        }
    }
}
