using Microsoft.EntityFrameworkCore;


namespace JWTLogin.Models
{
    public class OnlineBankingDbContext: DbContext
    {    
        public OnlineBankingDbContext(DbContextOptions<OnlineBankingDbContext>options):base(options)
        {

        }
        public DbSet<User> users { get; set; }
        //public object User { get; internal set; }
        public DbSet<Admin> admins { get; set; }    
        public DbSet<AccountDetails> accountDetails { get; set; }   
        public DbSet<Transaction> transactions { get; set; }

    }
}
