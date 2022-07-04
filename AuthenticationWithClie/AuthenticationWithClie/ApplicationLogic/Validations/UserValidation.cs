using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationWithClie.ApplicationLogic.Validations
{
    public class UserValidation
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

            Console.WriteLine("First name's length should be greater than 3 and less than 30");

            return false;
        }

        public static bool IsValidEmail(string email)
        {
            return true;
        }


        public static bool IsValidPassword(string password, string confirtPassword)
        {
            return true;
        }
    }
}
