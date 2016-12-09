using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class BUSQuyDinh
    {
        DAOQuyDinh daoQuyDinh = new DAOQuyDinh();

        public int getMinAge()
        {
             return  daoQuyDinh.LayTuoiToiThieu();
        }

        public int getMaxAge()
        {
            return daoQuyDinh.LayTuoiToiDa();
        }
        public int getGetMonthEx()
        {
            return daoQuyDinh.SoThangHetHan();
        }
        public int ThoiHanXB()
        {
            return daoQuyDinh.ThoiHanXB();
        }

        public int LaySoNgayMuonTD()
        {
            
            return daoQuyDinh.LaySongayMuonTD();
        }

        public int LaySoSachMuonTD()
        {
            return daoQuyDinh.LaySoSachMuonTD();
        }

        public double LayTienPhatMoiNgay()
        {
         
            return daoQuyDinh.LayTienPhatMoiNgay();
        }
        public bool CapNhat(DTOQuyDinh quydinh)
        {
           
            return daoQuyDinh.CapNhat(quydinh);
        }
        public bool ThemQuyDinh(DTOQuyDinh quydinh)
        {

            return daoQuyDinh.ThemQuyDinh(quydinh);
        }
        public DTOQuyDinh LayQuyDinh()
        {
           
            return daoQuyDinh.LayQuyDinh();
        }
    }
}
