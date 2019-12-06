using UserNamespace.Models;
using LoginNamespace.Models;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IndexViewModelNamespace.Models
{
  public class IndexViewModel
  {
    public User NewUser {get; set; }
    public Login NewLogin {get; set; }
  }
}