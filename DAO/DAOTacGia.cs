using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class DAOTacGia : DBConnection
    {

        public DAOTacGia() : base() { }
        public DTOTacGia ConvertToTacGia(DataRow row)
        {

            DTOTacGia tacgia = new DTOTacGia();
            tacgia.MaTG = row["MaTacGia"].ToString();
            tacgia.TenTG = row["TenTacGia"].ToString();
            return tacgia;
        }
        //Danh Sách Tác Giả

        public List<DTOTacGia> LayDSTacGia()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand(" spTacGia_LayDanhSachTG", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null)
                    return null;
                else
                {
                    List<DTOTacGia> list = new List<DTOTacGia>();
                    for (int i = 0; i < data.Rows.Count; i++)
                        list.Add(ConvertToTacGia(data.Rows[i]));
                    return list;
                }
            }
            catch
            {
                return null;
            }
        }

        //Thao tac cap nhat tac gia
        public bool CapNhat(DTOTacGia tacgia)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spTacGia_CapNhatTG";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaTacGia", SqlDbType.VarChar, 15) { Value = tacgia.MaTG };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TenTacGia", SqlDbType.NVarChar, 70) { Value = tacgia.TenTG };
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
        //Đếm số tác giả đã tồn tại
        public int SoLuongTacGia()
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spTacGia_DemTG";
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
        public DataTable LayDS()
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spTacGia_LayDanhSachTG", conn);
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

        public string LayTenTG(string matg)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spTacGia_LayTenTG", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaTacGia", SqlDbType.VarChar, 15) { Value = matg };
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
        public bool Xoa(string matg)
        {

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spTacGia_CapNhatTG";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 0 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaTacGia", SqlDbType.VarChar, 15) { Value = matg };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TenTacGia", SqlDbType.NVarChar, 70) { Value ="" };
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
        public bool KiemTraMaTacGia(string matg)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spTacGia_KiemTraMaTG";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaTacGia", SqlDbType.VarChar, 15) { Value = matg };
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
