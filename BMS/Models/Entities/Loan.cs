using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BMS.Models.Entities
{
    public class Loan
    {
        [Key] 
        public Guid Id { get; set; }
        
        [Required]
        public User Borrower { get; set; }
        
        [Required]
        public BookItem LoanBook { get; set; }
        
        [Required]
        public DateTime LoanDate { get; set; }
        
        [Required]
        public DateTime ReturnDate { get; set; }
    }
}