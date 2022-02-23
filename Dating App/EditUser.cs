using System;
using System.Collections.Generic;
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

            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Slet din profil (2)");


            Console.Write("->: ");

            int choice = Convert.ToInt32(HelpFunctions.InputChoice("12"));
        }
    }
}
