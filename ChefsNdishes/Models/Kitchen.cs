using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ChefNdishes.Models
{
  public class Chef
  {
    [Key]
    public int ChefId { get; set; }
    public string FirstName {get; set; }
    public string LastName {get; set; }
    public string DOB {get; set; }
    public List<Dish> HasDish {get; set; }
  }
  public class Dish
  {
    [Key]
    public int DishId { get; set; }
    public string Name {get; set; }
    public int Calories {get; set; }
    public string Description {get; set; }
    public int Tastiness {get; set; }
    public int ChefId {get; set; }
    public Chef Cook {get; set; }
  }  
}


