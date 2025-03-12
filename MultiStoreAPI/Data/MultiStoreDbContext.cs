using Microsoft.EntityFrameworkCore;
using MultiStoreAPI.Models;

namespace MultiStoreAPI.Data
{
    public class MultiStoreDbContext : DbContext
    {
        public MultiStoreDbContext(DbContextOptions<MultiStoreDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
    }
}
