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
    public class DAOTK_MuonSach:DBConnection
    {
        public DAOTK_MuonSach() : base() { }
        public int DemPhieuTK(DTOTK_MuonSach tkMuonSach)

        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spTK_MuonSach_DemPhieuTK";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlprThangTK = new SqlParameter("@ThangTK", SqlDbType.Int) { Value = tkMuonSach.ThangTK };
                SqlParameter sqlprNamTK = new SqlParameter("@NamTK", SqlDbType.Int) { Value = tkMuonSach.NamTK };
                cmd.Parameters.Add(sqlprThangTK);
                cmd.Parameters.Add(sqlprNamTK);
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
        public bool CapNhat(DTOTK_MuonSach tkMuonSach)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spTK_MuonSach_CapNhatPhieuTK";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@ThangTK", SqlDbType.Int) { Value = tkMuonSach.ThangTK };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@NamTK", SqlDbType.Int) { Value = tkMuonSach.NamTK };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@TongSoLuotMuon", SqlDbType.Int) { Value = tkMuonSach.TongSoLuotMuon };
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
        public bool LayDuLieuTK(ref DTOTK_MuonSach tkMuonSach)
        {
            int dem = -1;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spTK_MuonSach_LayPhieuTK";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThangTK", SqlDbType.Int) { Value = tkMuonSach.ThangTK };
                cmd.Parameters.Add(sqlParameter);
                 sqlParameter = new SqlParameter("@NamTK", SqlDbType.Int) { Value = tkMuonSach.NamTK };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt == null || dt.Rows.Count == 0)
                    return false;
                try
                {
                    tkMuonSach.TongSoLuotMuon = long.Parse(dt.Rows[0]["TongSoLuotMuon"].ToString());
                }
                catch
                { return false; }

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
