using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
  public class BakeryContext : DbContext
  {
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor_Treat> Flavor_Treat { get; set; }

    public BakeryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}