using System;
using System.Collections.Generic;
using ProductsCategories.Models;

namespace AllProductsNamespace.Models
{
  public class AllProducts
  {
    public Product Product {get; set; }
    public List<Product> Products {get; set; }
  }
}