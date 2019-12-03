using System;
using System.ComponentModel.DataAnnotations;

namespace Users.Models
{
  public class User
  {
    [Display(Name = "First Name")]
    [Required]
    [MinLength(4)]
    public string FirstName { get; set; }

    [Display(Name = "Last Name")]
    [Required]
    [MinLength(4)]
    public string LastName { get; set; }

    [Display(Name = "Age")]
    [Required]
    [Range(1,666)]
    public int Age { get; set; }

    [Display(Name = "Email")]
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Display(Name = "Password")]
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
  }
}
