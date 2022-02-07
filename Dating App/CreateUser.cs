using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating_App
{
    public class CreateUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public void CreateUserPage()
        {
            Console.Title = "Create Profile";

            Console.WriteLine("Velkommen til oprettelse af bruger.");

            Console.Write("");
        }
    }
}
