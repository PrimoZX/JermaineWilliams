using Xunit;
using Models;

namespace Tests;

public class ModelsTest
{
    [Fact]
    public void UserTest1()
    {
        User nu = new User();

        nu.Username = "JD";
        nu.UserID = 236;
        nu.Email = "JD.Saxton@gmail.com";
        nu.Fullname = "John Daly Saxton";

        Assert.Equal("JD", nu.Username);
        Assert.Equal(236, nu.UserID);
        Assert.Equal("JD.Saxton@gmail.com", nu.Email);
        Assert.Equal("John Daly Saxton", nu.Fullname);
    }

    [Fact]
    public void UserTest2()
    {
        User nu = new User();

        nu.Username = "Batman";
        nu.UserID = 808;
        nu.Email = "iamthenight@gothampd.net";
        nu.Fullname = "Bruce Wayne";

        Assert.Equal("Batman", nu.Username);
        Assert.Equal(808, nu.UserID);
        Assert.Equal("iamthenight@gothampd.net", nu.Email);
        Assert.Equal("Bruce Wayne", nu.Fullname);
    }

    [Fact]
    public void UserTest3()
    {
        User nu = new User();

        nu.Username = "Superman";
        nu.UserID = 864;
        nu.Email = "manoftomorrow@dailyplanet.net";
        nu.Fullname = "Clark Kent";

        Assert.Equal("Superman", nu.Username);
        Assert.Equal(864, nu.UserID);
        Assert.Equal("manoftomorrow@dailyplanet.net", nu.Email);
        Assert.Equal("Clark Kent", nu.Fullname);
    }

    [Fact]
    public void RestaurantTest1()
    {
        Restaurant rest = new Restaurant();

        rest.Name = "Golden Coral";
        rest.City = "Vero Beach";
        rest.State = "Florida";
        rest.RestID = 102;

        Assert.Equal("Golden Coral", rest.Name);
        Assert.Equal("Vero Beach", rest.City);
        Assert.Equal("Florida", rest.State);
        Assert.Equal(102, rest.RestID);
    }

    [Fact]
    public void RestaurantTest2()
    {
        Restaurant rest = new Restaurant();

        rest.Name = "Bono's";
        rest.City = "Vero Beach";
        rest.State = "Florida";
        rest.RestID = 402;

        Assert.Equal("Bono's", rest.Name);
        Assert.Equal("Vero Beach", rest.City);
        Assert.Equal("Florida", rest.State);
        Assert.Equal(402, rest.RestID);
    }

    [Fact]
    public void RestaurantTest3()
    {
        Restaurant rest = new Restaurant();

        rest.Name = "Pizza Hut";
        rest.City = "Vero Beach";
        rest.State = "Florida";
        rest.RestID = 684;

        Assert.Equal("Pizza Hut", rest.Name);
        Assert.Equal("Vero Beach", rest.City);
        Assert.Equal("Florida", rest.State);
        Assert.Equal(684, rest.RestID);
    }

    [Fact]
    public void ReviewTest1()
    {
        Review review = new Review();

        review.Rating = 1;
        review.Note = "This place is trash";

        Assert.Equal(1, review.Rating);
        Assert.Equal("This place is trash", review.Note);
    }

    [Fact]
    public void ReviewTest2()
    {
        Review review = new Review();

        review.Rating = 3;
        review.Note = "This place is okay";

        Assert.Equal(3, review.Rating);
        Assert.Equal("This place is okay", review.Note);
    }

    [Fact]
    public void ReviewTest3()
    {
        Review review = new Review();

        review.Rating = 5;
        review.Note = "This place is great";

        Assert.Equal(5, review.Rating);
        Assert.Equal("This place is great", review.Note);
    }

    [Fact]
    public void ReviewTest4()
    {
        Review review = new Review();

        review.Rating = 2;
        review.Note = "This place is just alright";

        Assert.Equal(2, review.Rating);
        Assert.Equal("This place is just alright", review.Note);
    }
}
