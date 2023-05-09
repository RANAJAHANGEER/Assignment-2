using Microsoft.EntityFrameworkCore;

namespace assugnmwnt2.Data
{
    public class ProDbContext : DbContext
    {
        public ProDbContext(DbContextOptions<ProDbContext> options):base (options) { }
        public DbSet<Product> Products { get; set; }
    }
}
