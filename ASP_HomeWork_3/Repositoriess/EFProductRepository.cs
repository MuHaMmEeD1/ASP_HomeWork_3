using ASP_HomeWork_3.Context;
using ASP_HomeWork_3.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_HomeWork_3.Repositoriess
{
    public class EFProductRepository : IProductRepository
    {

        private readonly ProductDbContext _context ;

        public EFProductRepository(ProductDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Product product)
        {
          _context.Products.Add(product);
          await Save();
        }

        public async Task DeleteAsync(int id)
        {
            var deleteData = await _context.Products.SingleOrDefaultAsync(p=>p.Id == id);

            _context.Products.Remove(deleteData);
            await Save();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
        {

             return await _context.Products.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task ModifyAsync(Product product)
        {




            _context.Products.Update(product); // bu nanlismi istediyim edit etmek
           
            await Save();
        }

        private async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
