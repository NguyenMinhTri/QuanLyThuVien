using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOCTTK_MuonSach
    {
        private int _ThangTK;
        public int ThangTK
        {
            get { return _ThangTK; }
            set { _ThangTK = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Năm thống kê
        //----------------------------------------------------------------------
        private long _NamTK;
        public long NamTK
        {
            get { return _NamTK; }
            set { _NamTK = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Thể Loại
        //----------------------------------------------------------------------
        private DTOTheLoai _TheLoai;
        public DTOTheLoai TheLoai
        {
            get { return _TheLoai; }
            set { _TheLoai = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Số lượt mượn
        //----------------------------------------------------------------------
        private long _SoLuotMuon;
        public long SoLuotMuon
        {
            get { return _SoLuotMuon; }
            set { _SoLuotMuon = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Tỉ lệ
        //----------------------------------------------------------------------
        private float _TiLe;
        public float TiLe
        {
            get { return _TiLe; }
            set { _TiLe = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTOCTTK_MuonSach()
        {
            _TheLoai = new DTOTheLoai();
        }

        //----------------------------------------------------------------------
        //Desc: Xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _TheLoai.Reset();
            _SoLuotMuon = 0;
            _TiLe = 0.0F;
        }
    }
}
