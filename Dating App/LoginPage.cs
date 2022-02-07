using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating_App
{
    public class LoginPage
    {
        public void Login()
        {
            Console.WriteLine("Velkommen til forsiden!\n");
            Console.WriteLine("Login (1)");
            Console.WriteLine("Opret (2)");
            Console.WriteLine("Slet  (3)");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Dit valg: ");
            var choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {

            }
            else if (choice == 2)
            {
                Console.Clear();
                var create = new CreateUser();
                create.CreateUserPage();
            }
            else if (choice == 3)
            {
                Console.Clear();
                var delete = new DeleteUser();
                delete.DeleteUserProfile();
            }
        }
    }
}
