using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wall.Models
{
    public class Message
    {
      [Key]
      public int MessageId {get; set; }
      public string Text {get; set; }
      public DateTime CreatedAt {get; set; } = DateTime.Now;
      public DateTime UpdatedAt {get; set; } = DateTime.Now;
      public int UserId {get; set; }
      public User Creator {get; set; }
      public List<Comment> Comments {get; set; }
    }
}