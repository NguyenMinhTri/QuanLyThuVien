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
    public class DAOCT_PhieuMuon:DBConnection
    {
        public DAOCT_PhieuMuon() : base() { }
        public DTOCT_PhieuMuon ConvertToCT_PhieuMuon(DataRow row)
        {
            DTOCT_PhieuMuon ctpmu = new DTOCT_PhieuMuon();
            ctpmu.MaPhieuMuon = row["MaPhieuMuon"].ToString();
            ctpmu.MaCuonSach = row["MaCuonSach"].ToString();
            return ctpmu;
        }
        public bool CapNhat(DTOCT_PhieuMuon ctpmu)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spCT_PhieuMuon_CapNhatCTPM";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@ThaoTac", SqlDbType.Int) { Value = 1 };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaPhieuMuon", SqlDbType.VarChar, 15) { Value = ctpmu.MaPhieuMuon };
                cmd.Parameters.Add(sqlParameter);
                sqlParameter = new SqlParameter("@MaCuonSach", SqlDbType.VarChar, 15) { Value = ctpmu.MaCuonSach };
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
        public List<DTOCT_PhieuMuon> LayDanhSachCT_PhieuMuon(string maphieumuon)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string spName = "spPhieuMuon_LayCT_PhieuMuon";
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter sqlParameter = new SqlParameter("@MaPhieuMuon", SqlDbType.VarChar, 15) { Value = maphieumuon };
                cmd.Parameters.Add(sqlParameter);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable data = new DataTable();
                da.Fill(data);
                conn.Close();

                if (data == null || data.Rows.Count == 0)
                    return null;
                else
                {

                    List<DTOCT_PhieuMuon> list = new List<DTOCT_PhieuMuon>();
                    foreach (DataRow row in data.Rows)
                        list.Add(ConvertToCT_PhieuMuon(row));
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
