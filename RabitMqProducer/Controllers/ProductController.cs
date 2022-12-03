using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabitMqProducer.Models;
using RabitMqProducer.Services;

namespace RabitMqProducer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<Product?> GetByIdAsync(string id)
        {
            return await _productService.GetByIdAsync(id);
        }
    }
}
