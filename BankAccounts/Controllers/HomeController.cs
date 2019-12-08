using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccounts.Models;
using DBContext.Models;
using Microsoft.AspNetCore.Http;
using UserTransactionNamespace.Models;
using UserNamespace.Models;
using LoginNamespace.Models;
using Microsoft.EntityFrameworkCore;
using CompleteUserNamespace.Models;
using TransactionNamespace.Models;


namespace BankAccounts.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
        dbContext = context;
        }
        public IActionResult Register()
        {
            HttpContext.Session.Clear();
            return View();
        }
        public IActionResult RegisterProcess(IndexViewModel modelData)
        {
            if(ModelState.IsValid)
            {
                User UserSubmitted = modelData.NewUser;
                dbContext.Add(UserSubmitted);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("LoggedIn", 1);
                User RetrievedUser = dbContext.Users.FirstOrDefault(u => u.Email == UserSubmitted.Email);
                HttpContext.Session.SetInt32("UserId", RetrievedUser.UserId);
                return RedirectToAction("Account");
            }
            else   
                return View("Register");
        }

        public IActionResult Login(string Message = "")
        {
            HttpContext.Session.Clear();
            ViewBag.Message = Message;
            return View();
        }
        public IActionResult LoginProcess(IndexViewModel modelData)
        {
            Login LoginInfoSubmitted = modelData.NewLogin;
            if (dbContext.Users.Any(u => u.Email == LoginInfoSubmitted.Email))
            {
                User RetrievedUser = dbContext.Users.FirstOrDefault(u => u.Email == LoginInfoSubmitted.Email);
                if (RetrievedUser.Password == LoginInfoSubmitted.Password)
                {
                    HttpContext.Session.SetInt32("LoggedIn", 1);
                    HttpContext.Session.SetInt32("UserId", RetrievedUser.UserId);
                    return RedirectToAction("Account");
                }
                else
                {
                    ModelState.AddModelError("Password", "Wrong Password");
                    return View("Login");
                }
            }
            else
            {
                ModelState.AddModelError("Email", "No such email registered");
                return View("Login");
            }   
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        
        public IActionResult Account(string TransactionStatusMessage = "")
        {   
            ViewBag.TransactionStatusMessage = TransactionStatusMessage;
            int? LoggedIn = HttpContext.Session.GetInt32("LoggedIn");
            if(LoggedIn == 1){
                {
                    User RetrievedUser = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
                    CompleteUser completeUser = new CompleteUser(){
                        UserItself = RetrievedUser,
                        UserTransaction = dbContext.Users.Include(u => u.PostedTransactions).FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId")).PostedTransactions.ToList()
                    };
                    return View(completeUser);
                }
            }
            else
            {
                return RedirectToAction("Login", new {Message = "Not Logged In"});
            }
        }

        public IActionResult AddTransactionProcess(int TransactionAmount)
        {
            User RetrievedUser = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            Transaction newTransaction = new Transaction(){
                Amount = TransactionAmount,
                UserId = RetrievedUser.UserId
            };

            List<Transaction> PreviousTransactions = dbContext.Users.Include(u => u.PostedTransactions).FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId")).PostedTransactions.ToList();
            int SumPreviousTransactions = 0;
            foreach (Transaction transaction in PreviousTransactions)
            {
                SumPreviousTransactions += transaction.Amount;
            }
            if(SumPreviousTransactions+TransactionAmount < 0)
            {
                return RedirectToAction("Account", new {TransactionStatusMessage = "Insufficient funds"});
            }
            else
            {
                dbContext.Add(newTransaction);
                dbContext.SaveChanges();
                return RedirectToAction("Account", new {TransactionStatusMessage = "Transaction complete at " + newTransaction.CreatedAt});
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
