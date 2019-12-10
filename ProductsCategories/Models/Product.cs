using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AssociationNamespace.Models;

namespace ProductsCategories.Models
{
    public class Product
    {
      [Key]
      public int ProductId {get; set; }
      [Required]
      public string Name {get; set; }
      [Required]
      public string Description {get; set; }
      [Required]
      public int Price {get; set; }
      public DateTime CreatedAt {get; set; } = DateTime.Today;
      public DateTime UpdatedAt {get; set; } = DateTime.Today;
      public List<Association> Category {get; set; }
    }
}