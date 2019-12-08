using System.ComponentModel.DataAnnotations;
using System;
using UserNamespace.Models;
using TransactionNamespace.Models;
using LoginNamespace.Models;

namespace UserTransactionNamespace.Models
{
    public class IndexViewModel
    {
      public User NewUser {get; set; }
      public Login NewLogin {get; set; }
      public Transaction NewTransaction {get; set; }
    }
}