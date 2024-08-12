using _18_MVC_UsegRepository.Models;
using _18_MVC_UsegRepository.Models.Context;

namespace _18_MVC_UsegRepository.Repositories
{
    public class EFProductRepository : IProductRepository
    {
        private readonly ProductContext _context;
        
        public EFProductRepository(ProductContext context)
        {
            _context = context;
        }
        public IQueryable<Product> Products => new List<Product>
        {
            new Product() { ProductName = "Fasulye", Description = "Yaz Sebzesi", Category = "Sebzeler", Price = 19.90M, Stock = 10 },
                        new Product() { ProductName = "Vişne", Description = "Tatlı bir meyvedir", Category = "Meyveler", Price = 29.00M, Stock = 30 },
                         new Product() { ProductName = "Mandalina", Description = "Kış Meyvesidir", Category = "Meyveler", Price = 15.00M, Stock = 40 },
                         new Product() { ProductName = "Salatalık", Description = "Kış Sebzesidir", Category = "Sebzeler", Price = 12.50M, Stock = 50 },
                         new Product() { ProductName = "Fındık", Description = "Sinop Ürünü", Category = "Kuruyemiş", Price = 20.00M, Stock = 30 }

        }.AsQueryable();

        public bool DeleteProduct(int id)
        {
            _context.Remove(id);
            return _context.SaveChanges()>0;
        }

        public Product GetProductById(int id)
        {
           return _context.Products.Find(id);
        }

        public bool InsertProduct(Product product)
        {
            _context.Products.Add(product);
            return _context.SaveChanges() > 0;//Etkilenen satır sayısı 0 dan büyükse true döer.Yani kayt gerçekleşti.
        }

        public bool UpdateProduct(Product product)
        {
           _context.Products.Update(product);
            return _context.SaveChanges()==0;
        }
    }
}
