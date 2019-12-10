using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssociationNamespace.Models;

namespace ProductsCategories.Models
{
    public class Category
    {
      [Key]
      public int CategoryId {get; set; }
      [Required]
      public string Name {get; set; }
      public DateTime CreatedAt {get; set; } = DateTime.Today;
      public DateTime UpdatedAt {get; set; } = DateTime.Today;
      public List<Association> Products {get; set; }
      
    }
}