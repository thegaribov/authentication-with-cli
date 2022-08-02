using AuthenticationWithClie.ApplicationLogic.Validations;
using AuthenticationWithClie.Database.Repository;
using AuthenticationWithClie.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationWithClie.UI;

namespace AuthenticationWithClie.ApplicationLogic
{
    public class Authentication
    {
        public static void Register()
        {
            string firstName = GetFirstName();
            string lastName = GetLastName();
            string email = GetEmail();
            string password = GetPassword();

            //User user = UserRepository.AddUser(firstName, lastName, email, password);
            //Console.WriteLine($"User successfully registered, his/her details are : {user.GetInfo()}");
            Program.Main(new string[] { });
        }


        private static string GetFirstName()
        {
            string firstName = string.Empty;
            bool isExceptionExists = false;

            do
            {
                try
                {
                    Console.Write("Please enter user's name : ");
                    firstName = Console.ReadLine();
                    isExceptionExists = false;
                }
                catch
                {
                    Console.Write("Something went wrong...");
                    isExceptionExists = true;
                }
            } while (!isExceptionExists && !UserValidation.IsValidFirstName(firstName));

            return firstName;
        }
        private static string GetLastName()
        {
            string lastName = string.Empty;
            bool isExceptionExists = false;

            do
            {
                try
                {
                    Console.Write("Please enter user's last name : ");
                    lastName = Console.ReadLine();
                    isExceptionExists = false;
                }
                catch
                {
                    Console.Write("Something went wrong...");
                    isExceptionExists = true;
                }
            } while (!isExceptionExists && !UserValidation.IsValidLastName(lastName));

            return lastName;
        }
        private static string GetEmail()
        {
            string email = string.Empty;
            bool isExceptionExists = false;

            do
            {
                try
                {
                    Console.Write("Please enter user's email : ");
                    email = Console.ReadLine();
                    isExceptionExists = false;
                }
                catch
                {
                    Console.Write("Something went wrong...");
                    isExceptionExists = true;
                }
            } while (!isExceptionExists && !UserValidation.IsValidEmail(email) && !UserValidation.IsUserExist(email));

            return email;
        }
        private static string GetPassword()
        {
            string password = string.Empty;
            string confirmPassword = string.Empty;
            bool isExceptionExists = false;

            do
            {
                try
                {
                    Console.Write("Please enter user's password : ");
                    password = Console.ReadLine();

                    Console.Write("Please enter confirm password : ");
                    confirmPassword = Console.ReadLine();

                    isExceptionExists = false;
                }
                catch
                {
                    Console.Write("Something went wrong...");
                    isExceptionExists = true;
                }
            } while (!isExceptionExists && !UserValidation.IsValidPassword(password) && !UserValidation.IsPasswordsMatch(password, confirmPassword));

            return password;
        }

        public static void Login()
        {
            Console.Write("Please enter user's email : ");
            string email = Console.ReadLine();

            Console.Write("Please enter user's password : ");
            string password = Console.ReadLine();

            User user = UserRepository.GetUserByEmail(email);

            if (user != null)
            {
                Dashboard.CurrentUser = user;

                if (user is Admin)
                {
                    Dashboard.AdminPanel();
                }
                else
                {
                    Dashboard.UserPanel();
                }
            }
            else
            {
                Console.WriteLine("User is not found, password or email is inccorrect");
                Console.WriteLine($"User successfully authenticated : {user.GetInfo()}");
            }
        }
    }
}
