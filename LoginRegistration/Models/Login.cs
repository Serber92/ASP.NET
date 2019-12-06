using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginNamespace.Models
{
  public class Login
  {
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
    public string Password { get; set; }
  }
}