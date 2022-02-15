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
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int Age { get; set; }
        public string gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string personUserName { get; private set; }
        public string personUserPassword { get; private set; }

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
            var connection = new SqlConnection();

            connection.Open();
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

            Console.Write("Indtast fødselsdag dd/mm/yyyy: ");
            BirthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Indtast brugernavn: ");
            personUserName = Console.ReadLine();

            Console.Write("Indtast adgangskode: ");
            personUserPassword = Console.ReadLine();

            //string query = "INSERT INTO CreateProfile (ID,FirstName,LastName,Age,Gender,Birthdate,PersonUN,PersonPW) VALUES('" + firstName + "";
        }
    }
}
