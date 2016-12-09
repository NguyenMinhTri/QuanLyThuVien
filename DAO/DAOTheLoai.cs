using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAO
{
    public class DAOTheLoai:DBConnection
    {
        public DAOTheLoai() : base() { }
        public DTOTheLoai ConvertToTLSach(DataRow row)
        {
            DTOTheLoai tlSach = new DTOTheLoai();
            tlSach.MaTheLoai = row["MaTheLoai"].ToString();
            tlSach.TenTheLoai = row["TenTheLoai"].ToString();
            return tlSach;
        }
        public int SoLuongTheLoai()
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spTheLoai_DemTL";
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
        public bool Xoa(string matheloai)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spTheLoai_CapNhatTheLoai";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 0 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaTheLoai", SqlDbType.VarChar, 15) { Value = matheloai };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TenTheLoai", SqlDbType.NVarChar, 70) { Value = "" };
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
        public bool CapNhat(DTOTheLoai theloai)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spTheLoai_CapNhatTheLoai";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaTheLoai", SqlDbType.VarChar, 15) { Value = theloai.MaTheLoai };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TenTheLoai", SqlDbType.NVarChar, 70) { Value = theloai.TenTheLoai };
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
        public DataTable LayDS()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spTheLoai_LayDanhSachTL", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
          
                return dt;
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }
        public List<DTOTheLoai> ListTheLoai()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spTheLoai_LayDanhSachTL", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null)
                    return null;
                else
                {
                    List<DTOTheLoai> list = new List<DTOTheLoai>();
                    for (int i = 0; i < data.Rows.Count; i++)
                        list.Add(ConvertToTLSach(data.Rows[i]));
                    return list;
                }
            }
            catch
            {
                return null;
            }
        }

        public string LayTenTheLoai(string matheloai)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spTheLoai_LayTenTL", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaTheLoai", SqlDbType.VarChar, 15) { Value = matheloai };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }
        public bool KiemTraMaTheLoai(string  matl)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spTheLoai_KiemTraMaTheLoai";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaTheLoai", SqlDbType.VarChar, 15) { Value = matl };
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
