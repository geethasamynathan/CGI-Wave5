using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTTokenDemo.Services;
using JWTTokenDemo.Models;
using JWTTokenDemo.Exceptions;
namespace JWTTokenDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _service;
        public AuthController(IUserService service)
        {
            _service = service;
        }  
        [HttpPost]
        public IActionResult Register(User user)
        {
            try
            {
                _service.RegisterUser(user);
                return StatusCode(201, "User registered Successfully");
            }
            catch(UserAlreadyExistsException ue)
            {
                return Conflict(ue.Message);
            }
            catch(Exception e)
            {
                return StatusCode(500, " Internal server Error");
            }
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] User user)
        {
            try
            {
                string userid = user.UserId;
                string password = user.Password;
              User loggedinuser=  _service.Login(userid, password);
                return Ok(loggedinuser.UserId);
            }
            catch(UserNotFoundException unf)
            {
                return NotFound(unf.Message);
            }
            catch(Exception)
            {
                return StatusCode(500, "Internal server Error");
            }
        }

    }
}
