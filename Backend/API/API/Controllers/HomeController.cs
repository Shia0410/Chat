using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService; // Inject your user service here

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLoginModel model)
        {
            // Implement login logic
            var user = _userService.Login(model._username, model._password);

            if (user == null)
            {
                // Return appropriate HTTP status code for login failure
                return BadRequest("Invalid credentials");
            }

            // Return appropriate HTTP status code and user data
            return Ok(new { Username = user.Username, /* other user data */ });
        }
    }

}

