using LoginRegister.Models;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineBankingCaseStudy.Model;
//using Microsoft.AspNetCore.Mvc;
namespace onlinebanking.controller
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;
        public readonly DBContext _context;
        public UserController(IConfiguration config, UserContext context)
        {
            _config = config;
            _context = context;
        }
        [HttpPost("CreateUser")]
        public IActionResult Create(User user)
        {
            user.MemberSince = DateTime.Now;
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok("Success from Create Method");
        }
    }
}



//https://localhost:7292/