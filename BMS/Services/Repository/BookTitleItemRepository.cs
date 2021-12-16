using System.Threading.Tasks;
using BMS.Database;
using BMS.Models.Entities;
using BMS.Services.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BMS.Services.Repository
{
    public class BookTitleItemRepository : IBookTitleItemRepository
    {
        private readonly AppDbContext _context;
        public BookTitleItemRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<BookTitleItem?> FindIsNotLoanedBookAsync()
        {
            return await _context.BookTitleItems.FirstOrDefaultAsync(item => item.IsBorrowed == false);
        }
    }
}