using Microsoft.EntityFrameworkCore;

namespace pms_api.data;

public class PMSContext : DbContext
{
    public PMSContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}