using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
  public class Order
  {
    [Key]
    public int OrderId {get; set; }
    public List<Product> Products {get; set; }
    public int CustomerId {get; set; }
    public Customer Customer {get; set; }
    public DateTime CreatedAt {get; set; } = DateTime.Now;
    public DateTime UpdatedAt {get; set; } = DateTime.Now;
  }
}