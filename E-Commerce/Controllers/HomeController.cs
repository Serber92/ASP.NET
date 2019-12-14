using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using E_Commerce.Models;
using Context.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace E_Commerce.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        public IActionResult Registration()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.SetString("Logged", "False");
            return View();
        }
        public IActionResult RegistrationProcess(Customer newCustomer)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Customers.Any(u => u.Email == newCustomer.Email))
                {
                    ModelState.AddModelError("Email", "Email already registered!");
                    return View("Registration");
                }
                PasswordHasher<Customer> Hasher = new PasswordHasher<Customer>();
                newCustomer.Password = Hasher.HashPassword(newCustomer, newCustomer.Password);
                dbContext.Customers.Add(newCustomer);
                dbContext.SaveChanges();
                Customer retrievedCustomer = dbContext.Customers.FirstOrDefault(u => u.Email == newCustomer.Email);
                HttpContext.Session.SetString("Logged", "True");
                HttpContext.Session.SetInt32("UserId", retrievedCustomer.CustomerId);
                return RedirectToAction("Dashboard");
            }
            else
                return View("Registration");
        }
        public IActionResult Login()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.SetString("Logged", "False");
            return View();
        }
        public IActionResult LoginProcess(Login newLogin)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Customers.Any(u => u.Email == newLogin.Email))
                {
                    Customer retrievedCustomer = dbContext.Customers.FirstOrDefault(u => u.Email == newLogin.Email);
                    var hasher = new PasswordHasher<Login>();
                    var result = hasher.VerifyHashedPassword(newLogin, retrievedCustomer.Password, newLogin.Password);
                    if(result != 0)
                    {
                        HttpContext.Session.SetString("Logged", "True");
                        HttpContext.Session.SetInt32("CustomerId", retrievedCustomer.CustomerId);
                        return RedirectToAction("Dashboard");
                    }
                    else
                    {
                        ModelState.AddModelError("Password", "Wrong Password!");
                        return View("Login");
                    }
                }
                else
                {
                    ModelState.AddModelError("Email", "No such email registered!");
                    return View("Login");
                }
            }
            else
                return View("Login");
        }
        public IActionResult Dashboard()
        {
            if(HttpContext.Session.GetString("Logged") == "True")
            {
                int? CurrentCustomerId = HttpContext.Session.GetInt32("CustomerId");
                Customer retrievedCustomer = dbContext.Customers.FirstOrDefault(u => u.CustomerId == (int)CurrentCustomerId);

                Wrapper modelData = new Wrapper()
                {
                    Customer = retrievedCustomer,
                };
                return View(modelData);
            }
            else
            {
                ModelState.AddModelError("Email", "Not Logged in!");
                return View("Login");
            }
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        public IActionResult Products()
        {
            List<Product> AllProducts = dbContext.Products.ToList();

            Wrapper modelData = new Wrapper()
            {
                Products = AllProducts,
            };
            return View(modelData);
        }
        public IActionResult AddProductProcess(Wrapper modelData)
        {
            if(ModelState.IsValid)
            {
                dbContext.Products.Add(modelData.Product);
                dbContext.SaveChanges();
                return RedirectToAction("Products");
            }
            else
            {
                return View("Products");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
