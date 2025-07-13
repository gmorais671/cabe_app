using cabe_API.Models;
using cabe_API.Models.Context;
using System.Security.Cryptography;

namespace cabe_API.Repository.Implementations
{
    public class ProductRepositoryImplementation : IProductRepository
    {
        private MySQLContext _context;

        public ProductRepositoryImplementation(MySQLContext context)
        {
            _context = context;
        }

        public Product Create(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while creating the product.", ex);
            }
            return product;
        }

        public Product? FindById(int id)
        {
            return _context.Products.ToList().SingleOrDefault(p => p.Id.Equals(id));
        }

        public List<Product> FindAll()
        {
            return _context.Products.ToList();
        }

        public Product Update(Product product)
        {
            var existingProduct = _context.Products.SingleOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                try
                {
                    _context.Entry(existingProduct).CurrentValues.SetValues(product);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while updating the product.", ex);
                }
                
            }
            else
            {
                throw new Exception("Product not found.");
            }
            return product;
        }

        public void Delete(int id)
        {
            var existingProduct = _context.Products.SingleOrDefault(p => p.Id == id);
            if (existingProduct != null)
            {
                try
                {
                    _context.Remove(existingProduct);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred while updating the product.", ex);
                }

            }
            else
            {
                throw new Exception("Product not found.");
            }
        }
    } 
}

