using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    public class DAOLoaiDocGia : DBConnection
    {
        public DAOLoaiDocGia() : base() { }
        public DTOLoaiDG ConvertToLoaiDG(DataRow row)
        {
            DTOLoaiDG loaiDG = new DTOLoaiDG();
            loaiDG.MaLoaiDG = row["MaLoaiDG"].ToString();
            loaiDG.TenLoaiDG = row["TenLoaiDG"].ToString();

            return loaiDG;
        }
        public List<DTOLoaiDG> LayDSDocGia()
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spLoaiDocGia_LayDanhSachLoaiDG", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
                List<DTOLoaiDG> list = new List<DTOLoaiDG>();
                for (int i = 0; i < dt.Rows.Count; i++)
                    list.Add(ConvertToLoaiDG(dt.Rows[i]));
                return list;

            }
            catch (Exception)
            {
                conn.Close();
            }
            return null;
        }
        public DataTable LayDS()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spLoaiDocGia_LayDanhSachLoaiDG", conn);
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
        public bool CapNhatLoaiDG(DTOLoaiDG loaiDG)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spLoaiDocGia_CapNhapLoaiDG";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaLoaiDG", SqlDbType.VarChar, 15) { Value = loaiDG.MaLoaiDG };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TenLoaiDG", SqlDbType.NVarChar, 70) { Value = loaiDG.TenLoaiDG };
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
        public bool KiemTraTonTai(string maLoaiDG)

        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spLoaiDocGia_DemMaLoaiDG";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaLoaiDG", SqlDbType.VarChar, 15) { Value = maLoaiDG };
                cmd.Parameters.Add(sqlParameter);
                SqlDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                    dem = Convert.ToInt32(rd[""]);
                rd.Close();
                if (dem == 0)
                {
                    conn.Close();
                    return false;
                }
                else
                {
                    conn.Close();
                    return true;
                }

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return false;

            }

        }
        public int SoLuongLoaiDocGia()
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spLoaiDocGia_DemLoaiDG";
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
        public bool KiemTraMaLoaiDG(string MaLoaiDG)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spLoaiDocGia_KiemTraMaLoaiDocGia";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaLoaiDG", SqlDbType.VarChar, 15) { Value = MaLoaiDG };
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
        public bool Xoa(string maloaiDG)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spLoaiDocGia_CapNhapLoaiDG";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 0 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaLoaiDG", SqlDbType.VarChar, 15) { Value = maloaiDG };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TenLoaiDG", SqlDbType.NVarChar, 70) { Value = "" };
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
        public string LayTenLoaiDG(string maloaidg)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand("spLoaiDocGia_LayTenLoaiDG", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaLoaiDG", SqlDbType.VarChar, 15) { Value = maloaidg };

                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();
                if (data == null || data.Rows.Count == 0)
                    return null;
                else
                {
                    return data.Rows[0][0].ToString();
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
