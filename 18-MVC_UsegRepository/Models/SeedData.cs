using _18_MVC_UsegRepository.Models.Context;
using Microsoft.EntityFrameworkCore;

namespace _18_MVC_UsegRepository.Models
{
    public  static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope=app.ApplicationServices.CreateScope())
            {
                ProductContext context=serviceScope.ServiceProvider.GetService<ProductContext>();
                context.Database.Migrate();//Uygulama çalıştığında bekleyen bir migration varsa onu gerçekleştirir.
                if (!context.Products.Any())//Product tablosu boşsa burası çalışıcak.
                {
                    context.Products.AddRange(
                        new Product() { ProductName = "Fasulye", Description = "Yaz Sebzesi", Category = "Sebzeler", Price = 19.90M, Stock = 10 },
                        new Product() { ProductName = "Vişne", Description = "Tatlı bir meyvedir", Category = "Meyveler", Price = 29.00M, Stock = 30 },
                         new Product() { ProductName = "Mandalina", Description = "Kış Meyvesidir", Category = "Meyveler", Price = 15.00M, Stock = 40 },
                         new Product() { ProductName = "Salatalık", Description = "Kış Sebzesidir", Category = "Sebzeler", Price = 12.50M, Stock = 50 },
                         new Product() { ProductName = "Fındık", Description = "Sinop Ürünü", Category = "Kuruyemiş", Price = 20.00M, Stock = 30 });


                }
                context.SaveChanges();
            }


        }

         public static void Seed(WebApplication app)
        {
            throw new NotImplementedException();
        }
    }
}
        
    

