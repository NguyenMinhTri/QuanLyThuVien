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
    public class DAOPhieuTra:DBConnection
    {
        public DAOPhieuTra() : base() { }
        public DTOPhieuTra ConvertToPhieuTra(DataRow row)
        {
            DTOPhieuTra phieutra = new DTOPhieuTra();
            phieutra.MaPhieuTra = row["MaPhieuTra"].ToString();
            try
            {
                phieutra.NgayTra = DateTime.Parse(row["NgayTra"].ToString());
            }
            catch { }
            phieutra.DocGia.MaDG = row["MaDG"].ToString();
            try
            {
                phieutra.TongTienPhat = Double.Parse(row["TongTienPhat"].ToString());
            }
            catch { }
          
            try
            {
                phieutra.ConLai = Double.Parse(row["ConLai"].ToString());
            }
            catch { }

            return phieutra;
        }
        public DataTable LayDanhSachPhieuTra()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spPhieuTra_LayDanhSachPhieuTra", conn);
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
        public bool CapNhat(DTOPhieuTra phieutra)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuTra_CapNhatPhieuTra";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaPhieuTra", SqlDbType.VarChar, 15) { Value = phieutra.MaPhieuTra };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgayTra", SqlDbType.Date) { Value = phieutra.NgayTra };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaDG", SqlDbType.VarChar, 15) { Value = phieutra.DocGia.MaDG };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TongTienPhat", SqlDbType.Money) { Value = phieutra.TongTienPhat };
                cmd.Parameters.Add(sqlParameter);
             
                sqlParameter = new SqlParameter("@ConLai", SqlDbType.Money) { Value = phieutra.ConLai };
                cmd.Parameters.Add(sqlParameter);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return false;
            }
        }
        public bool KiemTraTonTaiMaPhieuTra(string maphieutra)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuTra_DemMaPhieuTra";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaPhieuTra", SqlDbType.VarChar, 15) { Value = maphieutra };
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
        public int DemSoPhieuTra()
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuTra_DemPhieuTra";
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
        public DTOPhieuTra LayPhieuTra(string maphieutra)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spPhieuTra_LayPhieuTra", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaPhieuTra", SqlDbType.VarChar, 15) { Value = maphieutra };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt == null || dt.Rows.Count == 0)
                    return null;
                return ConvertToPhieuTra(dt.Rows[0]);
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }
    }
}
