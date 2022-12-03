using RabitMqProducer.Models;

namespace RabitMqProducer.Services
{
    public interface IProductService
    {
        ValueTask<Product?> GetByIdAsync(string id);
        
        Task<bool> AddAsync(Product product);

        Task DeleteAsync(string id);
        
        Task<bool> UpdateAsync(Product product);

        IAsyncEnumerable<Product> GetAllAsync();
    }
}
