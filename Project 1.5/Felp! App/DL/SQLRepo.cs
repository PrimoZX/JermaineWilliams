using Microsoft.Data.SqlClient;
using Models;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System;

namespace DL
{
    public class SQLRepo : ISQLRepo
    {
        private const string connectionStringFilePath = "../../../../Jermaine-Williams/Project 1.5/Felp! App/DL/Database/ConnectionString.txt";
        private readonly string connectionString;

        public SQLRepo()
        {
            connectionString = File.ReadAllText(connectionStringFilePath);
        }

        public User AddUser(User newuser)
        {
            string commandString = "INSERT INTO Users (Fullname, Username, Email, UserID) VALUES (@Fullname, @Username, @Email, @UserID)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            //connection.Open();
            command.Parameters.AddWithValue("@Fullname", newuser.Fullname);
            command.Parameters.AddWithValue("@Username", newuser.Username);
            command.Parameters.AddWithValue("@Email", newuser.Email);
            //command.Parameters.AddWithValue("@Password", newuser.Password);
            command.Parameters.AddWithValue("@UserID", newuser.UserID);
            connection.Open();
            command.ExecuteNonQuery();
            //catch (Exception ex)
            //{
            //    Console.WriteLine("That username is already taken");
            //    Console.WriteLine("Try to use another username");
            //}
            ////using SqlDataReader reader = command.ExecuteReader();
            connection.Close();

            return newuser;
        }

        public List<User> GetAllUsers()
        {
            string commandString = "SELECT * from Users";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var users = new List<User>();
            while (reader.Read())
            {
                User user = new User { Fullname = reader.GetString(0) };
            }
            return users;
        }

        public Restaurant AddRestaurant(Restaurant restaurantToAdd)
        {
            string commandString = "INSERT INTO Restaurants (Name, City, State, RestID) VALUES (@Name, @City, @State, @RestID)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@Name", restaurantToAdd.Name);
            command.Parameters.AddWithValue("@City", restaurantToAdd.City);
            command.Parameters.AddWithValue("@State", restaurantToAdd.State);
            command.Parameters.AddWithValue("@RestID", restaurantToAdd.RestID);
            connection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Something is missing, please enter the infomation correctly.");
            }
            //using SqlDataReader reader = command.ExecuteReader();
            connection.Close();

            return restaurantToAdd;
        }

        public Review AddReview(Review reviewToAdd)
        {
            string commandString = "INSERT INTO Review (ReviewID, Rating, RestID, Note) VALUES (@ReviewID, @Rating, @RestID, @Note)";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            command.Parameters.AddWithValue("@ReviewID", reviewToAdd.ReviewID);
            command.Parameters.AddWithValue("@Rating", reviewToAdd.Rating);
            command.Parameters.AddWithValue("@RestID", reviewToAdd.RestaurantID);
            command.Parameters.AddWithValue("@Note", reviewToAdd.Note);
            connection.Open();
            try
            {
                command.ExecuteNonQuery();
                using SqlDataReader reader = command.ExecuteReader();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("This might be an error. Either there's something wrong or there was a duplicate key. Either way, the info saved.");
            }
            connection.Close();

            return reviewToAdd;
        }

        public List<Restaurant> GetAllRestaurants()
        {
            string commandString = "SELECT * FROM Restaurants";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            IDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new();
            try
            {
                connection.Open();
                adapter.Fill(dataSet); // this sends the query. DataAdapter uses a DataReader to read.}
            }
            catch (SqlException ex)
            {
                throw;//rethrow the exception
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            // TODO: leaving out the abilities for now
            var restaurauts = new List<Restaurant>();
            DataColumn levelColumn = dataSet.Tables[0].Columns[3];
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                restaurauts.Add(new Restaurant
                {
                    Name = (string)row[0],
                    City = (string)row[1],
                    State = (string)row[2],
                    RestID = (int)row[3]
                });
            }
            return restaurauts;
            //string commandString = "SELECT * from Restaurants";

            //using SqlConnection connection = new(connectionString);
            //using SqlCommand command = new(commandString, connection);
            //connection.Open();
            //using SqlDataReader reader = command.ExecuteReader();

            //var restaurants = new List<Restaurant>();
            //while (reader.Read())
            //{
            //    Restaurant rest = new Restaurant { Name = reader.GetString(0) };
            //}
            //return restaurants;
        }

        public bool IsDuplicate(Restaurant restaurant)
        {
            return true;
        }

        public List<Restaurant> SearchRestaurants(string searchTerm)
        {
            string commandString = "SELECT Name, City, State, RestID from Restaurants";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(commandString, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            var restaurants = new List<Restaurant>();
            while (reader.Read())
            {
                Restaurant rest = new Restaurant { Name = reader.GetString(0) };
            }
            return restaurants;
        }

        public bool IsDuplicate(User newuser)
        {
            throw new NotImplementedException();
        }
    }
}

