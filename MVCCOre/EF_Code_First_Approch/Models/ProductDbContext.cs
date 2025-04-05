using Microsoft.EntityFrameworkCore;

namespace EF_Code_First_Approch.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Category>  categories {get;set;}
    }
}
 