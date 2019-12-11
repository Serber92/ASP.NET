using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using AssociationsNamespace.Models;
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
    [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
    public string Password {get; set; }
    [NotMapped]
    [Compare("Password")]
    [DataType(DataType.Password)]
    public string ConfirmPassword {get; set; }
    public DateTime CreatedAt {set; get; } = DateTime.Today;
    public DateTime UpdatedAt {get; set; } = DateTime.Today;
    public List<Associations> WeddingsAttending {get; set; }
  }
}

