using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BMS.Dtos
{
    public class BookTitleForUpdateDto
    {
        [Required(ErrorMessage = "书目名称不可为空")]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "书目作者不可为空")]
        [MaxLength(50)]
        public string Author { get; set; }
    }
}