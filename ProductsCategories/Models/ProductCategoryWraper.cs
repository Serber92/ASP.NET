using System;
using ProductsCategories.Models;
using System.Collections.Generic;

namespace ProductCategoryWraperNamespace.Models
{
    public class ProductCategoryWraper
    {
      public Product Product {get; set; }
      public Category Category {get; set; }
      public List<Category> Categories {get; set; }
      public List<Product> Products {get; set; }
    }
}