using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

namespace BMS.Models.Entities
{
    public class BookItem
    {
        [Key]
        public Guid Id { get; set; }
        public bool IsBorrowed { get; set; }
        
    }
}