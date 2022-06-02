namespace UI;

public class AddReview : IMenu
{
    private readonly ILogic _bl;
    public AddReview(ILogic bl)
    {
        _bl = bl;
    }

    private static Review newReview = new Review();
    private SQLRepo restRepo = new SQLRepo();
    private int restaurantID;

    public void Display()
    {
        throw new NotImplementedException();
    }

    public string UserChoice()
    {
        Console.Clear();

        Console.WriteLine("Enter a review for a restaurant you've visited: The info here are defaults\nYou can change them with the review's info if you press the number on the left of them.");
        Console.WriteLine("<1> ReviewID: " + newReview.ReviewID);
        Console.WriteLine("<2> Rating: " + newReview.Rating);
        Console.WriteLine("<3> RestaurantID: " + newReview.RestaurantID);
        Console.WriteLine("<4> Review of Restaurant: " + newReview.Note);
        Console.WriteLine("Press <5> to save the infomation");
        Console.WriteLine("Press <0> to return to the main menu");

        string userInput = Console.ReadLine();
        switch (userInput)
        {
            case "1":
                Console.WriteLine("Please a number to be an ID for your review: ");
                newReview.ReviewID = Convert.ToInt32(Console.ReadLine());
                return "reviewrest";

            case "2":
                Console.WriteLine("Please rate the restaurant between 1 and 5: ");
                newReview.Rating = Convert.ToInt32(Console.ReadLine());
                return "reviewrest";

            case "3":
                Console.WriteLine("Please enter the correct Restaurant ID number here for the select restaurant you'd like to review: ");
                newReview.RestaurantID = Convert.ToInt32(Console.ReadLine());
                return "reviewrest";

            case "4":
                Console.WriteLine("Tell us about your experience at the restaurant: ");
                newReview.Note = Console.ReadLine();
                return "reviewrest";

            case "5":
                restRepo.AddReview(newReview);
                return "mainmenu";

            case "0":
                return "mainmenu";

            default:
                Console.WriteLine("Please use the correct key");
                Console.WriteLine("Press <Enter> to continue");
                Console.ReadLine();
                return "reviewrest";
        }
    }
}