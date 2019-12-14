using System;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
  public class Product
  {
    [Key]
    public int ProductId {get; set; } 
    public string Name {get; set; }
    public int Amount {get; set; }
    public string Description {set; get; }
    public string Image {set; get; }
    public int OrderId {get; set; }
    public Order Order {get; set; }
    public DateTime CreatedAt {get; set; } = DateTime.Now;
    public DateTime UpdatedAt {get; set; } = DateTime.Now;
  }
}