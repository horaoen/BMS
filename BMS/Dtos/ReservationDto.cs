using System;

namespace BMS.Dtos
{
    public class ReservationDto
    {
        public Guid Id { get; set; }
        
        public Guid Borrower { get; set; }
        
        public Guid BookTitleId { get; set; }
        
        public int LoanTime { get; set; }
    }
}