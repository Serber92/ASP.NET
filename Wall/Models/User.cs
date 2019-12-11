using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wall.Models
{
    public class User
    {
        [Key]
        public int UserId {set; get; }
        [Required]
        public string FirstName {get; set; }
        [Required]
        public string LastName {get; set; }
        [Required]
        [EmailAddress]
        public string Email {get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password {get; set; }
        [Required]
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("Password")]
        public string ConfirmPassword {set; get; }
        public DateTime CreatedAt {get; set; } = DateTime.Today;
        public DateTime UpdatedAt {get; set; } = DateTime.Today;
        public List<Message> CreatedMessages {get; set; }
        public List<Comment> CreatedComments {get; set; }
    }
}