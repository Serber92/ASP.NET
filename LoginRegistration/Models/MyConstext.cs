using Microsoft.EntityFrameworkCore;
using UserNamespace.Models;
using WeddingNamespace.Models;
using AssociationsNamespace.Models;

namespace Context.Models
{
  public class MyContext : DbContext
  {
    // base() calls the parent class' constructor passing the "options" parameter along
    public MyContext(DbContextOptions options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Wedding> Weddings { get; set; }
    public DbSet<Associations> Associations { get; set; }
  }
}