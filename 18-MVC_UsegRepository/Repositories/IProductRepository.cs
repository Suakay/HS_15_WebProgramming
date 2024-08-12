using _18_MVC_UsegRepository.Models;

namespace _18_MVC_UsegRepository.Repositories
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get;  }
        bool InsertProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(int id);
        Product GetProductById(int id);
    }
}
