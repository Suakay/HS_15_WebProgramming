using _19_MVC_RepositorySchool.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace _19_MVC_RepositorySchool.Models.Seed
{
    public static  class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            using(var serviceScope=app.ApplicationServices.CreateScope())
            {
                ProjectContext context =serviceScope.ServiceProvider.GetService<ProjectContext>();
                context.Database.Migrate();
                if (!context.Okullar.Any())
                {
                    context.Okullar.AddRange(
                        new Okul(){ OkulAdi="Mimar Sinan" ,OkulAdresi="Ataköy",OkulEposta="",OkulKuruluşTarihi=DateTime.Now,OkulTelefonu="56770980"},
                        new Okul() { OkulAdi = "Ahmet Hamdi", OkulAdresi = "Bakırköy", OkulEposta = "", OkulKuruluşTarihi = DateTime.Now, OkulTelefonu = "5643535" },
                        new Okul() { OkulAdi = "Beh", OkulAdresi = "Ataköy", OkulEposta = "", OkulKuruluşTarihi = DateTime.Now, OkulTelefonu = "56770980" }

                        );
                }
                context.SaveChanges();
            }

        }
    }
}
