using System;
using System.Collections.Generic;

namespace Wall.Models
{
  public class Wrapper
  {
    public User User {get; set; }
    public Message Message {get; set; }
    public Comment Comment {get; set; }
    public List<User> Users {get; set; }
    public List<Message> Messages {get; set; }
    public List<Comment> Comments {get; set; }
  }
}