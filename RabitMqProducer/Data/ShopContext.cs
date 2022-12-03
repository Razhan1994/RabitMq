using Microsoft.EntityFrameworkCore;
using RabitMqProducer.Models;

namespace RabitMqProducer.Data
{
    public class ShopContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public ShopContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ShopDb"));
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Product> Products { get; set; }
    }
}
