using Geco.Models;
using Microsoft.EntityFrameworkCore;

namespace Geco.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Slider> Sliders{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Color> Colors{ get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<Setting> Settings{ get; set; }
    }
}
