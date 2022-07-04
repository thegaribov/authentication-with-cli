using AuthenticationWithClie.ApplicationLogic.Validations;
using AuthenticationWithClie.Database.Repository;
using AuthenticationWithClie.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationWithClie.ApplicationLogic
{
    public class Authentication
    {
        public static void Register()
        {
            Console.Write("Please enter user's name : ");
            string firstName = Console.ReadLine();

            Console.Write("Please enter user's last name : ");
            string lastName = Console.ReadLine();

            Console.Write("Please enter user's email : ");
            string email = Console.ReadLine();

            Console.Write("Please enter user's password : ");
            string password = Console.ReadLine();

            Console.Write("Please enter user's confirm password : ");
            string confirmPassword = Console.ReadLine();

            if (
                UserValidation.IsValidFirstName(firstName) &
                UserValidation.IsValidLastName(lastName) &
                UserValidation.IsValidEmail(email) &
                UserValidation.IsValidPassword(password, confirmPassword)  //&& -> shirt cut circuit
               )
            {
                User user = UserRepository.AddUser(firstName, lastName, email, password);
                Console.WriteLine($"User added to system, his/her details are : {user.GetUserInfo()}");
            }
        }


        public static void Login()
        {

        }

    }
}
