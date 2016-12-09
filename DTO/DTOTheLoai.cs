using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOTheLoai
    {
        //----------------------------------------------------------------------
        //Desc: Mã thể loại
        //----------------------------------------------------------------------
        private string _MaTheLoai;
        public string MaTheLoai
        {
            get { return _MaTheLoai; }
            set { _MaTheLoai = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Tên thể loại
        //----------------------------------------------------------------------
        private string _TenTheLoai;
        public string TenTheLoai
        {
            get { return _TenTheLoai; }
            set { _TenTheLoai = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTOTheLoai()
        { }

        //----------------------------------------------------------------------
        //Desc: constructor 1 tham số
        //----------------------------------------------------------------------
        public DTOTheLoai(string tentl)
        {
            _TenTheLoai = tentl;
        }

        //----------------------------------------------------------------------
        //Desc: constructor 2 tham số
        //----------------------------------------------------------------------
        public DTOTheLoai(string matl, string tentl)
        {
            _MaTheLoai = matl;
            _TenTheLoai = tentl;
        }

        //----------------------------------------------------------------------
        //Desc: xóa
        //----------------------------------------------------------------------
        public void Reset()
        {
            _MaTheLoai = "";
            _TenTheLoai = "";
        }
    }
}
