using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel.Models;
using Users.Models;
using Microsoft.AspNetCore.Http;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("UserName", "Pidr");
            return View();
        }
        public IActionResult Info(User Info)
        {
            if (ModelState.IsValid)
                return View(Info);
            else
            {
                Console.WriteLine("***********************************");
                Console.WriteLine(ModelState["isValid"]);
                Console.WriteLine("***********************************");
                return View("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
