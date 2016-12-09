using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOTacGia
    {
        private string _MaTG;
        public string MaTG
        {
            get { return _MaTG; }
            set { _MaTG = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Tên tác giả
        //----------------------------------------------------------------------
        private string _TenTG;
        public string TenTG
        {
            get { return _TenTG; }
            set { _TenTG = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTOTacGia()
        { }

        //----------------------------------------------------------------------
        //Desc: constructor 1 tham số
        //----------------------------------------------------------------------
        public DTOTacGia(string tentg)
        {
            _TenTG = tentg;
        }

        //----------------------------------------------------------------------
        //Desc: constructor 2 tham số
        //----------------------------------------------------------------------
        public DTOTacGia(string matg, string tentg)
        {
            _MaTG = matg;
            _TenTG = tentg;
        }

        //----------------------------------------------------------------------
        //Desc: xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _MaTG = "";
            _TenTG = "";
        }
    }
}
