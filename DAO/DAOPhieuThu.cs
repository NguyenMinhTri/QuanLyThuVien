using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAOPhieuThu:DBConnection
    {
        public DAOPhieuThu() : base() { }

        public DTOPhieuThu ConvertToPhieuThu(DataRow row)
        {
            DTOPhieuThu phieuthu = new DTOPhieuThu();
            phieuthu.MaPhieuThu = row["MaPhieuThu"].ToString();
            try
            {
                phieuthu.NgayLap = DateTime.Parse(row["NgayLap"].ToString());
            }
            catch { }
            phieuthu.DocGia.MaDG = row["MaDG"].ToString();
            try
            {
                phieuthu.SoTienThu = Double.Parse(row["TienThu"].ToString());
            }
            catch { }
            try
            {
                phieuthu.ConLai = Double.Parse(row["ConLai"].ToString());
            }
            catch { }

            return phieuthu;
        }
        public DataTable LayDanhSachPhieuThu()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spPhieuThu_LayDanhSachPhieuThu", conn);
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
        public DTOPhieuThu LayPhieuThu(string maphieuthu)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spPhieuThu_LayPhieuThu", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaPhieuThu", SqlDbType.VarChar, 15) { Value = maphieuthu };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt == null || dt.Rows.Count == 0)
                    return null;
                return ConvertToPhieuThu(dt.Rows[0]);
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }
        public int DemSoPhieuThu()
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuThu_DemPhieuThu";
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
        public bool KiemTraTonTaiMaPThu(string maphieuthu)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuThu_DemMaPhieuThu";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaPhieuThu", SqlDbType.VarChar, 15) { Value = maphieuthu };
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

        public bool CapNhat(DTOPhieuThu phieuthu)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuThu_CapNhatPhieuThu";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaPhieuThu", SqlDbType.VarChar, 15) { Value = phieuthu.MaPhieuThu };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgayLap", SqlDbType.Date) { Value = phieuthu.NgayLap };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaDG", SqlDbType.VarChar, 15) { Value = phieuthu.DocGia.MaDG };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TienThu", SqlDbType.Money) { Value = phieuthu.SoTienThu };
                cmd.Parameters.Add(sqlParameter);
                
                sqlParameter = new SqlParameter("@ConLai", SqlDbType.Money) { Value = phieuthu.ConLai };
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

    }
}
