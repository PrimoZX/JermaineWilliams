using CustomExceptions;

namespace BL;
public class Logic : ILogic// this class is inheriting the IBL interface 
{
    private readonly ISQLRepo repo;// readable variable that refers to the repo interface

    public Logic(ISQLRepo repo)
    {
        this.repo = repo;
    }

    /// <summary>
    /// Gets all restaurants
    /// </summary>
    /// <returns>list of all restaurants</returns>

    public List<Restaurant> GetAllRestaurants()
    {
        List<Restaurant> rest = repo.GetAllRestaurants();
        var allrest = rest.Select(r => r.Name);
        return (List<Restaurant>)allrest;
    }

    /// <summary>
    /// Adds a new restaurant to the list
    /// This method will check for the duplicate record before persisting
    /// </summary>
    /// <param name="restaurantToAdd">restaurant object to add</param>
    /// <exception cref="DuplicateRecordException">When there is a restaurant that already exists</exception>

    public void AddRestaurant(Restaurant restaurantToAdd)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Adds a new review to the restaurant that exists on that index
    /// </summary>
    /// <param name="restaurantId">index of the restaurant to leave a review for</param>
    /// <param name="reviewToAdd">a review object to be added to the restaurant</param>

    public void AddReview(int restaurantId, Review reviewToAdd)
    {
        throw new NotImplementedException();
    }

    public List<Restaurant> SearchRestaurants(string searchTerm)
    {
        List<Restaurant>? rest = repo.GetAllRestaurants();
        var filteredrest = rest.Where(r => r.Name.Contains(searchTerm) || r.City.Contains(searchTerm) || r.State.Contains(searchTerm)).ToList();
        return filteredrest;
    }

    public List<Restaurant> SearchAll()
    {
        return repo.GetAllRestaurants();
    }

    /// <summary>
    /// adds a new user infomation to create a new user
    /// </summary>
    /// <param name="newuser"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public User AddUser(User newuser)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// gets all the users
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public List<User> GetAllUsers()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// gets the username from the DB and check if there's a duplicate or not
    /// </summary>
    /// <param name="Username"></param>
    /// <returns></returns>
    public List<User> GetUsername(string Username)
    {
        List<User> users = repo.GetAllUsers();
        var filteredUsernames = users.Where(user => user.Username.ToLower().Contains(Username)).ToList();
        return filteredUsernames;
    }
}
