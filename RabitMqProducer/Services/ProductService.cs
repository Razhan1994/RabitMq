using Microsoft.EntityFrameworkCore;
using RabitMqProducer.Data;
using RabitMqProducer.Models;

namespace RabitMqProducer.Services
{
    public class ProductService : IProductService
    {
        private readonly ShopContext _dbContext;

        public ProductService(ShopContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ValueTask<Product?> GetByIdAsync(string id)
        {
            return _dbContext.Products.FindAsync(id);
        }

        public Task<bool> AddAsync(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChangesAsync();

            return Task.FromResult(true);
        }

        public Task DeleteAsync(string id)
        {
            var product = _dbContext.Products.FindAsync(id);
            _dbContext.Remove(product);

            return _dbContext.SaveChangesAsync();
        }

        public Task<bool> UpdateAsync(Product product)
        {
            _dbContext.Products.Update(product);

            _dbContext.SaveChangesAsync();

            return Task.FromResult(true);
        }

        public IAsyncEnumerable<Product> GetAllAsync()
        {
            return _dbContext.Products.AsAsyncEnumerable();
        }
    }
}
