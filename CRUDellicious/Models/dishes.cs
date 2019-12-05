using System.ComponentModel.DataAnnotations;
using System;
namespace MyProject.Models
{
  public class Dish
  {
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name {get; set; }
    [Required]
    public string Chef {get; set; }
    [Required]
    [Range(1, 5)]
    public int Tastiness {get; set; }
    [Required]
    [Range(1,2400)]
    public int Calories {get; set; }
    [Required]
    public string Description {get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
  }
}