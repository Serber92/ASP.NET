using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginRegistration.Models;
using IndexViewModelNamespace.Models;
using Context.Models;
using UserNamespace.Models;
using LoginNamespace.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LoginRegistration.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
        dbContext = context;
        }
        public IActionResult Registration()
        {
            HttpContext.Session.SetInt32("UserLogedIn", 0);
            return View();
        }
        public IActionResult RegistrationProcess(IndexViewModel modelData)
        {
            User newUser = modelData.NewUser;
        if (ModelState.IsValid)
        {
            PasswordHasher<User> Hasher = new PasswordHasher<User>();
            newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
            dbContext.Add(newUser);
            dbContext.SaveChanges();
            return RedirectToAction("Success");
        }
        else
            return View("Registration");
        }

        public IActionResult Login()
        {
            ViewBag.LoggedIn = "";
            return View();
        }

        public IActionResult LoginProcess(IndexViewModel modelData)
        {
            HttpContext.Session.SetInt32("UserLogedIn", 0);
            Login userToLogin = modelData.NewLogin;
          if(ModelState.IsValid)
          {
              if(!dbContext.Users.Any(u => u.Email == userToLogin.Email))
              {
                  ModelState.AddModelError("NewLogin.Email", "No such email in DB");
                    return View("Login");
              }
              User retrievedUser = dbContext.Users.FirstOrDefault(u => u.Email == userToLogin.Email);
                PasswordHasher<Login> Hasher = new PasswordHasher<Login>();
                var result = Hasher.VerifyHashedPassword(userToLogin, retrievedUser.Password, userToLogin.Password);
              if (result == 0)
              {
                ModelState.AddModelError("NewLogin.Password", "Wrong Password");
                return View("Login");
              }
            HttpContext.Session.SetInt32("UserLogedIn", 1);
            return RedirectToAction("Success"); 
          }  
          else
            return View("Login");
        }

        public IActionResult Success()
        {
            int? Logged = HttpContext.Session.GetInt32("UserLogedIn");
            if (Logged == 1)
                return View();
            else
                ViewBag.LoggedIn = "You are not logged in";
                return View("Login");
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
