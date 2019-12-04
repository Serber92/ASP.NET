using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoDachi.Models;
using Microsoft.AspNetCore.Http;

namespace DojoDachi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetInt32("fullness", 20);
            HttpContext.Session.SetInt32("happiness", 20);
            ViewBag.fullness = HttpContext.Session.GetInt32("fullness");
            ViewBag.happiness = HttpContext.Session.GetInt32("happiness");
            return View();
        }

        [HttpGet("feed")]
        public int? Feed()
        {
            Random random = new Random();
            int fullness_gained = 0;
            if (random.Next(1,4) == 1)
            {
                fullness_gained = random.Next(5,10);
            }
            int? fullness = HttpContext.Session.GetInt32("fullness");
            HttpContext.Session.SetInt32("fullness", (int)fullness + fullness_gained);
            return HttpContext.Session.GetInt32("fullness");
        }

        [HttpGet("play")]
        public int? Play()
        {
        Random random = new Random();
        int happiness_gained = 0;
        if (random.Next(1, 4) == 1)
        {
            happiness_gained = random.Next(5, 10);
        }
        int? happiness = HttpContext.Session.GetInt32("happiness");
        HttpContext.Session.SetInt32("happiness", (int)happiness + happiness_gained);
        return HttpContext.Session.GetInt32("happiness");
        }

        [HttpGet("work")]
        public void Work(string meal)
        {
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine(meal);
        // Random random = new Random();
        // int meal_gained = 0;
        // if (random.Next(1, 4) == 1)
        // {
        //     meal_gained = random.Next(1, 3);
        // }
        // meal += meal_gained;
        // return meal;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
