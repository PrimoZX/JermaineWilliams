using DL;

namespace UI;
public class MainMenu : IMenu
{
    
    public void Display()
    {
        Console.Clear();

        Console.WriteLine("Hello, and Welcome to the Felp! App");
        Console.WriteLine("Where you can write, review, and search you next favorite resturants!"); //Thread.Sleep(5000);

        Console.WriteLine("Please select from the following options:"); //Thread.Sleep(2000);
        Console.WriteLine("Press <1> to make a new user"); //Thread.Sleep(1000);
        Console.WriteLine("Press <2> to list all the restaurants in the system"); //Thread.Sleep(1000);
        Console.WriteLine("Press <3> to add a restaurant to the system"); //Thread.Sleep(1000);
        Console.WriteLine("Press <4> to review a restaurant"); //Thread.Sleep(1000);
        Console.WriteLine("Press <5> for Admin Access"); //Thread.Sleep(1000);
        Console.WriteLine("Press <0> to exit the app"); //Thread.Sleep(1000);

    }

    public string UserChoice()
    {

        string userinput = Console.ReadLine();

        switch (userinput)
        {
            case "1":
                return "adduser";
                break;

            case "2":
                return "listrest";
                break;

            case "3":
                return "addrest";
                break;

            case "4":
                return "reviewrest";
                break;

            case "5":
                return "adminaccess";
                break;

            case "0":
                return "exit";
                break;

            default:
                Console.WriteLine("Please enter a vaild response");
                Console.WriteLine("Press <Enter> to continue");
                Console.ReadLine();
                return "mainmenu";
                break;
        }
    }
}


