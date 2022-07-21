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
        public static void AdminPanel()
        {
            Console.WriteLine("/make-admin");
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
        }
    }

    public static partial class Dashboard
    {
        public static void UserPanel()
        {

        }
    }
}