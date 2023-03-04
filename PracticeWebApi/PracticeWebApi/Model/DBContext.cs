using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PracticeWebApi.Model
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options):base(options)
        {
            
        }
        public DbSet <EmployeeTBL> EmlployeeTBL { get; set; }
        public DbSet<DesignationTBL> DesignationTBL { get; set; }
    }
}
