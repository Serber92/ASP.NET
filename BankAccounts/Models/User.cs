using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using TransactionNamespace.Models;
using System.Collections.Generic;

namespace UserNamespace.Models
{
  public class User
  {
    [Key]
    public int UserId {get; set; }
    [Required]
    public string FirstName {get; set; }
    [Required]
    public string LastName {get; set; }
    [Required]
    [EmailAddress]
    public string Email {get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password {get; set; }
    [NotMapped]
    [Compare("Password")]
    [DataType(DataType.Password)]
    public string ConfirmPassword {get; set; }
    public DateTime CreatedAt {get; set; } = DateTime.Today;
    public DateTime UpdatedAt {get; set; } = DateTime.Today;
    public List<Transaction> PostedTransactions {get; set; }
  }
}