using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace YourNamespace.Controllers    
{
  public class firstController : Controller
  {
    [HttpGet("")]
    public IActionResult Index()
    {
      return View();
    }
    [HttpGet("projects")]
    public IActionResult Projects()
    {
      return View();
    }
    [HttpGet("contact")]
    public IActionResult Contact()
    {
      return View();
    }
  }
}