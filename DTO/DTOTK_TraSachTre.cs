using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOTK_TraSachTre
    {
        private DateTime _NgayTK;
        public DateTime NgayTK
        {
            get { return _NgayTK; }
            set { _NgayTK = value; }
        }

        //----------------------------------------------------------------------
        //Desc: mã cuốn sách
        //----------------------------------------------------------------------
        private string _MaCuonSach;
        public string MaCuonSach
        {
            get { return _MaCuonSach; }
            set { _MaCuonSach = value; }
        }

        //----------------------------------------------------------------------
        //Desc: ngày mượn
        //----------------------------------------------------------------------
        private DateTime _NgayMuon;
        public DateTime NgayMuon
        {
            get { return _NgayMuon; }
            set { _NgayMuon = value; }
        }

        //----------------------------------------------------------------------
        //Desc: số sách trả trễ
        //----------------------------------------------------------------------
        private int _SoNgayTraTre;
        public int SoNgayTraTre
        {
            get { return _SoNgayTraTre; }
            set { _SoNgayTraTre = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTOTK_TraSachTre()
        { }

        //----------------------------------------------------------------------
        //Desc: constructor 4 tham số
        //----------------------------------------------------------------------
        public DTOTK_TraSachTre(DateTime ngayTK, string macuonsach, DateTime ngaymuon, int songaytrate)
        {
            _NgayTK = ngayTK;
            _MaCuonSach = macuonsach;
            _NgayMuon = ngaymuon;
            _SoNgayTraTre = songaytrate;
        }

        //----------------------------------------------------------------------
        //Desc: xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _MaCuonSach = "";
            _SoNgayTraTre = 0;
        }
    }
}
