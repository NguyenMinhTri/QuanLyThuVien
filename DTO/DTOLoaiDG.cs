using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOLoaiDG
    {

        private string _MaLoaiDG;
        public string MaLoaiDG
        {
            get { return _MaLoaiDG; }
            set { _MaLoaiDG = value; }
        }

        //----------------------------------------------------------------------
        //Desc: Tên loại độc giả
        //----------------------------------------------------------------------
        private string _TenLoaiDG;
        public string TenLoaiDG
        {
            get { return _TenLoaiDG; }
            set { _TenLoaiDG = value; }
        }

        //----------------------------------------------------------------------
        //Desc: constructor mặc định
        //----------------------------------------------------------------------
        public DTOLoaiDG()
        { }

        //----------------------------------------------------------------------
        //Desc: constructor 2 tham số
        //----------------------------------------------------------------------
        public DTOLoaiDG(string maloaidg, string tenloaidg)
        {
            _MaLoaiDG = maloaidg;
            _TenLoaiDG = tenloaidg;
        }
        public void Reset()
        {
            _MaLoaiDG = "";
            _TenLoaiDG = "";
        }

    }
}
