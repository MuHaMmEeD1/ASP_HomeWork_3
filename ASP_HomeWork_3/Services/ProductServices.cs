using ASP_HomeWork_3.Entities;
using ASP_HomeWork_3.Repositoriess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP_HomeWork_3.Services
{
    public class ProductServices : IProductServices
    {

        private readonly IProductRepository _productRepository;

        public ProductServices(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddAsync(Product product)
        {
           await _productRepository.AddAsync(product);
        }

        public async Task DeleteAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task ModifyAsync(Product product)
        {
            await _productRepository.ModifyAsync(product);
        }
    }
}
