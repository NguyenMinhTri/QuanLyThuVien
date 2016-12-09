using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOCuonSach
    {
        private string _MaCuonSach;
        public string MaCuonSach
        {
            get { return _MaCuonSach; }
            set { _MaCuonSach = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Mã sách
        //----------------------------------------------------------------------
        private string _MaSach;
        public string MaSach
        {
            get { return _MaSach; }
            set { _MaSach = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Tình trạng
        //----------------------------------------------------------------------
        private bool _TinhTrang;
        public bool TinhTrang
        {
            get { return _TinhTrang; }
            set { _TinhTrang = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTOCuonSach()
        {
            _TinhTrang = true;
        }

        //----------------------------------------------------------------------
        //Desc: constructor 2 tham số
        //----------------------------------------------------------------------
        public DTOCuonSach(string masach, bool tinhtrang)
        {
            _MaSach = masach;
            _TinhTrang = tinhtrang;
        }

        //----------------------------------------------------------------------
        //Desc: xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _MaCuonSach = "";
            _MaSach = "";
            _TinhTrang = true;
        }
    }
}
