namespace UI;

public class ListAllRestaurants : IMenu
{
    private ILogic logic;
    private SQLRepo repo;

    public void GetAllRestaurants()
    {
        List<Restaurant>? restaurants = repo.GetAllRestaurants();
        foreach (Restaurant? restaurant in restaurants)
        {
            Console.WriteLine(restaurant);
            Console.WriteLine("=============");
        }
    }

    public ListAllRestaurants(ILogic logic) 
    {
        this.logic = logic;
    }

    public void Display()
    {
        //Console.WriteLine("Press <1> to add a restaurant to the system");
        //Console.WriteLine("Press <2> to show a list of all the restaurants in the system");
    }

    public string UserChoice()
    {
        Console.WriteLine("Press <1> to show a list of all the restaurants in the system");
        Console.WriteLine("Press <2> to search for a restaurant of your choosing");
        Console.WriteLine("Press <0> to go back to the Main Menu");

        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                repo.GetAllRestaurants();
                return "mainmenu";
                break;

            case "2":
                if (Console.ReadLine() is not string searchString)
                    throw new InvalidDataException("end of input");
                List<Models.Restaurant> results = logic.SearchRestaurants(searchString);
                if (results.Count > 0)
                {
                    foreach (Models.Restaurant r in results)
                    {
                        Console.WriteLine("=================");
                        Console.WriteLine(r.ToString());
                    }
                }
                else
                {
                    Console.WriteLine($"Restaurants with search string {searchString} not found");
                }
                Console.WriteLine("Press <enter> to continue");
                Console.ReadLine();
                return "mainmenu";
                break;

            case "0":
                return "mainmenu";
                break;

            default:
                return "Please enter a vaild response";
                Console.WriteLine("Press <Enter> to continue");
                Console.ReadLine();
                break;
        }
    }
}