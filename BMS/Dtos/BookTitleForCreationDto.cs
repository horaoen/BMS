using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BMS.Models.Entities;

namespace BMS.Dtos
{
    public class BookTitleForCreationDto
    {
        [Required(ErrorMessage = "书目名称不可为空")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "书目作者不可为空")]
        public string Author { get; set; }

        public int TotalNumber { get; set; } = 0;

    }
}