﻿using AuthenticationWithClie.Database.Models.Common;
using AuthenticationWithClie.Database.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationWithClie.Database.Models
{
    public class User : Entity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<DateTime> UpdatedAt { get; set; }


        public User(string firstName, string lastName, string email, string password, int? id = null)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;

            if (id != null ) // !id.HasValue  id ==  null
            {
                Id = id.Value;
            }
            else
            {
                Id = UserRepository.IdCounter;
            }

        }

        public virtual string GetInfo()
        {
            return $"Hello user, {FirstName} {LastName}";
        }

        public virtual string GetModifyInfo()
        {
            if (UpdatedAt.HasValue)
            {
                return $"Modifed at {UpdatedAt.Value.ToString("dd/MM/yyyy")}";
            }
            else
            {
                return "Not yet modifed";
            }

        }
    }
}
