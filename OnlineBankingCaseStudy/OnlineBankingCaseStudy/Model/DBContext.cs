using LoginRegister.Models;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OnlineBankingCaseStudy.Model
{
    public class DBContext : IdentityDbContext<User>
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<AccountDetails> accountDetails { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Admin> admin { get; set; }

        public static implicit operator DBContext(UserContext v)
        {
            throw new NotImplementedException();
        }
    }
}