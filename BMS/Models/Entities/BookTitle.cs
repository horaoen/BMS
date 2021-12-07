using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BMS.Models.Entities
{
    public class BookTitle
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Author { get; set; }
        
        public int TotalNumber { get; set; }    
        public int Revations { get; set; } = 0;
        public int BorrowedNumber { get; set; } = 0;

        public ICollection<BookItem> BookItems { get; set; } = new List<BookItem>();
    }
}