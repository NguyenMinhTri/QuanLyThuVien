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
    public class DAOTK_TraSachTre:DBConnection
    {
        public DAOTK_TraSachTre() : base() { }
        public DTOTK_TraSachTre ConvertToTKTraSachTre(DataRow row)
        {
            DTOTK_TraSachTre tktrasachtre = new DTOTK_TraSachTre();
            try
            {
                tktrasachtre.NgayTK = DateTime.Parse(row["NgayTK"].ToString());
            }
            catch { }
            try
            {
                tktrasachtre.MaCuonSach = row["MaCuonSach"].ToString();
            }
            catch { }
            try
            {
                tktrasachtre.NgayMuon = DateTime.Parse(row["NgayMuon"].ToString());
            }
            catch { }
            try
            {
                tktrasachtre.SoNgayTraTre = Int32.Parse(row["SoNgayTraTre"].ToString());
            }
            catch { }

            return tktrasachtre;
        }
        public int DemPhieuTK(DateTime ngaytk)

        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spTK_TraSachTre_DemPhieuTK";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlprNgayTK = new SqlParameter("@NgayTK", SqlDbType.Date) { Value = ngaytk };
            
                cmd.Parameters.Add(sqlprNgayTK);
              
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
        public bool CapNhat(DTOTK_TraSachTre tktrasachtre)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spTK_TraSachTre_CapNhatPhieuTK";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgayTK", SqlDbType.Date) { Value = tktrasachtre.NgayTK };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaCuonSach", SqlDbType.VarChar, 15) { Value = tktrasachtre.MaCuonSach };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NgayMuon", SqlDbType.Date) { Value = tktrasachtre.NgayMuon };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@SoNgayTraTre", SqlDbType.Int) { Value = tktrasachtre.SoNgayTraTre };
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
        public List<DTOTK_TraSachTre> LayDuLieuThongKe(DateTime ngaytk)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spTK_TraSachTre_LayPhieuTK";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@NgayTK", SqlDbType.Date) { Value = ngaytk };
                cmd.Parameters.Add(sqlParameter);
             
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null || data.Rows.Count == 0)
                    return null;
                else
                {
                   
                    List<DTOTK_TraSachTre> list = new List<DTOTK_TraSachTre>();
                    foreach (DataRow row in data.Rows)
                        list.Add(ConvertToTKTraSachTre(row));

                    return list;

                }

            }
            catch (Exception ex)
            {
                throw ex;
                conn.Close();
                return null;

            }
        }

    }
}
