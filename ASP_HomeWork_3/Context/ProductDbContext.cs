using ASP_HomeWork_3.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP_HomeWork_3.Context
{
    public class ProductDbContext : DbContext
    {
       

        public ProductDbContext(DbContextOptions<ProductDbContext> options)
        : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }    


    }
}
