using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel.Models;
using Users.Models;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            User someUser = new User()
            {
                FirstName = "Sally",
                LastName = "Sanderson"
            };
            return View(someUser);
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
