using WeddingNamespace.Models;
using System;
using System.Collections.Generic;
using UserNamespace.Models;

namespace WeddingWrapperNamespace.Models
{
    public class WeddingWrapper
    {
      public Wedding Wedding {get; set; }
      public List<Wedding> Weddings {get; set; }

      public User User {get; set; }
      public List<User> Users {get; set; }
    }
}