using Microsoft.EntityFrameworkCore;
using onlinebanking.Models;

namespace onlinebanking.Data
{
    public class DBContext:DbContext
        {
            public DBContext(DbContextOptions options) : base(options)
            {

            }
            public DbSet<User> Users { get; set; }
            public DbSet<Admin> Admins { get; set; }
            public DbSet<AccountDetails> accountDetails { get; set; }
            public DbSet<ChangePassword> changepassword { get; set; }

            public DbSet<Transaction> transactions { get; set; }
        }
    }


