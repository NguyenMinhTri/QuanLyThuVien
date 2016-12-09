using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAOCT_TacGia:DBConnection
    {
        public DAOCT_TacGia() : base() { }
        public DTOCT_TacGia ConvertToCT_TacGia(DataRow row)
        {
            DTOCT_TacGia cttg = new DTOCT_TacGia();
            cttg.MaDauSach = row["MaDauSach"].ToString();
            cttg.TacGia.MaTG = row["MaTG"].ToString();
            return cttg;
        }
        public List<DTOCT_TacGia> LayDSCT_TacGia(string madausach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("spCT_TacGia_LayDanhSachCTTG", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar, 15) { Value = madausach };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt == null)
                    return null;
                List<DTOCT_TacGia> list = new List<DTOCT_TacGia>();
                foreach (DataRow row in dt.Rows)
                    list.Add(ConvertToCT_TacGia(row));
                return list;
            }
            catch (Exception)
            {
                conn.Close();

            }
            return null;
        }
        public int DemCTTG(DTOCT_TacGia cttg)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCT_TacGia_DemCTTG";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar, 15) { Value = cttg.MaDauSach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaTG", SqlDbType.VarChar, 15) { Value = cttg.TacGia.MaTG };
                cmd.Parameters.Add(sqlParameter);
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
        public bool CapNhat(DTOCT_TacGia cttg)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCT_TacGia_CapNhatCTTG";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar, 15) { Value = cttg.MaDauSach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaTG", SqlDbType.VarChar, 15) { Value = cttg.TacGia.MaTG };
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
        public bool Xoa(string madausach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCT_TacGia_Xoa";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaDauSach", SqlDbType.VarChar,15) { Value = madausach };
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
        public bool DieuKienXoaTacGia(string matg)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spTacGia_DemSoDauSach";
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
            catch
            {
                conn.Close();
                return false;
            }
        }
    }
}
