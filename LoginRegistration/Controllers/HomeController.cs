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
using WeddingNamespace.Models;
using Microsoft.EntityFrameworkCore;
using WeddingWrapperNamespace.Models;
using AssociationsNamespace.Models;

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
            HttpContext.Session.Clear();
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
            HttpContext.Session.SetInt32("UserLogedIn", 1);
            User retrievedUser = dbContext.Users.FirstOrDefault(u => u.Email == newUser.Email);
            HttpContext.Session.SetInt32("LoggedUserId", retrievedUser.UserId);
            return RedirectToAction("Dashboard");
        }
        else
            return View("Registration");
        }

        public IActionResult Login()
        {
            HttpContext.Session.Clear();
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
            HttpContext.Session.SetInt32("LoggedUserId", retrievedUser.UserId);
            return RedirectToAction("Dashboard"); 
          }  
          else
            return View("Login");
        }

        public IActionResult Dashboard()
        {
            int? Logged = HttpContext.Session.GetInt32("UserLogedIn");
            if (Logged == 1)
            {
                int? LoggedUserId = HttpContext.Session.GetInt32("LoggedUserId");
                User retrievedUser = dbContext.Users
                .Include(u => u.WeddingsAttending)
                .FirstOrDefault(u => u.UserId == (int)LoggedUserId);

                List<Wedding> AllWeddings = dbContext.Weddings
                .Include(w => w.User1)
                .Include(w => w.User2)
                .Include(w => w.UsersAttending)
                .ToList();

                WeddingWrapper modelData = new WeddingWrapper()
                {
                    User = retrievedUser,
                    Weddings = AllWeddings,
                };
                return View(modelData);
            }
            else
            {
                ViewBag.LoggedIn = "You are not logged in";
                return View("Login");
            }
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        public IActionResult NewWedding()
        {
            List<User> AllUsers = dbContext.Users.ToList();
            WeddingWrapper modelData = new WeddingWrapper()
            {
                Users = AllUsers,
            };
            return View(modelData);
        }

        public IActionResult NewWeddingProcess(WeddingWrapper modelData)
        {
            if(ModelState.IsValid)
            {
                Wedding NewWedding = modelData.Wedding;
                dbContext.Add(NewWedding);
                dbContext.SaveChanges();
               return RedirectToAction("Dashboard"); 
            }
            else
                return View("NewWedding");
        }

        [HttpGet("Home/JoinWeddingProcess/{weddingId}")]
        public IActionResult JoinWeddingProcess(int weddingId)
        {
            int? loggedUserId = HttpContext.Session.GetInt32("LoggedUserId");

            Associations newAssociation = new Associations()
            {
                UserId = (int)loggedUserId,
                WeddingId = weddingId
            };

            dbContext.Add(newAssociation);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpGet("Home/GetOutProcess/{weddingId}")]
        public IActionResult GetOutProcess(int weddingId)
        {
            int? loggedUserId = HttpContext.Session.GetInt32("LoggedUserId");

            Associations associationToRemove = dbContext.Associations.FirstOrDefault(a => a.UserId==(int)loggedUserId && a.WeddingId==weddingId);

            dbContext.Associations.Remove(associationToRemove);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpGet("Home/DeleteWeddingProcess/{weddingId}")]
        public IActionResult DeleteWeddingProcess(int weddingId)
        {

            Wedding weddingtoRemove = dbContext.Weddings.FirstOrDefault(w => w.WeddingId == weddingId);
            List<Associations> associationsToRemove = dbContext.Associations
            .Where(a => a.WeddingId == weddingId)
            .ToList();

            dbContext.Weddings.Remove(weddingtoRemove);
            foreach (Associations association in associationsToRemove)
            {
               dbContext.Associations.Remove(association); 
            }
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpGet("Home/WeddingInfo/{weddingId}")]
        public IActionResult WeddingInfo(int weddingId)
        {
            Wedding retrievedWedding = dbContext.Weddings
            .Include(w => w.User1)
            .Include(w => w.User2)
            .Include(w => w.UsersAttending)
            .ThenInclude(sub => sub.User)
            .FirstOrDefault(w => w.WeddingId == weddingId);

            WeddingWrapper modelData = new WeddingWrapper()
            {
                Wedding = retrievedWedding,
            };
            return View(modelData);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
