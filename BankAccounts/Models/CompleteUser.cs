using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using TransactionNamespace.Models;
using System.Collections.Generic;
using UserNamespace.Models;
using UserTransactionNamespace.Models;


namespace CompleteUserNamespace.Models
{
    public class CompleteUser
    {
      public User UserItself {get; set; }
      public List<Transaction> UserTransaction {get; set; } 
    }
}