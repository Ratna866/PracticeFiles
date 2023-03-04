using LoginRegister.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using onlineBanking1.Models;
using System.ComponentModel.DataAnnotations;

namespace onlineBanking1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _config;
        public readonly DBContext _context;
        public UserController(IConfiguration config, DBContext context)
        {
            _config = config;
            _context = context;
        }
        [HttpPost("CreateUser")]
        public IActionResult Create(User user)
        {
            if (_context.users.Where(u => u.Email == user.Email).FirstOrDefault() != null)
            {
                return Ok("Already Exist");
            }
            user.MemberSince = DateTime.Now;
            _context.users.Add(user);
            _context.SaveChanges();
            return Ok("success");
        }
    }
}
//://localhost:7294/swagger/index.html
