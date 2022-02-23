using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating_App
{
    public class HelpFunctions
    {
        public static string InputChoice(string acceptdata)
        {
            int xpos = Console.CursorLeft;
            int ypos = Console.CursorTop;

            bool choiceaccept = false;

            string input = "";

            do
            {
                Console.SetCursorPosition(xpos, ypos);
                Console.WriteLine("");
                Console.SetCursorPosition(xpos, ypos);
                input = Console.ReadLine();

                if (input.Length == 1 && acceptdata.IndexOf(input)>=0)
                {
                    choiceaccept = true;
                }
            } while (choiceaccept == false);
            return input;
        }


    }
}
