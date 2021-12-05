using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BMS.Models.Entities
{
    public class Loan
    {
        [Key] 
        public Guid Id { get; set; }
        public User Borrower { get; set; }
        public BookItem LoanBook { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        
    }
}