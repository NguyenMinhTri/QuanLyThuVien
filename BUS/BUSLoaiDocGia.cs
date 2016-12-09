using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class BUSLoaiDocGia
    {
        
        
        DAOLoaiDocGia dtoLoaiDG = new DAOLoaiDocGia();
        public List<DTOLoaiDG> LayDSLoaiDG()
        {
            return dtoLoaiDG.LayDSDocGia();
        }
        public DataTable LayDataDG()
        {
            return dtoLoaiDG.LayDS();
        }
        public bool CapNhat(DTOLoaiDG LoaiDG)
        {
          return  dtoLoaiDG.CapNhatLoaiDG(LoaiDG);
        }
        public bool KiemTra(string MaLoaiDG)
        {
            return dtoLoaiDG.KiemTraTonTai(MaLoaiDG);
        }
        public bool PhatSinhMaLoaiDG(ref DTOLoaiDG loaiDG)
        {
            try
            {
                int stt = dtoLoaiDG.SoLuongLoaiDocGia() + 1;
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
                    loaiDG.MaLoaiDG = "LDG" + stt.ToString("D" + demSo.ToString());
                }
                else
                    loaiDG.MaLoaiDG = "LDG" + stt.ToString("D3");
                bool iCheck = dtoLoaiDG.KiemTraMaLoaiDG(loaiDG.MaLoaiDG);
                while (iCheck)
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
                        loaiDG.MaLoaiDG = "LDG" + stt.ToString("D" + demSo.ToString());
                    }
                    else
                        loaiDG.MaLoaiDG = "LDG" + stt.ToString("D3");
                    iCheck = dtoLoaiDG.KiemTraMaLoaiDG(loaiDG.MaLoaiDG);
                }

                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool Xoa(string maloaiDG)
        {
            return dtoLoaiDG.Xoa(maloaiDG);
        }
    }
}
