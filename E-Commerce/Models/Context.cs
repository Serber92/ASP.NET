using Microsoft.EntityFrameworkCore;
using E_Commerce.Models;
 
namespace Context.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<Customer> Customers {get;set;}
        public DbSet<Order> Orders {get;set;}
        public DbSet<Product> Products {get;set;}
    }
}