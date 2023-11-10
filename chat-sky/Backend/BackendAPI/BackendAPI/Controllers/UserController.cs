using BackendAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendAPI.Controllers
{
    public class UserController : Controller
    {
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
