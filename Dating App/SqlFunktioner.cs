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
        public static string strConn = @"Data Source=DESKTOP-M8A87VO;Initial Catalog=Dating;Integrated Security=True";
        //connection til sql databasen

        public static bool InsertNewUser()
        {
            bool isInserted = false;

            using (SqlConnection connection = new SqlConnection(strConn))
            {
                string query = "INSERT INTO dbo.PersonUserAccont (FirstName, LastName, BirthDate, PersonUserName, PersonUserPassword) VALUES " +
                    "(@FirstName, @LastName, @birthdate, @PersonUserName, @PersonUserPassword)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", CreateUser.firstName);
                    command.Parameters.AddWithValue("@LastName", CreateUser.lastName);
                    command.Parameters.AddWithValue("@birthdate", CreateUser.BirthDate);
                    command.Parameters.AddWithValue("@PersonUserName", CreateUser.personUserName);
                    command.Parameters.AddWithValue("@PersonUserPassword", CreateUser.personUserPsw);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                    else
                    {
                        Console.WriteLine("Din profil er oprettet!");
                    }
                }
            }

            return isInserted;
        }
    }
}