using cabe_API.Models;

namespace cabe_API.Repository
{
    public interface IProductRepository
    {
        Product Create(Product product);
        Product? FindById(int id);
        List<Product> FindAll();
        Product Update(Product product);
        void Delete(int id);
    }
}
