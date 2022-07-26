using AuthenticationWithClie.Database.Models;
using AuthenticationWithClie.Database.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationWithClie.ApplicationLogic
{
    public static partial class Dashboard
    {
        public static User CurrentUser { get; set; }

        public static void AdminPanel()
        {
            string command = Console.ReadLine();

            if (command == "/make-admin")
            {
                string email = Console.ReadLine();
                User user = UserRepository.GetUserByEmail(email);

                if (user == null)
                {
                    Console.WriteLine("Email ile isitfadeci tapilmadi");
                }
                else
                {
                    UserRepository.Delete(user);
                    Admin admin = new Admin(user.FirstName, user.LastName, user.Email, user.Password, user.Id);
                    UserRepository.AddUser(admin);
                }
            }
            else
            {

            }

            if (command == "/show-reports")
            {
                List<Report> reports = ReportRepository.GetAll();
                int reportCounter = 1;

                foreach (Report report in reports)
                {
                    Console.WriteLine($"{reportCounter}." + report.GetInfo());
                    reportCounter++;
                }

            }
        }
    }

    public static partial class Dashboard
    {
        public static void UserPanel()
        {
            while (true)
            {
                string command = Console.ReadLine();

                if (command == "/report")
                {
                    string email = Console.ReadLine();
                    string content = Console.ReadLine();

                    User to = UserRepository.GetUserByEmail(email); //DRY

                    if (to == null)
                    {
                        Console.WriteLine("Email ile isitfadeci tapilmadi");
                    }
                    if (to == CurrentUser)
                    {
                        Console.WriteLine("oZUVUZU REPORT Ede bilmezsiniz");
                    }
                    else
                    {
                        ReportRepository.Add(CurrentUser, to, content);
                    }
                }
                else
                {
                    return;
                }
            }
        }
    }
}