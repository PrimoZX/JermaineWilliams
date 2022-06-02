using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using BL;
using DL;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FelpController : ControllerBase
    {
        private ISQLRepo dl;
        private ILogic bl;
        private IMemoryCache memoryCache;
        private string stringname;

        public FelpController(ISQLRepo dl, ILogic bl, IMemoryCache memoryCache)
        {
            this.dl = dl;
            this.memoryCache = memoryCache;
            this.bl = bl;
        }

        //[HttpGet("Search Users")]
        //[ProducesResponseType(200, Type = typeof(User))]
        //[ProducesResponseType(404)]
        //public ActionResult<List<User>> Get(string usersearch)
        //{
        //    List<User> users = new List<User>();

        //    var su = bl.GetUsername(usersearch);
        //    if (su.Count <= 0)
        //        return NotFound($"User with this name: {usersearch} is not found in the database.");
        //    return Ok(su);
        //}

        [HttpGet("Search Restaurants")]
        [ProducesResponseType(200, Type = typeof(Restaurant))]
        [ProducesResponseType(404)]
        public ActionResult<List<Restaurant>> Get(string name)
        {
            List<Restaurant> rest = new List<Restaurant>();

            var sr = bl.SearchRestaurants(name);
            if (sr.Count <= 0)
                return NotFound($"Restaurant {name} is not found in the database.");
            return Ok(sr);
        }

        //[HttpGet("Search Reviews")]
        //[ProducesResponseType(200, Type = typeof(Review))]
        //[ProducesResponseType(404)]
        //public ActionResult<List<Review>> Get(string name)
        //{
        //    List<Review> re = new List<Review>();

        //    var sr = bl.SearchReview(name);
        //    if (sr.Count <= 0)
        //        return NotFound($"Restaurant {name} is not found in the database.");
        //    return Ok(sr);
        //}

        [HttpPut("Add User")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] User user)
        {
            if (user == null)
                return BadRequest("Invaild user, try again with vaild values");
            dl.AddUser(user);
            return CreatedAtAction("Get", user);
        }

        [HttpPut("Adding Restaurant")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] Restaurant rest)
        {
            if (rest == null)
                return BadRequest("Invaild restaurant, try again with vaild values");
            dl.AddRestaurant(rest);
            return CreatedAtAction("Get", rest);
        }

        [HttpPut("Adding Review")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] Review review)
        {
            if (review == null)
                return BadRequest("Invaild review, try again with vaild values");
            dl.AddReview(review);
            return CreatedAtAction("Get", review);
        }
    }
}
