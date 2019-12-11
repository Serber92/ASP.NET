using UserNamespace.Models;
using WeddingNamespace.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace AssociationsNamespace.Models
{
    public class Associations
    {
      [Key]
      public int AssociationsId {get; set; }
      public int UserId {get; set;}
      public User User {get; set; }
      public int WeddingId {get; set; }
      public Wedding Wedding {get; set; }
    }
}