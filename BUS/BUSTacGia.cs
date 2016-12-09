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
    public class BUSTacGia
    {
        DAOTacGia _daoTacGia = new DAOTacGia();
        //Giới hạn số lượng 100 tác giả
        public bool PhatSinhMaTG(ref DTOTacGia tacgia)
        {
            
            int stt = _daoTacGia.SoLuongTacGia();
            if (stt > 100)
                return false;
            stt++;
            tacgia.MaTG = "TG" + stt.ToString("D3");
            bool iCheck = _daoTacGia.KiemTraMaTacGia(tacgia.MaTG);
            while(iCheck)
            {
                stt++;
                tacgia.MaTG = "TG" + stt.ToString("D3");
                iCheck = _daoTacGia.KiemTraMaTacGia(tacgia.MaTG);
                
            }
            return true;
        }
        //Bao gồm các thao tác thêm, sửa delete
        public bool CapNhat(DTOTacGia tacgia)
        {
            return _daoTacGia.CapNhat(tacgia);
        }
        //Lấy danh sách tác giả hiện có
        public DataTable DanhSachTacGia()
        {
            return _daoTacGia.LayDS();
        }
        public List<DTOTacGia> listTacGia()
        {
            return _daoTacGia.LayDSTacGia();
        }
        public string LayTenTG(string matg)
        {
            return _daoTacGia.LayTenTG(matg);
        }
        public bool Xoa(string matg)
        {
            return _daoTacGia.Xoa(matg);
        }
       
    }
}
