using Microsoft.EntityFrameworkCore;
using UserNamespace.Models;
using TransactionNamespace.Models;

namespace DBContext.Models
{
  public class MyContext : DbContext
  {
    public MyContext(DbContextOptions options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
  }
}