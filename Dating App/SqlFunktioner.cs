using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Dating_App
{
    public class SqlFunktioner
    {
        public static string connection = @"";

        public static bool InsertNewUser()
        {
            bool IsInserted = false;

            using (SqlConnection sqlConnection = new SqlConnection(connection))
            {
                string query = "INSERT INTO "
            }
        }
    }
}
