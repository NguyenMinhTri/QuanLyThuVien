using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class BUSCuonSach
    {
        DAOCuonSach _daoCuonSach = new DAOCuonSach();
        public bool PhatSinhMaCuonSach(ref DTOCuonSach cuonsach)
        {
            try
            {
                int stt = _daoCuonSach.DemCuonSach(cuonsach.MaSach) + 1;
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
                    cuonsach.MaCuonSach = cuonsach.MaSach + stt.ToString("D" + demSo.ToString());
                }
                else
                    cuonsach.MaCuonSach = cuonsach.MaSach + stt.ToString("D3");
                bool iCheck = _daoCuonSach.KiemTraMaCuonSach(cuonsach.MaCuonSach);
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
                        cuonsach.MaCuonSach = cuonsach.MaSach + stt.ToString("D" + demSo.ToString());
                    }
                    else
                        cuonsach.MaCuonSach = cuonsach.MaSach + stt.ToString("D3");
                    iCheck = _daoCuonSach.KiemTraMaCuonSach(cuonsach.MaCuonSach);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool CapNhat(DTOCuonSach cuonsach)
        {
            return _daoCuonSach.CapNhat(cuonsach);
        }
        public int DemSoSachMuon(string masach)
        {
            return _daoCuonSach.DemCuonSachMuon(masach);
        }
        public List<string> MaCuonSachXoaDuoc(string masach)
        {
            return _daoCuonSach.MaCuonSachXoaDuoc(masach);
        }
        public bool Xoa(string macuonsach)
        {
            return _daoCuonSach.Xoa(macuonsach);
        }
        public bool KiemTraTonTaiMaCuonSach(string macuonsach)
        {
           return _daoCuonSach.KiemTraMaCuonSach(macuonsach);
        }
        public string MaCuonSachMuonDuoc(string masach)
        {
            return _daoCuonSach.MaCuonSachCoTheMuon(masach);
        }
        public string LayTenDauSach(string macuonsach)
        {
            return _daoCuonSach.TenDauSach(macuonsach);
        }
        public string LayMaTL(string macuonsach)
        {
          
            return _daoCuonSach.LayMaTL(macuonsach);
        }
        public List<DTOTacGia> LayDSTacGia(string macuonsach)
        {
          
            return _daoCuonSach.LayDSTacGia(macuonsach);
        }

        public bool CapNhatTinhTrang(string macuonsach,bool tinhtrang)
        {
            return _daoCuonSach.CapNhatTinhTrang(macuonsach, tinhtrang);
        }
        public string LayTenTL(string macuonsach)
        {
            return _daoCuonSach.LayTenTL(macuonsach);
        }
        public DTOCuonSach LayThongTinCuonSach(string macuonsach)
        {
         
            return _daoCuonSach.LayThongTinCuonSach(macuonsach);
        }
    }
}
