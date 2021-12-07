using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime LoanDate { get; set; }
        
        [Required]
        public DateTime ReturnDate { get; set; }
    }
}