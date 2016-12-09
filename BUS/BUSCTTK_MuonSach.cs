using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BUSCTTK_MuonSach
    {
        DAOCTTK_MuonSach _daoCTTK_MuonSach = new DAOCTTK_MuonSach();
        public List<DTOCTTK_MuonSach> LayCTTKMuonSach(int thang, long nam)
        {
        
            return _daoCTTK_MuonSach.LayCTTKMuonSach(thang, nam);
        }

        //----------------------------------------------------------------------
        //Desc: Cập nhật CTTK_MuonSach
        //----------------------------------------------------------------------
        public bool CapNhat(DTOCTTK_MuonSach cttkMuonSach)
        {
           
            return _daoCTTK_MuonSach.CapNhat(cttkMuonSach);
        }
    }
}
