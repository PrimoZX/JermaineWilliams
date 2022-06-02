using Models;
using System;

namespace UI
{
    public class AdminMenu : IMenu
    {
        private Logic _bl;

        public AdminMenu(Logic ubl)
        {
            _bl = ubl;
        }
        public void Display()
        {
            Console.WriteLine("Press 1 to add a new User for a test");
            Console.WriteLine("Press 2 to see all the user for a test");
            Console.WriteLine("Press 0 to return to the main menu");

        }

        public string UserChoice()
        {
            string userinput = Console.ReadLine();
            switch (userinput)
            {
                case "1":
                    return "1"; 
                    break;

                case "2":
                    return "2";
                    break;

                case "0":
                    return "MainMenu";
                
                default:
                    return "Please enter the right key";
            }
        }
    }
}
