using System;

namespace BMS.Dtos
{
    public class ReservationDto
    {
        public Guid Id { get; set; }
        
        public Guid BorrowerId { get; set; }
        
        public Guid BookTitleId { get; set; }
        
        public int LoanTime { get; set; }
    }
}