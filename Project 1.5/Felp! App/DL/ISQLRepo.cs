using Models;

namespace DL;


public interface ISQLRepo// repository interface for the restaurant/reviews
{
    List<Restaurant> GetAllRestaurants();// list of all restaurants that are already added to the repo

    Restaurant AddRestaurant(Restaurant restaurantToAdd);// method to add a restaurant

    Review AddReview(Review reviewToAdd);// method to add a review

    List<Restaurant> SearchRestaurants(string searchTerm);// list with a method with a string parameter that'll be used to search restaurants 

    bool IsDuplicate(Restaurant restaurant);// boolean to check if the restaurant has already been added or not

    User AddUser(User newuser); // method that will add a new user to the list

    List<User> GetAllUsers();// list of all the users that are already added to the repo

    bool IsDuplicate(User newuser);
    
}
