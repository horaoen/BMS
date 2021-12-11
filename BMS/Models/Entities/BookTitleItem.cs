using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;

namespace BMS.Models.Entities
{
    public class BookTitleItem
    {
        [Key]
        public Guid Id { get; set; }
        
        public Guid BookTitleId { get; set; }
        
        [ForeignKey("BookTitleId")]
        public BookTitle BookTitle { get; set; }
        
        public bool IsBorrowed { get; set; } = false;
    }
}