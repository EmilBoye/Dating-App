using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Dating_App
{
    public class CreateUser
    {
        public static string firstName { get; set; }
        public static string lastName { get; set; }
        public static int Age { get; set; }
        public static string gender { get; set; }
        public static DateTime BirthDate { get; set; }
        public static string personUserName { get; set; }
        public static string personUserPsw { get; set; }

        public bool isCreated = true;
        bool AgeConfirm = true;

        public void CreateUserPage()
        {
            Console.Title = "Create Profile";
            Console.Clear();
            Console.ResetColor();

            Console.WriteLine("Velkommen til oprettelse af bruger.\n");

            CreateUserInfo();
        }
        public void CreateUserInfo()
        {
            Console.Clear();
            Console.Write("Indtast fornavn: ");
            firstName = Console.ReadLine();
            
            Console.Write("Indtast efternavn: ");
            lastName = Console.ReadLine();


            AgeConfirm = true;
            do
            {
                try
                {
                    Console.Write("Indtast alder: ");
                    Age = Convert.ToInt32(Console.ReadLine());
                    if (Age >= 18)
                    {
                        Console.ResetColor();
                        Console.WriteLine("Alderen er accepteret.");
                        AgeConfirm = false;
                    }
                    else
                    {
                        Age.ToString("");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Du er desværre for ung...");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("",e.Message);
                    AgeConfirm = true;
                }
            }while(AgeConfirm);
            

            Console.Write("Indtast køn: ");
            gender = Console.ReadLine();

            isCreated = true;
            do {
                try
                {
                    Console.Write("Indtast fødselsdag dd/mm/yyyy: ");
                    BirthDate = DateTime.Parse(Console.ReadLine());
                    
                    isCreated = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Fejl i fødselsdag",e.Message);
                    isCreated = true;
                }

            } while (isCreated);


            Console.Write("Indtast brugernavn: ");
            personUserName = Console.ReadLine();

            bool ToShort = true;
            do
            {
                try
                {
                    Console.Write("Indtast adgangskode: ");
                    personUserPsw = Console.ReadLine();

                    if (personUserPsw.Length >= 6)
                    {
                        Console.ResetColor();
                        Console.WriteLine("Det er sikkert nok");
                        Console.WriteLine();
                        
                        ToShort = false;
                    }
                    else
                    {
                        personUserPsw = "";
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Dit password er for kort. Minimum seks");
                    }
                }
                catch(Exception f)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("dit password er for kort!! " +
                        "", f.Message);
                    ToShort = true;
                }

            } while (ToShort);

            SqlStuff.InsertNewUser();
            var la = new LoginPage();
            la.LogPage();
        }
        //private int GetAge(DateTime yearsold)
        //{
        //    int age = 0;
        //    age = DateTime.Now.Subtract(yearsold).Days;
        //    age = age / 365;
        //    return age;
        //}
        //public int GetAge()
        //{
        //    return GetAge(DateTime.Now);
        //}
    }
}
