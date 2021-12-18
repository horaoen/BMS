using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace BMS.Models.Entities
{
    public class User : IdentityUser
    {
        public int MaxBooks { get; set; }
        public int MaxDays { get; set; }
        public int Fine { get; set; }
        public ICollection<BookTitle> BorrowedBooks { get; set; } = new List<BookTitle>();
    }
}