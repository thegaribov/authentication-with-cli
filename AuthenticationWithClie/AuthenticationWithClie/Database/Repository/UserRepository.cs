using AuthenticationWithClie.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthenticationWithClie.Database.Repository.Common;


namespace AuthenticationWithClie.Database.Repository
{
    class UserRepository : Common.Repository<User, int> // full qualified namespace
    {
        private static int _idCounter;

        public static int IdCounter
        {
            get
            {
                _idCounter++;
                return _idCounter;
            }
        }

        //private static List<User> Users { get; set; } = new List<User>()
        //{
        //    new Admin("Mahmood", "Garibov", "qaribovmahmud@gmail.com", "123321"),
        //    new User("Eshqin", "Mahmudov", "eshqin@gmail.com", "123321"),
        //    new User("Yehya", "Mahmudov", "yehya@gmail.com", "123321"),
        //};

        public User AddUser(string firstName, string lastName, string email, string password)
        {
            User user = new User(firstName, lastName, email, password, IdCounter);
            DbContext.Add(user);
            return user;
        }

        public User AddUser(string firstName, string lastName, string email, string password, int id)
        {
            User user = new User(firstName, lastName, email, password, id);
            DbContext.Add(user);
            return user;
        }

        public static bool IsUserExistsByEmail(string email)
        {
            foreach (User user in DbContext)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }

            return false;
        }

        public static User GetUserByEmailAndPassword(string email, string password)
        {
            foreach (User user in DbContext)
            {
                if (user.Email == email && user.Password == password)
                {
                    return user;
                }
            }

            return null;
        }

        public static bool IsUserExistByEmailAndPassword(string email, string password)
        {
            foreach (User user in DbContext)
            {
                if (user.Email == email && user.Password == password)
                {
                    return true;
                }
            }

            return false; ;
        }

        public static User GetUserByEmail(string email)
        {
            foreach (User user in DbContext)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }

            return null;
        }

        public static User GetUserById(int id)
        {
            foreach (User user in DbContext)
            {
                if (user.Id == id)
                {
                    return user;
                }
            }

            return null;
        }

       
        public static User Update(int id, string firstName)
        {
            User user = GetUserById(id);
            user.FirstName = firstName;
            user.UpdatedAt = DateTime.Now;

            return user;
        }
    }
}
