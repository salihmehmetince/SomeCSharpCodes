using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Web.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
