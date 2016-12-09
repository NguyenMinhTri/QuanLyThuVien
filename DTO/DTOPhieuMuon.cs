using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOPhieuMuon
    {
        private string _MaPhieuMuon;
        public string MaPhieuMuon
        {
            get { return _MaPhieuMuon; }
            set { _MaPhieuMuon = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Danh sách CT_Phiếu Mượn
        //----------------------------------------------------------------------
        private List<DTOCT_PhieuMuon> _DSCTPhieuMuon;
        public List<DTOCT_PhieuMuon> DSCTPhieuMuon
        {
            get { return _DSCTPhieuMuon; }
            set { _DSCTPhieuMuon = value; }
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
        //Desc: Ngày mượn
        //----------------------------------------------------------------------
        private DateTime _NgayMuon;
        public DateTime NgayMuon
        {
            get { return _NgayMuon; }
            set { _NgayMuon = value; }
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
        //Desc: Constructor mặc định
        //----------------------------------------------------------------------
        public DTOPhieuMuon()
        {
            _DSCTPhieuMuon = new List<DTOCT_PhieuMuon>();
            _DocGia = new DTODocGia();
            _NgayMuon = new DateTime();
            _NgayHetHan = new DateTime();
        }

        //----------------------------------------------------------------------
        //Desc: Xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _MaPhieuMuon = "";
            _DocGia.Reset();
            _DSCTPhieuMuon.Clear();
            //_NgayMuon = new DateTime();
            //_NgayHetHan = new DateTime();
        }
    }
}
