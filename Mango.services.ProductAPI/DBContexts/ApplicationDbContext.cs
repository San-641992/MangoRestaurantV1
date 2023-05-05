using Mango.services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.services.ProductAPI.DBContexts
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
              
        }

        public DbSet<Product> Products { get; set; }
    }
}
