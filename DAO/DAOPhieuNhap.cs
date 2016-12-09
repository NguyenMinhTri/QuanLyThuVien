using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DAOPhieuNhap:DBConnection
    {
        public DAOPhieuNhap() : base() { }
        public DTOPhieuNhap ConvertToPhieuNhap(DataRow row)
        {
            DTOPhieuNhap phieunhap = new DTOPhieuNhap();
            phieunhap.MaPhieuNhap = row["MaPhieuNhap"].ToString();
            try
            {
                phieunhap.NgayNhap = DateTime.Parse(row["NgayNhap"].ToString());
            }
            catch { }
            try
            {
                phieunhap.TongTriGia = Double.Parse(row["TongTriGia"].ToString());
            }
            catch { }
            return phieunhap;
        }
        //Đếm số phiếu nhập
        public int SoLuongPhieuNhap()
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuNhap_DemPhieuNhap";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    dem = Convert.ToInt32(rd[""]);
                rd.Close();
                return dem;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return -1;

            }

        }
        public DataTable DanhSachPhieuNhap()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spPhieuNhap_LayDanhSachPhieuNhap", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }
        public bool Xoa(string mapn)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuNhap_CapNhatPhieuNhap";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 0 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaPhieuNhap", SqlDbType.VarChar, 15) { Value = mapn };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgayNhap", SqlDbType.Date) { Value = DateTime.Today};
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TongTriGia", SqlDbType.Money) { Value = 0 };
                cmd.Parameters.Add(sqlParameter);

                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;

                return false;
            }
        }
        public bool CapNhatPhieuNhap(DTOPhieuNhap phieunhap)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuNhap_CapNhatPhieuNhap";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaPhieuNhap", SqlDbType.VarChar, 15) { Value = phieunhap.MaPhieuNhap };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgayNhap", SqlDbType.Date) { Value = phieunhap.NgayNhap };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TongTriGia", SqlDbType.Money) { Value = phieunhap.TongTriGia };
                cmd.Parameters.Add(sqlParameter);
           
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
               
                return false;
            }
        }
        public bool CapNhatTriGia(double sotienbitru, string mapn)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuNhap_CapNhatTriGia";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
               
                SqlParameter sqlParameter = new SqlParameter("@MaPhieuNhap", SqlDbType.VarChar, 15) { Value = mapn };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TongTriGia", SqlDbType.Money) { Value = sotienbitru };
                cmd.Parameters.Add(sqlParameter);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
                return false;
            }
        }
        public bool CapNhatTongTriGia(string mapn,double sotien)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "[spPhieuNhap_UpdateTongTriGia]";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sqlParameter = new SqlParameter("@MaPhieuNhap", SqlDbType.VarChar, 15) { Value = mapn };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TongTriGia", SqlDbType.Money) { Value = sotien };
                cmd.Parameters.Add(sqlParameter);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
                return false;
            }
        }
        public DTOPhieuNhap LayPhieuNhap(string maphieunhap)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spPhieuNhap_LayPhieuNhap", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaPhieuNhap", SqlDbType.VarChar, 15) { Value = maphieunhap };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt == null || dt.Rows.Count == 0)
                    return null;
                return ConvertToPhieuNhap(dt.Rows[0]);
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }
        public bool KiemTraTonTaiMaPN(string maphieunhap)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuNhap_DemMaPhieuNhap";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaPhieuNhap", SqlDbType.VarChar, 15) { Value = maphieunhap };
                cmd.Parameters.Add(sqlParameter);

                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                    dem = Convert.ToInt32(rd[""]);
                rd.Close();
                if (dem > 0)
                    return true;
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return false;
            }
        }

    }
}
