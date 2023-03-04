using Microsoft.EntityFrameworkCore;

namespace AngularwebAPI.Model
{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> options) : base(options)
        {

        } 
        public DbSet<Login>? Logins { get; set; }
    }
}
