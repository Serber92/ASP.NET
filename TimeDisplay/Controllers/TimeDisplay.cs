using Microsoft.AspNetCore.Mvc;
using System;
namespace YourNamespace.Controllers 
{
  public class TimeController : Controller 
  {
    [HttpGet("")]       
    public IActionResult Index()
    {
      return View();
    }

    [HttpGet("get_time")]
    public string Time()
    {
      string time = DateTime.Now.ToString("h:mm:ss tt");
      return time;
    }
  }
}