using System;
using System.ComponentModel.DataAnnotations;

namespace Users.Models
{
  public class User
  {
    [Display(Name = "Name from model")]
    [MinLength(2)]
    public string Name { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public string Language { get; set; }
    [MinLength(20)]
    public string Message { get; set; }
  }
}
