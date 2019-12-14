using System;
using System.Collections.Generic;

namespace E_Commerce.Models
{
    public class Wrapper
    {
      public Customer Customer {get; set; }
      public Product Product {get; set; }
      public Order Order {get; set; }
      public List<Customer> Customers {get; set; }
      public List<Product> Products {get; set; }
      public List<Order> Orders {get; set; }
    }
}