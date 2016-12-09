using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAODuLieu : DBConnection
    {
        static string server_name = "";
        public DAODuLieu() : base() { }
        public bool KhoiTaoChuoiKetNoi(string server, string namedatabase)
        {
            //    if (namedatabase == "DATA_THUVIEN")
            {
                server_name = server;
                DBConnection.conn = new SqlConnection(@"Data Source=" + server + ";Initial Catalog=" + namedatabase + ";Integrated Security=True");
                return true;
            }
            return false;
        }
        public bool SaoLuuDuLieu(string duongdan, string database)
        {
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string sql = "BACKUP DATABASE " + database + " TO DISK = '" + duongdan + "'";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
        public bool PhucHoi(string duongdan, string database)
        {

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                SqlConnection connect = new SqlConnection(@"Data Source=" + server_name + ";Integrated Security=True");

                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }
                string sql = "ALTER DATABASE " + database + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                sql += " RESTORE DATABASE " + database + " FROM DISK = '" + duongdan + "' WITH REPLACE; ";
                SqlCommand command = new SqlCommand(sql, connect);
                command.ExecuteNonQuery();
                connect.Close();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }
        public List<string> DanhSachCoSoDuLieu(string server)
        {

            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source=" + server + ";Integrated Security=True");
                if (connect.State != ConnectionState.Open)
                {
                    connect.Open();
                }

                string sql = "EXEC sp_databases";
                SqlCommand command = new SqlCommand(sql, connect);

                SqlDataReader reader = command.ExecuteReader();

                List<string> list = new List<string>();
                while (reader.Read())
                {

                    list.Add(reader[0].ToString());
                }

                reader.Close();
                connect.Close();
                return list;

            }
            catch (Exception ex)
            {
                string a = ex.Message;
                return null;
            }

        }
    }
}
