using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BMS.Dtos
{
    public class BookTitleForUpdateDto
    {
        [MaxLength(50)]
        public string Name { get; set; }
        
        [MaxLength(50)]
        public string Author { get; set; }
    }
}