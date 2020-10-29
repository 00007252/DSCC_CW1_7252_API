using DSCC_CW1_7252_API.Model;
using Microsoft.EntityFrameworkCore;

namespace DSCC_CW1_7252_API.DbContexts
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

    }
}
