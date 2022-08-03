using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace Dating_App
{
    public class LoginPage
    {

        // Den private int giver programmet en mulighed,
        // for at kunne opdaterer ved en pludselig ændring.
        private static int _puaId;

        public static int puaId
        {
            get { return _puaId; }
            set { _puaId = value; }
        }
        public void LogPage()
        {
            bool IsLoggedIn = true;
            do
            {
                Console.Clear();
                SqlConnection sqlCon = new SqlConnection(SqlStuff.strConn);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Indtast dit username");
                Console.Write("-> ");
                string username = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Indtast password");
                Console.Write("-> ");
                string password = Console.ReadLine();


                if (sqlCon.State == System.Data.ConnectionState.Closed)
                    sqlCon.Open();
                string query = $"SELECT UserId FROM CreateProfile WHERE personusername = '{ username}' AND personuserpsw = '{password}'";

                //Console.WriteLine($"Din streng: {query}");
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);

                puaId = Convert.ToInt32(sqlCmd.ExecuteScalar());

                if (puaId != 0)
                {
                    Console.Clear();
                    Console.WriteLine("Du er nu logget ind som: {0}",username);

                    UserMain.userMain();
                }
                else
                {
                    Console.WriteLine("Username or Password is incorrect! ");
                    Console.WriteLine();
                    Console.Write("Vil du prøve igen? (Y) for ja eller Opret profil (C) ");
                    Console.Write("-> ");
                    string yesno = Console.ReadLine().ToUpper();
                    if (yesno == "Y")
                    {
                        var lp = new LoginPage();
                        lp.LogPage();
                    }
                    else if (yesno == "C")
                    {
                        var cup = new CreateUser();
                        cup.CreateUserPage();
                    }
                }

                Console.ReadLine();
                Console.Clear();

                sqlCon.Close();
                
            } while (IsLoggedIn == false);
        }
    }
}
