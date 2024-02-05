using EffectiveUsers.Models;
using Microsoft.EntityFrameworkCore;

namespace EffectiveUsers.Data
{
    public class ApplicationDBContext:DbContext
    {
public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options) :base(options)  {  }
        public DbSet<Users> Users { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Position> Positions { get; set; } 
        public DbSet<Status> status { get; set; }

    }
}
