using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class DBConnection
    {
        protected static SqlConnection conn;// = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Directory.GetCurrentDirectory() + @"\DATA_THUVIEN.mdf;Integrated Security=True;Connect Timeout=30");
        // = new SqlConnection(@"Data Source=TRIUIT\SQLEXPRESS;Initial Catalog=DATA_THUVIEN;Integrated Security=True");
    }

}
