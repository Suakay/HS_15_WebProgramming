using _20_Identity.Models.Entities.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _20_Identity.Models.Infrastructure.ContextDb
{
    public class ApplicationContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext>options):base(options) 
        {

        }
        public DbSet<Product> Products { get; set; }

    }
  
}
