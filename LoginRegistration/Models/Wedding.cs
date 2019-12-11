using System;
using System.ComponentModel.DataAnnotations;
using UserNamespace.Models;
using AssociationsNamespace.Models;
using System.Collections.Generic;

namespace WeddingNamespace.Models
{
    public class Wedding
    {
      [Key]
      public int WeddingId {get; set; }
      public int User1Id {get; set;}
      public int User2Id {get; set; }
      public User User1 {get; set; }
      public User User2 {get; set; }
      [Required]
      public DateTime Date {get; set; }
      [Required]
      public string WeddingAddress {get; set; }
      public DateTime CreatedAt {get; set; } = DateTime.Today;
      public DateTime UpdatedAt {get; set; } = DateTime.Today;
      public List<Associations> UsersAttending {get; set; }
    }
}