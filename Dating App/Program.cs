using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating_App
{
    class Program
    {
        static void Main(string[] args)
        {
            var loginScreen = new LoginPage();
            loginScreen.Login();
            Console.ReadKey();
        }
    }
}
