using BackendAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendAPI.Controllers
{
    public class UserController : Controller
    {
        [HttpPost("register")]
        public IActionResult Register([FromBody] User user)
        {
            // Implement registration logic here
            // Validate input, store user in the database, etc.
            // Return appropriate HTTP status codes and responses
            return Ok("User registered successfully");
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] User user)
        {
            // Implement login logic here
            // Validate credentials, generate JWT token, etc.
            // Return appropriate HTTP status codes and responses
            return Ok("Login successful");
        }
    }
}
