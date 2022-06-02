namespace BL;

public interface ILogic// business logic interface for Restaurants/Reviews
{
    /// <summary>
    /// will give you restaurants with the seached name
    /// </summary>
    /// <param name="searchString"></param>
    /// <returns>returns a list of the searched restaurunts</returns>
    List<Restaurant> SearchRestaurants(string searchString);// list of all restaurants to search all the restaurants with a string parameter "searchString"


    List<Restaurant> GetAllRestaurants(); // list of all restaurants to return the list of restaurants

    //void AddRestaurant(Restaurant restaurantToAdd); // method to add a restaurant to the list

    //void AddReview(int restaurantId, Review reviewToAdd); // method to add a review to a restaurant

    //User AddUser(User newuser); // method that will add a new user to the list

    //List<User> GetAllUsers();// list of all the users that are already added to the repo

    public List<User> GetUsername(string Username); // will retrive a username from the database for the login

}

public interface ISearch : ILogic
{
    List<Restaurant> SearchAll();
}