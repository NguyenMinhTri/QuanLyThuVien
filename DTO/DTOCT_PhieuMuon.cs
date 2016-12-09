using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOCT_PhieuMuon
    {
        private string _MaPhieuMuon;
        public string MaPhieuMuon
        {
            get { return _MaPhieuMuon; }
            set { _MaPhieuMuon = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Mã Cuốn Sách
        //----------------------------------------------------------------------
        private string _MaCuonSach;
        public string MaCuonSach
        {
            get { return _MaCuonSach; }
            set { _MaCuonSach = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTOCT_PhieuMuon()
        { }

        //----------------------------------------------------------------------
        //Desc: Constructor 2 tham số
        //----------------------------------------------------------------------
        public DTOCT_PhieuMuon(string maphieumuon, string macuonsach)
        {
            _MaPhieuMuon = maphieumuon;
            _MaCuonSach = macuonsach;
        }

        //----------------------------------------------------------------------
        //Desc: Hàm xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _MaPhieuMuon = "";
            _MaCuonSach = "";
        }
    }
}
