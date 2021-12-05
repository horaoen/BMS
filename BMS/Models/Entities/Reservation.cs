using System;
using System.ComponentModel.DataAnnotations;

namespace BMS.Models.Entities
{
    public class Reservation
    {
        [Key] public Guid Id { get; set; }
        public Guid BorrowerId { get; set; }
        public int LoanTime { get; set; }
    }
}