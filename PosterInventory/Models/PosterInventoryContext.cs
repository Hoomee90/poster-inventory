using Microsoft.EntityFrameworkCore;

namespace PosterInventory.Models
{
  public class PosterInventoryContext : DbContext
  {
    public DbSet<Poster> Posters { get; set; }

    public PosterInventoryContext(DbContextOptions options) : base(options) { }
  }
}