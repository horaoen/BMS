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
        [MaxLength(50)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Author { get; set; }
        
        public int TotalNumber { get; set; }    
        public int Revations { get; set; } = 0;
        public int BorrowedNumber { get; set; } = 0;

        public ICollection<BookTitleItem> BookItems { get; set; }

        public void InitBookItems()
        {
            BookItems = new List<BookTitleItem>();
            for (int i = 0; i < TotalNumber; i++)
            {
                BookItems.Add(new BookTitleItem(){ Id = Guid.NewGuid(), BookTitleId = Id});
            }
        }
    }
}