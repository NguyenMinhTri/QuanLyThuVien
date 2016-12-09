using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUSCT_PhieuMuon
    {
        DAOCT_PhieuMuon _daoCT_PhieuMuon = new DAOCT_PhieuMuon();
        public bool CapNhat(DTOCT_PhieuMuon ct_phieumuon)
        {
            return _daoCT_PhieuMuon.CapNhat(ct_phieumuon);
        }
    }
}
