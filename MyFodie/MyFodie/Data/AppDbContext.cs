using Microsoft.EntityFrameworkCore;
using MyFodie.Models;
using System.Collections.Generic;

namespace MyFodie.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<recept> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
