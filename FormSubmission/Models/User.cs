using System;
using System.ComponentModel.DataAnnotations;

namespace Users.Models
{

  public class DOBnotPastAttribute : ValidationAttribute
  {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      int isLater = DateTime.Compare((DateTime)value, DateTime.Today);
      if (isLater > 0)
        return new ValidationResult("Cant use future date");
      return ValidationResult.Success;
    }
  }
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

    [Display(Name = "Date of Birth")]
    [Required]
    [DOBnotPast]
    public DateTime DOB { get; set; }
  }
}
