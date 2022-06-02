using UI;
using DL;
using Serilog;

//Log.Logger = new LoggerConfiguration();

IMenu menu = new MainMenu();
ISQLRepo sqlrepo = new SQLRepo();
ILogic bl = new Logic(sqlrepo);
AddUser au = new AddUser();
ListAllRestaurants listrest = new ListAllRestaurants(bl);


bool repeat = true;

Console.Clear();
menu.Display();

while (repeat) //while repeat is true, display will loop until it's false
{
    string userinput = menu.UserChoice();

    switch (userinput)
    {
        case "adduser":
            menu = new AddUser();
            break;

        case "listrest":
            menu = new ListAllRestaurants(bl);
            break;

        case "addrest":
            menu = new AddRest(bl);
            break;

        case "reviewrest":
            menu = new AddReview(bl);
            break;

        case "adminaccess":
            Console.WriteLine("Call AddAdmin method");
            break;

        case "exit":
            repeat = false;
            break;

        case "mainmenu":
            menu = new MainMenu();
            break;
    }
}

