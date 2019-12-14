using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId {set; get; }
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
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;
        public List<Order> Orders {get; set; }
        
    }
}