using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;

namespace UI
{
    internal class AddRest : IMenu
    {
        private readonly ILogic _bl;
        public AddRest(ILogic bl)
        {
            _bl = bl;
        }
        private static Restaurant newRestaurant = new Restaurant();
        private SQLRepo RestRepo = new SQLRepo();

        public void Display()
        {
            throw new NotImplementedException();
        }

        public string UserChoice()
        {

            Console.Clear();

            Console.WriteLine("Enter Restaurant Information: The info here are defaults\nYou can change them with the restaurant's info if you press the number on the left of them.");
            Console.WriteLine("<1> Restaurant Name: " + newRestaurant.Name);
            Console.WriteLine("<2> City: " + newRestaurant.City);
            Console.WriteLine("<3> State: " + newRestaurant.State);
            Console.WriteLine("<4> RestaurantID: " + newRestaurant.RestID);
            Console.WriteLine("Press <5> to save the infomation");
            Console.WriteLine("Press <0> to return to the main menu");

            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Please the name of the restaurant you would like to add: ");
                    newRestaurant.Name = Console.ReadLine();
                    return "addrest";

                case "2":
                    Console.WriteLine("Enter the name of the City the restaurant is located in: ");
                    newRestaurant.City = Console.ReadLine();
                    return "addrest";

                case "3":
                    Console.WriteLine("Enter the State that the City is located in: ");
                    newRestaurant.State = Console.ReadLine();
                    return "addrest";

                case "4":
                    Console.WriteLine("Enter a three digit number for an ID for the restaurant: ");
                    newRestaurant.RestID = Convert.ToInt32(Console.ReadLine());
                    return "addrest";

                case "5":
                    RestRepo.AddRestaurant(newRestaurant);
                    return "mainmenu";

                case "0":
                    return "mainmenu";

                default:
                    Console.WriteLine("Please use the correct key");
                    Console.WriteLine("Press <Enter> to continue");
                    Console.ReadLine();
                    return "addrest";
            }
        }
    }
}

