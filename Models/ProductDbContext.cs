using Microsoft.EntityFrameworkCore;

namespace StoreCURDApp.Models
{
    public class ProductDbContext: DbContext
    {
        public ProductDbContext( DbContextOptions<ProductDbContext> options ): base( options )
        {
            
        }

        public DbSet<Product> ProductInfo { get; set; }

    }
}
