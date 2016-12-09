using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUSDauSach
    {
        DAODauSach _daoDauSach = new DAODauSach();
        public bool PhatSinhDauSach(ref DTODauSach dausach)
        {
            try
            {
                int stt = _daoDauSach.SoLuongDauSach() + 1;
                if (stt < 0)
                    return false;
                int tempSTT = stt;
                int demSo = 0;
                while ((tempSTT / 10) >= 1)
                {
                    demSo++;
                    tempSTT = tempSTT / 10;
                }
                if (demSo > 3)
                {
                    dausach.MaDauSach = stt.ToString("D" + demSo.ToString());
                }
                else
                    dausach.MaDauSach = stt.ToString("D3");
                for (int i = 0; i < dausach.DSCT_TacGia.Count; i++)
                    dausach.DSCT_TacGia[i].MaDauSach = dausach.MaDauSach;
               
                bool iCheck = _daoDauSach.KiemTraTonTaiMaDauSach(dausach.MaDauSach);
                while(iCheck)
                {
                    stt++;
                    tempSTT = stt;
                    demSo = 0;
                    while ((tempSTT / 10) >= 1)
                    {
                        demSo++;
                        tempSTT = tempSTT / 10;
                    }
                    if (demSo > 3)
                    {
                        dausach.MaDauSach = stt.ToString("D" + demSo.ToString());
                    }
                    else
                        dausach.MaDauSach = stt.ToString("D3");
                    for (int i = 0; i < dausach.DSCT_TacGia.Count; i++)
                        dausach.DSCT_TacGia[i].MaDauSach = dausach.MaDauSach;
                    iCheck = _daoDauSach.KiemTraTonTaiMaDauSach(dausach.MaDauSach);
                }
                return true;

            }
            catch
            {
                return false;
            }

        }
        public bool CapNhat(DTODauSach dausach)
        {
            return _daoDauSach.CapNhat(dausach);
        }
        public List<DTODauSach> LayDSDauSach()
        {
            return _daoDauSach.LayDSDauSach();
        }
        public string LayTenTheLoai(string madausach)
        {
            return _daoDauSach.LayTenTheLoai(madausach);
        }
        public List<string> LayDSTenTG(string madausach)
        {
            return _daoDauSach.LayDSTenTG(madausach);
        }
        public DTODauSach LayDauSach(string madausach)
        {
            return _daoDauSach.LayDauSach(madausach);
        }

        public DTODauSach DauSach(string madausach)
        {
            
            
            DAODauSach _daoDauSach = new DAODauSach();
            DTODauSach dausach = _daoDauSach.LayDauSach(madausach);

            if (dausach == null)
                return null;

            DAOTheLoai _dalTheLoai = new DAOTheLoai();
            string tentl = _dalTheLoai.LayTenTheLoai(dausach.TheLoai.MaTheLoai);
            if (tentl == null)
                return null;
            dausach.TheLoai.TenTheLoai = tentl;

            DAOCT_TacGia _dalCT_TacGia = new DAOCT_TacGia();
            dausach.DSCT_TacGia = _dalCT_TacGia.LayDSCT_TacGia(madausach);
            if (dausach.DSCT_TacGia == null)
                return null;

            DAOTacGia _dalTacGia = new DAOTacGia();
            for (int i = 0; i < dausach.DSCT_TacGia.Count; i++)
                dausach.DSCT_TacGia[i].TacGia.TenTG = _dalTacGia.LayTenTG(dausach.DSCT_TacGia[i].TacGia.MaTG);

            return dausach;
        }
        public DataTable LayDuLieuBangDauSach()
        {
            return _daoDauSach.LayDuLieuBangDauSach();
        }
        public bool KiemTraTonTai(DTODauSach dausach)
        {
            return _daoDauSach.KiemTraTonTai(dausach);
        }
        public bool Xoa(string madausach)
        {
            return _daoDauSach.Xoa(madausach);
        }
        public bool KiemTraTonMaTheLoai(string matl)
        {
            return _daoDauSach.KiemTraTonTaiMaTheLoai(matl);
        }
    }
}
