using System;
using System.ComponentModel.DataAnnotations;

namespace BMS.Dtos
{
    public class ReservationForCreation
    {
        [Required]
        public Guid BookTitleId { get; set; }
        
        public int LoanTime { get; set; }
    }
}