using Microsoft.EntityFrameworkCore;
using MyFodie.Models;

namespace MyFodie.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Any additional configuration, if needed.
    }
}
