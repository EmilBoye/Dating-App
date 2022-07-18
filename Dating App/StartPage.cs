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

            Console.Clear();
            Console.WriteLine("Velkommen til forsiden!\n");
            Console.WriteLine("Login (1)");
            Console.WriteLine("Opret (2)");
            Console.WriteLine("Sluk programmet (3)");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Dit valg: ");

            int yourChoice = Convert.ToInt32(HelpFunctions.InputChoice("123"));

            if (yourChoice == 1)
            {
                var login = new LoginPage();
                login.LogPage();
            }
            else if (yourChoice == 2)
            {
                
                var create = new CreateUser();
                create.CreateUserPage();
            }
            else if (yourChoice == 3)
            {
                var cp = new ClosePage();
                cp.CloseDown();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Vælg venligst en af de tre muligheder.");
            }
        }
    }
}
