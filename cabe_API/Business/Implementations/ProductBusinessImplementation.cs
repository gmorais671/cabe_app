using cabe_API.Models;
using cabe_API.Repository;

namespace cabe_API.Business.Implementations
{
    public class ProductBusinessImplementation : IProductBusiness
    {
        private IProductRepository _repository;

        public ProductBusinessImplementation(IProductRepository repository)
        {
            _repository = repository;
        }
        public Product Create(Product product)
        {
            return _repository.Create(product);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Product> FindAll()
        {
            return _repository.FindAll();
        }

        public Product? FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Product Update(Product product)
        {
            return _repository.Update(product);
        }
    }
}
