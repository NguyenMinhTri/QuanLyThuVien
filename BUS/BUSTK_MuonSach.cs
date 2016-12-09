using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BUSTK_MuonSach
    {
        DAOTK_MuonSach _daoTK_MuonSach = new DAOTK_MuonSach();
        public int KiemTraTonTai(DTOTK_MuonSach tkmuonsach)
        {
            return _daoTK_MuonSach.DemPhieuTK(tkmuonsach);
        }
        public bool LayDuLieuTK(ref DTOTK_MuonSach tkMuonSach)
        {
            return _daoTK_MuonSach.LayDuLieuTK(ref tkMuonSach);
        }
        public bool CapNhat(DTOTK_MuonSach tkMuonSach)
        {
            return _daoTK_MuonSach.CapNhat(tkMuonSach);
        }
        public void TinhLuotMuon_TiLe(ref DTOTK_MuonSach tkMuonSach, List<DTOCuonSach> dsCuonSachMuon)
        {
            DAOCuonSach _daoCuonSach = new DAOCuonSach();

            //tinh so luot muon
            int tongsoluotmon = 0;
            for (int i = 0; i < dsCuonSachMuon.Count; i++)
            {
                for (int j = 0; j < tkMuonSach.DSCTTKMuonSach.Count; j++)
                {
                    string matl = _daoCuonSach.LayMaTL(dsCuonSachMuon[i].MaCuonSach);
                    if (matl != null && tkMuonSach.DSCTTKMuonSach[j].TheLoai.MaTheLoai == matl)
                    {
                        tkMuonSach.DSCTTKMuonSach[j].SoLuotMuon++;
                        tongsoluotmon++;
                    }
                }
            }
            tkMuonSach.TongSoLuotMuon = tongsoluotmon;

            //tinh ti le
            for (int i = 0; i < tkMuonSach.DSCTTKMuonSach.Count; i++)
            {
                if (tkMuonSach.DSCTTKMuonSach[i].SoLuotMuon > 0)
                    tkMuonSach.DSCTTKMuonSach[i].TiLe = tkMuonSach.DSCTTKMuonSach[i].SoLuotMuon * 1.0F / tkMuonSach.TongSoLuotMuon;
            }

            for (int i = 0; i < tkMuonSach.DSCTTKMuonSach.Count; i++)
            {
                tkMuonSach.DSCTTKMuonSach[i].ThangTK = tkMuonSach.ThangTK;
                tkMuonSach.DSCTTKMuonSach[i].NamTK = tkMuonSach.NamTK;
            }
        }
    }
}
