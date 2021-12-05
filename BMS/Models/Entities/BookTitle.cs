using System;
using System.ComponentModel.DataAnnotations;

namespace BMS.Models.Entities
{
    public class BookTitle
    {
        [Key]
        public Guid Id { get; set; }
        
        public string Name { get; set; }
        public string Author { get; set; }
        public int TotalNumber { get; set; }
        public int Revations { get; set; }
        public int BorrowedNumber { get; set; }
    }
}