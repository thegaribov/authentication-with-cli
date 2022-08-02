using AuthenticationWithClie.ApplicationLogic;
using AuthenticationWithClie.Database.Models;
using AuthenticationWithClie.Database.Models.Common;
using AuthenticationWithClie.Database.Repository;
using AuthenticationWithClie.Database.Repository.Common;
using System;
using System.Collections.Generic;

namespace AuthenticationWithClie.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserRepository userRepository = new UserRepository();

            userRepository.Add(new User("Mahmood", "Garibov", "123", "!23", 1));

            User user = userRepository.GetById(1);
            List<User> users = userRepository.GetAll();
            userRepository.Delete(user);

            UserRepository userRepository2 = new UserRepository();


            UserRepository userRepository = new UserRepository();

            //Console.WriteLine();
            //Console.WriteLine("Commands :");
            //Console.WriteLine("/register");
            //Console.WriteLine("/login");
            //Console.WriteLine("/exit");

            //while (true)
            //{
            //    Console.WriteLine();
            //    Console.Write("Enter command : ");
            //    string command = Console.ReadLine();

            //    if (command == "/register")
            //    {
            //        Authentication.Register();
            //    }
            //    else if (command == "/login")
            //    {
            //        Authentication.Login();
            //    }
            //    else if (command == "/exit")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Command not found!");
            //    }
            //}
        }
    }

}
