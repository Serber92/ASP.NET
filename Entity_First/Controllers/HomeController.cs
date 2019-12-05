using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Entity_First.Models;
using MyProject.Models;
using YourNamespace.Models;

namespace Entity_First.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
        dbContext = context;
        }
        public IActionResult Index()
        {
            List<User> AllUsers = dbContext.Users.ToList();
            Console.WriteLine("*********************");
            Console.WriteLine(AllUsers.First().LastName);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
