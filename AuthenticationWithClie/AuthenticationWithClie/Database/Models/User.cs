using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationWithClie.Database.Models
{
    public class User
    {
        public int MyProperty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

        public virtual string GetInfo()
        {
            return $"Hello user, {FirstName} {LastName}";
        }
    }
}
