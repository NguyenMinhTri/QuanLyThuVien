using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOCT_TacGia
    {
        //Desc: Mã đầu sách
        //----------------------------------------------------------------------
        private string _MaDauSach;
        public string MaDauSach
        {
            get { return _MaDauSach; }
            set { _MaDauSach = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Tác giả
        //----------------------------------------------------------------------
        private DTOTacGia _TacGia;
        public DTOTacGia TacGia
        {
            get { return _TacGia; }
            set { _TacGia = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTOCT_TacGia()
        {
            _TacGia = new DTOTacGia();
        }

        //----------------------------------------------------------------------
        //Desc: constructor 1 tham số
        //----------------------------------------------------------------------
        public DTOCT_TacGia(DTOTacGia tacgia)
        {
            _TacGia = tacgia;
        }

        //----------------------------------------------------------------------
        //Desc: Xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _MaDauSach = "";
            _TacGia.Reset();
        }
    }
}
