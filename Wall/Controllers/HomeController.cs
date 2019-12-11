using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wall.Models;
using ContextNamespace.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Wall.Controllers
{
    public class HomeController : Controller
    {
        private Context dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(Context context)
        {
            dbContext = context;
        }
        public IActionResult Registration()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.SetString("Logged", "False");
            return View();
        }
        public IActionResult RegistrationProcess(User newUser)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already registered!");
                    return View("Registration");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                dbContext.Users.Add(newUser);
                dbContext.SaveChanges();
                User retrievedUser = dbContext.Users.FirstOrDefault(u => u.Email == newUser.Email);
                HttpContext.Session.SetString("Logged", "True");
                HttpContext.Session.SetInt32("UserId", retrievedUser.UserId);
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
                if(dbContext.Users.Any(u => u.Email == newLogin.Email))
                {
                    User retrievedUser = dbContext.Users.FirstOrDefault(u => u.Email == newLogin.Email);
                    var hasher = new PasswordHasher<Login>();
                    var result = hasher.VerifyHashedPassword(newLogin, retrievedUser.Password, newLogin.Password);
                    if(result != 0)
                    {
                        HttpContext.Session.SetString("Logged", "True");
                        HttpContext.Session.SetInt32("UserId", retrievedUser.UserId);
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
                int? CurrentUserId = HttpContext.Session.GetInt32("UserId");
                User retrievedUser = dbContext.Users.FirstOrDefault(u => u.UserId == (int)CurrentUserId);

                List<Message> AllMessages = dbContext.Messages
                .Include(m => m.Creator)
                .Include(m => m.Comments)
                .ToList();

                List<Comment> AllComments = dbContext.Comments
                .Include(c => c.Message)
                .Include(c => c.Creator)
                .ToList();

                Wrapper modelData = new Wrapper()
                {
                    User = retrievedUser,
                    Messages = AllMessages,
                    Comments = AllComments,
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
            return View("Login");
        }
        [HttpGet("home/DeleteMessageProcess/{MessageId}")]
        public IActionResult DeleteMessageProcess(int MessageId)
        {
            Message retreivedMessage = dbContext.Messages.FirstOrDefault(m => m.MessageId == MessageId);
            List<Comment> CommentsDelete = dbContext.Comments.Where(c => c.MessageId == MessageId).ToList();
            foreach (Comment comment in CommentsDelete)
            {
                dbContext.Comments.Remove(comment);
            }
            dbContext.Messages.Remove(retreivedMessage);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        public IActionResult AddMessageProcess(Wrapper modelData)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            Message newMessage = new Message()
            {
                Text = modelData.Message.Text,
                UserId = (int)UserId
            };
            dbContext.Add(newMessage);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        public IActionResult AddCommentProcess(Wrapper modelData)
        {
            int? UserId = HttpContext.Session.GetInt32("UserId");
            Comment newComment = new Comment()
            {
                UserId = (int)UserId,
                Text = modelData.Comment.Text,
                MessageId = modelData.Comment.MessageId,
            };
            dbContext.Add(newComment);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
