using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating_App
{
    public class StartPage
    {
        public void Start_Page()
        {
            Console.Title = "Start";

            Console.WriteLine("Velkommen til forsiden!\n");
            Console.WriteLine("Login (1)");
            Console.WriteLine("Opret (2)");
            Console.WriteLine("Slet  (3)");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Dit valg: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Clear();
                var login = new LoginPage();
                login.Login();
            }
            else if (choice == "2")
            {
                Console.Clear();
                var create = new CreateUser();
                create.CreateUserPage();
            }
            else if (choice == "3")
            {
                Console.Clear();
                var delete = new DeleteUser();
                delete.DeleteUserProfile();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vælg venligst en af de tre muligheder.");
            }
        }
    }
}
