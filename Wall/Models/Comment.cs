using System;
using System.ComponentModel.DataAnnotations;

namespace Wall.Models
{
    public class Comment
    {
      [Key]
      public int CommentId {get; set; }
      public string Text {get; set; }
      public DateTime CreatedAt {get; set; } = DateTime.Now;
      public DateTime UpdatedAt {get; set; } = DateTime.Now;
      public int MessageId {get; set; }
      public Message Message {get; set; }
      public int UserId {get; set; }
      public User Creator {get; set; }
    }
}