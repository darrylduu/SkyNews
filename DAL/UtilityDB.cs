using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyNews.DAL
{
    class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=E7470\\SQLEXPRESS;database=SkyViewDB;user=sa;password=Sarah1010";
            conn.Open();
            return conn;
        }

    }
}
