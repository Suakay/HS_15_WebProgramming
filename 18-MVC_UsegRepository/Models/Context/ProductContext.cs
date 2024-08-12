using Microsoft.EntityFrameworkCore;

namespace _18_MVC_UsegRepository.Models.Context
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext>options):base()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("UseSqlServer");
            }
        }
        public DbSet<Product> Products { get; set;}

    }
}
