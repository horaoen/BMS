using System;

namespace BMS.Dtos
{
    public class LoanDto
    {   
        public Guid id { get; set; }
        
        public string BorrowerId { get; set; }
        
        public Guid LoanBookId { get; set; }
        
        public DateTime ReturnDate { get; set; }
    }
}