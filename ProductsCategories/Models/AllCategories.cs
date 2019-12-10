using System;
using System.Collections.Generic;
using ProductsCategories.Models;

namespace AllCategoriesNamespace.Models
{
  public class AllCategories
  {
    public Category Category {get; set; }
    public List<Category> Categories {get; set; }
  }
}