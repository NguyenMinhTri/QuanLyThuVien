using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOTK_MuonSach
    {
        private int _ThangTK;
        public int ThangTK
        {
            get { return _ThangTK; }
            set { _ThangTK = value; }
        }

        //----------------------------------------------------------------------
        //Desc: năm thống kê
        //----------------------------------------------------------------------
        private long _NamTK;
        public long NamTK
        {
            get { return _NamTK; }
            set { _NamTK = value; }
        }

        //----------------------------------------------------------------------
        //Desc: danh sách CTTK_MUONSACH
        //----------------------------------------------------------------------
        private List<DTOCTTK_MuonSach> _DSCTTKMuonSach;
        public List<DTOCTTK_MuonSach> DSCTTKMuonSach
        {
            get { return _DSCTTKMuonSach; }
            set { _DSCTTKMuonSach = value; }
        }

        //----------------------------------------------------------------------
        //Desc: tổng số lượt mượn
        //----------------------------------------------------------------------
        private long _TongSoLuotMuon;
        public long TongSoLuotMuon
        {
            get { return _TongSoLuotMuon; }
            set { _TongSoLuotMuon = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTOTK_MuonSach()
        {
            _DSCTTKMuonSach = new List<DTOCTTK_MuonSach>();
        }

        //----------------------------------------------------------------------
        //Desc: xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _DSCTTKMuonSach.Clear();
            _TongSoLuotMuon = 0;
        }
    }
}
