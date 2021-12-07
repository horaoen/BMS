using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace BMS.Dtos
{
    public class BookTitleDto
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int RemaindBook { get; set; }
    }
}