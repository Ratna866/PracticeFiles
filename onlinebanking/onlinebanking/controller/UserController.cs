using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc;
namespace onlinebanking.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;
        public UserController(IConfiguration config)
        {
            _config = config;
        }
        [HttpPost("CreateUser")]
        public IActionResult Create() 
        {
            return Ok("Success from Create Method");
        }

        }

    }

