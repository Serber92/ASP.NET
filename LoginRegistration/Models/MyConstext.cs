using Microsoft.EntityFrameworkCore;
using UserNamespace.Models;

namespace Context.Models
{
  public class MyContext : DbContext
  {
    // base() calls the parent class' constructor passing the "options" parameter along
    public MyContext(DbContextOptions options) : base(options) { }

    public DbSet<User> Users { get; set; }
  }
}