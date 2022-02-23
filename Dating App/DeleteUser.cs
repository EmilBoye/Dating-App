using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating_App
{
    public class DeleteUser
    {
        public void DeleteUserProfile()
        {
            var sqlcon = new SqlConnection(@"");
            SqlCommand cmd;

            if (sqlcon.State == System.Data.ConnectionState.Open)
            {
                sqlcon.Close();
            }

            cmd = new SqlCommand("DELETE FROM PersonUserAccount Where PUAID=@i", sqlcon);

            cmd.Parameters.Add("@i",System.Data.SqlDbType.Int);

        }
    }
}
