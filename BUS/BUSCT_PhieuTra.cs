using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BUSCT_PhieuTra
    {
        DAOCT_PhieuTra _daCT_PhieuTra = new DAOCT_PhieuTra();
        public bool CapNhat(DTOCT_PhieuTra ct_phieutra)
        {
            return _daCT_PhieuTra.CapNhat(ct_phieutra);
        }
    }
}
