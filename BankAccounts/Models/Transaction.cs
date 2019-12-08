using System.ComponentModel.DataAnnotations;
using System;
using UserNamespace.Models;

namespace TransactionNamespace.Models
{
    public class Transaction
    {
      [Key]
      public int TransactionId {get; set; }
      public int Amount {get; set; }
      public DateTime CreatedAt {get; set; } = DateTime.Today;
      public DateTime UpdatedAt {get; set; } = DateTime.Today;
      public int UserId {get; set; }
      public User Payer {get; set; }
    }
}