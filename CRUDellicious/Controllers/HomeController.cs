using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDellicious.Models;
using MyProject.Models;
using MyNamespace.Models;

namespace CRUDellicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        public IActionResult Dishes()
        {
            List<Dish> dishes = dbContext.Dishes.Where(dish => true).ToList();
            ViewBag.dishes = dishes;

            return View();
        }

        public IActionResult AddDish()
        {
            return View();
        }

        public IActionResult AddDishProcess(Dish newDish)
        {
            if(ModelState.IsValid){
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            else
                return View("AddDish");
        }
        [HttpGet("{id}")]
        public IActionResult Info(int id)
        {
            Dish RetrievedDish = dbContext.Dishes.FirstOrDefault(dish => dish.Id == id);
            ViewBag.Dish = RetrievedDish;
            return View();
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            Dish RetrievedDish = dbContext.Dishes.FirstOrDefault(dish => dish.Id == id);
            dbContext.Dishes.Remove(RetrievedDish);
            dbContext.SaveChanges();
            return RedirectToAction("Dishes");
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            Dish RetrievedDish = dbContext.Dishes.FirstOrDefault(dish => dish.Id == id);
            ViewBag.Dish = RetrievedDish;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
