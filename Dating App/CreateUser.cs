using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Dating_App
{
    public class CreateUser
    {
        public static int PUAID;
        public static string firstName { get; set; }
        public static string lastName { get; set; }
        public static int Age { get; set; }
        public static string gender { get; set; }
        public static DateTime BirthDate { get; set; }
        public static string personUserName { get; private set; }
        public static string personUserPsw { get; private set; }

        public bool isCreated = true;

        public void CreateUserPage()
        {
            Console.Title = "Create Profile";

            Console.WriteLine("Velkommen til oprettelse af bruger.\n");
            Console.ResetColor();

            var info = new CreateUser();
            info.CreateUserInfo();
        }

        public void CreateUserInfo()
        {
            /*var connection = new SqlConnection();

            connection.Open();*/
            Console.Write("Indtast fornavn: ");
            firstName = Console.ReadLine();
            
            Console.Write("Indtast efternavn: ");
            lastName = Console.ReadLine();

            Console.Write("Indtast alder: ");
            Age = Convert.ToInt32(Console.ReadLine());
            if (Age < 18)
            {
                Console.WriteLine("Du er desværre for ung...");
                return;
            }
            else
            {
                Console.WriteLine("Alderen er accepteret.");
            }

            Console.Write("Indtast køn: ");
            gender = Console.ReadLine();

            isCreated = true;
            do {
                try
                {
                    Console.Write("Indtast fødselsdag dd/mm/yyyy: ");
                    BirthDate = DateTime.Parse(Console.ReadLine());
                    isCreated = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Fejl i fødselsdag",e.Message);
                    isCreated = true;
                }

            } while (isCreated);


            Console.Write("Indtast brugernavn: ");
            personUserName = Console.ReadLine();

            Console.Write("Indtast adgangskode: ");
            personUserPsw = Console.ReadLine();

            
            //string query = "INSERT INTO CreateProfile (ID,FirstName,LastName,Age,Gender,Birthdate,PersonUN,PersonPW) VALUES('" + firstName + "";
        }
    }
}
