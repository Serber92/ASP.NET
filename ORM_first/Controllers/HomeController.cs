using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ORM_first.Models;
using DapperApp.Factory; 
using DbConnection;
using UserM.Models;


namespace ORM_first.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            User pidr = new User()
            {
                Name = "Gnida",
                Pidr = true,
            };
            string query = $"INSERT INTO users (Name, Pidr) VALUES ('{pidr.Name}', '{pidr.Pidr}')";
            DbConnector.Execute(query);
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
