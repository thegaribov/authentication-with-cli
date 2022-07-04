using AuthenticationWithClie.Database.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationWithClie.ApplicationLogic.Validations
{
    public static class UserValidation
    {
        public static bool IsValidFirstName(string firstName)
        {
            if (Validation.IsLengthBetween(firstName, 3, 30))
            {
                return true;
            }

            Console.WriteLine("First name's length should be greater than 3 and less than 30");

            return false;
        }

        public static bool IsValidLastName(string lastName)
        {
            if (Validation.IsLengthBetween(lastName, 5, 20))
            {
                return true;
            }

            Console.WriteLine("Last name's length should be greater than 5 and less than 20");

            return false;
        }

        public static bool IsValidEmail(string email)
        {
            if (Validation.Contains(email, '@'))
            {
                return true;
            }

            Console.WriteLine("Email should contain @ characher.");

            return false;
        }

        public static bool IsValidPassword(string password, string confirmPassword)
        {
            if (password == confirmPassword)
            {
                return true;
            }

            Console.WriteLine("Password is not match");

            return false;
        }

        public static bool IsUserExist(string email)
        {
            if (UserRepository.IsUserExistsByEmail(email))
            {
                Console.WriteLine("User already exists");

                return true;
            }

            return false;
        }
    }
}
