using _18_MVC_UsegRepository.Models;

namespace _18_MVC_UsegRepository.Repositories
{
    public class ProductRepository : IProductRepository
    {


        public IQueryable<Product> Products =>new List<Product>
        {
            new Product() { ProductName = "Fasulye", Description = "Yaz Sebzesi", Category = "Sebzeler", Price = 19.90M, Stock = 10 },
                        new Product() { ProductName = "Vişne", Description = "Tatlı bir meyvedir", Category = "Meyveler", Price = 29.00M, Stock = 30 },
                         new Product() { ProductName = "Mandalina", Description = "Kış Meyvesidir", Category = "Meyveler", Price = 15.00M, Stock = 40 },
                         new Product() { ProductName = "Salatalık", Description = "Kış Sebzesidir", Category = "Sebzeler", Price = 12.50M, Stock = 50 },
                         new Product() { ProductName = "Fındık", Description = "Sinop Ürünü", Category = "Kuruyemiş", Price = 20.00M, Stock = 30 }

        }.AsQueryable();

        public bool DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public bool InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
