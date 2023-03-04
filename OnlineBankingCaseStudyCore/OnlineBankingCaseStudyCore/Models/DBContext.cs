using LoginRegister.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace onlineBanking1.Models
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> users { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<AccountDetails> accountDetails { get; set; }

    }
}
