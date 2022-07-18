using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Dating_App
{
    public class SqlStuff
    {
        public static string strConn = @"server=TEC-F-PC04\MSSQLSERVER3;Initial Catalog=Dating; User Id=sa;Password=Passw0rd;";
        //connection til sql databasen

        public static bool InsertNewUser()
        {
            bool isInserted = false;
            using (SqlConnection connection = new SqlConnection(strConn))
            {
                string query = "INSERT INTO dbo.CreateProfile (firstname, lastname, age, gender, birthDate, personusername, personuserpsw) VALUES " +
                    "(@firstName, @lastName, @Age, @gender, @birthdate, @personUserName, @personUserPsw)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //command.Parameters.AddWithValue("@UserId", CreateUser.UserId);
                    command.Parameters.AddWithValue("@firstname", CreateUser.firstName);
                    command.Parameters.AddWithValue("@lastname", CreateUser.lastName);
                    command.Parameters.AddWithValue("@age", CreateUser.Age);
                    command.Parameters.AddWithValue("@gender", CreateUser.gender);
                    command.Parameters.AddWithValue("@birthDate", CreateUser.BirthDate);
                    command.Parameters.AddWithValue("@personusername", CreateUser.personUserName);
                    command.Parameters.AddWithValue("@personUserpsw", CreateUser.personUserPsw);

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