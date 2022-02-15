using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dating_App
{
    public class DeleteUser
    {
        public void DeleteUserProfile()
        {
            SqlConnection sqlConnection = new SqlConnection();
            Console.Title = "Slet profil";
            Console.WriteLine("Er du sikker på du vil slette din profil? (1) for ja og (2) for nej.");
            try
            {
                Console.Write("Valg: ");
                var choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Profil er slettet");
                }
                else if (choice == 2)
                {
                    var startPage = new StartPage();
                    startPage.Start_Page();
                }
                else
                {
                    Console.WriteLine("Det var ikke en valg mulighed");
                    Console.Write("Valg: ");
                    var choice1 = Convert.ToInt32(Console.ReadLine());

                    if (choice1 == 1)
                    {
                        Console.WriteLine("Profil er slettet");
                    }
                    else if (choice1 == 2)
                    {
                        Console.Clear();
                        var startPage = new StartPage();
                        startPage.Start_Page();
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
