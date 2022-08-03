using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating_App
{
    public class EditUser
    {
        public void Settings()
        {
            Console.ResetColor();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ændre din profil (1)");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Slet din profil (2)");
            Console.Write("->: ");

            int choice = Convert.ToInt32(HelpFunctions.InputChoice("12"));

            if (choice == 1)
            {
                Console.ResetColor();
                var editUser = new EditUser();
                editUser.EditUserChanges();
            }
            else if (choice == 2)
            {
                var DelUser = new DeleteUser();
                DelUser.DeleteUserProfile();
            }
        }
        public void EditUserChanges()
        {
            string firstName = "";
            string lastName = "";
            string gender = "";
            DateTime birthDate = SqlDateTime.MaxValue.Value;
            string personUserName = "";
            string personUserPsw = "";

            SqlConnection sqlConnection = new SqlConnection(SqlStuff.strConn);

            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
            var query = $"SELECT * FROM CreateProfile WHERE UserId =" + LoginPage.puaId;
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                firstName = sqlDataReader["firstname"].ToString();
                lastName = sqlDataReader["lastname"].ToString();
                gender = sqlDataReader["gender"].ToString();
                birthDate = (DateTime)sqlDataReader["birthDate"];
                personUserName = sqlDataReader["personusername"].ToString();
                personUserPsw = sqlDataReader["personuserpsw"].ToString();
            }
            sqlDataReader.Close();
            sqlDataReader = null;
            string valg = "";
            bool dataokay = true;
            do
            {
                Console.Clear();

                Console.WriteLine("(1)       Fornavn: " + firstName);
                Console.WriteLine("(2)     Efternavn: " + lastName);
                Console.WriteLine("(3)        Gender: " + gender);
                Console.WriteLine("(4)    Fødselsdag: " + birthDate.ToString());
                Console.WriteLine("(5)     User Name: " + personUserName);
                Console.WriteLine("(6) User Password: " + personUserPsw);
                Console.WriteLine();
                Console.WriteLine("(f) for at fortryde dit valg");
                Console.WriteLine("(g) for at gemme");
                Console.WriteLine();
                Console.WriteLine("Bruger Id: " + LoginPage.puaId);
                Console.WriteLine();
                Console.Write("-> ");
                Console.Beep();
                valg = HelpFunctions.InputChoice("123456fg");
                Console.WriteLine();

                switch (valg)
                {
                    case "1":
                        Console.WriteLine("Indtast nyt fornavn");
                        Console.Write("-> ");
                        firstName = Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("Indtast nyt efternavn");
                        Console.Write("-> ");
                        lastName = Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("Indtast nyt køn");
                        Console.Write("-> ");
                        gender = Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine("Indtast ny fødselsdag");
                        Console.Write("-> ");
                        birthDate = DateTime.Parse(Console.ReadLine());
                        break;                    
                    
                    case "5":
                        Console.WriteLine("Indtast nyt brugernavn");
                        Console.Write("-> ");
                        personUserName = Console.ReadLine();
                        break;
                    
                    case "6":
                        Console.WriteLine("Indtast nyt password");
                        Console.Write("-> ");
                        personUserPsw = Console.ReadLine();
                        break;

                    case "g":
                        dataokay = true;
                        if (firstName.Length == 0 || firstName.Length > 30)
                        {
                            Console.WriteLine("Navn er ikke korrekt!");
                            dataokay = false;
                        }
                        if (lastName.Length == 0 || lastName.Length > 30)
                        {
                            Console.WriteLine("Navn er ikke korrekt!");
                            dataokay = false;
                        }
                        if (gender.Length == 0 || gender.Length >= 7)
                        {
                            Console.WriteLine("Køn er ikke korrekt!");
                            dataokay = false;
                        }
                        if (birthDate > DateTime.Now)
                        {
                            Console.WriteLine("Fødselsdag er ikke KORREKT!!");
                            dataokay = false;
                        }
                        if (personUserName.Length == 0 || personUserName.Length > 40)
                        {
                            Console.WriteLine("Brugernavenet er ikke KORREKT!!");
                            dataokay = false;
                        }
                        if (personUserPsw.Length == 0 || personUserPsw.Length > 20)
                        {
                            Console.WriteLine("Password er ikke KORREKT!!");
                            dataokay = false;
                        }
                        try
                        {
                            if (dataokay == false)
                            {
                                Console.WriteLine("Gør det ordenligt");
                                Console.WriteLine("Tryk på slukknappen for at forsætte");
                                Console.ReadLine();
                        }
                            else
                            {
                                //query = @"Update CreateProfile SET firstname ='{firstName}',lastname='{lastName}',gender='{gender}'
                                //,birthdate='{birthDate}', personusername='{personUserName}', personuserpsw='{personUserPsw}'WHERE UserId=" + LoginPage.puaId;

                                string sqlUp = "UPDATE CreateProfile SET " +
                                "firstname=@firstName, lastname=@lastName, gender=@gender, birthdate=@birthDate, personusername=@personUserName, personuserpsw=@personUserPsw " +
                                "WHERE UserId=" + LoginPage.puaId;
                                sqlCommand = new SqlCommand(sqlUp, sqlConnection);
                                sqlCommand.Parameters.AddWithValue("@firstName", CreateUser.firstName);
                                sqlCommand.Parameters.AddWithValue("@lastName", CreateUser.lastName);
                                sqlCommand.Parameters.AddWithValue("@gender", CreateUser.gender);
                                sqlCommand.Parameters.AddWithValue("@birthdate", CreateUser.BirthDate);
                                sqlCommand.Parameters.AddWithValue("@personUserName", CreateUser.personUserName);
                                sqlCommand.Parameters.AddWithValue("@personUserPsw", CreateUser.personUserPsw);
                                Console.WriteLine(sqlUp);
                                sqlCommand.ExecuteNonQuery();
                                valg = "f";
                            }
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine(ex.Message);
                            throw;
                        }

                        break;
                }
            } while (valg != "f");
        }
    }
}
