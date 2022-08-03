using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dating_App.HelpFunctions;

namespace Dating_App
{
    public static class UserMain
    {
        public static void userMain()
        {
            bool Restart = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Velkommen til Main");
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Indstillinger (1)");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Find matches! Ud og led! (2)");

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Log ud (3)");
                Console.Write("->: ");
                Console.Beep(200,200);

                int yourChoice = Convert.ToInt32(HelpFunctions.InputChoice("123"));


                if (yourChoice == 1)
                {
                    var settings = new EditUser();
                    settings.Settings();
                }

                if (yourChoice == 2)
                {
                    /*var fg = new FindDamer();
                    fg.FGirls();*/
                    var startPage = new StartPage();
                    startPage.Start_Page();
                }
                if (yourChoice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Du er nu logget ud ");
                    var lp = new StartPage();
                    lp.Start_Page();
                }

            } while (Restart == true);
        }
    }
}
