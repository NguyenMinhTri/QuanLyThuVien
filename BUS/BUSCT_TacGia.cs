using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BUSCT_TacGia
    {
        DAOCT_TacGia _daoCT_tacgia=new DAOCT_TacGia();
        public bool CapNhat(DTOCT_TacGia ct_tacgia)
        {
            return _daoCT_tacgia.CapNhat(ct_tacgia);
        }
        public bool Xoa(string madausach)
        {
            return _daoCT_tacgia.Xoa(madausach);
        }
        public bool DieuKienXoaTacGia(string matg)
        {
            return _daoCT_tacgia.DieuKienXoaTacGia(matg);
        }
        public List<DTOCT_TacGia> LayDSCT_TacGia(string madausach)
        {
            return _daoCT_tacgia.LayDSCT_TacGia(madausach);
        }
    }
}
