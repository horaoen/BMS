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
        
        [ForeignKey("BorrowerId")]
        public User Borrower { get; set; }
        
        public string BorrowerId { get; set; }
        
        [ForeignKey("LoanBookId")]
        public BookTitleItem LoanBook { get; set; }
        
        public Guid LoanBookId { get; set; }
        
        public DateTime LoanDate { get; set; }
        
        [Required]
        public DateTime ReturnDate { get; set; }
    }
}