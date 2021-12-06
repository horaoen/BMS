using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace BMS.Dtos
{
    public class BookTitleForCreationDto
    {
        [Required(ErrorMessage = "书目名称不可为空")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "书目作者不可为空")]
        public string Author { get; set; }
        
        public int TotalNumber { get; set; }
    }
}