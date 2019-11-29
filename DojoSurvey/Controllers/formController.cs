using Microsoft.AspNetCore.Mvc;
using System.Web;
using System;
namespace DojoSurvey.Controllers
{
    static class globalData
    {
      public static string _Name;
      public static string _Location;
      public static string _Language;
      public static string _Message;
    }
    public class FormController : Controller
    {
      [HttpGet("index")]
      public IActionResult Index()
      {
        return View();
      }

      [HttpGet("show_info")]
      public IActionResult show_info()
      {
        ViewBag.name = globalData._Name;
        ViewBag.location = globalData._Location;
        ViewBag.language = globalData._Language;
        ViewBag.message = globalData._Message;
        return View();
      }

      [HttpPost("post_info")]
      public RedirectToActionResult Method(string name, string location, string language, string message)
      {
        globalData._Name = name;
        globalData._Location = location;
        globalData._Language = language;
        globalData._Message = message;
        return RedirectToAction("show_info");
      }
    }
}