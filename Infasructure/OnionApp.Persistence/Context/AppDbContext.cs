using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OnionApp.Domain.Entities;

namespace OnionApp.Persistence.Context
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }



}

