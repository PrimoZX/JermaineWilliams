using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace UI
{
    public class AddUser : IMenu
    {
        private static User newUser = new User();
        private SQLRepo userRepo = new SQLRepo();
        public void Display()
        {
            //Console.WriteLine("Enter User Information:");
            //Console.WriteLine("<1> Fullname: " + newUser.Fullname);
            //Console.WriteLine("<2> Username: " + newUser.Username);
            //Console.WriteLine("<3> Email: " + newUser.Email);
            //Console.WriteLine("<4> UserID: " + newUser.UserID);
            //Console.WriteLine("Press <5> to save the infomation");
            //Console.WriteLine("Press <0> to return to the main menu");
        }

        public string UserChoice()
        {
            Console.Clear();

            Console.WriteLine("Enter User Information: The info here are defaults\nYou can change them with your info if you hit the number on the left of them.");
            Console.WriteLine("<1> Fullname: " + newUser.Fullname);
            Console.WriteLine("<2> Username: " + newUser.Username);
            Console.WriteLine("<3> Email: " + newUser.Email);
            Console.WriteLine("Your randomly generated UserID is: " + newUser.UserID);
            Console.WriteLine("Press <4> to save the infomation");
            Console.WriteLine("Press <0> to return to the main menu");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Please your full name: ");
                    newUser.Fullname = Console.ReadLine();
                    return "adduser";

                case "2":
                    Console.WriteLine("Please enter a username you would like to use: ");
                    newUser.Username = Console.ReadLine();
                    return "adduser";

                case "3":
                    Console.WriteLine("Please enter your email: ");
                    newUser.Email = Console.ReadLine();
                    return "adduser";

                case "4":
                    userRepo.AddUser(newUser);
                    return "mainMenu";

                case "0":
                    return "mainmenu";
                
                default:
                    Console.WriteLine("Please use the correct key");
                    Console.WriteLine("Press <Enter> to continue");
                    Console.ReadLine();
                    return "adduser";
            }
        }
    }
}
