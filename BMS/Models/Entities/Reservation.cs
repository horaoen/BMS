using System;
using System.ComponentModel.DataAnnotations;

namespace BMS.Models.Entities
{
    public class Reservation
    {
        [Key] 
        public Guid Id { get; set; }
        
        [Required]
        public Guid BookTitleId { get; set; }
        
        [Required]
        public Guid BorrowerId { get; set; }
        
        public int LoanTime { get; set; }
    }
}