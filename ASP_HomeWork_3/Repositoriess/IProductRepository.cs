using ASP_HomeWork_3.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASP_HomeWork_3.Repositoriess
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();

        Task AddAsync(Product product);

        Task DeleteAsync(int id);

        Task ModifyAsync(Product product);

        Task<Product> GetByIdAsync(int id);
    }
}
