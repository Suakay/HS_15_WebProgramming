using Microsoft.EntityFrameworkCore;

namespace _19_MVC_RepositorySchool.Models.Context
{
    public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext>options) :base(options) 
        {
            
        }
        public DbSet<Okul>Okullar { get; set; } 
        public DbSet<Ogrenci> Ogrenciler { get; set; }

    }
}
