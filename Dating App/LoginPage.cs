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
        public void LogPage()
        {
        //    do
        //    {
        //        SqlConnection sqlCon = new SqlConnection(sqlStuff.strConn);
        //        Console.Clear();
        //        Console.ForegroundColor = ConsoleColor.Blue;
        //        Console.WriteLine("Indtast dit username");
        //        Console.Write("-> ");
        //        string username = Console.ReadLine();

        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.WriteLine("Indtast password");
        //        Console.Write("-> ");
        //        string password = Console.ReadLine();

        //        Console.Beep();
        //        //SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-M8A87VO;Initial Catalog=Tinder 3.0;Integrated Security=True");

        //        if (sqlCon.State == System.Data.ConnectionState.Closed)
        //            sqlCon.Open();
        //        string query = $"SELECT PUAID FROM PersonUserAccont WHERE PersonUserName = '{ username}' AND PersonUserPassword = '{password}'";

        //        //Console.WriteLine($"Din streng: {query}");
        //        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
        //        //sqlCmd.CommandType = System.Data.CommandType.Text;
        //        //sqlCmd.Parameters.AddWithValue("@Username", txtUsername.Text);
        //        //sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password);
        //        int puaId = Convert.ToInt32(sqlCmd.ExecuteScalar());
        //        if (puaId != 0)
        //        {
        //            Console.WriteLine("Du er logget ind");

        //            Sheard_data.PUAID = puaId;

        //            UserMain.userMain();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Username or Password is incorrect! ");
        //            Console.WriteLine("your idiot");
        //            Console.WriteLine();
        //            Console.Write("Vil du prøve igen? 👍 for ja eller Opret profil (C) ");
        //            Console.Write("-> ");
        //            string yesno = Console.ReadLine().ToUpper();
        //            if (yesno == "Y")
        //            {
        //                var lp = new Loginpage();
        //                lp.LogPage();
        //            }
        //            else if (yesno == "C")
        //            {
        //                var cup = new CreateUser();
        //                cup.CreateUPage();
        //                Console.Clear();
        //            }
        //        }

        //        Console.ReadLine();
        //        Console.Clear();

        //        sqlCon.Close();

        //    } while (IsLoggedIn == false);

        }
    }
}
