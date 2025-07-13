using cabe_API.Models;

namespace cabe_API.Business
{
    public interface IProductBusiness
    {
        Product Create(Product product);
        Product? FindById(int id);
        List<Product> FindAll();
        Product Update(Product product);
        void Delete(int id);
    }
}
