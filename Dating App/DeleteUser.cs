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
            try
            {
                var sqlcon = new SqlConnection(@"server=TEC-F-PC04\MSSQLSERVER3;Initial Catalog=Dating; User Id=sa;Password=Passw0rd;");
                sqlcon.Open();
                SqlCommand cmd;
                Console.WriteLine(LoginPage.puaId);

                cmd = new SqlCommand("DELETE FROM CreateProfile WHERE UserId="+ LoginPage.puaId, sqlcon);
                //cmd.Parameters.Add("@UserId", System.Data.SqlDbType.Int).Value = CreateUser.UserId;
                cmd.Parameters.AddWithValue("@UserId", LoginPage.puaId);
                cmd.Connection = sqlcon;
                cmd.ExecuteNonQuery();

                if (sqlcon.State == System.Data.ConnectionState.Open)

                {
                    sqlcon.Close();
                }
                sqlcon.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
    }
}
