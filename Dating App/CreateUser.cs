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
        public int Age { get; set; }
        public string gender { get; set; }
        public DateTime BirthDate { get; set; }
        public void CreateUserPage()
        {
            Console.Title = "Create Profile";

            Console.WriteLine("Velkommen til oprettelse af bruger.\n");

            var info = new CreateUser();
            info.CreateUserInfo();
        }

        public void CreateUserInfo()
        {
            Console.Write("Indtast fornavn: ");
            firstName = Console.ReadLine();

        }
    }
}
