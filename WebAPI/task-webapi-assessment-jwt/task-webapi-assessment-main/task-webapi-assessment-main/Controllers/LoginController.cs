using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskApi.Models;
using TaskApi.Repository;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAuthService _authService;

        public LoginController(IAuthService authService)
        {
            _authService = authService;

		}


		[HttpPost]
        public string Login([FromBody] LoginRequest loginModel)
        { 
           var result = _authService.Login(loginModel); 
           return result;
        }
	

	   [HttpPost("AddUser")]
	    public User AddUser([FromBody] User value)
        {
			var user = _authService.AddUser(value); 
            return user;
	    }



    }
}

