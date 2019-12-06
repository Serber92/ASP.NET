using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefNdishes.Models;
using ContextNamespace.Models;
using ChefsNdishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNdishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Chefs()
        {
            ViewBag.AllChefs = dbContext.Chefs.Include(c => c.HasDish).ToList();
            return View();
        }

        public IActionResult Dishes()
        {
            ViewBag.AllDishes = dbContext.Dishes.Include(d => d.Cook).ToList();
            return View();
        }
        public IActionResult AddDish()
        {
            ViewBag.AllChefs = dbContext.Chefs.ToList();
            return View();
        }
        public IActionResult AddDishProcess(Dish newDish)
        {
            dbContext.Add(newDish);
            dbContext.SaveChanges();
            Dish lastDish = dbContext.Dishes.Last();
            return RedirectToAction("Dishes");
        }
        public IActionResult AddChef()
        {
            return View();
        }
        public IActionResult AddChefProcess(Chef newChef)
        {
            dbContext.Add(newChef);
            dbContext.SaveChanges();
            return RedirectToAction("Chefs");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
